using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Google.Cloud.TextToSpeech.V1;
using System.IO;
using Google.Apis.Auth.OAuth2;
using Grpc.Core;
using Grpc.Auth;
using System.Globalization;



namespace TextToVoice
{
    public partial class Form_Main : Form
    {
        public Form_Main()
        {
            InitializeComponent();
        }


        private GoogleCredential credential;
        private Channel channel;
        private TextToSpeechClient client;
        private string jsonTokenFile = "";
        private string outputFile = "E:\\output.mp3";
        private string LanguageCode = "en-US";



        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox_Gender.SelectedIndex = 0;
        }





        #region Generate Audio

        // Generate
        private void button2_Click(object sender, EventArgs e)
        {
            try
            {

                if (!AuthenticateWithGoogle())
                    return;

                // Set the text input to be synthesized.
                SynthesisInput input = new SynthesisInput();

                if (checkBox_SSML.Checked)
                {
                    input.Ssml = richTextBox_Text.Text;
                }
                else
                {
                    input.Text = richTextBox_Text.Text;
                }

                // Build the voice request, select the language code ("en-US"),
                // and the SSML voice gender ("neutral").

                SsmlVoiceGender selected = (SsmlVoiceGender)Enum.Parse(typeof(SsmlVoiceGender), comboBox_Gender.Text);

                VoiceSelectionParams voice = new VoiceSelectionParams
                {
                    LanguageCode = LanguageCode,
                    SsmlGender = selected
                };

                // Select the type of audio file you want returned.
                AudioConfig config = new AudioConfig
                {
                    AudioEncoding = AudioEncoding.Mp3,
                    Pitch = (double)numericUpDown_Pitch.Value,
                    SpeakingRate = (double)numericUpDown_Speed.Value
                };

                // Perform the Text-to-Speech request, passing the text input
                // with the selected voice parameters and audio file type
                var response = client.SynthesizeSpeech(new SynthesizeSpeechRequest
                {
                    Input = input,
                    Voice = voice,
                    AudioConfig = config
                });

                // Write the binary AudioContent of the response to an MP3 file.
                using (Stream output = File.Create(outputFile))
                {
                    response.AudioContent.WriteTo(output);
                    Log("Audio content written to " + outputFile + "");
                }

            }
            catch (Exception e2)
            {
                Log("Error: " + e2.Message);
            }
        }

        #endregion

        #region Get Voices

        public class LanguageItem
        {
            public string Text { get; set; }
            public string Id { get; set; }

            public override string ToString()
            {
                return Text;
            }
        }

        public class VoiceItem
        {
            public string Name { get; set; }
            public string Gender { get; set; }
            public string Language { get; set; }

            public override string ToString()
            {
                return Name;
            }
        }

        private void btn_GetVoices_Click_1(object sender, EventArgs e)
        {
            try
            {
                listBox_Voices.Items.Clear();

                if (!AuthenticateWithGoogle())
                    return;
                Log("Getting a list of available voices...");

                Dictionary<string, LanguageItem> results = ListVoiceLanguages(channel);        // list of languages
                List<VoiceItem> result2 = ListVoices(channel);



                foreach (KeyValuePair<string, LanguageItem> a in results)
                {
                    listBox_Voices.Items.Add(a.Value.Id);
                }
                // 
                Log("Voice list complete.");
            }
            catch(Exception e2)
            {
                Log("Error: " + e2.Message);
            }
        }
        public Dictionary<string, LanguageItem> ListVoiceLanguages(Grpc.Core.Channel channel)
        {
            Dictionary<string, LanguageItem> languages = new Dictionary<string, LanguageItem>();
            try
            {
                TextToSpeechClient client = TextToSpeechClient.Create(channel);


                // Performs the list voices request
                var response = client.ListVoices(new ListVoicesRequest { });
                foreach (Voice voice in response.Voices)
                {
                    foreach (var languageCode in voice.LanguageCodes)
                    {
                        if (!languages.ContainsKey(languageCode.ToString()))
                        {
                            string displayName = languageCode + " | " + new CultureInfo($"{languageCode}").DisplayName;
                            LanguageItem newItem = new LanguageItem
                            {
                                Text = displayName,
                                Id = languageCode
                            };

                            languages.Add(languageCode, newItem);
                        }
                    }
                }

            }
            catch (Grpc.Core.RpcException e2)
            {
                Log("RpcException Error with Json API File: " + e2.Message);
            }
            catch (Exception e2)
            {
                Log("Error with Json API File: " + e2.Message);
            }

            return languages;
        }
        public  List<VoiceItem> ListVoices(Grpc.Core.Channel channel)
        {
            TextToSpeechClient client = TextToSpeechClient.Create(channel);

            // Performs the list voices request
            var response = client.ListVoices(new ListVoicesRequest
            { });

            List<VoiceItem> voices = new List<VoiceItem>();

            foreach (Voice voice in response.Voices)
            {
                foreach (var languageCode in voice.LanguageCodes)
                {
                    VoiceItem voiceItem = new VoiceItem
                    {
                        Name = voice.Name,
                        Gender = voice.SsmlGender.ToString(),
                        Language = languageCode,
                    };
                    voices.Add(voiceItem);
                }
            }
            return voices;
        }

        // Selected Voice Change
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            LanguageCode = listBox_Voices.SelectedItem.ToString();
            textBox_languageSelected.Text = LanguageCode;
        }

        #endregion

        #region Google Authentication / Load API File

        // JSON File Select
        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    jsonTokenFile = openFileDialog1.FileName;
                    txt_JsonAPIFile.Text = jsonTokenFile;
                    Log("JSON API File selected: " + openFileDialog1.FileName);
                }
            }
            catch(Exception e2)
            {
                Log("ERROR - Processing JSON API File: " + e2.Message);
            }
        }

        // Google Authentication
        public bool AuthenticateWithGoogle()
        {
            if (jsonTokenFile == "")
            {
                Log("Select a json api file");
                return false;
            }
            if (channel == null)
            {
                Log("Authenticating with Google....");
                credential = GoogleCredential.FromFile(jsonTokenFile).CreateScoped(TextToSpeechClient.DefaultScopes);
                channel = new Channel(TextToSpeechClient.DefaultEndpoint.ToString(), credential.ToChannelCredentials());
                client = TextToSpeechClient.Create(channel);
                Log("Authenticated.");
                return true;
            }
            return true;
        }

        #endregion

        #region Logging

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            richTextBox_Log.ScrollToCaret();
        }
        public void Log(string input)
        {
            richTextBox_Log.AppendText(DateTime.Now.ToString() + " " + input + "\n");
        }

        #endregion

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            outputFile = txt_Output.Text;
        }

        // Link Clicked
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start("https://cloud.google.com/text-to-speech/");
            }
            catch(Exception e2)
            {
                Log("Error: " + e2.Message);
            }
        }

    }
}

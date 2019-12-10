namespace TextToVoice
{
    partial class Form_Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_GetVoices = new System.Windows.Forms.Button();
            this.txt_JsonAPIFile = new System.Windows.Forms.TextBox();
            this.richTextBox_Text = new System.Windows.Forms.RichTextBox();
            this.listBox_Voices = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_VoiceSelect = new System.Windows.Forms.Label();
            this.txt_Output = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_Generate = new System.Windows.Forms.Button();
            this.button_OpenConfigFile = new System.Windows.Forms.Button();
            this.comboBox_Gender = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.textBox_languageSelected = new System.Windows.Forms.TextBox();
            this.richTextBox_Log = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.checkBox_SSML = new System.Windows.Forms.CheckBox();
            this.numericUpDown_Pitch = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.numericUpDown_Speed = new System.Windows.Forms.NumericUpDown();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Pitch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Speed)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_GetVoices
            // 
            this.btn_GetVoices.Location = new System.Drawing.Point(111, 576);
            this.btn_GetVoices.Name = "btn_GetVoices";
            this.btn_GetVoices.Size = new System.Drawing.Size(136, 37);
            this.btn_GetVoices.TabIndex = 0;
            this.btn_GetVoices.Text = "Get Voices";
            this.btn_GetVoices.UseVisualStyleBackColor = true;
            this.btn_GetVoices.Click += new System.EventHandler(this.btn_GetVoices_Click_1);
            // 
            // txt_JsonAPIFile
            // 
            this.txt_JsonAPIFile.Location = new System.Drawing.Point(109, 34);
            this.txt_JsonAPIFile.Name = "txt_JsonAPIFile";
            this.txt_JsonAPIFile.ReadOnly = true;
            this.txt_JsonAPIFile.Size = new System.Drawing.Size(387, 20);
            this.txt_JsonAPIFile.TabIndex = 1;
            // 
            // richTextBox_Text
            // 
            this.richTextBox_Text.Location = new System.Drawing.Point(109, 60);
            this.richTextBox_Text.Name = "richTextBox_Text";
            this.richTextBox_Text.Size = new System.Drawing.Size(546, 200);
            this.richTextBox_Text.TabIndex = 2;
            this.richTextBox_Text.Text = "Welcome and thank you for using Google Cloud Text to Voice.  Try selecting differ" +
    "ent voices or changing this text.";
            // 
            // listBox_Voices
            // 
            this.listBox_Voices.FormattingEnabled = true;
            this.listBox_Voices.Location = new System.Drawing.Point(111, 424);
            this.listBox_Voices.Name = "listBox_Voices";
            this.listBox_Voices.Size = new System.Drawing.Size(136, 147);
            this.listBox_Voices.TabIndex = 3;
            this.listBox_Voices.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "JSON API FILE";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Text";
            // 
            // lbl_VoiceSelect
            // 
            this.lbl_VoiceSelect.AutoSize = true;
            this.lbl_VoiceSelect.Location = new System.Drawing.Point(21, 403);
            this.lbl_VoiceSelect.Name = "lbl_VoiceSelect";
            this.lbl_VoiceSelect.Size = new System.Drawing.Size(67, 13);
            this.lbl_VoiceSelect.TabIndex = 6;
            this.lbl_VoiceSelect.Text = "Voice Select";
            // 
            // txt_Output
            // 
            this.txt_Output.Location = new System.Drawing.Point(111, 347);
            this.txt_Output.Name = "txt_Output";
            this.txt_Output.Size = new System.Drawing.Size(136, 20);
            this.txt_Output.TabIndex = 7;
            this.txt_Output.Text = "E:\\\\output.mp3";
            this.txt_Output.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 350);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Output File";
            // 
            // btn_Generate
            // 
            this.btn_Generate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Generate.Location = new System.Drawing.Point(281, 523);
            this.btn_Generate.Name = "btn_Generate";
            this.btn_Generate.Size = new System.Drawing.Size(374, 90);
            this.btn_Generate.TabIndex = 9;
            this.btn_Generate.Text = "Generate Audio Output";
            this.btn_Generate.UseVisualStyleBackColor = true;
            this.btn_Generate.Click += new System.EventHandler(this.button2_Click);
            // 
            // button_OpenConfigFile
            // 
            this.button_OpenConfigFile.Location = new System.Drawing.Point(502, 32);
            this.button_OpenConfigFile.Name = "button_OpenConfigFile";
            this.button_OpenConfigFile.Size = new System.Drawing.Size(153, 23);
            this.button_OpenConfigFile.TabIndex = 10;
            this.button_OpenConfigFile.Text = "Open JSON Config";
            this.button_OpenConfigFile.UseVisualStyleBackColor = true;
            this.button_OpenConfigFile.Click += new System.EventHandler(this.button3_Click);
            // 
            // comboBox_Gender
            // 
            this.comboBox_Gender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_Gender.FormattingEnabled = true;
            this.comboBox_Gender.Items.AddRange(new object[] {
            "Male",
            "Female",
            "Neutral",
            "Unspecified"});
            this.comboBox_Gender.Location = new System.Drawing.Point(111, 373);
            this.comboBox_Gender.Name = "comboBox_Gender";
            this.comboBox_Gender.Size = new System.Drawing.Size(136, 21);
            this.comboBox_Gender.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 376);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Gender";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog_JSON";
            this.openFileDialog1.Filter = "json api (*.json)|*.json|All files (*.*)|*.*";
            // 
            // textBox_languageSelected
            // 
            this.textBox_languageSelected.Location = new System.Drawing.Point(111, 400);
            this.textBox_languageSelected.Name = "textBox_languageSelected";
            this.textBox_languageSelected.ReadOnly = true;
            this.textBox_languageSelected.Size = new System.Drawing.Size(136, 20);
            this.textBox_languageSelected.TabIndex = 14;
            this.textBox_languageSelected.Text = "en-US";
            // 
            // richTextBox_Log
            // 
            this.richTextBox_Log.Location = new System.Drawing.Point(281, 299);
            this.richTextBox_Log.Name = "richTextBox_Log";
            this.richTextBox_Log.ReadOnly = true;
            this.richTextBox_Log.Size = new System.Drawing.Size(374, 218);
            this.richTextBox_Log.TabIndex = 15;
            this.richTextBox_Log.Text = "";
            this.richTextBox_Log.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(278, 270);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Log:";
            // 
            // checkBox_SSML
            // 
            this.checkBox_SSML.AutoSize = true;
            this.checkBox_SSML.Location = new System.Drawing.Point(111, 266);
            this.checkBox_SSML.Name = "checkBox_SSML";
            this.checkBox_SSML.Size = new System.Drawing.Size(55, 17);
            this.checkBox_SSML.TabIndex = 17;
            this.checkBox_SSML.Text = "SSML";
            this.checkBox_SSML.UseVisualStyleBackColor = true;
            // 
            // numericUpDown_Pitch
            // 
            this.numericUpDown_Pitch.Location = new System.Drawing.Point(111, 323);
            this.numericUpDown_Pitch.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.numericUpDown_Pitch.Minimum = new decimal(new int[] {
            20,
            0,
            0,
            -2147483648});
            this.numericUpDown_Pitch.Name = "numericUpDown_Pitch";
            this.numericUpDown_Pitch.Size = new System.Drawing.Size(136, 20);
            this.numericUpDown_Pitch.TabIndex = 18;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(21, 325);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 13);
            this.label6.TabIndex = 19;
            this.label6.Text = "Pitch";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(21, 299);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 13);
            this.label7.TabIndex = 21;
            this.label7.Text = "Speaking Rate";
            // 
            // numericUpDown_Speed
            // 
            this.numericUpDown_Speed.DecimalPlaces = 2;
            this.numericUpDown_Speed.Increment = new decimal(new int[] {
            25,
            0,
            0,
            131072});
            this.numericUpDown_Speed.Location = new System.Drawing.Point(111, 297);
            this.numericUpDown_Speed.Maximum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.numericUpDown_Speed.Name = "numericUpDown_Speed";
            this.numericUpDown_Speed.Size = new System.Drawing.Size(136, 20);
            this.numericUpDown_Speed.TabIndex = 20;
            this.numericUpDown_Speed.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(106, 9);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(204, 13);
            this.linkLabel1.TabIndex = 22;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "https://cloud.google.com/text-to-speech/";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // Form_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(672, 647);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.numericUpDown_Speed);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.numericUpDown_Pitch);
            this.Controls.Add(this.checkBox_SSML);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.richTextBox_Log);
            this.Controls.Add(this.textBox_languageSelected);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.comboBox_Gender);
            this.Controls.Add(this.button_OpenConfigFile);
            this.Controls.Add(this.btn_Generate);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_Output);
            this.Controls.Add(this.lbl_VoiceSelect);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBox_Voices);
            this.Controls.Add(this.richTextBox_Text);
            this.Controls.Add(this.txt_JsonAPIFile);
            this.Controls.Add(this.btn_GetVoices);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Form_Main";
            this.ShowIcon = false;
            this.Text = "Google - Text to Speech ";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Pitch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Speed)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_GetVoices;
        private System.Windows.Forms.TextBox txt_JsonAPIFile;
        private System.Windows.Forms.RichTextBox richTextBox_Text;
        private System.Windows.Forms.ListBox listBox_Voices;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_VoiceSelect;
        private System.Windows.Forms.TextBox txt_Output;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_Generate;
        private System.Windows.Forms.Button button_OpenConfigFile;
        private System.Windows.Forms.ComboBox comboBox_Gender;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TextBox textBox_languageSelected;
        private System.Windows.Forms.RichTextBox richTextBox_Log;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox checkBox_SSML;
        private System.Windows.Forms.NumericUpDown numericUpDown_Pitch;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown numericUpDown_Speed;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}


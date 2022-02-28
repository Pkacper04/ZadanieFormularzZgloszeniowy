namespace FormularzZgloszeniowy
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.checkBox5 = new System.Windows.Forms.CheckBox();
            this.label7 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.SaveButton = new System.Windows.Forms.Button();
            this.Error = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.SavedPanel = new System.Windows.Forms.Panel();
            this.DataPanel = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.labelLastName = new System.Windows.Forms.Label();
            this.labelPlec = new System.Windows.Forms.Label();
            this.labelBirthday = new System.Windows.Forms.Label();
            this.labelInterests = new System.Windows.Forms.Label();
            this.labelWebBrowser = new System.Windows.Forms.Label();
            this.ReturnButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.DataPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.25F);
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(100, 0, 10, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(860, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "WYPEŁNIJ FORMULARZ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.textBox1.Location = new System.Drawing.Point(117, 100);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(250, 26);
            this.textBox1.TabIndex = 1;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.label2.Location = new System.Drawing.Point(0, 60);
            this.label2.Margin = new System.Windows.Forms.Padding(100, 0, 10, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(484, 39);
            this.label2.TabIndex = 2;
            this.label2.Text = "IMIE";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.label3.Location = new System.Drawing.Point(0, 150);
            this.label3.Margin = new System.Windows.Forms.Padding(100, 0, 10, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(484, 39);
            this.label3.TabIndex = 3;
            this.label3.Text = "NAZWISKO";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.textBox2.Location = new System.Drawing.Point(117, 190);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(250, 26);
            this.textBox2.TabIndex = 4;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.label4.Location = new System.Drawing.Point(0, 240);
            this.label4.Margin = new System.Windows.Forms.Padding(100, 0, 10, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(484, 39);
            this.label4.TabIndex = 5;
            this.label4.Text = "PŁEĆ";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // radioButton1
            // 
            this.radioButton1.Checked = true;
            this.radioButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.radioButton1.Location = new System.Drawing.Point(42, 18);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(121, 24);
            this.radioButton1.TabIndex = 6;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Mężczyzna";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.radioButton2.Location = new System.Drawing.Point(42, 48);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(110, 24);
            this.radioButton2.TabIndex = 7;
            this.radioButton2.Text = "Kobieta";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(142, 430);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.label5.Location = new System.Drawing.Point(0, 371);
            this.label5.Margin = new System.Windows.Forms.Padding(100, 0, 10, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(484, 39);
            this.label5.TabIndex = 9;
            this.label5.Text = "DATA URODZIN";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.checkBox1.Location = new System.Drawing.Point(556, 102);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(68, 24);
            this.checkBox1.TabIndex = 10;
            this.checkBox1.Text = "Sport";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.label6.Location = new System.Drawing.Point(370, 60);
            this.label6.Margin = new System.Windows.Forms.Padding(100, 0, 10, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(484, 39);
            this.label6.TabIndex = 11;
            this.label6.Text = "ZAINTERESOWANIA";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.checkBox2.Location = new System.Drawing.Point(556, 132);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(108, 24);
            this.checkBox2.TabIndex = 12;
            this.checkBox2.Text = "Komputery";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.checkBox3.Location = new System.Drawing.Point(556, 162);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(95, 24);
            this.checkBox3.TabIndex = 13;
            this.checkBox3.Text = "Jedzenie";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.checkBox4.Location = new System.Drawing.Point(556, 192);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(90, 24);
            this.checkBox4.TabIndex = 14;
            this.checkBox4.Text = "Podróże";
            this.checkBox4.UseVisualStyleBackColor = true;
            // 
            // checkBox5
            // 
            this.checkBox5.AutoSize = true;
            this.checkBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.checkBox5.Location = new System.Drawing.Point(556, 222);
            this.checkBox5.Name = "checkBox5";
            this.checkBox5.Size = new System.Drawing.Size(59, 24);
            this.checkBox5.TabIndex = 15;
            this.checkBox5.Text = "Inne";
            this.checkBox5.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.label7.Location = new System.Drawing.Point(370, 283);
            this.label7.Margin = new System.Windows.Forms.Padding(100, 0, 10, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(484, 39);
            this.label7.TabIndex = 16;
            this.label7.Text = "JAKIEJ PRZEGLĄDARKI UŻYWASZ";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Google Chrome",
            "Opera",
            "Firefox",
            "Safari",
            "Microsoft Edge"});
            this.comboBox1.Location = new System.Drawing.Point(531, 346);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(144, 28);
            this.comboBox1.TabIndex = 17;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // SaveButton
            // 
            this.SaveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.SaveButton.Location = new System.Drawing.Point(527, 430);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(148, 36);
            this.SaveButton.TabIndex = 18;
            this.SaveButton.Text = "Zapisz Dane";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // Error
            // 
            this.Error.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Error.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.Error.Location = new System.Drawing.Point(0, 560);
            this.Error.Name = "Error";
            this.Error.Size = new System.Drawing.Size(860, 101);
            this.Error.TabIndex = 19;
            this.Error.Text = "label8";
            this.Error.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Location = new System.Drawing.Point(142, 274);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            // 
            // SavedPanel
            // 
            this.SavedPanel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.SavedPanel.Location = new System.Drawing.Point(813, 0);
            this.SavedPanel.Name = "SavedPanel";
            this.SavedPanel.Size = new System.Drawing.Size(860, 661);
            this.SavedPanel.TabIndex = 21;
            this.SavedPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.SavedPanel_Paint);
            // 
            // DataPanel
            // 
            this.DataPanel.Controls.Add(this.ReturnButton);
            this.DataPanel.Controls.Add(this.labelWebBrowser);
            this.DataPanel.Controls.Add(this.labelInterests);
            this.DataPanel.Controls.Add(this.labelBirthday);
            this.DataPanel.Controls.Add(this.labelPlec);
            this.DataPanel.Controls.Add(this.labelLastName);
            this.DataPanel.Controls.Add(this.labelName);
            this.DataPanel.Controls.Add(this.label8);
            this.DataPanel.Location = new System.Drawing.Point(5, 3);
            this.DataPanel.Name = "DataPanel";
            this.DataPanel.Size = new System.Drawing.Size(864, 661);
            this.DataPanel.TabIndex = 25;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.25F);
            this.label8.Location = new System.Drawing.Point(289, 36);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(200, 39);
            this.label8.TabIndex = 0;
            this.label8.Text = "Twoje Dane";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.labelName.Location = new System.Drawing.Point(247, 129);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(63, 25);
            this.labelName.TabIndex = 1;
            this.labelName.Text = "Imię: ";
            // 
            // labelLastName
            // 
            this.labelLastName.AutoSize = true;
            this.labelLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.labelLastName.Location = new System.Drawing.Point(247, 186);
            this.labelLastName.Name = "labelLastName";
            this.labelLastName.Size = new System.Drawing.Size(116, 25);
            this.labelLastName.TabIndex = 2;
            this.labelLastName.Text = "Nazwisko: ";
            // 
            // labelPlec
            // 
            this.labelPlec.AutoSize = true;
            this.labelPlec.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.labelPlec.Location = new System.Drawing.Point(247, 243);
            this.labelPlec.Name = "labelPlec";
            this.labelPlec.Size = new System.Drawing.Size(66, 25);
            this.labelPlec.TabIndex = 3;
            this.labelPlec.Text = "Płeć: ";
            // 
            // labelBirthday
            // 
            this.labelBirthday.AutoSize = true;
            this.labelBirthday.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.labelBirthday.Location = new System.Drawing.Point(247, 303);
            this.labelBirthday.Name = "labelBirthday";
            this.labelBirthday.Size = new System.Drawing.Size(149, 25);
            this.labelBirthday.TabIndex = 4;
            this.labelBirthday.Text = "Data Urodzin: ";
            // 
            // labelInterests
            // 
            this.labelInterests.AutoSize = true;
            this.labelInterests.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.labelInterests.Location = new System.Drawing.Point(247, 368);
            this.labelInterests.Name = "labelInterests";
            this.labelInterests.Size = new System.Drawing.Size(182, 25);
            this.labelInterests.TabIndex = 5;
            this.labelInterests.Text = "Zainteresowania: ";
            // 
            // labelWebBrowser
            // 
            this.labelWebBrowser.AutoSize = true;
            this.labelWebBrowser.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.labelWebBrowser.Location = new System.Drawing.Point(247, 557);
            this.labelWebBrowser.Name = "labelWebBrowser";
            this.labelWebBrowser.Size = new System.Drawing.Size(151, 25);
            this.labelWebBrowser.TabIndex = 6;
            this.labelWebBrowser.Text = "Przeglądarka: ";
            // 
            // ReturnButton
            // 
            this.ReturnButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.ReturnButton.Location = new System.Drawing.Point(638, 593);
            this.ReturnButton.Name = "ReturnButton";
            this.ReturnButton.Size = new System.Drawing.Size(148, 53);
            this.ReturnButton.TabIndex = 7;
            this.ReturnButton.Text = "Powrót";
            this.ReturnButton.UseVisualStyleBackColor = true;
            this.ReturnButton.Click += new System.EventHandler(this.ReturnButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(860, 661);
            this.Controls.Add(this.SavedPanel);
            this.Controls.Add(this.DataPanel);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Error);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.checkBox5);
            this.Controls.Add(this.checkBox4);
            this.Controls.Add(this.checkBox3);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Formularz";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.DataPanel.ResumeLayout(false);
            this.DataPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.CheckBox checkBox5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Label Error;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel SavedPanel;
        private System.Windows.Forms.Panel DataPanel;
        private System.Windows.Forms.Label labelWebBrowser;
        private System.Windows.Forms.Label labelInterests;
        private System.Windows.Forms.Label labelBirthday;
        private System.Windows.Forms.Label labelPlec;
        private System.Windows.Forms.Label labelLastName;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button ReturnButton;
    }
}


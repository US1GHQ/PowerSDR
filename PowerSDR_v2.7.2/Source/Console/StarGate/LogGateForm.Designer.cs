namespace PowerSDR.StarGate
{
    partial class LogGateForm
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
            this.CloseBtn = new System.Windows.Forms.Button();
            this.SaveBtn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.RxFreqTb = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.SentReportTb = new System.Windows.Forms.TextBox();
            this.RecReportTb = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.call = new System.Windows.Forms.TextBox();
            this.ModeCombo = new System.Windows.Forms.ComboBox();
            this.PowerTb = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.frequencyTb = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.PasswordTb = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.UserNameTb = new System.Windows.Forms.TextBox();
            this.UserNameLbl = new System.Windows.Forms.Label();
            this.BandTb = new System.Windows.Forms.TextBox();
            this.BandLbl = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // CloseBtn
            // 
            this.CloseBtn.Location = new System.Drawing.Point(166, 251);
            this.CloseBtn.Name = "CloseBtn";
            this.CloseBtn.Size = new System.Drawing.Size(75, 23);
            this.CloseBtn.TabIndex = 2;
            this.CloseBtn.Text = "Close";
            this.CloseBtn.UseVisualStyleBackColor = true;
            this.CloseBtn.Click += new System.EventHandler(this.CloseBtn_Click);
            // 
            // SaveBtn
            // 
            this.SaveBtn.Location = new System.Drawing.Point(34, 251);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Size = new System.Drawing.Size(75, 23);
            this.SaveBtn.TabIndex = 8;
            this.SaveBtn.Text = "Save";
            this.SaveBtn.UseVisualStyleBackColor = true;
            this.SaveBtn.Click += new System.EventHandler(this.SaveQso_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.BandTb);
            this.panel1.Controls.Add(this.BandLbl);
            this.panel1.Controls.Add(this.RxFreqTb);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.SentReportTb);
            this.panel1.Controls.Add(this.RecReportTb);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.call);
            this.panel1.Controls.Add(this.ModeCombo);
            this.panel1.Controls.Add(this.PowerTb);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.frequencyTb);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 66);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(504, 165);
            this.panel1.TabIndex = 15;
            // 
            // RxFreqTb
            // 
            this.RxFreqTb.Location = new System.Drawing.Point(379, 39);
            this.RxFreqTb.Name = "RxFreqTb";
            this.RxFreqTb.ReadOnly = true;
            this.RxFreqTb.Size = new System.Drawing.Size(100, 20);
            this.RxFreqTb.TabIndex = 23;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(307, 42);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 13);
            this.label7.TabIndex = 28;
            this.label7.Text = "RX Freq";
            // 
            // SentReportTb
            // 
            this.SentReportTb.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.SentReportTb.Location = new System.Drawing.Point(79, 107);
            this.SentReportTb.Name = "SentReportTb";
            this.SentReportTb.Size = new System.Drawing.Size(100, 20);
            this.SentReportTb.TabIndex = 20;
            // 
            // RecReportTb
            // 
            this.RecReportTb.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.RecReportTb.Location = new System.Drawing.Point(79, 81);
            this.RecReportTb.Name = "RecReportTb";
            this.RecReportTb.Size = new System.Drawing.Size(100, 20);
            this.RecReportTb.TabIndex = 18;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(35, 107);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(33, 13);
            this.label6.TabIndex = 27;
            this.label6.Text = "Sent";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 83);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 13);
            this.label5.TabIndex = 26;
            this.label5.Text = "Received";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(16, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 13);
            this.label4.TabIndex = 25;
            this.label4.Text = "Call Sign";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(35, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 24;
            this.label3.Text = "Mode";
            // 
            // call
            // 
            this.call.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.call.Location = new System.Drawing.Point(79, 10);
            this.call.Name = "call";
            this.call.Size = new System.Drawing.Size(100, 20);
            this.call.TabIndex = 16;
            // 
            // ModeCombo
            // 
            this.ModeCombo.FormattingEnabled = true;
            this.ModeCombo.Items.AddRange(new object[] {
            "AM",
            "ATV",
            "CHIP",
            "CLO",
            "CONTESTI",
            "CW",
            "DIGITALVOICE",
            "DOMINO",
            "DSTAR",
            "FAX",
            "FM",
            "FSK441",
            "HELL",
            "ISCAT",
            "JT4",
            "JT6M",
            "JT9",
            "JT44",
            "JT65",
            "LSB",
            "MFSK",
            "OLIVIA",
            "OPERA",
            "PAC",
            "PAX",
            "PKT",
            "PSK",
            "PSK2K",
            "Q15",
            "ROS",
            "RTTY",
            "RTTYM",
            "SSB",
            "SSTV",
            "THOR",
            "THRB",
            "TOR",
            "USB",
            "V4",
            "VOI",
            "WINMOR",
            "WSPR"});
            this.ModeCombo.Location = new System.Drawing.Point(79, 42);
            this.ModeCombo.Name = "ModeCombo";
            this.ModeCombo.Size = new System.Drawing.Size(100, 21);
            this.ModeCombo.TabIndex = 17;
            // 
            // PowerTb
            // 
            this.PowerTb.Location = new System.Drawing.Point(379, -28);
            this.PowerTb.Name = "PowerTb";
            this.PowerTb.ReadOnly = true;
            this.PowerTb.Size = new System.Drawing.Size(100, 20);
            this.PowerTb.TabIndex = 21;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(310, -20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 19;
            this.label2.Text = "Power";
            // 
            // frequencyTb
            // 
            this.frequencyTb.Location = new System.Drawing.Point(379, 10);
            this.frequencyTb.Name = "frequencyTb";
            this.frequencyTb.ReadOnly = true;
            this.frequencyTb.Size = new System.Drawing.Size(100, 20);
            this.frequencyTb.TabIndex = 22;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(307, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Frequency";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.PasswordTb);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.UserNameTb);
            this.panel2.Controls.Add(this.UserNameLbl);
            this.panel2.Location = new System.Drawing.Point(12, 16);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(495, 44);
            this.panel2.TabIndex = 16;
            // 
            // PasswordTb
            // 
            this.PasswordTb.Location = new System.Drawing.Point(273, 16);
            this.PasswordTb.Name = "PasswordTb";
            this.PasswordTb.PasswordChar = '*';
            this.PasswordTb.Size = new System.Drawing.Size(100, 20);
            this.PasswordTb.TabIndex = 31;
            this.PasswordTb.UseSystemPasswordChar = true;
            this.PasswordTb.Leave += new System.EventHandler(this.PasswordTb_Leave);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(206, 19);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(61, 13);
            this.label8.TabIndex = 32;
            this.label8.Text = "Password";
            // 
            // UserNameTb
            // 
            this.UserNameTb.Location = new System.Drawing.Point(79, 16);
            this.UserNameTb.Name = "UserNameTb";
            this.UserNameTb.Size = new System.Drawing.Size(100, 20);
            this.UserNameTb.TabIndex = 30;
            this.UserNameTb.Leave += new System.EventHandler(this.UserNameTb_Leave);
            // 
            // UserNameLbl
            // 
            this.UserNameLbl.AutoSize = true;
            this.UserNameLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserNameLbl.Location = new System.Drawing.Point(7, 21);
            this.UserNameLbl.Name = "UserNameLbl";
            this.UserNameLbl.Size = new System.Drawing.Size(69, 13);
            this.UserNameLbl.TabIndex = 29;
            this.UserNameLbl.Text = "User Name";
            // 
            // BandTb
            // 
            this.BandTb.Location = new System.Drawing.Point(379, 65);
            this.BandTb.Name = "BandTb";
            this.BandTb.ReadOnly = true;
            this.BandTb.Size = new System.Drawing.Size(100, 20);
            this.BandTb.TabIndex = 29;
            // 
            // BandLbl
            // 
            this.BandLbl.AutoSize = true;
            this.BandLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BandLbl.Location = new System.Drawing.Point(307, 68);
            this.BandLbl.Name = "BandLbl";
            this.BandLbl.Size = new System.Drawing.Size(36, 13);
            this.BandLbl.TabIndex = 30;
            this.BandLbl.Text = "Band";
            // 
            // LogGateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(529, 290);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.SaveBtn);
            this.Controls.Add(this.CloseBtn);
            this.Name = "LogGateForm";
            this.Text = "LogGateForm";
            this.Activated += new System.EventHandler(this.LogGateForm_Activated);
            this.Load += new System.EventHandler(this.LogGateForm_Load);
            this.Enter += new System.EventHandler(this.LogGateForm_Enter);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button CloseBtn;
        private System.Windows.Forms.Button SaveBtn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox RxFreqTb;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox SentReportTb;
        private System.Windows.Forms.TextBox RecReportTb;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox call;
        private System.Windows.Forms.ComboBox ModeCombo;
        private System.Windows.Forms.TextBox PowerTb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox frequencyTb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox PasswordTb;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox UserNameTb;
        private System.Windows.Forms.Label UserNameLbl;
        private System.Windows.Forms.TextBox BandTb;
        private System.Windows.Forms.Label BandLbl;
    }
}
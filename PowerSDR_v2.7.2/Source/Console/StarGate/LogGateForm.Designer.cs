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
            this.label1 = new System.Windows.Forms.Label();
            this.frequencyTb = new System.Windows.Forms.TextBox();
            this.CloseBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.PowerTb = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.ModeCombo = new System.Windows.Forms.ComboBox();
            this.call = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(320, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Frequency";
            // 
            // frequencyTb
            // 
            this.frequencyTb.Location = new System.Drawing.Point(392, 21);
            this.frequencyTb.Name = "frequencyTb";
            this.frequencyTb.ReadOnly = true;
            this.frequencyTb.Size = new System.Drawing.Size(100, 20);
            this.frequencyTb.TabIndex = 1;
            // 
            // CloseBtn
            // 
            this.CloseBtn.Location = new System.Drawing.Point(166, 197);
            this.CloseBtn.Name = "CloseBtn";
            this.CloseBtn.Size = new System.Drawing.Size(75, 23);
            this.CloseBtn.TabIndex = 2;
            this.CloseBtn.Text = "Close";
            this.CloseBtn.UseVisualStyleBackColor = true;
            this.CloseBtn.Click += new System.EventHandler(this.CloseBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(323, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Power";
            // 
            // PowerTb
            // 
            this.PowerTb.Location = new System.Drawing.Point(392, 42);
            this.PowerTb.Name = "PowerTb";
            this.PowerTb.ReadOnly = true;
            this.PowerTb.Size = new System.Drawing.Size(100, 20);
            this.PowerTb.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(34, 197);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.SaveQso_Click);
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
            this.ModeCombo.Location = new System.Drawing.Point(77, 50);
            this.ModeCombo.Name = "ModeCombo";
            this.ModeCombo.Size = new System.Drawing.Size(121, 21);
            this.ModeCombo.TabIndex = 6;
            // 
            // call
            // 
            this.call.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.call.Location = new System.Drawing.Point(75, 17);
            this.call.Name = "call";
            this.call.Size = new System.Drawing.Size(100, 20);
            this.call.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Mode";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Call Sign";
            // 
            // LogGateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(529, 261);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.call);
            this.Controls.Add(this.ModeCombo);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.PowerTb);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CloseBtn);
            this.Controls.Add(this.frequencyTb);
            this.Controls.Add(this.label1);
            this.Name = "LogGateForm";
            this.Text = "LogGateForm";
            this.Load += new System.EventHandler(this.LogGateForm_Load);
            this.Enter += new System.EventHandler(this.LogGateForm_Enter);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox frequencyTb;
        private System.Windows.Forms.Button CloseBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox PowerTb;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox ModeCombo;
        private System.Windows.Forms.TextBox call;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}
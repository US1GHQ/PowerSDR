using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PowerSDR;
using StarGate.LogGate;
using LogGateLibrary;
using MyCouch;
using MyCouch.Requests;
using MyCouch.Responses;
using Newtonsoft.Json;

namespace PowerSDR.StarGate
{
    public partial class LogGateForm : Form
    {
        private Console console;
        public LogGateForm(Console con)
        {
            InitializeComponent();
            console = con;
        }

        static private string userName = string.Empty;

        static private string password = string.Empty;

        private void LogGateForm_Load(object sender, EventArgs e)
        {
            frequencyTb.Text = console.TXFreq.ToString();
            PowerTb.Text = console.PWR.ToString();
            ModeCombo.Text = console.RX1DSPMode.ToString();

            userName = Properties.Settings.Default.UserName;
            password = Properties.Settings.Default.Password;

            if (string.IsNullOrWhiteSpace(userName))
            {
                this.Text = "No Database User Defined";
            }
            else
            {
                this.Text = "Database User: " + userName;
            }
        }

        private void CloseBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void SaveQso_Click(object sender, EventArgs e)
        {

            var qso = new Qso();
            qso.Call = call.Text;
            if (string.IsNullOrWhiteSpace(qso.Call)  || qso.Call.Length < 3)
            {
                MessageBox.Show("Valid call sign required! ");
                return;              
            }
            qso.Power = console.PWR.ToString();
            qso.Mode = ModeCombo.Text;
            qso.QsoStartDtg = DateTime.UtcNow;
            qso.Freq = console.TXFreq.ToString();
            qso.RstRcvd = RecReportTb.Text;
            qso.RstSent = SentReportTb.Text;
            qso.Band = GetAdifBand();

            if (console.VFOBTX == true)
            {
                qso.Freq_rx = console.VFOAFreq.ToString();
                qso.Band_rx = console.RX1Band.ToString();
            }
            

            CouchDbHandler.SetUrl(userName, password, "localhost", "5984", "loggate");

            GetDatabaseResponse dbStr = CouchDbHandler.GetDb("loggate");
            if (dbStr.Error == "not_found")
            {
                string errorStr = CouchDbHandler.CreateDb("loggate");
                if (errorStr != null)
                {
                    MessageBox.Show("Create Database returns: " + errorStr);
                    return;
                }
            }
            if (string.IsNullOrWhiteSpace(contextExch.Text) == false)
            {
                qso.Fields.Add("Exchange", contextExch.Text);
            }
            CouchDbHandler.SaveQSO(qso);
            MessageBox.Show("QSO Saved to LogGate!");
            call.Text = string.Empty;
            RecReportTb.Text = string.Empty;
            SentReportTb.Text = string.Empty;
            contextExch.Text = string.Empty;

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void LogGateForm_Enter(object sender, EventArgs e)
        {
            PowerTb.Text = console.PWR.ToString();
        }

        private void PasswordTb_Leave(object sender, EventArgs e)
        {
            password = PasswordTb.Text;
        }

        private void UserNameTb_Leave(object sender, EventArgs e)
        {
            userName = UserNameTb.Text;
            if (string.IsNullOrWhiteSpace(userName))
            {
                this.Text = "No Database User Defined";
            }
            else
            {
                this.Text = "Database User: " + userName;
            }
        }

        private void LogGateForm_Activated(object sender, EventArgs e)
        {
            frequencyTb.Text = console.TXFreq.ToString();
            PowerTb.Text = console.PWR.ToString();
            ModeCombo.Text = console.RX1DSPMode.ToString();
            BandTb.Text = GetAdifBand();

            if (console.VFOBTX == true)
            {
                RxFreqTb.Text = console.VFOAFreq.ToString();
            }
        }
        private string GetAdifBand()
        {

            string band = console.TXBand.ToString();
            band = band.Substring(1);
            return band;
        }

        private void LogGateForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            this.Hide();
        }
    }
}

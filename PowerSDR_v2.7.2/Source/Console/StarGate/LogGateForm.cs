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

        private void LogGateForm_Load(object sender, EventArgs e)
        {
            frequencyTb.Text = console.TXFreq.ToString();
            PowerTb.Text = console.PWR.ToString();
            ModeCombo.Text = console.RX1DSPMode.ToString();
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


            CouchDbHandler.SetUrl("wa1gon", "kb1etc73", "localhost", "5984", "loggate");

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

            CouchDbHandler.SaveQSO(qso);

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void LogGateForm_Enter(object sender, EventArgs e)
        {
            PowerTb.Text = console.PWR.ToString();
        }
    }
}

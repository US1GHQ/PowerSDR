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
            ModeCombo.SelectedText = console.RX1DSPMode.ToString();
        }

        private void CloseBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void SaveQso_Click(object sender, EventArgs e)
        {
            CouchDbHandler.SetUrl("wa1gon", "kb1etc73", "localhost", "5984", "loggate");
            string errorStr = CouchDbHandler.CreateDb("loggate");
            //if (errorStr != null)
            //{
            //    MessageBox.Show("Create Database returns: " + errorStr);
            //    return;
            //}

            var qso = new Qso();
            qso.Call = call.Text;
            qso.Power = console.PWR.ToString();
            qso.Mode = ModeCombo.SelectedText;
            qso.QsoStartDtg = DateTime.UtcNow;

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}

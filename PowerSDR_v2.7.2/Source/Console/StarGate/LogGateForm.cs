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

        private void button1_Click(object sender, EventArgs e)
        {
            CouchDbHandler.SetUrl("wa1gon", "kb1etc73", "localhost", "5984", "loggate");
            CouchDbHandler.CreateDb("loggate");
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}

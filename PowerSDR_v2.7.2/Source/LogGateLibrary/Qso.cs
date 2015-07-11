using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;
namespace LogGateLibrary
{
    public class Qso
    {
        public SortedList<string,string> Fields { get; set; }
        public Qso()
        {
            Fields = new SortedList<string, string>();
            DocType = this.GetType().Name;
        }

        public string GetCallSign()
        {
            string call;
            call = Fields["call"];
            return call;
        }

        private string call;
        public string Call
        {
            get { return call; }
            set { call = value; }
        }
        private string band;
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string Band
        {
            get { return band; }
            set { band = value; }
        }

        private string mode;
        public string Mode
        {
            get { return mode; }
            set { mode = value; }
        }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string Power
        {
            get { return power; }
            set { power = value; }
        }

        private DateTime qsoStartDtg;
        public DateTime QsoStartDtg
        {
            get { return qsoStartDtg; }
            set { qsoStartDtg = value; }
        }
        private string freq;

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string Freq
        {
            get { return freq; }
            set { freq = value; }
        }
        private string freq_rx;
        private string rstRcvd;

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string RstRcvd
        {
            get { return rstRcvd; }
            set { rstRcvd = value; }
        }
        private string rstSent;
        public string RstSent
        {
            get { return rstSent; }
            set { rstSent = value; }
        }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string Freq_rx
        {
            get { return freq_rx; }
            set { freq_rx = value; }
        }

        private string band_rx;
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string Band_rx
        {
            get { return band_rx; }
            set { band_rx = value; }
        }

        private string power;
              
        public string DocType { get; set; }
        public string _id { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string _rev { get; set; }
    }

}

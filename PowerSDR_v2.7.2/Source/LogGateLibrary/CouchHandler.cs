
using LogGateLibrary;
using MyCouch;
using MyCouch.Requests;
using MyCouch.Responses;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;


namespace StarGate.LogGate
{
    public class CouchDbHandler
    {
        static public string UserName { get; set; }
        static public string Password { get; set; }

        static public  string LogGateUrl = "http://wa1gon:****@localhost:5984/loggate";
        static public string LogGateServerUrl = "";


        static public bool SetUrl(string user,string password, string host,string port,string dbName)
        {
            LogGateUrl = string.Empty;
            if (string.IsNullOrWhiteSpace(host) || string.IsNullOrWhiteSpace(port) || string.IsNullOrWhiteSpace(dbName))
            {
                return false;
            }
            string url = string.Format("http://{0}:{1}/", host, port);
            if (string.IsNullOrWhiteSpace(host) && string.IsNullOrWhiteSpace(port))
            {
                var urlBuilder = new MyCouchUriBuilder(url).SetDbName(dbName);
                LogGateUrl = urlBuilder.Build().ToString();
                urlBuilder = new MyCouchUriBuilder(url);
                LogGateServerUrl = urlBuilder.Build().ToString();
                return true;
            }
            else
            {
                var urlBuilder = new MyCouchUriBuilder(url).SetDbName(dbName).SetBasicCredentials(user, password);
                LogGateUrl = urlBuilder.Build().ToString();
                urlBuilder = new MyCouchUriBuilder(url).SetBasicCredentials(user, password);
                LogGateServerUrl = urlBuilder.Build().ToString();
                return true;
            }
        }
        static public SortedList<string, Qso> GetQsos()
        {
            Qso qso;

            var retContext = new SortedList<string, Qso>();
            using (var client = new MyCouchClient(LogGateUrl))
            {

                var jspecQuery = new QueryViewRequest("Docs", "Doctype")
                    .Configure(query => query
                    .Reduce(false).Key("Qso").Descending(true).IncludeDocs(true));

                ViewQueryResponse<string> result = client.Views.QueryAsync<string>(jspecQuery).Result;


                foreach (var row in result.Rows)
                {
                    if (row == null)
                    {
                        continue;
                    }
                    qso = JsonConvert.DeserializeObject<Qso>(row.IncludedDoc);
                    retContext.Add(qso.GetCallSign(), qso);

                }
                return retContext;
            }
        }
        public static string CreateDb(string name)
        {
            using (var client = new MyCouchServerClient(LogGateServerUrl))
            {
                var rc = client.Databases.PutAsync(name).Result;
                if (rc.Error != null)
                {
                    return rc.Error;
                }  
            }
            return "Unknown Error";
        }
        static public bool SaveQSO(Qso qso)
        {
            using (var client = new MyCouchClient(LogGateUrl))
            {
                //var dbClip = GetQso(qso._id);
                //if (dbClip != null && qso != null)
                //{
                //    if (dbClip._rev != qso._rev)
                //    {
                //        qso.Merge(dbClip);
                //    }
                //}

                if (string.IsNullOrWhiteSpace(qso._id))
                {
                    qso._id = Guid.NewGuid().ToString();
                }

                var put = client.Entities.PutAsync<Qso>(qso).Result;
                qso._rev = put.Content._rev;
                if (put.Error == null)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        private async Task<ViewQueryResponse<string>> Query(MyCouchClient client, QueryViewRequest clipquery)
        {
            ViewQueryResponse<string> result = await client.Views.QueryAsync<string>(clipquery);
            return result;
        }

        

    }
}



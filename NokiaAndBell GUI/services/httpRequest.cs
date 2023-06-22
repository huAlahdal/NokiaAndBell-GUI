using Nancy.Json;
using Newtonsoft.Json;
using NokiaAndBell_GUI.models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NokiaAndBell_GUI.services
{
    class httpRequest
    {
        private static readonly HttpClient _Client = new HttpClient();
        private static JavaScriptSerializer _Serializer = new JavaScriptSerializer();
        class Input
        {
            public string dateFrom { get; set; }
            public string dateTo { get; set; }
            public string mru { get; set; }
            public string mfgSerNo { get; set; }
            public string[] status { get; set; }
            public string cycle { get; set; }
            public string installedMeterNumber { get; set; }
            public string premise { get; set; }
            public string office { get; set; }
            public int pageNum { get; set; }
            public int pageSize { get; set; }
        }
        public static async Task<Response> Run(string dateFrom, string dateTo, string mru, string mfgSerNo, string[] status, string cycle, string installedMeterNumber, string premise, string office, int pageSize, int pageNum)
        {
            Response value = null;
            if(!File.Exists("token.txt"))
            {
                MessageBox.Show("You must login", "Nokia & Bell", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return value;
            }

            string url = "https://sec.nokia-zjbell.com/rolloutapi/meterManage/getSurveyInstallByOffice";
            Input cust = new Input()
            {
                dateFrom = dateFrom,
                dateTo = dateTo,
                mru = mru,
                mfgSerNo = mfgSerNo,
                status = status,
                cycle = cycle,
                installedMeterNumber = installedMeterNumber,
                premise = premise,
                office = office,
                pageSize = pageSize,
                pageNum = pageNum
            };
            var json = _Serializer.Serialize(cust);

            var response = await Request(HttpMethod.Post, url, json, new Dictionary<string, string>());

            string responseText = await response.Content.ReadAsStringAsync();




            if (responseText.Contains(@"s\\n"))
            {
                responseText = responseText.Replace(@"s\\n", "");
                
            }

            if (responseText.Contains(@"S\\n"))
            {
                responseText = responseText.Replace(@"S\\n", "");
                
            }

            if (responseText.Contains(@"\n"))
            {
                while (responseText.Contains(@"\n"))
                {
                    responseText = responseText.Replace(@"\n", "");
                }
                

            }
            var model = JsonConvert.DeserializeObject<Response>(responseText);
           

            return model;
        }

        /// <summary>
        /// Makes an async HTTP Request
        /// </summary>
        /// <param name="pMethod">Those methods you know: GET, POST, HEAD, etc...</param>
        /// <param name="pUrl">Very predictable...</param>
        /// <param name="pJsonContent">String data to POST on the server</param>
        /// <param name="pHeaders">If you use some kind of Authorization you should use this</param>
        /// <returns></returns>
        static async Task<HttpResponseMessage> Request(HttpMethod pMethod, string pUrl, string pJsonContent, Dictionary<string, string> pHeaders)
        {
            string token = null;
            var lines = File.ReadLines("token.txt");
            foreach (var line in lines)
            {
                if(line.Contains("token"))
                {
                    token = line.Replace("token", "");
                }
            }
            
            try
            {
                var httpRequestMessage = new HttpRequestMessage();
                httpRequestMessage.Method = pMethod;
                httpRequestMessage.RequestUri = new Uri(pUrl);
                httpRequestMessage.Headers.Add("token", token);
                foreach (var head in pHeaders)
                {
                    httpRequestMessage.Headers.Add(head.Key, head.Value);
                }
                switch (pMethod.Method)
                {
                    case "POST":
                        HttpContent httpContent = new StringContent(pJsonContent, Encoding.UTF8, "application/json");
                        httpRequestMessage.Content = httpContent;
                        break;

                }
                return await _Client.SendAsync(httpRequestMessage);
            }
            catch
            {
              //  MessageBox.Show(error.Message);
                System.Threading.Thread.Sleep(5000);
                return await Request(pMethod, pUrl, pJsonContent, pHeaders);
            }

        }
    }
}

using Nancy.Json;
using Newtonsoft.Json;
using NokiaAndBell_GUI.models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NokiaAndBell_GUI.services
{
    class GetPremiseData
    {
        private static JavaScriptSerializer _Serializer = new JavaScriptSerializer();
        class Input
        {
            /*public string dateFrom { get; set; }
            public string dateTo { get; set; }
            public string mru { get; set; }
            public string mfgSerNo { get; set; }
            public string[] status { get; set; }
            public string cycle { get; set; }
            public string installedMeterNumber { get; set; }*/
            public string premise { get; set; }
            /*public string office { get; set; }
            public int pageNum { get; set; }
            public int pageSize { get; set; }*/
        }
        public static PremiseRes GetToken(/*string dateFrom, string dateTo, string mru, string mfgSerNo, string[] status, string cycle, string installedMeterNumber, */string premise/*, string office, int pageSize, int pageNum*/)
        {
            JavaScriptSerializer js = new JavaScriptSerializer();
            string logs = "";
            /*string token = null;
            var lines = File.ReadLines("token.txt");
            foreach (var line in lines)
            {
                if (line.Contains("token"))
                {
                    token = line.Replace("token", "");
                }
            }*/

        request: try
        {
            using (var wc = new WebClient())
            {
                Input cust = new Input()
                {
                    /* dateFrom = dateFrom,
                        dateTo = dateTo,
                        mru = mru,
                        mfgSerNo = mfgSerNo,
                        status = status,
                        cycle = cycle,
                        installedMeterNumber = installedMeterNumber,*/
                    premise = premise,
                    /*office = office,
                    pageSize = pageSize,
                    pageNum = pageNum*/
                };
                var postData = _Serializer.Serialize(cust);
                wc.Headers["Content-type"] = "application/json";
                wc.Headers["token"] = "eyJhbGciOiJIUzI1NiJ9.eyJ1aWQiOiJEU1NGQVdEV0FEQVMuLi4iLCJzdWIiOiJ7XCJpZFwiOjk1LFwiYWNjb3VudElkXCI6XCIyOTQwMDNcIixcImFjY291bnROYW1lXCI6XCJFbG1lciBDLiBEdW1hbmRhblwiLFwicGhvbmVOdW1iZXJcIjpcIjU4MDEzODI5MlwiLFwiYWNjb3VudFN0YXR1c1wiOlwibm9ybWFsXCIsXCJsYXN0TG9naW5cIjpcIk1heSAyOCwgMjAyMCA1OjM1OjQ5IEFNXCIsXCJwYXNzd29yZFwiOlwiXCIsXCJlbWFpbFwiOlwiZWR1bWFuZGFuMjdAeWFob28uY29tXCIsXCJjb250cmFjdG9ySWRcIjoyLFwiY29udHJhY3Rvck5hbWVcIjpcIjAyQUlHYWh6aVwiLFwiaXNEZWxldGVcIjowLFwiY3JlYXRlZEF0XCI6XCJNYXIgMjMsIDIwMjAgODoxNDo1OCBBTVwiLFwidXBkYXRlZEF0XCI6XCJNYXkgMjgsIDIwMjAgMzowMTo1NSBBTVwifSIsInVzZXJfbmFtZSI6ImFkbWluIiwibmlja19uYW1lIjoiREFTREExMjEiLCJleHAiOjE1OTE4NDI5NDksImlhdCI6MTU5MDYzMzM0OSwianRpIjoiand0In0.bHKNq9JOS-vCVdQHuUQ0gVsWvezK07AlP-oP6Q5JrmA";

                var response = wc.UploadString("https://sec.nokia-zjbell.com/rolloutapi/meterManage/getMeterByMfgSerNo", "POST", postData);
                if (response.Contains(@"s\\n"))
                {
                    response = response.Replace(@"s\\n", "");
                 //   logs = response;
                }

                if (response.Contains(@"S\\n"))
                {
                    response = response.Replace(@"S\\n", "");
                  //  logs = response;
                }

                if (response.Contains(@"\n"))
                {
                    while(response.Contains(@"\n"))
                    {
                        response = response.Replace(@"\n", "");
                    }
                    //    logs = response;
                    
                }
                

                var jsonresult = JsonConvert.DeserializeObject<PremiseRes>(response);

                return jsonresult;
            }

        }
        catch (Exception error)
        {
                /*StreamWriter file = new StreamWriter("logs.txt");
                file.WriteLine(logs);
                file.Flush();
                file.Close();*/
                MessageBox.Show(error.Message);
            goto request;
        }
        }
    }
}

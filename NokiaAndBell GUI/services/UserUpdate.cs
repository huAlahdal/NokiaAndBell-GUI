using Nancy.Json;
using Newtonsoft.Json;
using NokiaAndBell_GUI.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NokiaAndBell_GUI.services
{
    class UserUpdate
    {
        private static readonly HttpClient _Client = new HttpClient();
        private static JavaScriptSerializer _Serializer = new JavaScriptSerializer();
        class Input
        {
            public string accountId { get; set; }
            public string password { get; set; }
            public string verifyCode { get; set; }
            public string verifyId { get; set; }

        }
            public static async Task<LoginRes> Run(string accountId, string password)
            {
                string url = "https://sec.nokia-zjbell.com/rolloutapi/loginService/login";
                Input cust = new Input()
                {
                    accountId = accountId,
                    password = password,
                    verifyCode = "0819",
                    verifyId = "2a27885191b440ca8e7a19e3dfbffafb",
                };
                var json = _Serializer.Serialize(cust);

                var response = await Request(HttpMethod.Post, url, json, new Dictionary<string, string>());

                string responseText = await response.Content.ReadAsStringAsync();
                var model = JsonConvert.DeserializeObject<LoginRes>(responseText);
                // var totext = JsonConvert.SerializeObject(model.data.meterSurveyInstalls);
                MessageBox.Show(model.msg);
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
                try
                {
                    var httpRequestMessage = new HttpRequestMessage();
                    httpRequestMessage.Method = pMethod;
                    httpRequestMessage.RequestUri = new Uri(pUrl);
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
                catch (Exception error)
                {
                    MessageBox.Show(error.Message);
                    System.Threading.Thread.Sleep(5000);
                    return await Request(pMethod, pUrl, pJsonContent, pHeaders);
                }

            }
    
    }
}

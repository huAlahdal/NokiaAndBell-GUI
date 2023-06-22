using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NokiaAndBell_GUI.models
{
    class LoginRes
    {
        public int code { get; set; }
        public string msg { get; set; }
        public LoginData data { get; set; }
    }

    class LoginData
    {
        public string errorReason { get; set; }
        public string success { get; set; }
        public string errorCode { get; set; }
        public string returnCode { get; set; }
        public string accountName { get; set; }
        public string accountType { get; set; }
        public string department { get; set; }
        public string post { get; set; }
        public string phoneNumber { get; set; }
        public string accountStatus { get; set; }
        public double lastLogin { get; set; }
        public string accountId { get; set; }
        public string email { get; set; }
        public int contractorId { get; set; }
        public string contractorName { get; set; }
        public string token { get; set; }
    }
}

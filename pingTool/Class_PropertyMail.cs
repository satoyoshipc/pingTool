using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pingTool
{
    class Class_PropertyMail
    {   
        
        
        //メール関係
        public string mailSendCheck { get; set; }
        public string sendtime { get; set; }

        public string smtpServer { get; set; }
        public string smtpPort { get; set; }
        public string sendAddress { get; set; }
        public string authCheck { get; set; }
        public string subject { get; set; }

        public string userID { get; set; }
        public string password { get; set; }


        public Class_PropertyMail()
        {
            //iniファイル取得
            Class_IniFile ini = new Class_IniFile("./pingTool.ini");

            //メール関係
            mailSendCheck = (ini["mail", "mailSendCheck"] == "") ? "no" : ini["mail", "mailSendCheck"];

            //
            smtpServer = (ini["mail", "smtpServer"] == "") ? "" : ini["mail", "smtpServer"];

            sendtime = (ini["mail", "sendtime"] == "") ? "" : ini["mail", "sendtime"];
            //
            smtpPort = (ini["mail", "smtpPort"] == "") ? "25" : ini["mail", "smtpPort"];

            sendAddress = (ini["mail", "sendAddress"] == "") ? "" : ini["mail", "sendAddress"];

            //
            subject = (ini["mail", "subject"] == "") ? "" : ini["mail", "subject"];

            //
            smtpPort = (ini["mail", "smtpPort"] == "") ? "" : ini["mail", "smtpPort"];

            authCheck = (ini["mail", "authCheck"] == "") ? "no" : ini["mail", "authCheck"];
            //
            userID = (ini["mail", "userID"] == "") ? "" : ini["mail", "userID"];

            //
            password = (ini["mail", "password"] == "") ? "" : ini["mail", "password"];
        }
    }
}

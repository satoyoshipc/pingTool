using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pingTool
{
    class Class_PropertyData
    {
        //実行間隔
        public int Timespan { get; set; }
        //通知する連続障害回数
        public int MessageCount { get; set; }
        //通知する連続復旧回数
        public int recoverMsgCount { get; set; }

        //トラップ関係
        public string recieveServer { get; set; }
        public string community { get; set; }
        public string version { get; set; }
        public string port { get; set; }
        public string objectID { get; set; }
        public string snmpTrapCheck { get; set; }



        public Class_PropertyData()
        {
            //iniファイル取得
            Class_IniFile ini = new Class_IniFile("./pingTool.ini");

            //読み込み
            int interval = (ini["ping", "interval"] == "") ? 60 : Convert.ToInt32(ini["ping", "interval"]);

            //最低10秒
            if (interval < 10) interval = 10;

            Timespan = interval;

            int alertCount = (ini["ping", "alertCount"] == "") ? 1 : Convert.ToInt32(ini["ping", "alertCount"]);

            //最低1回
            if (alertCount < 1) alertCount = 1;

            //間隔
            MessageCount = alertCount;

            //復旧カウント
            int recoverCount = (ini["ping", "recoverCount"] == "") ? 1 : Convert.ToInt32(ini["ping", "recoverCount"]);

            //最低1回
            if (recoverCount < 1) recoverCount = 1;

            //間隔
            recoverMsgCount = recoverCount;


            //取らなければno
            snmpTrapCheck = (ini["trap", "snmpTrapCheck"] == "") ? "no" : ini["trap", "snmpTrapCheck"];


            recieveServer = (ini["trap", "recieveServer"] == "") ? "" : ini["trap", "recieveServer"];

            //取れなければpublic
            community = (ini["trap", "community"] == "") ? "public" : ini["trap", "community"];

            //取れなければ1
            version = (ini["trap", "version"] == "") ? "1" : ini["trap", "version"];

            //取れなければ162
            port = (ini["trap", "port"] == "") ? "162" : ini["trap", "port"];

            objectID = (ini["trap", "objectID"] == "") ? "" : ini["trap", "objectID"];


        }

    }

}

using SnmpSharpNet;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pingTool
{
    class Class_sendTrap
    {
        //トラップ送信先
        public string trapServer { get; set; }
        //コミュニティ名
        public string communityname { get; set; }
        //ポート番号
        public int recieverport { get; set; }
        //SNMPバージョン
        public string version { get; set; }
        //ObjectID
        public string oid { get; set; }

        //トラップ送信
        public int execute(Class_keepResult res_cls)
        {
            TrapAgent agent = new TrapAgent();
            string oid_str = "";

            // Variable Binding collection to send with the trap
            VbCollection col = new VbCollection();
            oid_str = oid;

            //oidが取得できない
            if(oid_str == "" || oid_str == null) return -1;
            
            //varbind
            col.Add(new Oid(oid_str + ".1"), new Integer32(1));

            // Send the trap to the localhost port 162
            agent.SendV1Trap(new IpAddress(trapServer), recieverport, communityname,
                 new Oid(oid_str), new IpAddress(res_cls.address), SnmpConstants.EnterpriseSpecific,10,1,col);

            //正常時
            return 1;
        }

        //復旧トラップ
        public int recoverexecute(Class_keepResult res_cls)
        {
            TrapAgent agent = new TrapAgent();
            string oid_str = "";
            // Variable Binding collection to send with the trap
            VbCollection col = new VbCollection();

            oid_str = oid;
            //oidが取得できない
            if (oid_str == "" || oid_str == null) return -1;
            
            //varbind
            col.Add(new Oid(oid_str + ".1"), new Integer32(0));

            // Send the trap to the localhost port 162
            //1.3.6.1.2.1.1.2.0
            agent.SendV1Trap(new IpAddress(trapServer), recieverport, communityname,
                 new Oid(oid_str), new IpAddress(res_cls.address), SnmpConstants.EnterpriseSpecific, 10, 0, col);

            //正常時
            return 1;


        }

        //現在時間をUNIXTimeで取得
        public static uint GetTimeStamp(DateTime datetime)
        {
            return (uint)(datetime - new DateTime(1970, 1, 1, 0, 0, 0)).TotalSeconds;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pingTool
{
    class Class_Ping
    {
        private static readonly log4net.ILog logger = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        //パラメータのアドレスに対して、PINGを実行する。
        public void ExecPing(Class_keepResult res_cls)
        {   
            res_cls.newDt = DateTime.Now;


            //Pingオブジェクトの作成
            System.Net.NetworkInformation.Ping p =
                new System.Net.NetworkInformation.Ping();
            //IPaddressにPingを送信する 5秒固定
            //デフォルトのバッファ・サイズは32bytes
            System.Net.NetworkInformation.PingReply reply = p.Send(res_cls.address,5000);
            
            //失敗時リトライ
            //if(reply.Status != System.Net.NetworkInformation.IPStatus.Success) 
            //    reply = p.Send(res_cls.address, 5000);


            //結果を取得
            //成功時
            if (reply.Status == System.Net.NetworkInformation.IPStatus.Success)
            {
                //Console.WriteLine("Reply from {0}:bytes={1} time={2}ms TTL={3}",
                //    reply.Address, reply.Buffer.Length,
                //    reply.RoundtripTime, reply.Options.Ttl);

                //前回成功時
                if (res_cls.status == 1)
                {
                    //復旧カウントをプラス
                    if (res_cls.recoverCount > 0)
                        res_cls.recoverCount++;
                    res_cls.changeflg = 0;
                }
                // 前回障害 (復旧)
                else if(res_cls.status == -1)
                {
                    // 復旧時
                    logger.Warn(res_cls.address + ": Ping応答復旧。" + reply.Status);

                    res_cls.status = 1;
                    
                    //カウントを0に戻す
                    res_cls.count = 0;
                    //メッセージを消す
                    res_cls.message = "";
                    //復旧カウントを開始
                    res_cls.recoverCount = 1;
                    res_cls.changeflg = 1;


                }
                //初回
                else
                {
                    res_cls.status = 1;
                    res_cls.changeflg = 0;

                }

            }
            else
            {

                // 失敗時
                logger.Warn(res_cls.address + ": Ping応答なし。" + reply.Status);

                res_cls.message = reply.Status.ToString();

                // 前回成功時
                if (res_cls.status == 1)
                {
                    res_cls.lastDt = DateTime.Now;
                    //カウントを開始
                    res_cls.count = 1;
                    res_cls.status = -1;
                    //復旧カウントを0
                    res_cls.recoverCount = 0;
                    
                    res_cls.changeflg = 1;

                }
                // 障害
                else if (res_cls.status == -1)
                {
                    //カウント追加(カウントが振り切れたら1に戻す)
                    res_cls.count = (res_cls.count == long.MaxValue) ? 1 : res_cls.count + 1;
                    res_cls.changeflg = 0;
                }
                // 初回
                else 
                {
                    res_cls.lastDt = DateTime.Now;
                    res_cls.status = -1;
                    //カウント追加　カウントが振り切れたら1に戻す
                    res_cls.count = (res_cls.count == long.MaxValue) ? 1 : res_cls.count + 1;
                    res_cls.changeflg = 0;

                }
            }
            p.Dispose();
        } 

    }
}

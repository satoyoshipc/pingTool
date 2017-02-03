using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pingTool
{
    class Class_SendMail
    {
        private static readonly log4net.ILog logger = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        private static string bodyText = "PingTool正常稼動中です。";

        public string send(Class_PropertyMail prop) { 
            try
            {

                
                //JISコード
                System.Text.Encoding enc = System.Text.Encoding.GetEncoding(50220);

                //MailMessageの作成
                System.Net.Mail.MailMessage msg = new System.Net.Mail.MailMessage("pingTool@actwatch.com", prop.sendAddress);
                msg.Subject = prop.subject;
                msg.SubjectEncoding = enc;
            
                //本文と、本文の文字コードを設定する
                msg.Body = bodyText;
                
                //文字コード
                msg.BodyEncoding = enc;
                //「content-transfer-encoding」を「7bit」にする
                msg.BodyTransferEncoding = System.Net.Mime.TransferEncoding.SevenBit;

                System.Net.Mail.SmtpClient sc = new System.Net.Mail.SmtpClient();

                //SMTPサーバーなどを設定する
                sc.Host = prop.smtpServer;
                sc.Port = Int16.Parse(prop.smtpPort);

                //ユーザー名とパスワードを設定する(AUTH LOGIN認証)
                if (prop.authCheck.IndexOf("yes", StringComparison.OrdinalIgnoreCase) > -1)
                    sc.Credentials = new System.Net.NetworkCredential(prop.userID, prop.password);

                sc.DeliveryMethod = System.Net.Mail.SmtpDeliveryMethod.Network;
                //メッセージを送信する
                sc.Send(msg);

                //後始末
                msg.Dispose();
                sc.Dispose();
                logger.Info("メールを送信しました。");
                return "メールを送信しました。";
            }
            catch (Exception ex)
            {
                logger.Error("メールの送信時にエラーが発生しました。" + ex.Message + " " + ex.StackTrace);
                return "メールの送信時にエラーが発生しました。";
            }
        }
    }
}

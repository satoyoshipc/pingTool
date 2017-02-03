using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pingTool
{
    public partial class Form_Configure : Form
    {
        private static readonly log4net.ILog logger = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public Form_Configure()
        {
            InitializeComponent();
        }

        //閉じるボタン
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();

        }
        //OKボタン
        private void button1_Click(object sender, EventArgs e)
        {
            //プロパティ情報をファイルに書き込む

            //iniファイル取得
            Class_IniFile ini = new Class_IniFile("./pingTool.ini");
            //書き込み
            //間隔
            if (this.numericUpDown1.Value.ToString() != "")
                ini["ping", "interval"] = this.numericUpDown1.Value.ToString();

            //通知する連続障害回数
            if (this.numericUpDown2.Value.ToString() != "")
                ini["ping", "alertCount"] = this.numericUpDown2.Value.ToString();

            //トラップ通知復旧回数
            if (this.m_recoverCount.Value.ToString() != "")
                ini["ping", "recoverCount"] = this.m_recoverCount.Value.ToString();

            //トラップ設定
            ini["trap", "recieveServer"] = this.m_recieveServer.Text;
            ini["trap", "community"] = this.m_community.Text;
            ini["trap", "version"] = this.versionCombo.Text;
            ini["trap", "port"] = this.m_port.Text;
            ini["trap", "objectID"] = this.m_objectID.Text;


            if (this.m_SnmpTrapCheck.Checked)
                ini["trap", "snmpTrapCheck"] = "yes";
            else
                ini["trap", "snmpTrapCheck"] = "no";


            if (this.m_mailSendCheck.Checked)
            {
                ini["mail", "mailSendCheck"] = "yes";
                //メール関係はサブルーチンで行う
                if (!mailDatacheck()) return;
            }
            else
            {
                ini["mail", "mailSendCheck"] = "no";
            }


            string sendtime;

            if ((Int32.Parse(this.m_comboHour.Text) >= 0 && Int32.Parse(this.m_comboHour.Text) < 24) &&
                    (Int32.Parse(this.m_comboMinute.Text) >= 0 && (Int32.Parse(this.m_comboMinute.Text) <= 59)))
            {
                sendtime = this.m_comboHour.Text + ":" + this.m_comboMinute.Text;
                ini["mail", "sendtime"] = sendtime;

            }
            else
            {
                ini["mail", "sendtime"] = "00:00";

            }

            ini["mail", "smtpServer"] = this.m_smtpServer.Text;
            ini["mail", "smtpPort"] = this.m_smtpPort.Text;
            ini["mail", "sendAddress"] = this.m_sendAddress.Text;
            ini["mail", "subject"] = this.m_subject.Text;

            //認証
            if (this.m_authCheck.Checked)
                ini["mail", "authCheck"] = "yes";
            else
                ini["mail", "authCheck"] = "no";
            //
            ini["mail", "userID"] = this.m_username.Text;
            ini["mail", "password"] = this.m_password.Text;


            this.Close();
        }
        private Boolean mailDatacheck( )
        {
            if (this.m_mailSendCheck.Checked)
            {

                if (this.m_smtpServer.Text == "")
                {
                    MessageBox.Show("SMTPサーバを入力してください。", "pingTool", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    m_smtpServer.Focus();
                    return false;
                }
                if (this.m_smtpPort.Text == "")
                {
                    MessageBox.Show("ポートを入力してください。", "pingTool", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    m_smtpPort.Focus();
                    return false;

                }

                if (this.m_sendAddress.Text == "")
                {
                    MessageBox.Show("メール宛先を入力してください。", "pingTool", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    m_sendAddress.Focus();
                    return false;

                }
                if (this.m_subject.Text == "")
                {
                    MessageBox.Show("メールタイトルを入力してください。", "pingTool", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    m_subject.Focus();
                    return false;
                }
            }
   
            return true;
        }
        private void Form_Configure_Load(object sender, EventArgs e)
        {

            //iniファイル取得
            Class_IniFile ini = new Class_IniFile("./pingTool.ini");

            //インターバル
            Decimal interval = (ini["ping", "interval"] == "") ? 60 : Convert.ToDecimal(ini["ping", "interval"]);

            //最低10秒
            if (interval < 10) interval = 10;

            //アラートカウント
            Decimal alertCount = (ini["ping", "alertCount"] == "") ? 1 : Convert.ToDecimal(ini["ping", "alertCount"]);

            //最低1回
            if (alertCount < 1) alertCount = 1;

            //復旧カウント
            Decimal recoverCount = (ini["ping", "recoverCount"] == "") ? 1 : Convert.ToDecimal(ini["ping", "recoverCount"]);


            //最低1回
            if (recoverCount < 1) recoverCount = 1;

            //間隔
            this.numericUpDown1.Value = interval;
            this.numericUpDown2.Value = alertCount;
            this.m_recoverCount.Value = recoverCount;


            this.versionCombo.SelectedIndex = 0;


            //トラップ送信する/しない
            string SnmpTrapCheck = (ini["trap", "snmpTrapCheck"] == "") ? "" : ini["trap", "snmpTrapCheck"].Trim();

            if (String.Compare(SnmpTrapCheck, "yes", true) == 0)
                //Yes
                this.m_SnmpTrapCheck.Checked = true;
            else
                //No
                this.m_SnmpTrapCheck.Checked = false;



            string recieveServer = (ini["trap", "recieveServer"] == "") ? "" : ini["trap", "recieveServer"];
            this.m_recieveServer.Text = recieveServer;

            string community = (ini["trap", "community"] == "") ? "" : ini["trap", "community"];
            this.m_community.Text = community;

            string version = (ini["trap", "version"] == "") ? "" : ini["trap", "version"];
            this.versionCombo.Text = version;

            string port = (ini["trap", "port"] == "") ? "162" : ini["trap", "port"];
            this.m_port.Text = port;

            string objectID = (ini["trap", "objectID"] == "") ? "" : ini["trap", "objectID"];
            this.m_objectID.Text = objectID;


            //メール送信する/しない

            string MailSendCheck = (ini["mail", "mailSendCheck"] == "") ? "" : ini["mail", "mailSendCheck"].Trim();

            if (String.Compare(MailSendCheck, "yes", true) == 0)
                //Yes
                this.m_mailSendCheck.Checked = true;
            else
                //No
                this.m_mailSendCheck.Checked = false;

            string sendtime;
            if (ini["mail", "sendtime"] == "") {
                sendtime = "";
            }
            else
            {
                string[] array;
                sendtime = ini["mail", "sendtime"];
                array = sendtime.Split(':');
                if(array.Length > 1)
                {
                    this.m_comboHour.Text = array[0];
                    this.m_comboMinute.Text = array[1];
                }


            }

            string smtpServer = (ini["mail", "smtpServer"] == "") ? "" : ini["mail", "smtpServer"];
            this.m_smtpServer.Text = smtpServer;

            string smtpPort = (ini["mail", "smtpPort"] == "") ? "" : ini["mail", "smtpPort"];
            this.m_smtpPort.Text = smtpPort;

            string sendaddress = (ini["mail", "sendAddress"] == "") ? "" : ini["mail", "sendAddress"];
            this.m_sendAddress.Text = sendaddress;

            string subject = (ini["mail", "subject"] == "") ? "162" : ini["mail", "subject"];
            this.m_subject.Text = subject;

            //認証
            string authcheck = (ini["mail", "authCheck"] == "") ? "" : ini["mail", "authCheck"].Trim();

            if (String.Compare(authcheck, "yes", true) == 0)
                //Yes
                this.m_authCheck.Checked = true;
            else
                //No
                this.m_authCheck.Checked = false;

            string userID = (ini["mail", "userID"] == "") ? "" : ini["mail", "userID"];
            this.m_username.Text = userID;

            string password = (ini["mail", "password"] == "") ? "" : ini["mail", "password"];
            this.m_password.Text = password;
        }
        //テスト送信ボタン
        private void button3_Click(object sender, EventArgs e)
        {
            //メール関係はサブルーチンで行う
            if (!mailDatacheck()) return;
            try
            {

                //JISコード
                System.Text.Encoding enc = System.Text.Encoding.GetEncoding(50220);

                //MailMessageの作成
                System.Net.Mail.MailMessage msg = new System.Net.Mail.MailMessage("pingTool@actwatch.com", m_sendAddress.Text);
                msg.Subject = m_subject.Text;
                msg.SubjectEncoding = enc;

                //本文と、本文の文字コードを設定する
                msg.Body = "pingToolよりメールテスト送信。";

                msg.BodyEncoding = enc;
                //「content-transfer-encoding」を「7bit」にする
                msg.BodyTransferEncoding = System.Net.Mime.TransferEncoding.SevenBit;

                System.Net.Mail.SmtpClient sc = new System.Net.Mail.SmtpClient();
                //SMTPサーバーなどを設定する
                sc.Host = m_smtpServer.Text;
                sc.Port = Int16.Parse(m_smtpPort.Text);

                //ユーザー名とパスワードを設定する(AUTH LOGIN認証)
                if (m_authCheck.Checked) sc.Credentials = new System.Net.NetworkCredential(m_username.Text, m_password.Text);

                sc.DeliveryMethod = System.Net.Mail.SmtpDeliveryMethod.Network;
                //メッセージを送信する
                sc.Send(msg);

                //後始末
                msg.Dispose();
                sc.Dispose();

                MessageBox.Show("メール送信しました。","pingTool",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("テストメールの送信時にエラーが発生しました。" + ex.Message, "pingTool", MessageBoxButtons.OK, MessageBoxIcon.Error);
                logger.Error("テストメールの送信時にエラーが発生しました。" + ex.Message + " " + ex.StackTrace);
            }


        }

        //タブが変更されたとき
        private void tabControl1_Selected(object sender, TabControlEventArgs e)
        {
            int index = tabControl1.SelectedIndex;
            if(index == 2)

                m_hanei_label.Enabled = false;
            else
                m_hanei_label.Enabled = true;

        }
    }
}

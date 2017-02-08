using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;



namespace pingTool
{
    public partial class Form_main : Form
    {
        private static readonly log4net.ILog logger = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        ArrayList tmpArray;
        Dictionary<int, Class_keepResult> classList;
        delegate void Listdelegate(Class_keepResult cls,int newFlg);

        private System.Timers.Timer myTimer;

        private Class_PropertyData iniData ;

        // CancellationTokenSourceクラスを準備（これでキャンセルを通知出来る）
        private CancellationTokenSource cts;

        //メール送信したら立てる
        private Boolean mailsendflg = false;

        public Form_main()
        {
            InitializeComponent();
            //スレッドからラベル等のコントロールをアクセスすることを指定
            Control.CheckForIllegalCrossThreadCalls = false;
        }

        private void 停止sToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(停止sToolStripMenuItem.Text.StartsWith("停止"))
            {

                if (MessageBox.Show("停止しますか?","pingTool",MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    m_status.ForeColor = Color.Red;
                    m_status.Text = "停止中";
                    myTimer.Enabled = false;
                    //タスクスレッドをキャンセル
                    cts.Cancel();
                    this.開始eToolStripMenuItem.Enabled = true;
                    logger.Info("PING停止");
                    停止sToolStripMenuItem.Text="再開(&r)";
                    TaskBarLabel1.Text = "停止中";
                    
                }
            }
            else if (停止sToolStripMenuItem.Text.StartsWith("再開"))
            {
                if (MessageBox.Show("再開しますか?", "pingTool", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    m_status.ForeColor = Color.Red;
                    m_status.Text = "実行中";
                    TaskBarLabel1.Text = "実行中";

                    //キャンセルトークンスタート
                    cts = new CancellationTokenSource();
               
                    myTimer.Enabled = true;
                    停止sToolStripMenuItem.Enabled = true;
                    this.開始eToolStripMenuItem.Enabled = false;
                    logger.Info("PING再開");
                    停止sToolStripMenuItem.Text = "停止(&e)";
                }
            }
        }

        private void 開くoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //ファイル選択ダイアログの表示
            string str = "";
            str = Disp_FileSelectDlg();
            if (str != "")
            {
                m_listfile.Text = str;
                this.開始eToolStripMenuItem.Enabled = true;
            }
        }
        //ファイル選択ダイアログを表示
        private string Disp_FileSelectDlg()
        {

            string retStr = "";

            //OpenFileDialogクラスのインスタンスを作成
            OpenFileDialog ofd = new OpenFileDialog();

            //はじめのファイル名を指定する
            //はじめに「ファイル名」で表示される文字列を指定する
            ofd.FileName = "";
            //はじめに表示されるフォルダを指定する
            //指定しない（空の文字列）の時は、現在のディレクトリが表示される
            ofd.InitialDirectory = "";
            //[ファイルの種類]に表示される選択肢を指定する
            //指定しないとすべてのファイルが表示される
            ofd.Filter =
                "すべてのファイル(*.*)|*.*";
            //[ファイルの種類]ではじめに
            //「すべてのファイル」が選択されているようにする
            ofd.FilterIndex = 2;
            //タイトルを設定する
            ofd.Title = "開くファイルを選択してください";
            //ダイアログボックスを閉じる前に現在のディレクトリを復元するようにする
            ofd.RestoreDirectory = true;
            //存在しないファイルの名前が指定されたとき警告を表示する
            //デフォルトでTrueなので指定する必要はない
            ofd.CheckFileExists = true;
            //存在しないパスが指定されたとき警告を表示する
            //デフォルトでTrueなので指定する必要はない
            ofd.CheckPathExists = true;

            //ダイアログを表示する
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                //OKボタンがクリックされたとき
                //選択されたファイル名を表示する
                retStr = ofd.FileName;
            }

            return retStr;
        }

        //表示前処理
        private void Form1_Load(object sender, EventArgs e)
        {
            //バージョン情報
            System.Diagnostics.FileVersionInfo ver =
                System.Diagnostics.FileVersionInfo.GetVersionInfo(System.Reflection.Assembly.GetExecutingAssembly().Location);
            this.m_versioninfo.Text = "ver:" + ver.FileVersion;


            //ツールメニューの設定
            this.開始eToolStripMenuItem.Enabled = false;
            this.停止sToolStripMenuItem.Enabled = false;


            //ListViewコントロールの設定
            listView1.View = View.Details;
            listView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);

            listView1.SmallImageList = imageList1;
            listView1.FullRowSelect = true;

            //カラムの設定（4列）
            listView1.Columns.Add("結果");
            listView1.Columns.Add("障害カウント");
            listView1.Columns.Add("対象");
            listView1.Columns.Add("開始日時");
            listView1.Columns.Add("最新監視日時");
            listView1.Columns.Add("前回障害日時");
            listView1.Columns[0].Width = 50;
            listView1.Columns[1].Width = 50;
            listView1.Columns[2].Width = 130;
            listView1.Columns[3].Width = 160;
            listView1.Columns[4].Width = 160;
            listView1.Columns[5].Width = 160;
        }
        private async void OnTimerEvent(object source, ElapsedEventArgs e)
        {

            //PING処理を実行
            try
            {
                string retstr;
                TaskBarLabel1.Text = "PING実行中";

                retstr = await pingexe(tmpArray, classList, cts.Token);

            }
            catch (Exception ex)
            {
                logger.Fatal("PING処理で異常が発生しました。" + ex.Message);
            }

            //指定時間にメール通知を行う
            PeriodicReportMail();
        }

        private void PeriodicReportMail()
        {
            //プロパティファイルを読み込む
            Class_PropertyMail prop_mail = new Class_PropertyMail();

            if (prop_mail.mailSendCheck.IndexOf("yes", StringComparison.OrdinalIgnoreCase) > -1)
            {
                // 現在時を取得
                DateTime datetime = DateTime.Now;
                //DateTime datetime_now = new DateTime(datetime.Year, datetime.Month, datetime.Day, datetime.Hour, datetime.Minute, 0); //年, 月, 日, 時間, 分, 秒
                
                string[] str_array;
                string sendtm = prop_mail.sendtime, hour = "00", min = "00";
                if(sendtm != "")
                {
                    str_array = sendtm.Split(':');
                    if(str_array.Length > 1)
                    {
                        hour = str_array[0];
                        min = str_array[1];
                    }
                }

                //設定時刻を過ぎたらメールを送信する。
                //DateTime datetime_set = new DateTime(datetime.Year, datetime.Month, datetime.Day, Int32.Parse(hour), Int32.Parse(min), 0); //年, 月, 日, 時間, 分, 秒

                //現在日時の取得
                int datetime_now;
                datetime_now = Int32.Parse(datetime.Hour.ToString("00") + datetime.Minute.ToString("00"));


                //設定日時の取得
                int datetime_set;
                datetime_set = Int32.Parse(hour.PadLeft(2, '0') + min.PadLeft(2, '0'));
                if ((datetime_now > datetime_set) && mailsendflg == false)
                {
                    mailsendflg = true;
                    Class_SendMail sendmail_cls = new Class_SendMail();
                    string retstr = sendmail_cls.send(prop_mail);

                    this.TaskBarLabel1.Text = retstr;
                    
                }
                //日が変わったらフラグを変える
                if ((datetime_now < datetime_set) && mailsendflg == true)
                {
                    mailsendflg = false;
                }

            }

        }
        //一覧ファイルを読み込み実行を行う
        private async void 開始eToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //プロパティファイルを読み込む
            iniData = new Class_PropertyData();

            //一覧ファイルの読み込み
            Class_ReadFile readList = new Class_ReadFile();

            //ファイルを読み込む
            if ( readList.readListFile(m_listfile.Text) ==  0 ){
                  tmpArray = readList.listfiletext;
            }

            //確認画面
            if (MessageBox.Show(tmpArray.Count.ToString() + "件読み込みました。" + Environment.NewLine + "PING処理実行します。よろしいですか？", "pingTool", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                try { 
                    this.停止sToolStripMenuItem.Enabled = true;
                    this.開始eToolStripMenuItem.Enabled = false;
                    停止sToolStripMenuItem.Text = "停止(&e)";
                    m_countDisp.Text = tmpArray.Count.ToString() + "件";
                    logger.Info("PING開始");
                    listView1.Items.Clear();
                    //iniData.Timespan + "秒周期";
                    m_status.ForeColor = System.Drawing.Color.Pink;
                    m_status.Text = "実行中";
                    mailsendflg = false;
                    停止sToolStripMenuItem.Enabled = true;

                    //キャンセルトークンスタート
                    cts = new CancellationTokenSource();

                    tmpArray = readList.listfiletext;

                    classList = new Dictionary<int, Class_keepResult>();

                    //PING処理を実行
                    string retstr;

                    TaskBarLabel1.Text = "お待ちください...";
                    retstr = await pingexe(tmpArray, classList, cts.Token);

                    myTimer = new System.Timers.Timer();
                    myTimer.Enabled = true;
                    myTimer.AutoReset = true;
                    myTimer.Interval = iniData.Timespan*1000;
                    //myTimer.Interval = 10000;
                    myTimer.Elapsed += new ElapsedEventHandler(OnTimerEvent);
                }
                catch (Exception ex)
                {
                    logger.Fatal("PING処理で異常が発生しました。 "+ ex.Message);
                    TaskBarLabel1.Text = "PING処理で異常が発生しました。 " + ex.Message;
                }
            }
        }

        //非同期でPINGを実行する。
        private Task<string> pingexe(ArrayList tmpArray, Dictionary<int, Class_keepResult> classList, CancellationToken token) 
        {
            try {
                Class_keepResult res_cls;
                Class_Ping cls_ping = new Class_Ping();
                for (int i = 0; i < tmpArray.Count; i++)
                {
                    int newFlg = 1;

                    // キーの存在チェック
                    if (classList.ContainsKey(i + 1))
                    {
                        newFlg = 0;
                        //すでにある場合
                        res_cls = classList[i + 1];
                    }
                    else
                    {
                        // 存在しない場合
                        newFlg = 1;
                        res_cls = new Class_keepResult();
                        res_cls.startDt = DateTime.Now;
                        //結果クラス
                        res_cls.id = i + 1;
                        res_cls.address = (string)tmpArray[i];
                        res_cls.status = 0;
                    }

                    classList[i + 1] = res_cls;

                    //PING実行
                    cls_ping.ExecPing(res_cls);
                    TaskBarLabel1.Text = "";

                    classList[i + 1] = res_cls;
                    
                    //キャンセルが押されたとき
                    token.ThrowIfCancellationRequested();

                    if (iniData.snmpTrapCheck.IndexOf("yes", StringComparison.OrdinalIgnoreCase) > -1)
                    {
                        //エラー回数が設定数を超えたらメッセージを出す
                        if (res_cls.count > 0)
                        {

                            //int ccount = (int)res_cls.count % iniData.MessageCount;

                            if (iniData.MessageCount == res_cls.count)
                            {

                                Class_sendTrap sendTrap = new Class_sendTrap();
                                sendTrap.trapServer = iniData.recieveServer;
                                sendTrap.communityname = iniData.community;
                                sendTrap.recieverport = int.Parse(iniData.port);
                                sendTrap.oid = iniData.objectID;

                                int ret = sendTrap.execute(res_cls);
                                //正常
                                if (ret == 1 )
                                {
                                    logger.Info("SNMP障害トラップを送信しました。");
                                    TaskBarLabel1.Text = "SNMP障害トラップを送信しました。";
                                }
                                //エラー
                                else if (ret == -1)
                                {
                                    logger.Warn("SNMP障害トラップ送信に失敗しました。OIDが取得できませんでした。");
                                    TaskBarLabel1.Text = "SNMP障害トラップ送信に失敗しました。OIDが取得できませんでした。";
                                }
                            }
                        }
                    
                        //復旧カウントが設定数を超えていたらトラップを送信
                        if (res_cls.recoverCount > 0)
                        {
                            int ccount = (int)res_cls.recoverCount % iniData.recoverMsgCount;
                            if (ccount == 0)
                            {

                                Class_sendTrap sendTrap = new Class_sendTrap();
                                sendTrap.trapServer = iniData.recieveServer;
                                sendTrap.communityname = iniData.community;
                                sendTrap.recieverport = int.Parse(iniData.port);
                                sendTrap.oid = iniData.objectID;

                                int ret = sendTrap.recoverexecute(res_cls);
                                //正常
                                if (ret == 1)
                                {
                                    logger.Info("SNMP復旧トラップを送信しました。");
                                    TaskBarLabel1.Text = "SNMP復旧トラップを送信しました。";
                                    res_cls.recoverCount = 0;
                                }
                                //エラー
                                else if (ret ==-1)
                                {
                                    logger.Warn("SNMP復旧トラップ送信に失敗しました。OIDが取得できませんでした。");
                                    TaskBarLabel1.Text = "SNMP復旧トラップ送信に失敗しました。OIDが取得できませんでした。";
                                }
                            }
                        }
                    }
                    //一覧に表示
                    Invoke(new Listdelegate(Displist), new object[] { res_cls, newFlg });
                }


            }
            catch (OperationCanceledException)
            {
                //キャンセル
                MessageBox.Show("停止しました。","pingTool",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }

            catch (Exception ex)
            {
                MessageBox.Show("例外が発生しました。" + " pingexe " + ex.Message);
                logger.Fatal("例外が発生しました。" + " pingexe " + ex.Message);
                
            }
            return Task.Delay(0)
                    .ContinueWith(t => "Hello");
            
        }

        //取得した値を一覧に反映
        private void Displist(Class_keepResult res_cls,int newFlg)
        {
            //リスト項目の設定
            ListViewItem itemx = new ListViewItem();
            listView1.BeginUpdate();

            //すでに存在する場合は更新
            if (newFlg == 0)
            {

                foreach (ListViewItem item in listView1.Items)
                {
                    var invoice = int.Parse(item.Name);
                    if (invoice == res_cls.id)
                    {
                        //結果、カウント、最新を変更する
                        if (res_cls.status == 1)
                        {
                            //正常
                            item.ImageIndex = 0;
                        }
                        else
                        {
                            //不通
                            item.ImageIndex = 1;
                        }
                        //カウント
                        item.SubItems[1].Text = res_cls.count.ToString();

                        //直近の監視日時
                        DateTime dateDefault = new DateTime();
                        string str_date;
                        if (res_cls.newDt.CompareTo(dateDefault) == 0)
                            str_date = "";
                        else
                            str_date = res_cls.newDt.ToString();

                        item.SubItems[4].Text = str_date;


                        //障害日時
                        if (res_cls.lastDt.CompareTo(dateDefault) == 0)
                            str_date = "";
                        else
                            str_date = res_cls.lastDt.ToString();


                        item.SubItems[5].Text = str_date;

                        //変化があった場合色を変える
                        if (res_cls.changeflg == 1)
                        {
                            item.BackColor = Color.Yellow;
                        }else
                        {
                            item.BackColor = SystemColors.Window;
                        }

                        break;
                    }
                }

                
            }
            //新規挿入のとき
            else if (newFlg == 1)
            {


                if (res_cls.status == 1)
                {
                    itemx.ImageIndex = 0;
                }
                else
                {
                    itemx.ImageIndex = 1;
                }
                itemx.Name = res_cls.id.ToString();
                itemx.SubItems.Add(res_cls.count.ToString());
                itemx.SubItems.Add(res_cls.address + " ");
                itemx.SubItems.Add(res_cls.startDt.ToString());
                itemx.SubItems.Add(res_cls.newDt.ToString());

                DateTime dateDefault = new DateTime();
                string str_date;
                if (res_cls.lastDt.CompareTo(dateDefault) == 0)
                    str_date = "";
                else
                    str_date = res_cls.lastDt.ToString();

                itemx.SubItems.Add(str_date);



                //アイテムをリスビューに追加する
                listView1.Items.Add(itemx);
            
                int count = listView1.Items.Count;

                if (count > 0)
                {
                    //listView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);

                    listView1.EnsureVisible(count - 1);
                }
            }
            listView1.EndUpdate();

        }

        private void 設定cToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //設定画面を開く
            Form_Configure form = new Form_Configure();
            form.Show();
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {

            
        }
        //詳細画面を表示する
        private void listView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (listView1.SelectedItems.Count == 0) return;

            //詳細画面表示
            ListViewItem itemx = new ListViewItem();

            Class_keepResult res_cls = new Class_keepResult();

            itemx = listView1.SelectedItems[0];
            var invoice = int.Parse(itemx.Name);
            // キーの存在チェック
            if (classList.ContainsKey(invoice ))
            {
                res_cls = classList[invoice ];
            }

            String ss = Form_detail.ShowMiniForm(res_cls);
        }

        //リストビューについてCtrl + cを有効に
        private void listView1_KeyDown(object sender, KeyEventArgs e)
        {
            if (sender != listView1) return;
            if (e.Control && e.KeyCode == Keys.C)
                CopySelectedValuesToClipboard();
        }
        //値のこぴぺ
        private void CopySelectedValuesToClipboard()
        {
            if (listView1.SelectedItems.Count == 0)
            {
                return;
            }
            string yuncstr = "";
            foreach (ListViewItem item in listView1.SelectedItems) {
                yuncstr = yuncstr + item.SubItems[1].Text + ",";
                yuncstr = yuncstr + item.SubItems[2].Text + ",";
                yuncstr = yuncstr + item.SubItems[3].Text + ",";
                yuncstr = yuncstr + item.SubItems[4].Text + ",";
                yuncstr = yuncstr + item.SubItems[5].Text + Environment.NewLine;

            }
            Clipboard.SetText(yuncstr);
        }

        private void コピーToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(listView1.SelectedItems.Count == 0)
            {
                return;
            }
            string yuncstr = "";
            foreach (ListViewItem item in listView1.SelectedItems)
            {
                yuncstr = yuncstr + item.SubItems[1].Text + ",";
                yuncstr = yuncstr + item.SubItems[2].Text + ",";
                yuncstr = yuncstr + item.SubItems[3].Text + ",";
                yuncstr = yuncstr + item.SubItems[4].Text + ",";
                yuncstr = yuncstr + item.SubItems[5].Text + Environment.NewLine;

            }

            Clipboard.SetText(yuncstr);

        }

        //終了時確認ダイアログを表示する
        private void Form_main_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("pingToolを終了しますか？", "pingTool", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.Cancel)
                e.Cancel = true; 
        }
    }
}

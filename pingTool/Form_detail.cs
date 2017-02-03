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
    public partial class Form_detail : Form
    {

        public string ReturnValue;       //Form1に返す戻り値

        private Class_keepResult argumentValues; //Form1から受け取った引数

        public Form_detail(Class_keepResult arguments)
        {
            //Form_mainから受け取ったデータをForm_detailのインスタンスのメンバに格納
            this.argumentValues = arguments;

            InitializeComponent();
        }

        static public string ShowMiniForm(Class_keepResult argments)
        {
            Form_detail f = new Form_detail(argments);
            f.ShowDialog();
            string receiveText = f.ReturnValue;
            f.Dispose();

            return receiveText;

        }
        //閉じるボタン
        private void button1_Click(object sender, EventArgs e)
        {
            this.ReturnValue = "";
            this.Close();
        }

        //表示前処理
        private void Form_detail_Load(object sender, EventArgs e)
        {
            listView1.View = View.Details;
            listView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
            listView1.FullRowSelect = true;
            listView1.GridLines = true;


            //カラムの設定（9列）
            listView1.Columns.Add("項目");
            listView1.Columns.Add("値");

            listView1.Columns[0].Width = 100;
            listView1.Columns[1].Width = 250;

            ListViewItem itemx;

            //アイテムの作成
            itemx = listView1.Items.Add("通番");

            itemx.SubItems.Add(argumentValues.id.ToString());


            itemx = listView1.Items.Add("アドレス");
            itemx.SubItems.Add(argumentValues.address);


            itemx = listView1.Items.Add("開始日時");
            DateTime dateDefault = new DateTime();
            string str_date;
            if (argumentValues.startDt.CompareTo(dateDefault) == 0)
                str_date = "";
            else
                str_date = argumentValues.startDt.ToString();

            itemx.SubItems.Add(str_date);

            itemx = listView1.Items.Add("最新収集日時");



            if (argumentValues.newDt.CompareTo(dateDefault) == 0)
                str_date = "";
            else
                str_date = argumentValues.newDt.ToString();

            itemx.SubItems.Add(str_date);
            //ステータス
            // -1　失敗
            // 0  初回
            // 1  成功
            int stat = argumentValues.status;
            string str;
            str = "";
            if (stat == -1)
                str = "失敗";

            else if (stat == 1)
                str = "成功";
            else if (stat == 0)
                str = "未実行";
            itemx = listView1.Items.Add("結果");
            itemx.SubItems.Add(str);

            itemx = listView1.Items.Add("連続失敗回数");
            itemx.SubItems.Add(argumentValues.count.ToString());

            itemx = listView1.Items.Add("前回障害日時");

            if (argumentValues.lastDt.CompareTo(dateDefault) == 0)
                str_date = "";
            else
                str_date = argumentValues.lastDt.ToString();

            itemx.SubItems.Add(str_date);

            itemx = listView1.Items.Add("復旧回数");
            itemx.SubItems.Add(argumentValues.recoverCount.ToString());

            itemx = listView1.Items.Add("メッセージ");
            itemx.SubItems.Add(argumentValues.message);


        }
        //値のこぴぺ
        private void listView1_KeyDown(object sender, KeyEventArgs e)
        {
            if (sender != listView1) return;
            if (e.Control && e.KeyCode == Keys.C)
                CopySelectedValuesToClipboard();
        }
        //値のこぴぺ
        private void CopySelectedValuesToClipboard()
        {


            if (listView1.SelectedItems.Count == 0) return;

            string yuncstr = "";
            foreach (ListViewItem item in listView1.SelectedItems)
            {
                yuncstr = yuncstr + item.SubItems[0].Text + ",";
                yuncstr = yuncstr + item.SubItems[1].Text + Environment.NewLine;

            }
            Clipboard.SetText(yuncstr);
            
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void コピーToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 0) return;
            string yuncstr = "";
            foreach (ListViewItem item in listView1.SelectedItems)
            {
                yuncstr = yuncstr + item.SubItems[0].Text + ",";
                yuncstr = yuncstr + item.SubItems[1].Text + Environment.NewLine;

            }
            Clipboard.SetText(yuncstr);
        }
    }
}

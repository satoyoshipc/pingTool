namespace pingTool
{
    partial class Form_main
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_main));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.開くoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.開始eToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.停止sToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.設定cToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listView1 = new System.Windows.Forms.ListView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.コピーToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.m_listfile = new System.Windows.Forms.TextBox();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.m_status = new System.Windows.Forms.TextBox();
            this.TaskBarStrip1 = new System.Windows.Forms.StatusStrip();
            this.TaskBarLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.m_versioninfo = new System.Windows.Forms.Label();
            this.m_countDisp = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.TaskBarStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.開くoToolStripMenuItem,
            this.開始eToolStripMenuItem,
            this.停止sToolStripMenuItem,
            this.設定cToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(729, 26);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 開くoToolStripMenuItem
            // 
            this.開くoToolStripMenuItem.Name = "開くoToolStripMenuItem";
            this.開くoToolStripMenuItem.Size = new System.Drawing.Size(61, 22);
            this.開くoToolStripMenuItem.Text = "開く(&o)";
            this.開くoToolStripMenuItem.Click += new System.EventHandler(this.開くoToolStripMenuItem_Click);
            // 
            // 開始eToolStripMenuItem
            // 
            this.開始eToolStripMenuItem.Name = "開始eToolStripMenuItem";
            this.開始eToolStripMenuItem.Size = new System.Drawing.Size(60, 22);
            this.開始eToolStripMenuItem.Text = "開始(&s)";
            this.開始eToolStripMenuItem.Click += new System.EventHandler(this.開始eToolStripMenuItem_Click);
            // 
            // 停止sToolStripMenuItem
            // 
            this.停止sToolStripMenuItem.Name = "停止sToolStripMenuItem";
            this.停止sToolStripMenuItem.Size = new System.Drawing.Size(61, 22);
            this.停止sToolStripMenuItem.Text = "停止(&e)";
            this.停止sToolStripMenuItem.Click += new System.EventHandler(this.停止sToolStripMenuItem_Click);
            // 
            // 設定cToolStripMenuItem
            // 
            this.設定cToolStripMenuItem.Name = "設定cToolStripMenuItem";
            this.設定cToolStripMenuItem.Size = new System.Drawing.Size(60, 22);
            this.設定cToolStripMenuItem.Text = "設定(&c)";
            this.設定cToolStripMenuItem.Click += new System.EventHandler(this.設定cToolStripMenuItem_Click);
            // 
            // listView1
            // 
            this.listView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listView1.ContextMenuStrip = this.contextMenuStrip1;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(12, 54);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(705, 364);
            this.listView1.TabIndex = 1;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.listView1_KeyDown);
            this.listView1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listView1_MouseDoubleClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.コピーToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(113, 26);
            // 
            // コピーToolStripMenuItem
            // 
            this.コピーToolStripMenuItem.Name = "コピーToolStripMenuItem";
            this.コピーToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.コピーToolStripMenuItem.Text = "コピー";
            this.コピーToolStripMenuItem.Click += new System.EventHandler(this.コピーToolStripMenuItem_Click);
            // 
            // m_listfile
            // 
            this.m_listfile.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.m_listfile.Location = new System.Drawing.Point(115, 29);
            this.m_listfile.Name = "m_listfile";
            this.m_listfile.ReadOnly = true;
            this.m_listfile.Size = new System.Drawing.Size(602, 19);
            this.m_listfile.TabIndex = 2;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "丸.jpg");
            this.imageList1.Images.SetKeyName(1, "バツ.jpg");
            // 
            // m_status
            // 
            this.m_status.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.m_status.Location = new System.Drawing.Point(12, 29);
            this.m_status.Name = "m_status";
            this.m_status.ReadOnly = true;
            this.m_status.Size = new System.Drawing.Size(47, 19);
            this.m_status.TabIndex = 3;
            // 
            // TaskBarStrip1
            // 
            this.TaskBarStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TaskBarLabel1});
            this.TaskBarStrip1.Location = new System.Drawing.Point(0, 421);
            this.TaskBarStrip1.Name = "TaskBarStrip1";
            this.TaskBarStrip1.Size = new System.Drawing.Size(729, 22);
            this.TaskBarStrip1.TabIndex = 4;
            this.TaskBarStrip1.Text = "statusStrip1";
            // 
            // TaskBarLabel1
            // 
            this.TaskBarLabel1.Name = "TaskBarLabel1";
            this.TaskBarLabel1.Size = new System.Drawing.Size(0, 17);
            // 
            // m_versioninfo
            // 
            this.m_versioninfo.AutoSize = true;
            this.m_versioninfo.Font = new System.Drawing.Font("MS UI Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.m_versioninfo.Location = new System.Drawing.Point(252, 11);
            this.m_versioninfo.Name = "m_versioninfo";
            this.m_versioninfo.Size = new System.Drawing.Size(0, 11);
            this.m_versioninfo.TabIndex = 5;
            // 
            // m_countDisp
            // 
            this.m_countDisp.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.m_countDisp.Location = new System.Drawing.Point(62, 29);
            this.m_countDisp.Name = "m_countDisp";
            this.m_countDisp.ReadOnly = true;
            this.m_countDisp.Size = new System.Drawing.Size(47, 19);
            this.m_countDisp.TabIndex = 7;
            // 
            // Form_main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(729, 443);
            this.Controls.Add(this.m_countDisp);
            this.Controls.Add(this.m_versioninfo);
            this.Controls.Add(this.TaskBarStrip1);
            this.Controls.Add(this.m_status);
            this.Controls.Add(this.m_listfile);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form_main";
            this.Text = "Ping Tool";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.TaskBarStrip1.ResumeLayout(false);
            this.TaskBarStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 開くoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 停止sToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 開始eToolStripMenuItem;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.TextBox m_listfile;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ToolStripMenuItem 設定cToolStripMenuItem;
        private System.Windows.Forms.TextBox m_status;
        private System.Windows.Forms.StatusStrip TaskBarStrip1;
        private System.Windows.Forms.ToolStripStatusLabel TaskBarLabel1;
        private System.Windows.Forms.Label m_versioninfo;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem コピーToolStripMenuItem;
        private System.Windows.Forms.TextBox m_countDisp;
    }
}


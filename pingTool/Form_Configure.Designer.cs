namespace pingTool
{
    partial class Form_Configure
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Configure));
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.m_recoverCount = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.m_SnmpTrapCheck = new System.Windows.Forms.CheckBox();
            this.label8 = new System.Windows.Forms.Label();
            this.m_objectID = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.m_port = new System.Windows.Forms.TextBox();
            this.versionCombo = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.m_community = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.m_recieveServer = new System.Windows.Forms.TextBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.label15 = new System.Windows.Forms.Label();
            this.m_password = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.m_username = new System.Windows.Forms.TextBox();
            this.m_authCheck = new System.Windows.Forms.CheckBox();
            this.button3 = new System.Windows.Forms.Button();
            this.m_mailSendCheck = new System.Windows.Forms.CheckBox();
            this.label10 = new System.Windows.Forms.Label();
            this.m_subject = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.m_smtpPort = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.m_sendAddress = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.m_smtpServer = new System.Windows.Forms.TextBox();
            this.m_hanei_label = new System.Windows.Forms.Label();
            this.m_comboHour = new System.Windows.Forms.ComboBox();
            this.m_comboMinute = new System.Windows.Forms.ComboBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.m_recoverCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(315, 331);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(70, 36);
            this.button1.TabIndex = 0;
            this.button1.Text = "OK";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.Location = new System.Drawing.Point(396, 331);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(70, 36);
            this.button2.TabIndex = 1;
            this.button2.Text = "キャンセル";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(-1, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(467, 322);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.Selected += new System.Windows.Forms.TabControlEventHandler(this.tabControl1_Selected);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.m_recoverCount);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.numericUpDown2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.numericUpDown1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(459, 255);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "PING設定";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // m_recoverCount
            // 
            this.m_recoverCount.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.m_recoverCount.Location = new System.Drawing.Point(16, 119);
            this.m_recoverCount.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.m_recoverCount.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.m_recoverCount.Name = "m_recoverCount";
            this.m_recoverCount.Size = new System.Drawing.Size(70, 19);
            this.m_recoverCount.TabIndex = 5;
            this.m_recoverCount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(152, 12);
            this.label3.TabIndex = 4;
            this.label3.Text = "トラップ通知する連続復旧回数";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(152, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "トラップ通知する連続障害回数";
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.numericUpDown2.Location = new System.Drawing.Point(16, 77);
            this.numericUpDown2.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.numericUpDown2.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(70, 19);
            this.numericUpDown2.TabIndex = 3;
            this.numericUpDown2.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "間隔(秒)";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.numericUpDown1.Location = new System.Drawing.Point(16, 29);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            60000,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(70, 19);
            this.numericUpDown1.TabIndex = 1;
            this.numericUpDown1.Value = new decimal(new int[] {
            600,
            0,
            0,
            0});
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.m_SnmpTrapCheck);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.m_objectID);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.m_port);
            this.tabPage2.Controls.Add(this.versionCombo);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.m_community);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.m_recieveServer);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(459, 296);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "SNMPトラップ設定";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // m_SnmpTrapCheck
            // 
            this.m_SnmpTrapCheck.AutoSize = true;
            this.m_SnmpTrapCheck.Location = new System.Drawing.Point(8, 18);
            this.m_SnmpTrapCheck.Name = "m_SnmpTrapCheck";
            this.m_SnmpTrapCheck.Size = new System.Drawing.Size(102, 16);
            this.m_SnmpTrapCheck.TabIndex = 0;
            this.m_SnmpTrapCheck.Text = "SNMPTrap送信";
            this.m_SnmpTrapCheck.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(204, 94);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(49, 12);
            this.label8.TabIndex = 10;
            this.label8.Text = "ObjectID";
            // 
            // m_objectID
            // 
            this.m_objectID.Location = new System.Drawing.Point(203, 109);
            this.m_objectID.Name = "m_objectID";
            this.m_objectID.Size = new System.Drawing.Size(209, 19);
            this.m_objectID.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(201, 52);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(33, 12);
            this.label7.TabIndex = 4;
            this.label7.Text = "ポート";
            // 
            // m_port
            // 
            this.m_port.Location = new System.Drawing.Point(203, 67);
            this.m_port.Name = "m_port";
            this.m_port.Size = new System.Drawing.Size(45, 19);
            this.m_port.TabIndex = 5;
            this.m_port.Text = "162";
            // 
            // versionCombo
            // 
            this.versionCombo.Enabled = false;
            this.versionCombo.FormattingEnabled = true;
            this.versionCombo.Items.AddRange(new object[] {
            "1",
            "2c"});
            this.versionCombo.Location = new System.Drawing.Point(8, 157);
            this.versionCombo.Name = "versionCombo";
            this.versionCombo.Size = new System.Drawing.Size(121, 20);
            this.versionCombo.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 142);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(126, 12);
            this.label6.TabIndex = 5;
            this.label6.Text = "SNMPバージョン (v1のみ)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 94);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 12);
            this.label5.TabIndex = 3;
            this.label5.Text = "コミュニティ";
            // 
            // m_community
            // 
            this.m_community.Location = new System.Drawing.Point(8, 109);
            this.m_community.Name = "m_community";
            this.m_community.Size = new System.Drawing.Size(185, 19);
            this.m_community.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 52);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 12);
            this.label4.TabIndex = 1;
            this.label4.Text = "トラップ受信サーバ";
            // 
            // m_recieveServer
            // 
            this.m_recieveServer.Location = new System.Drawing.Point(8, 67);
            this.m_recieveServer.Name = "m_recieveServer";
            this.m_recieveServer.Size = new System.Drawing.Size(185, 19);
            this.m_recieveServer.TabIndex = 1;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.label17);
            this.tabPage3.Controls.Add(this.label16);
            this.tabPage3.Controls.Add(this.m_comboMinute);
            this.tabPage3.Controls.Add(this.m_comboHour);
            this.tabPage3.Controls.Add(this.label15);
            this.tabPage3.Controls.Add(this.m_password);
            this.tabPage3.Controls.Add(this.label14);
            this.tabPage3.Controls.Add(this.m_username);
            this.tabPage3.Controls.Add(this.m_authCheck);
            this.tabPage3.Controls.Add(this.button3);
            this.tabPage3.Controls.Add(this.m_mailSendCheck);
            this.tabPage3.Controls.Add(this.label10);
            this.tabPage3.Controls.Add(this.m_subject);
            this.tabPage3.Controls.Add(this.label11);
            this.tabPage3.Controls.Add(this.m_smtpPort);
            this.tabPage3.Controls.Add(this.label12);
            this.tabPage3.Controls.Add(this.m_sendAddress);
            this.tabPage3.Controls.Add(this.label13);
            this.tabPage3.Controls.Add(this.m_smtpServer);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(459, 296);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "定期メール";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(10, 263);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(52, 12);
            this.label15.TabIndex = 24;
            this.label15.Text = "パスワード";
            // 
            // m_password
            // 
            this.m_password.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.m_password.Location = new System.Drawing.Point(75, 260);
            this.m_password.Name = "m_password";
            this.m_password.PasswordChar = '*';
            this.m_password.Size = new System.Drawing.Size(164, 19);
            this.m_password.TabIndex = 23;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(10, 238);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(47, 12);
            this.label14.TabIndex = 22;
            this.label14.Text = "ユーザ名";
            // 
            // m_username
            // 
            this.m_username.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.m_username.Location = new System.Drawing.Point(75, 235);
            this.m_username.Name = "m_username";
            this.m_username.Size = new System.Drawing.Size(164, 19);
            this.m_username.TabIndex = 21;
            // 
            // m_authCheck
            // 
            this.m_authCheck.AutoSize = true;
            this.m_authCheck.Location = new System.Drawing.Point(8, 214);
            this.m_authCheck.Name = "m_authCheck";
            this.m_authCheck.Size = new System.Drawing.Size(48, 16);
            this.m_authCheck.TabIndex = 20;
            this.m_authCheck.Text = "認証";
            this.m_authCheck.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button3.Location = new System.Drawing.Point(357, 253);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(99, 32);
            this.button3.TabIndex = 6;
            this.button3.Text = "テスト送信";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // m_mailSendCheck
            // 
            this.m_mailSendCheck.AutoSize = true;
            this.m_mailSendCheck.Location = new System.Drawing.Point(12, 19);
            this.m_mailSendCheck.Name = "m_mailSendCheck";
            this.m_mailSendCheck.Size = new System.Drawing.Size(95, 16);
            this.m_mailSendCheck.TabIndex = 0;
            this.m_mailSendCheck.Text = "メール送信する";
            this.m_mailSendCheck.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(10, 168);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(68, 12);
            this.label10.TabIndex = 19;
            this.label10.Text = "メールタイトル";
            // 
            // m_subject
            // 
            this.m_subject.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.m_subject.Location = new System.Drawing.Point(7, 183);
            this.m_subject.Name = "m_subject";
            this.m_subject.Size = new System.Drawing.Size(446, 19);
            this.m_subject.TabIndex = 5;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(215, 83);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(33, 12);
            this.label11.TabIndex = 2;
            this.label11.Text = "ポート";
            // 
            // m_smtpPort
            // 
            this.m_smtpPort.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.m_smtpPort.Location = new System.Drawing.Point(217, 98);
            this.m_smtpPort.Name = "m_smtpPort";
            this.m_smtpPort.Size = new System.Drawing.Size(45, 19);
            this.m_smtpPort.TabIndex = 3;
            this.m_smtpPort.Text = "25";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(10, 125);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(237, 12);
            this.label12.TabIndex = 15;
            this.label12.Text = "メール宛先 (複数指定するときはカンマ\',\'で分ける)";
            // 
            // m_sendAddress
            // 
            this.m_sendAddress.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.m_sendAddress.Location = new System.Drawing.Point(7, 140);
            this.m_sendAddress.Name = "m_sendAddress";
            this.m_sendAddress.Size = new System.Drawing.Size(446, 19);
            this.m_sendAddress.TabIndex = 4;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(10, 83);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(65, 12);
            this.label13.TabIndex = 12;
            this.label13.Text = "SMTPサーバ";
            // 
            // m_smtpServer
            // 
            this.m_smtpServer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.m_smtpServer.Location = new System.Drawing.Point(7, 98);
            this.m_smtpServer.Name = "m_smtpServer";
            this.m_smtpServer.Size = new System.Drawing.Size(204, 19);
            this.m_smtpServer.TabIndex = 1;
            // 
            // m_hanei_label
            // 
            this.m_hanei_label.AutoSize = true;
            this.m_hanei_label.ForeColor = System.Drawing.Color.Red;
            this.m_hanei_label.Location = new System.Drawing.Point(12, 331);
            this.m_hanei_label.Name = "m_hanei_label";
            this.m_hanei_label.Size = new System.Drawing.Size(137, 12);
            this.m_hanei_label.TabIndex = 23;
            this.m_hanei_label.Text = "反映するには再実行が必要";
            // 
            // m_comboHour
            // 
            this.m_comboHour.FormattingEnabled = true;
            this.m_comboHour.Items.AddRange(new object[] {
            "00",
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23"});
            this.m_comboHour.Location = new System.Drawing.Point(7, 58);
            this.m_comboHour.Name = "m_comboHour";
            this.m_comboHour.Size = new System.Drawing.Size(42, 20);
            this.m_comboHour.TabIndex = 25;
            this.m_comboHour.Text = "00";
            // 
            // m_comboMinute
            // 
            this.m_comboMinute.FormattingEnabled = true;
            this.m_comboMinute.Items.AddRange(new object[] {
            "00",
            "30"});
            this.m_comboMinute.Location = new System.Drawing.Point(72, 58);
            this.m_comboMinute.Name = "m_comboMinute";
            this.m_comboMinute.Size = new System.Drawing.Size(42, 20);
            this.m_comboMinute.TabIndex = 26;
            this.m_comboMinute.Text = "00";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(10, 42);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(53, 12);
            this.label16.TabIndex = 27;
            this.label16.Text = "送信時間";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(56, 61);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(11, 12);
            this.label17.TabIndex = 28;
            this.label17.Text = "：";
            // 
            // Form_Configure
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(475, 372);
            this.Controls.Add(this.m_hanei_label);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form_Configure";
            this.Text = "設定画面";
            this.Load += new System.EventHandler(this.Form_Configure_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.m_recoverCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ComboBox versionCombo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox m_community;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox m_recieveServer;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox m_port;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox m_objectID;
        private System.Windows.Forms.CheckBox m_SnmpTrapCheck;
        private System.Windows.Forms.NumericUpDown m_recoverCount;
        private System.Windows.Forms.Label m_hanei_label;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.CheckBox m_mailSendCheck;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox m_subject;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox m_smtpPort;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox m_sendAddress;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox m_smtpServer;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox m_password;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox m_username;
        private System.Windows.Forms.CheckBox m_authCheck;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.ComboBox m_comboMinute;
        private System.Windows.Forms.ComboBox m_comboHour;
    }
}
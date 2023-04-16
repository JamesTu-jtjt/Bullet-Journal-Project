namespace team20
{
    partial class Content
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editInformationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.guideToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.relationsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.projectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.List = new System.Windows.Forms.ToolStripMenuItem();
            this.R = new System.Windows.Forms.ToolStripMenuItem();
            this.welcome = new System.Windows.Forms.Label();
            this.year_label = new System.Windows.Forms.Label();
            this.month_label = new System.Windows.Forms.Label();
            this.daily_label = new System.Windows.Forms.Label();
            this.AccLab = new System.Windows.Forms.Label();
            this.NameLab = new System.Windows.Forms.Label();
            this.BDLab = new System.Windows.Forms.Label();
            this.PassLab = new System.Windows.Forms.Label();
            this.AccBox = new System.Windows.Forms.TextBox();
            this.NameBox = new System.Windows.Forms.TextBox();
            this.PassBox = new System.Windows.Forms.TextBox();
            this.BDPicker1 = new System.Windows.Forms.DateTimePicker();
            this.UpdateBtn = new System.Windows.Forms.Button();
            this.YearlyLog = new System.Windows.Forms.DataGridView();
            this.MonthlyLog = new System.Windows.Forms.DataGridView();
            this.DailyLog = new System.Windows.Forms.DataGridView();
            this.AddYearly = new System.Windows.Forms.Button();
            this.AddMonthly = new System.Windows.Forms.Button();
            this.AddDaily = new System.Windows.Forms.Button();
            this.PageLab = new System.Windows.Forms.Label();
            this.DelYearly = new System.Windows.Forms.Button();
            this.DelMonthly = new System.Windows.Forms.Button();
            this.DelDaily = new System.Windows.Forms.Button();
            this.Refresh = new System.Windows.Forms.Button();
            this.ProjectLog = new System.Windows.Forms.DataGridView();
            this.DelProjBtn = new System.Windows.Forms.Button();
            this.AddProjBtn = new System.Windows.Forms.Button();
            this.projRefresh = new System.Windows.Forms.Button();
            this.ProjectList = new System.Windows.Forms.DataGridView();
            this.ProjLab = new System.Windows.Forms.Label();
            this.ProjLogLab = new System.Windows.Forms.Label();
            this.drawChartsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.YearlyLog)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MonthlyLog)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DailyLog)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProjectLog)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProjectList)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.settingsToolStripMenuItem,
            this.guideToolStripMenuItem,
            this.logToolStripMenuItem,
            this.projectToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1100, 28);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editInformationToolStripMenuItem,
            this.logOutToolStripMenuItem});
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(76, 24);
            this.settingsToolStripMenuItem.Text = "settings";
            // 
            // editInformationToolStripMenuItem
            // 
            this.editInformationToolStripMenuItem.Name = "editInformationToolStripMenuItem";
            this.editInformationToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.E)));
            this.editInformationToolStripMenuItem.Size = new System.Drawing.Size(250, 26);
            this.editInformationToolStripMenuItem.Text = "Edit Information";
            this.editInformationToolStripMenuItem.Click += new System.EventHandler(this.editInformationToolStripMenuItem_Click);
            // 
            // logOutToolStripMenuItem
            // 
            this.logOutToolStripMenuItem.Name = "logOutToolStripMenuItem";
            this.logOutToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.L)));
            this.logOutToolStripMenuItem.Size = new System.Drawing.Size(250, 26);
            this.logOutToolStripMenuItem.Text = "Log Out";
            this.logOutToolStripMenuItem.Click += new System.EventHandler(this.logOutToolStripMenuItem_Click);
            // 
            // guideToolStripMenuItem
            // 
            this.guideToolStripMenuItem.Name = "guideToolStripMenuItem";
            this.guideToolStripMenuItem.Size = new System.Drawing.Size(62, 24);
            this.guideToolStripMenuItem.Text = "guide";
            // 
            // logToolStripMenuItem
            // 
            this.logToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showAllToolStripMenuItem,
            this.relationsToolStripMenuItem});
            this.logToolStripMenuItem.Name = "logToolStripMenuItem";
            this.logToolStripMenuItem.Size = new System.Drawing.Size(48, 24);
            this.logToolStripMenuItem.Text = "Log";
            // 
            // showAllToolStripMenuItem
            // 
            this.showAllToolStripMenuItem.Name = "showAllToolStripMenuItem";
            this.showAllToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.showAllToolStripMenuItem.Size = new System.Drawing.Size(203, 26);
            this.showAllToolStripMenuItem.Text = "Log List";
            this.showAllToolStripMenuItem.Click += new System.EventHandler(this.showAllToolStripMenuItem_Click);
            // 
            // relationsToolStripMenuItem
            // 
            this.relationsToolStripMenuItem.Name = "relationsToolStripMenuItem";
            this.relationsToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.R)));
            this.relationsToolStripMenuItem.Size = new System.Drawing.Size(203, 26);
            this.relationsToolStripMenuItem.Text = "Relations";
            this.relationsToolStripMenuItem.Click += new System.EventHandler(this.relationsToolStripMenuItem_Click);
            // 
            // projectToolStripMenuItem
            // 
            this.projectToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.List,
            this.R,
            this.drawChartsToolStripMenuItem});
            this.projectToolStripMenuItem.Name = "projectToolStripMenuItem";
            this.projectToolStripMenuItem.Size = new System.Drawing.Size(73, 24);
            this.projectToolStripMenuItem.Text = "project ";
            // 
            // List
            // 
            this.List.Name = "List";
            this.List.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.List.Size = new System.Drawing.Size(262, 26);
            this.List.Text = "Projects and Logs";
            this.List.Click += new System.EventHandler(this.List_Click);
            // 
            // R
            // 
            this.R.Name = "R";
            this.R.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.T)));
            this.R.Size = new System.Drawing.Size(262, 26);
            this.R.Text = "Relation By Tags";
            this.R.Click += new System.EventHandler(this.R_Click);
            // 
            // welcome
            // 
            this.welcome.Font = new System.Drawing.Font("新細明體", 12F);
            this.welcome.Location = new System.Drawing.Point(852, 11);
            this.welcome.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.welcome.Name = "welcome";
            this.welcome.Size = new System.Drawing.Size(215, 49);
            this.welcome.TabIndex = 6;
            this.welcome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // year_label
            // 
            this.year_label.AutoSize = true;
            this.year_label.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.year_label.Location = new System.Drawing.Point(28, 118);
            this.year_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.year_label.Name = "year_label";
            this.year_label.Size = new System.Drawing.Size(129, 27);
            this.year_label.TabIndex = 10;
            this.year_label.Text = "Yearly Log";
            // 
            // month_label
            // 
            this.month_label.AutoSize = true;
            this.month_label.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.month_label.Location = new System.Drawing.Point(28, 341);
            this.month_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.month_label.Name = "month_label";
            this.month_label.Size = new System.Drawing.Size(150, 27);
            this.month_label.TabIndex = 11;
            this.month_label.Text = "Monthly Log";
            // 
            // daily_label
            // 
            this.daily_label.AutoSize = true;
            this.daily_label.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.daily_label.Location = new System.Drawing.Point(28, 655);
            this.daily_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.daily_label.Name = "daily_label";
            this.daily_label.Size = new System.Drawing.Size(117, 27);
            this.daily_label.TabIndex = 12;
            this.daily_label.Text = "Daily Log";
            // 
            // AccLab
            // 
            this.AccLab.AutoSize = true;
            this.AccLab.Location = new System.Drawing.Point(351, 236);
            this.AccLab.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.AccLab.Name = "AccLab";
            this.AccLab.Size = new System.Drawing.Size(54, 15);
            this.AccLab.TabIndex = 13;
            this.AccLab.Text = "Account";
            // 
            // NameLab
            // 
            this.NameLab.AutoSize = true;
            this.NameLab.Location = new System.Drawing.Point(351, 330);
            this.NameLab.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.NameLab.Name = "NameLab";
            this.NameLab.Size = new System.Drawing.Size(40, 15);
            this.NameLab.TabIndex = 14;
            this.NameLab.Text = "Name";
            // 
            // BDLab
            // 
            this.BDLab.AutoSize = true;
            this.BDLab.Location = new System.Drawing.Point(351, 414);
            this.BDLab.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.BDLab.Name = "BDLab";
            this.BDLab.Size = new System.Drawing.Size(56, 15);
            this.BDLab.TabIndex = 15;
            this.BDLab.Text = "Birthday";
            // 
            // PassLab
            // 
            this.PassLab.AutoSize = true;
            this.PassLab.Location = new System.Drawing.Point(351, 511);
            this.PassLab.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.PassLab.Name = "PassLab";
            this.PassLab.Size = new System.Drawing.Size(60, 15);
            this.PassLab.TabIndex = 16;
            this.PassLab.Text = "Password";
            // 
            // AccBox
            // 
            this.AccBox.Location = new System.Drawing.Point(451, 232);
            this.AccBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.AccBox.Name = "AccBox";
            this.AccBox.ReadOnly = true;
            this.AccBox.Size = new System.Drawing.Size(265, 25);
            this.AccBox.TabIndex = 17;
            // 
            // NameBox
            // 
            this.NameBox.Location = new System.Drawing.Point(451, 326);
            this.NameBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.NameBox.Name = "NameBox";
            this.NameBox.Size = new System.Drawing.Size(265, 25);
            this.NameBox.TabIndex = 18;
            // 
            // PassBox
            // 
            this.PassBox.Location = new System.Drawing.Point(451, 508);
            this.PassBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.PassBox.Name = "PassBox";
            this.PassBox.Size = new System.Drawing.Size(265, 25);
            this.PassBox.TabIndex = 20;
            // 
            // BDPicker1
            // 
            this.BDPicker1.Location = new System.Drawing.Point(451, 405);
            this.BDPicker1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BDPicker1.Name = "BDPicker1";
            this.BDPicker1.Size = new System.Drawing.Size(265, 25);
            this.BDPicker1.TabIndex = 21;
            // 
            // UpdateBtn
            // 
            this.UpdateBtn.Location = new System.Drawing.Point(855, 152);
            this.UpdateBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.UpdateBtn.Name = "UpdateBtn";
            this.UpdateBtn.Size = new System.Drawing.Size(200, 29);
            this.UpdateBtn.TabIndex = 22;
            this.UpdateBtn.Text = "Update Information";
            this.UpdateBtn.UseVisualStyleBackColor = true;
            this.UpdateBtn.Click += new System.EventHandler(this.UpdateBtn_Click);
            // 
            // YearlyLog
            // 
            this.YearlyLog.AllowUserToAddRows = false;
            this.YearlyLog.AllowUserToDeleteRows = false;
            this.YearlyLog.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.YearlyLog.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.YearlyLog.Location = new System.Drawing.Point(33, 148);
            this.YearlyLog.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.YearlyLog.Name = "YearlyLog";
            this.YearlyLog.ReadOnly = true;
            this.YearlyLog.RowTemplate.Height = 24;
            this.YearlyLog.Size = new System.Drawing.Size(1033, 179);
            this.YearlyLog.TabIndex = 23;
            // 
            // MonthlyLog
            // 
            this.MonthlyLog.AllowUserToAddRows = false;
            this.MonthlyLog.AllowUserToDeleteRows = false;
            this.MonthlyLog.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.MonthlyLog.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MonthlyLog.Location = new System.Drawing.Point(33, 371);
            this.MonthlyLog.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MonthlyLog.Name = "MonthlyLog";
            this.MonthlyLog.ReadOnly = true;
            this.MonthlyLog.RowTemplate.Height = 24;
            this.MonthlyLog.Size = new System.Drawing.Size(1033, 270);
            this.MonthlyLog.TabIndex = 24;
            // 
            // DailyLog
            // 
            this.DailyLog.AllowUserToAddRows = false;
            this.DailyLog.AllowUserToDeleteRows = false;
            this.DailyLog.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DailyLog.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DailyLog.Location = new System.Drawing.Point(33, 686);
            this.DailyLog.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.DailyLog.Name = "DailyLog";
            this.DailyLog.ReadOnly = true;
            this.DailyLog.RowTemplate.Height = 24;
            this.DailyLog.Size = new System.Drawing.Size(1033, 311);
            this.DailyLog.TabIndex = 25;
            // 
            // AddYearly
            // 
            this.AddYearly.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.AddYearly.Location = new System.Drawing.Point(967, 105);
            this.AddYearly.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.AddYearly.Name = "AddYearly";
            this.AddYearly.Size = new System.Drawing.Size(100, 40);
            this.AddYearly.TabIndex = 26;
            this.AddYearly.Text = "+";
            this.AddYearly.UseVisualStyleBackColor = false;
            this.AddYearly.Click += new System.EventHandler(this.AddYearly_Click);
            // 
            // AddMonthly
            // 
            this.AddMonthly.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.AddMonthly.Location = new System.Drawing.Point(967, 328);
            this.AddMonthly.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.AddMonthly.Name = "AddMonthly";
            this.AddMonthly.Size = new System.Drawing.Size(100, 40);
            this.AddMonthly.TabIndex = 27;
            this.AddMonthly.Text = "+";
            this.AddMonthly.UseVisualStyleBackColor = false;
            this.AddMonthly.Click += new System.EventHandler(this.AddMonthly_Click);
            // 
            // AddDaily
            // 
            this.AddDaily.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.AddDaily.Location = new System.Drawing.Point(967, 641);
            this.AddDaily.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.AddDaily.Name = "AddDaily";
            this.AddDaily.Size = new System.Drawing.Size(100, 40);
            this.AddDaily.TabIndex = 28;
            this.AddDaily.Text = "+";
            this.AddDaily.UseVisualStyleBackColor = false;
            this.AddDaily.Click += new System.EventHandler(this.AddDaily_Click);
            // 
            // PageLab
            // 
            this.PageLab.AutoSize = true;
            this.PageLab.Font = new System.Drawing.Font("新細明體", 39.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.PageLab.Location = new System.Drawing.Point(227, 44);
            this.PageLab.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.PageLab.Name = "PageLab";
            this.PageLab.Size = new System.Drawing.Size(264, 67);
            this.PageLab.TabIndex = 29;
            this.PageLab.Text = "My Logs";
            // 
            // DelYearly
            // 
            this.DelYearly.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.DelYearly.Location = new System.Drawing.Point(855, 105);
            this.DelYearly.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.DelYearly.Name = "DelYearly";
            this.DelYearly.Size = new System.Drawing.Size(100, 40);
            this.DelYearly.TabIndex = 30;
            this.DelYearly.Text = "-";
            this.DelYearly.UseVisualStyleBackColor = false;
            this.DelYearly.Click += new System.EventHandler(this.DelYearly_Click);
            // 
            // DelMonthly
            // 
            this.DelMonthly.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.DelMonthly.Location = new System.Drawing.Point(855, 328);
            this.DelMonthly.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.DelMonthly.Name = "DelMonthly";
            this.DelMonthly.Size = new System.Drawing.Size(100, 40);
            this.DelMonthly.TabIndex = 31;
            this.DelMonthly.Text = "-";
            this.DelMonthly.UseVisualStyleBackColor = false;
            this.DelMonthly.Click += new System.EventHandler(this.DelMonthly_Click);
            // 
            // DelDaily
            // 
            this.DelDaily.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.DelDaily.Location = new System.Drawing.Point(855, 641);
            this.DelDaily.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.DelDaily.Name = "DelDaily";
            this.DelDaily.Size = new System.Drawing.Size(100, 40);
            this.DelDaily.TabIndex = 32;
            this.DelDaily.Text = "-";
            this.DelDaily.UseVisualStyleBackColor = false;
            this.DelDaily.Click += new System.EventHandler(this.DelDaily_Click);
            // 
            // Refresh
            // 
            this.Refresh.Location = new System.Drawing.Point(955, 60);
            this.Refresh.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Refresh.Name = "Refresh";
            this.Refresh.Size = new System.Drawing.Size(100, 34);
            this.Refresh.TabIndex = 33;
            this.Refresh.Text = "Refresh";
            this.Refresh.UseVisualStyleBackColor = true;
            this.Refresh.Click += new System.EventHandler(this.Refresh_Click);
            // 
            // ProjectLog
            // 
            this.ProjectLog.AllowUserToAddRows = false;
            this.ProjectLog.AllowUserToDeleteRows = false;
            this.ProjectLog.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ProjectLog.Location = new System.Drawing.Point(33, 458);
            this.ProjectLog.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ProjectLog.Name = "ProjectLog";
            this.ProjectLog.ReadOnly = true;
            this.ProjectLog.RowTemplate.Height = 24;
            this.ProjectLog.Size = new System.Drawing.Size(1033, 525);
            this.ProjectLog.TabIndex = 34;
            // 
            // DelProjBtn
            // 
            this.DelProjBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.DelProjBtn.Location = new System.Drawing.Point(855, 105);
            this.DelProjBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.DelProjBtn.Name = "DelProjBtn";
            this.DelProjBtn.Size = new System.Drawing.Size(100, 40);
            this.DelProjBtn.TabIndex = 35;
            this.DelProjBtn.Text = "-";
            this.DelProjBtn.UseVisualStyleBackColor = false;
            this.DelProjBtn.Click += new System.EventHandler(this.DelProjBtn_Click);
            // 
            // AddProjBtn
            // 
            this.AddProjBtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.AddProjBtn.Location = new System.Drawing.Point(967, 105);
            this.AddProjBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.AddProjBtn.Name = "AddProjBtn";
            this.AddProjBtn.Size = new System.Drawing.Size(100, 40);
            this.AddProjBtn.TabIndex = 36;
            this.AddProjBtn.Text = "+";
            this.AddProjBtn.UseVisualStyleBackColor = false;
            this.AddProjBtn.Click += new System.EventHandler(this.AddProjBtn_Click);
            // 
            // projRefresh
            // 
            this.projRefresh.Location = new System.Drawing.Point(955, 60);
            this.projRefresh.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.projRefresh.Name = "projRefresh";
            this.projRefresh.Size = new System.Drawing.Size(100, 29);
            this.projRefresh.TabIndex = 37;
            this.projRefresh.Text = "Refresh";
            this.projRefresh.UseVisualStyleBackColor = true;
            this.projRefresh.Click += new System.EventHandler(this.projRefresh_Click);
            // 
            // ProjectList
            // 
            this.ProjectList.AllowUserToAddRows = false;
            this.ProjectList.AllowUserToDeleteRows = false;
            this.ProjectList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ProjectList.Location = new System.Drawing.Point(33, 149);
            this.ProjectList.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ProjectList.Name = "ProjectList";
            this.ProjectList.ReadOnly = true;
            this.ProjectList.RowTemplate.Height = 24;
            this.ProjectList.Size = new System.Drawing.Size(1033, 259);
            this.ProjectList.TabIndex = 38;
            // 
            // ProjLab
            // 
            this.ProjLab.AutoSize = true;
            this.ProjLab.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.ProjLab.Location = new System.Drawing.Point(28, 119);
            this.ProjLab.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ProjLab.Name = "ProjLab";
            this.ProjLab.Size = new System.Drawing.Size(130, 27);
            this.ProjLab.TabIndex = 41;
            this.ProjLab.Text = "Project List";
            // 
            // ProjLogLab
            // 
            this.ProjLogLab.AutoSize = true;
            this.ProjLogLab.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.ProjLogLab.Location = new System.Drawing.Point(28, 428);
            this.ProjLogLab.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ProjLogLab.Name = "ProjLogLab";
            this.ProjLogLab.Size = new System.Drawing.Size(179, 27);
            this.ProjLogLab.TabIndex = 42;
            this.ProjLogLab.Text = "Logs By Project";
            // 
            // drawChartsToolStripMenuItem
            // 
            this.drawChartsToolStripMenuItem.Name = "drawChartsToolStripMenuItem";
            this.drawChartsToolStripMenuItem.Size = new System.Drawing.Size(262, 26);
            this.drawChartsToolStripMenuItem.Text = "Draw Charts";
            this.drawChartsToolStripMenuItem.Click += new System.EventHandler(this.drawChartsToolStripMenuItem_Click);
            // 
            // Content
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1100, 1012);
            this.Controls.Add(this.ProjLogLab);
            this.Controls.Add(this.ProjLab);
            this.Controls.Add(this.ProjectList);
            this.Controls.Add(this.projRefresh);
            this.Controls.Add(this.AddProjBtn);
            this.Controls.Add(this.DelProjBtn);
            this.Controls.Add(this.ProjectLog);
            this.Controls.Add(this.Refresh);
            this.Controls.Add(this.DelDaily);
            this.Controls.Add(this.DelMonthly);
            this.Controls.Add(this.DelYearly);
            this.Controls.Add(this.PageLab);
            this.Controls.Add(this.AddDaily);
            this.Controls.Add(this.AddMonthly);
            this.Controls.Add(this.AddYearly);
            this.Controls.Add(this.DailyLog);
            this.Controls.Add(this.MonthlyLog);
            this.Controls.Add(this.YearlyLog);
            this.Controls.Add(this.UpdateBtn);
            this.Controls.Add(this.BDPicker1);
            this.Controls.Add(this.PassBox);
            this.Controls.Add(this.NameBox);
            this.Controls.Add(this.AccBox);
            this.Controls.Add(this.PassLab);
            this.Controls.Add(this.BDLab);
            this.Controls.Add(this.NameLab);
            this.Controls.Add(this.AccLab);
            this.Controls.Add(this.daily_label);
            this.Controls.Add(this.month_label);
            this.Controls.Add(this.year_label);
            this.Controls.Add(this.welcome);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Content";
            this.Text = "Content";
            this.Load += new System.EventHandler(this.Content_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.YearlyLog)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MonthlyLog)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DailyLog)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProjectLog)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProjectList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem guideToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem projectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.Label welcome;
        private System.Windows.Forms.Label year_label;
        private System.Windows.Forms.Label month_label;
        private System.Windows.Forms.Label daily_label;
        private System.Windows.Forms.Label AccLab;
        private System.Windows.Forms.Label NameLab;
        private System.Windows.Forms.Label BDLab;
        private System.Windows.Forms.Label PassLab;
        private System.Windows.Forms.TextBox AccBox;
        private System.Windows.Forms.TextBox NameBox;
        private System.Windows.Forms.TextBox PassBox;
        private System.Windows.Forms.DateTimePicker BDPicker1;
        private System.Windows.Forms.Button UpdateBtn;
        private System.Windows.Forms.ToolStripMenuItem editInformationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logOutToolStripMenuItem;
        private System.Windows.Forms.DataGridView YearlyLog;
        private System.Windows.Forms.DataGridView MonthlyLog;
        private System.Windows.Forms.DataGridView DailyLog;
        private System.Windows.Forms.Button AddYearly;
        private System.Windows.Forms.Button AddMonthly;
        private System.Windows.Forms.Button AddDaily;
        private System.Windows.Forms.Label PageLab;
        private System.Windows.Forms.Button DelYearly;
        private System.Windows.Forms.Button DelMonthly;
        private System.Windows.Forms.Button DelDaily;
        private System.Windows.Forms.Button Refresh;
        private System.Windows.Forms.ToolStripMenuItem showAllToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem relationsToolStripMenuItem;
        private System.Windows.Forms.DataGridView ProjectLog;
        private System.Windows.Forms.Button DelProjBtn;
        private System.Windows.Forms.Button AddProjBtn;
        private System.Windows.Forms.Button projRefresh;
        private System.Windows.Forms.DataGridView ProjectList;
        private System.Windows.Forms.Label ProjLab;
        private System.Windows.Forms.Label ProjLogLab;
        private System.Windows.Forms.ToolStripMenuItem List;
        private System.Windows.Forms.ToolStripMenuItem R;
        private System.Windows.Forms.ToolStripMenuItem drawChartsToolStripMenuItem;
    }
}
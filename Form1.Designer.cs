namespace SQL_Tool
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.txtSQL = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.txtEntityClass = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbTable = new System.Windows.Forms.ComboBox();
            this.cmbDatabase = new System.Windows.Forms.ComboBox();
            this.btnQuery = new System.Windows.Forms.Button();
            this.btnLogin = new System.Windows.Forms.Button();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtServer = new System.Windows.Forms.TextBox();
            this.txtUserID = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.执行F5ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.清空ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.实体类ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.插入语句ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.创建数据库ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.创建表ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.保存ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.删除ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.保存ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(4, 4);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(4);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.txtSQL);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dataGridView1);
            this.splitContainer1.Size = new System.Drawing.Size(997, 502);
            this.splitContainer1.SplitterDistance = 219;
            this.splitContainer1.SplitterWidth = 5;
            this.splitContainer1.TabIndex = 0;
            // 
            // txtSQL
            // 
            this.txtSQL.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtSQL.Location = new System.Drawing.Point(0, 0);
            this.txtSQL.Margin = new System.Windows.Forms.Padding(4);
            this.txtSQL.Multiline = true;
            this.txtSQL.Name = "txtSQL";
            this.txtSQL.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtSQL.Size = new System.Drawing.Size(997, 219);
            this.txtSQL.TabIndex = 0;
            this.txtSQL.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSQL_KeyDown);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(997, 278);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.DataSourceChanged += new System.EventHandler(this.dataGridView1_DataSourceChanged);
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(16, 149);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1013, 539);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.splitContainer1);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage1.Size = new System.Drawing.Size(1005, 510);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "SQL查询";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.txtEntityClass);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage2.Size = new System.Drawing.Size(1005, 510);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "实体类";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // txtEntityClass
            // 
            this.txtEntityClass.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtEntityClass.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtEntityClass.Location = new System.Drawing.Point(4, 4);
            this.txtEntityClass.Margin = new System.Windows.Forms.Padding(4);
            this.txtEntityClass.Multiline = true;
            this.txtEntityClass.Name = "txtEntityClass";
            this.txtEntityClass.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtEntityClass.Size = new System.Drawing.Size(997, 502);
            this.txtEntityClass.TabIndex = 1;
            this.txtEntityClass.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtEntityClass_KeyDown);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cmbTable);
            this.groupBox1.Controls.Add(this.cmbDatabase);
            this.groupBox1.Controls.Add(this.btnQuery);
            this.groupBox1.Controls.Add(this.btnLogin);
            this.groupBox1.Controls.Add(this.txtPassword);
            this.groupBox1.Controls.Add(this.txtServer);
            this.groupBox1.Controls.Add(this.txtUserID);
            this.groupBox1.Location = new System.Drawing.Point(16, 49);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(1013, 76);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "连接信息";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(713, 36);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(22, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "表";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(496, 35);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(22, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "库";
            // 
            // cmbTable
            // 
            this.cmbTable.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbTable.FormattingEnabled = true;
            this.cmbTable.Location = new System.Drawing.Point(744, 31);
            this.cmbTable.Margin = new System.Windows.Forms.Padding(4);
            this.cmbTable.Name = "cmbTable";
            this.cmbTable.Size = new System.Drawing.Size(160, 23);
            this.cmbTable.TabIndex = 3;
            this.cmbTable.TextChanged += new System.EventHandler(this.cmbTable_TextChanged);
            // 
            // cmbDatabase
            // 
            this.cmbDatabase.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbDatabase.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDatabase.FormattingEnabled = true;
            this.cmbDatabase.Location = new System.Drawing.Point(527, 31);
            this.cmbDatabase.Margin = new System.Windows.Forms.Padding(4);
            this.cmbDatabase.Name = "cmbDatabase";
            this.cmbDatabase.Size = new System.Drawing.Size(160, 23);
            this.cmbDatabase.TabIndex = 3;
            this.cmbDatabase.TextChanged += new System.EventHandler(this.cmbDatabase_TextChanged);
            // 
            // btnQuery
            // 
            this.btnQuery.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnQuery.Location = new System.Drawing.Point(913, 30);
            this.btnQuery.Margin = new System.Windows.Forms.Padding(4);
            this.btnQuery.Name = "btnQuery";
            this.btnQuery.Size = new System.Drawing.Size(79, 29);
            this.btnQuery.TabIndex = 2;
            this.btnQuery.Text = "查询";
            this.btnQuery.UseVisualStyleBackColor = true;
            this.btnQuery.Click += new System.EventHandler(this.btnQuery_Click);
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(367, 29);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(4);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(79, 29);
            this.btnLogin.TabIndex = 2;
            this.btnLogin.Text = "登录";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(265, 30);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(4);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(92, 25);
            this.txtPassword.TabIndex = 1;
            // 
            // txtServer
            // 
            this.txtServer.Location = new System.Drawing.Point(23, 30);
            this.txtServer.Margin = new System.Windows.Forms.Padding(4);
            this.txtServer.Name = "txtServer";
            this.txtServer.Size = new System.Drawing.Size(132, 25);
            this.txtServer.TabIndex = 1;
            this.txtServer.Text = "(local)";
            // 
            // txtUserID
            // 
            this.txtUserID.Location = new System.Drawing.Point(164, 30);
            this.txtUserID.Margin = new System.Windows.Forms.Padding(4);
            this.txtUserID.Name = "txtUserID";
            this.txtUserID.Size = new System.Drawing.Size(92, 25);
            this.txtUserID.TabIndex = 1;
            this.txtUserID.Text = "sa";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.执行F5ToolStripMenuItem,
            this.清空ToolStripMenuItem,
            this.保存ToolStripMenuItem,
            this.实体类ToolStripMenuItem,
            this.插入语句ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1045, 28);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 执行F5ToolStripMenuItem
            // 
            this.执行F5ToolStripMenuItem.Name = "执行F5ToolStripMenuItem";
            this.执行F5ToolStripMenuItem.ShortcutKeyDisplayString = "";
            this.执行F5ToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F5;
            this.执行F5ToolStripMenuItem.Size = new System.Drawing.Size(78, 24);
            this.执行F5ToolStripMenuItem.Text = "执行(F5)";
            this.执行F5ToolStripMenuItem.Click += new System.EventHandler(this.执行F5ToolStripMenuItem_Click);
            // 
            // 清空ToolStripMenuItem
            // 
            this.清空ToolStripMenuItem.Name = "清空ToolStripMenuItem";
            this.清空ToolStripMenuItem.Size = new System.Drawing.Size(51, 24);
            this.清空ToolStripMenuItem.Text = "清空";
            this.清空ToolStripMenuItem.Click += new System.EventHandler(this.清空ToolStripMenuItem_Click);
            // 
            // 实体类ToolStripMenuItem
            // 
            this.实体类ToolStripMenuItem.Name = "实体类ToolStripMenuItem";
            this.实体类ToolStripMenuItem.Size = new System.Drawing.Size(96, 24);
            this.实体类ToolStripMenuItem.Text = "保存实体类";
            this.实体类ToolStripMenuItem.Click += new System.EventHandler(this.实体类ToolStripMenuItem_Click);
            // 
            // 插入语句ToolStripMenuItem
            // 
            this.插入语句ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.创建数据库ToolStripMenuItem,
            this.创建表ToolStripMenuItem});
            this.插入语句ToolStripMenuItem.Name = "插入语句ToolStripMenuItem";
            this.插入语句ToolStripMenuItem.Size = new System.Drawing.Size(81, 24);
            this.插入语句ToolStripMenuItem.Text = "插入语句";
            // 
            // 创建数据库ToolStripMenuItem
            // 
            this.创建数据库ToolStripMenuItem.Name = "创建数据库ToolStripMenuItem";
            this.创建数据库ToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.创建数据库ToolStripMenuItem.Text = "创建数据库";
            this.创建数据库ToolStripMenuItem.Click += new System.EventHandler(this.创建数据库ToolStripMenuItem_Click);
            // 
            // 创建表ToolStripMenuItem
            // 
            this.创建表ToolStripMenuItem.Name = "创建表ToolStripMenuItem";
            this.创建表ToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.创建表ToolStripMenuItem.Text = "创建表";
            this.创建表ToolStripMenuItem.Click += new System.EventHandler(this.创建表ToolStripMenuItem_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Location = new System.Drawing.Point(0, 680);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1045, 22);
            this.statusStrip1.TabIndex = 4;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // 保存ToolStripMenuItem1
            // 
            this.保存ToolStripMenuItem1.Name = "保存ToolStripMenuItem1";
            this.保存ToolStripMenuItem1.Size = new System.Drawing.Size(216, 26);
            this.保存ToolStripMenuItem1.Text = "删除选中行";
            this.保存ToolStripMenuItem1.Click += new System.EventHandler(this.删除ToolStripMenuItem_Click);
            // 
            // 删除ToolStripMenuItem1
            // 
            this.删除ToolStripMenuItem1.Name = "删除ToolStripMenuItem1";
            this.删除ToolStripMenuItem1.Size = new System.Drawing.Size(216, 26);
            this.删除ToolStripMenuItem1.Text = "保存";
            this.删除ToolStripMenuItem1.Click += new System.EventHandler(this.保存ToolStripMenuItem_Click);
            // 
            // 保存ToolStripMenuItem
            // 
            this.保存ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.保存ToolStripMenuItem1,
            this.删除ToolStripMenuItem1});
            this.保存ToolStripMenuItem.Name = "保存ToolStripMenuItem";
            this.保存ToolStripMenuItem.Size = new System.Drawing.Size(66, 24);
            this.保存ToolStripMenuItem.Text = "表数据";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1045, 702);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "SQL_TOOL";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TextBox txtSQL;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtUserID;
        private System.Windows.Forms.TextBox txtServer;
        private System.Windows.Forms.ComboBox cmbDatabase;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.ComboBox cmbTable;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtEntityClass;
        private System.Windows.Forms.Button btnQuery;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 执行F5ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 清空ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 实体类ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 插入语句ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 创建数据库ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 创建表ToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripMenuItem 保存ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 保存ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 删除ToolStripMenuItem1;
    }
}


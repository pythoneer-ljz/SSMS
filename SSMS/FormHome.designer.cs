namespace SSMS
{
    partial class FormHome
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
            this.components = new System.ComponentModel.Container();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.txtSQL = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.添加数据ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.删除所选ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.更新到数据库ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.全选ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.txtEntityClass = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtUserID = new System.Windows.Forms.TextBox();
            this.txtServer = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbTable = new System.Windows.Forms.ComboBox();
            this.cmbDatabase = new System.Windows.Forms.ComboBox();
            this.btnQuery = new System.Windows.Forms.Button();
            this.btnLogin = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.执行F5ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.清空ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.清空ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.查找ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.插入ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.创建数据库ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.创建表ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.创建存储过程ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.增删改列ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.查看表结构ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.新建查询窗口ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.实体类ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.关于ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
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
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
            this.splitContainer1.SplitterDistance = 291;
            this.splitContainer1.SplitterWidth = 5;
            this.splitContainer1.TabIndex = 0;
            // 
            // txtSQL
            // 
            this.txtSQL.AcceptsTab = true;
            this.txtSQL.BackColor = System.Drawing.Color.AliceBlue;
            this.txtSQL.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtSQL.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtSQL.ForeColor = System.Drawing.Color.Black;
            this.txtSQL.Location = new System.Drawing.Point(0, 0);
            this.txtSQL.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtSQL.MaxLength = 32767000;
            this.txtSQL.Multiline = true;
            this.txtSQL.Name = "txtSQL";
            this.txtSQL.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtSQL.Size = new System.Drawing.Size(997, 291);
            this.txtSQL.TabIndex = 0;
            this.txtSQL.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSQL_KeyDown);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.ContextMenuStrip = this.contextMenuStrip1;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(997, 206);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.DataSourceChanged += new System.EventHandler(this.dataGridView1_DataSourceChanged_1);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.添加数据ToolStripMenuItem,
            this.删除所选ToolStripMenuItem,
            this.更新到数据库ToolStripMenuItem,
            this.全选ToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(169, 100);
            // 
            // 添加数据ToolStripMenuItem
            // 
            this.添加数据ToolStripMenuItem.Name = "添加数据ToolStripMenuItem";
            this.添加数据ToolStripMenuItem.Size = new System.Drawing.Size(168, 24);
            this.添加数据ToolStripMenuItem.Text = "添加数据";
            this.添加数据ToolStripMenuItem.Click += new System.EventHandler(this.添加数据ToolStripMenuItem_Click);
            // 
            // 删除所选ToolStripMenuItem
            // 
            this.删除所选ToolStripMenuItem.Name = "删除所选ToolStripMenuItem";
            this.删除所选ToolStripMenuItem.Size = new System.Drawing.Size(168, 24);
            this.删除所选ToolStripMenuItem.Text = "删除所选";
            this.删除所选ToolStripMenuItem.Click += new System.EventHandler(this.删除所选ToolStripMenuItem_Click);
            // 
            // 更新到数据库ToolStripMenuItem
            // 
            this.更新到数据库ToolStripMenuItem.Name = "更新到数据库ToolStripMenuItem";
            this.更新到数据库ToolStripMenuItem.Size = new System.Drawing.Size(168, 24);
            this.更新到数据库ToolStripMenuItem.Text = "更新到数据库";
            this.更新到数据库ToolStripMenuItem.Click += new System.EventHandler(this.更新到数据库ToolStripMenuItem_Click);
            // 
            // 全选ToolStripMenuItem
            // 
            this.全选ToolStripMenuItem.Name = "全选ToolStripMenuItem";
            this.全选ToolStripMenuItem.Size = new System.Drawing.Size(168, 24);
            this.全选ToolStripMenuItem.Text = "全选";
            this.全选ToolStripMenuItem.Click += new System.EventHandler(this.全选ToolStripMenuItem_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(16, 149);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1013, 539);
            this.tabControl1.TabIndex = 1;
            this.tabControl1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tabControl1_KeyDown);
            this.tabControl1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tabControl1_KeyPress);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.splitContainer1);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage1.Size = new System.Drawing.Size(1005, 510);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "SQL查询";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.txtEntityClass);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
            this.txtEntityClass.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
            this.groupBox1.Controls.Add(this.txtPassword);
            this.groupBox1.Controls.Add(this.txtUserID);
            this.groupBox1.Controls.Add(this.txtServer);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cmbTable);
            this.groupBox1.Controls.Add(this.cmbDatabase);
            this.groupBox1.Controls.Add(this.btnQuery);
            this.groupBox1.Controls.Add(this.btnLogin);
            this.groupBox1.Location = new System.Drawing.Point(16, 49);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(1013, 76);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "连接信息";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(220, 31);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(104, 25);
            this.txtPassword.TabIndex = 5;
            // 
            // txtUserID
            // 
            this.txtUserID.Location = new System.Drawing.Point(96, 31);
            this.txtUserID.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtUserID.Name = "txtUserID";
            this.txtUserID.Size = new System.Drawing.Size(115, 25);
            this.txtUserID.TabIndex = 5;
            this.txtUserID.Text = "sa";
            // 
            // txtServer
            // 
            this.txtServer.Location = new System.Drawing.Point(9, 31);
            this.txtServer.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtServer.Name = "txtServer";
            this.txtServer.Size = new System.Drawing.Size(77, 25);
            this.txtServer.TabIndex = 5;
            this.txtServer.Text = "(local)";
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
            this.cmbTable.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
            this.cmbDatabase.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbDatabase.Name = "cmbDatabase";
            this.cmbDatabase.Size = new System.Drawing.Size(160, 23);
            this.cmbDatabase.TabIndex = 3;
            this.cmbDatabase.TextChanged += new System.EventHandler(this.cmbDatabase_TextChanged);
            // 
            // btnQuery
            // 
            this.btnQuery.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnQuery.Location = new System.Drawing.Point(913, 30);
            this.btnQuery.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
            this.btnLogin.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(79, 29);
            this.btnLogin.TabIndex = 2;
            this.btnLogin.Text = "登录";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.执行F5ToolStripMenuItem,
            this.清空ToolStripMenuItem,
            this.插入ToolStripMenuItem1,
            this.新建查询窗口ToolStripMenuItem,
            this.实体类ToolStripMenuItem,
            this.关于ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1045, 28);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 执行F5ToolStripMenuItem
            // 
            this.执行F5ToolStripMenuItem.Name = "执行F5ToolStripMenuItem";
            this.执行F5ToolStripMenuItem.ShortcutKeyDisplayString = "";
            this.执行F5ToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F5;
            this.执行F5ToolStripMenuItem.Size = new System.Drawing.Size(80, 24);
            this.执行F5ToolStripMenuItem.Text = "执行(F5)";
            this.执行F5ToolStripMenuItem.Click += new System.EventHandler(this.执行F5ToolStripMenuItem_Click);
            // 
            // 清空ToolStripMenuItem
            // 
            this.清空ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.清空ToolStripMenuItem1,
            this.查找ToolStripMenuItem});
            this.清空ToolStripMenuItem.Name = "清空ToolStripMenuItem";
            this.清空ToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.R)));
            this.清空ToolStripMenuItem.Size = new System.Drawing.Size(71, 24);
            this.清空ToolStripMenuItem.Text = "编辑(&E)";
            // 
            // 清空ToolStripMenuItem1
            // 
            this.清空ToolStripMenuItem1.Name = "清空ToolStripMenuItem1";
            this.清空ToolStripMenuItem1.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.R)));
            this.清空ToolStripMenuItem1.Size = new System.Drawing.Size(178, 26);
            this.清空ToolStripMenuItem1.Text = "清空";
            this.清空ToolStripMenuItem1.Click += new System.EventHandler(this.清空ToolStripMenuItem_Click);
            // 
            // 查找ToolStripMenuItem
            // 
            this.查找ToolStripMenuItem.Name = "查找ToolStripMenuItem";
            this.查找ToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F)));
            this.查找ToolStripMenuItem.Size = new System.Drawing.Size(178, 26);
            this.查找ToolStripMenuItem.Text = "查找";
            this.查找ToolStripMenuItem.Click += new System.EventHandler(this.查找ToolStripMenuItem_Click);
            // 
            // 插入ToolStripMenuItem1
            // 
            this.插入ToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.创建数据库ToolStripMenuItem,
            this.创建表ToolStripMenuItem,
            this.创建存储过程ToolStripMenuItem,
            this.增删改列ToolStripMenuItem,
            this.查看表结构ToolStripMenuItem});
            this.插入ToolStripMenuItem1.Name = "插入ToolStripMenuItem1";
            this.插入ToolStripMenuItem1.Size = new System.Drawing.Size(67, 24);
            this.插入ToolStripMenuItem1.Text = "插入(&I)";
            // 
            // 创建数据库ToolStripMenuItem
            // 
            this.创建数据库ToolStripMenuItem.Name = "创建数据库ToolStripMenuItem";
            this.创建数据库ToolStripMenuItem.Size = new System.Drawing.Size(182, 26);
            this.创建数据库ToolStripMenuItem.Text = "创建数据库";
            this.创建数据库ToolStripMenuItem.Click += new System.EventHandler(this.创建数据库ToolStripMenuItem_Click);
            // 
            // 创建表ToolStripMenuItem
            // 
            this.创建表ToolStripMenuItem.Name = "创建表ToolStripMenuItem";
            this.创建表ToolStripMenuItem.Size = new System.Drawing.Size(182, 26);
            this.创建表ToolStripMenuItem.Text = "创建表";
            this.创建表ToolStripMenuItem.Click += new System.EventHandler(this.创建表ToolStripMenuItem_Click);
            // 
            // 创建存储过程ToolStripMenuItem
            // 
            this.创建存储过程ToolStripMenuItem.Name = "创建存储过程ToolStripMenuItem";
            this.创建存储过程ToolStripMenuItem.Size = new System.Drawing.Size(182, 26);
            this.创建存储过程ToolStripMenuItem.Text = "创建存储过程";
            this.创建存储过程ToolStripMenuItem.Click += new System.EventHandler(this.创建存储过程ToolStripMenuItem_Click);
            // 
            // 增删改列ToolStripMenuItem
            // 
            this.增删改列ToolStripMenuItem.Name = "增删改列ToolStripMenuItem";
            this.增删改列ToolStripMenuItem.Size = new System.Drawing.Size(182, 26);
            this.增删改列ToolStripMenuItem.Text = "增删改列";
            this.增删改列ToolStripMenuItem.Click += new System.EventHandler(this.增删改列ToolStripMenuItem_Click);
            // 
            // 查看表结构ToolStripMenuItem
            // 
            this.查看表结构ToolStripMenuItem.Name = "查看表结构ToolStripMenuItem";
            this.查看表结构ToolStripMenuItem.Size = new System.Drawing.Size(182, 26);
            this.查看表结构ToolStripMenuItem.Text = "查看表结构";
            this.查看表结构ToolStripMenuItem.Click += new System.EventHandler(this.查看表结构ToolStripMenuItem_Click);
            // 
            // 新建查询窗口ToolStripMenuItem
            // 
            this.新建查询窗口ToolStripMenuItem.Name = "新建查询窗口ToolStripMenuItem";
            this.新建查询窗口ToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.T)));
            this.新建查询窗口ToolStripMenuItem.Size = new System.Drawing.Size(83, 24);
            this.新建查询窗口ToolStripMenuItem.Text = "新建查询";
            this.新建查询窗口ToolStripMenuItem.Click += new System.EventHandler(this.新建查询窗口ToolStripMenuItem_Click);
            // 
            // 实体类ToolStripMenuItem
            // 
            this.实体类ToolStripMenuItem.Name = "实体类ToolStripMenuItem";
            this.实体类ToolStripMenuItem.Size = new System.Drawing.Size(98, 24);
            this.实体类ToolStripMenuItem.Text = "保存实体类";
            this.实体类ToolStripMenuItem.Click += new System.EventHandler(this.实体类ToolStripMenuItem_Click);
            // 
            // 关于ToolStripMenuItem
            // 
            this.关于ToolStripMenuItem.Name = "关于ToolStripMenuItem";
            this.关于ToolStripMenuItem.Size = new System.Drawing.Size(53, 24);
            this.关于ToolStripMenuItem.Text = "关于";
            this.关于ToolStripMenuItem.Click += new System.EventHandler(this.关于ToolStripMenuItem_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Location = new System.Drawing.Point(0, 680);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 13, 0);
            this.statusStrip1.Size = new System.Drawing.Size(1045, 22);
            this.statusStrip1.TabIndex = 4;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // FormHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1045, 702);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FormHome";
            this.Text = "SSMS";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
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
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripMenuItem 清空ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 新建查询窗口ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 插入ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 创建数据库ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 创建表ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 查找ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 创建存储过程ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 增删改列ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 查看表结构ToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 添加数据ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 删除所选ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 更新到数据库ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 全选ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 关于ToolStripMenuItem;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtUserID;
        private System.Windows.Forms.TextBox txtServer;
    }
}


using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Threading;

namespace SSMS
{
    public partial class FormHome : Form
    {

        public string tableName;
        public DBHelper dBHelper;

        public FormHome()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dBHelper = new DBHelper();

            if (Program.args.Length == 1)
            {
                string text = File.ReadAllText(Program.args[0], Encoding.UTF8);
                txtSQL.Text = text;
            }
        }

        private void txtSQL_KeyDown(object sender, KeyEventArgs e)
        {


            //Ctrl+A全选
            if (e.Modifiers == Keys.Control && e.KeyCode == Keys.A)
            {
                ((TextBox)sender).SelectAll();
            }





        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                string server = txtServer.Text, userID = txtUserID.Text, password = txtPassword.Text;
                if (txtUserID.Text != "" || txtPassword.Text != "")
                    dBHelper.connStr = "Data Source=" + server + ";Initial Catalog=;User ID=" + userID + ";Password=" + password + ";Connect Timeout=1";
                else
                    dBHelper.connStr = "Data Source=" + server + ";Initial Catalog=;Integrated Security=True;Connect Timeout=1";

                dBHelper.Init();

                //查询数据列表
                DataTable dt = dBHelper.GetDataTable("select name from sysdatabases");

                //清理
                cmbDatabase.Items.Clear();
                cmbTable.Text = "";

                if (dt.Rows.Count > 0)
                {

                    //遍历添加表名
                    foreach (DataRow row in dt.Rows)
                        cmbDatabase.Items.Add(row["name"].ToString());

                    //默认选中第一个
                    cmbDatabase.Text = cmbDatabase.Items[0].ToString();

                }

                cmbDatabase.Enabled =
                cmbTable.Enabled =
                btnQuery.Enabled =
                执行F5ToolStripMenuItem.Enabled =
                    true;

            }
            catch (Exception ex)
            {
                cmbDatabase.Enabled =
                cmbTable.Enabled =
                btnQuery.Enabled =
                执行F5ToolStripMenuItem.Enabled =
                    false;


                MessageBox.Show(ex.Message);
            }
        }


        private void cmbDatabase_TextChanged(object sender, EventArgs e)
        {
            string database = cmbDatabase.Text;
            string server = txtServer.Text, userID = txtUserID.Text, password = txtPassword.Text;

            if (txtUserID.Text != "" && txtPassword.Text != "")
                dBHelper.connStr = "Data Source=" + server + ";Initial Catalog=" + database + ";Persist Security Info=True;User ID=" + userID + ";Password=" + password + ";Connect Timeout=1";
            else
                dBHelper.connStr = "Data Source=" + server + ";Initial Catalog=" + database + ";Integrated Security=True;Connect Timeout=1";

            dBHelper.Init();

            DataTable dt = dBHelper.GetDataTable("select name from sysobjects where xtype = 'U'");

            //清理
            cmbTable.Items.Clear();
            cmbTable.Text = "";
            if (dt.Rows.Count > 0)
            {
                //遍历添加表名
                foreach (DataRow row in dt.Rows)
                    cmbTable.Items.Add(row["name"].ToString());

                //默认选中第一个
                cmbTable.Text = cmbTable.Items[0].ToString();

            }

        }

        private void cmbTable_TextChanged(object sender, EventArgs e)
        {
            tableName = cmbTable.Text;

            //加载实体类
            string sql = "select column_name,data_type from " + cmbDatabase.Text + ".information_schema.columns where table_name='" + tableName + "'";
            DataTable dt = dBHelper.GetDataTable(sql);

            StringBuilder sb = new StringBuilder("public class " + tableName + "\r\n{");

            foreach (DataRow field in dt.Rows)
            {
                string column_name = field["column_name"].ToString();
                string data_type = DBTpyeConvertCSType(field["data_type"].ToString());
                sb.Append("\r\n\tprivate " + data_type + " _" + column_name + ";\r\n\tpublic " + data_type + " " + column_name + "\r\n\t{\r\n\t\tget { return _" + column_name + "; }\r\n\t\tset { _" + column_name + " = value; }\r\n\t}\r\n");
            }

            sb.Append("}");

            txtEntityClass.Text = sb.ToString();

        }


        private string DBTpyeConvertCSType(string dbtype)
        {
            Hashtable hashtable = new Hashtable();
            hashtable.Add("SQL", "C#");
            hashtable.Add("bigint", "long");
            hashtable.Add("binary", "object");
            hashtable.Add("bit", "bool");
            hashtable.Add("char", "string");
            hashtable.Add("datetime", "DateTime");
            hashtable.Add("decimal", "decimal");
            hashtable.Add("float", "double");
            hashtable.Add("image", "byte[]");
            hashtable.Add("int", "int");
            hashtable.Add("money", "decimal");
            hashtable.Add("nchar", "string");
            hashtable.Add("ntext", "string");
            hashtable.Add("numeric", "decimal");
            hashtable.Add("nvarchar", "string");
            hashtable.Add("real", "float");
            hashtable.Add("smalldatetime", "DateTime");
            hashtable.Add("smallint", "short");
            hashtable.Add("smallmoney", "decimal");
            hashtable.Add("text", "string");
            hashtable.Add("timestamp", "byte[]");
            hashtable.Add("tinyint", "byte");
            hashtable.Add("uniqueidentifier", "Guid");
            hashtable.Add("varbinary", "byte[]");
            hashtable.Add("varchar", "string");
            hashtable.Add("xml", "string");
            hashtable.Add("sql_variant", "object");
            hashtable.Add("date", "string");
            hashtable.Add("time", "string");

            string text = "未知类型";
            if (!string.IsNullOrEmpty(dbtype))
            {
                try
                {
                    text = hashtable[dbtype].ToString();
                    if (string.IsNullOrEmpty(text))
                    {
                        text = "未知类型";
                    }
                }
                catch
                {
                    text = "未知类型";
                }
            }
            return text;
        }

        private void txtEntityClass_KeyDown(object sender, KeyEventArgs e)
        {
            //Ctrl+A全选
            if (e.Modifiers == Keys.Control && e.KeyCode == Keys.A)
            {
                ((TextBox)sender).SelectAll();
            }
        }

        private void btnQuery_Click(object sender, EventArgs e)
        {
            tableName = cmbTable.Text;

            TextBox txtSQL = (TextBox)(tabControl1.SelectedTab.Controls.Find("txtSQL", true)[0]);
            DataGridView dataGridView1 = (DataGridView)(tabControl1.SelectedTab.Controls.Find("dataGridView1", true)[0]);

            txtSQL.Text += "\r\nSELECT * FROM " + tableName + "";

            try
            {
                string[] nums = txtSQL.Text.Split('\n');


                dataGridView1.DataSource = dBHelper.GetDataTable(nums[nums.Length - 1]);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }








        }

        private void 执行F5ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string sql = "";

            TextBox txtSQL = (TextBox)(tabControl1.SelectedTab.Controls.Find("txtSQL", true)[0]);

            if (txtSQL.Text == "") return;

            DataGridView dataGridView1 = (DataGridView)(tabControl1.SelectedTab.Controls.Find("dataGridView1", true)[0]);
            if (txtSQL.SelectionLength > 0)
            {
                sql = txtSQL.SelectedText;
            }
            else
            {
                sql = txtSQL.Text;
            }

            if (sql.Contains("GO\r\n") || sql.Contains("go\r\n"))
            {
                string[] datas = Regex.Split(sql, "GO", RegexOptions.IgnoreCase);
                foreach (string str in datas)
                {

                    try
                    {
                        dBHelper.GetDataTable(str);

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
            else
            {
                try
                {
                    dataGridView1.DataSource = dBHelper.GetDataTable(sql);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    return;
                }
            }

            //重新加载表
            string table = cmbTable.Text;
            cmbDatabase_TextChanged(null, null);
            cmbTable.Text = table;


            statusStrip1.Items.Clear();
            statusStrip1.Items.Add("   执行时间: " + DateTime.Now.ToLocalTime());

        }

        private void 清空ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TextBox txtSQL = (TextBox)(tabControl1.SelectedTab.Controls.Find("txtSQL", true)[0]);

            if (MessageBox.Show("是否清空?", "清空", MessageBoxButtons.YesNo) == DialogResult.Yes)
                txtSQL.Text = "";
        }

        private void 实体类ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.FileName = cmbTable.Text;
            saveFileDialog.Filter = "Visual C# 文件(*.cs)|*.cs";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
                File.WriteAllText(saveFileDialog.FileName, txtEntityClass.Text, Encoding.UTF8);
        }

        private void 创建数据库ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string text = @"
CREATE DATABASE DB
ON PRIMARY
(
    NAME = 'DB',                        --逻辑名称
    FILENAME = 'D:\MSSQL\DB.mdf',       --保存路径
    SIZE = 5MB,                         --初始大小
    MAXSIZE = 150MB,                    --最大容量
    FILEGROWTH = 20 %                   --文件增长
)
LOG ON
(
    NAME = 'DB_log',                    --逻辑名称
    FILENAME = 'D:\MSSQL\DB_log.ldf',   --保存路径
    SIZE = 5MB,                         --初始大小
    FILEGROWTH = 5MB                    --文件增长
)
";
            TextBox txtSQL = (TextBox)(tabControl1.SelectedTab.Controls.Find("txtSQL", true)[0]);
            //文本框文本长度
            int len = txtSQL.Text.Length;
            //在结尾追加文本
            txtSQL.Text += text;
            //选中
            txtSQL.Select(len, text.Length);
            //滚动到光标处
            txtSQL.ScrollToCaret();
        }

        private void 创建表ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string text = @"
CREATE TABLE Table_1
(
    ID int IDENTITY(1,1) PRIMARY KEY,   --自增,种子1,增量1  主键
    Name nvarchar(100) NOT NULL,        --Unicode编码 每字符占两字节,最多4000
    Content nvarchar(MAX),              --最多536870912
    DateTime smalldatetime,             --2000/01/01 00:00:00
    Date date,                          --2000/01/01
    Time time,                          --00:00:00
    Checked bit,                        --允许 0、1 或 NULL
    Num decimal(8,0)                    --小数点左边8位, 右边0位
)
";
            TextBox txtSQL = (TextBox)(tabControl1.SelectedTab.Controls.Find("txtSQL", true)[0]);
            //文本框文本长度
            int len = txtSQL.Text.Length;
            //在结尾追加文本
            txtSQL.Text += text;
            //选中
            txtSQL.Select(len, text.Length);
            //滚动到光标处
            txtSQL.ScrollToCaret();
        }

        private void 创建存储过程ToolStripMenuItem_Click(object sender, EventArgs e)
        {

            string text = @"
CREATE PROCEDURE Procedure_Name
    @Param1 nvarchar(50),
    @Param2 nvarchar(50)
AS
BEGIN
	SELECT * FROM Table_1 WHERE name=@Param1
END
";
            TextBox txtSQL = (TextBox)(tabControl1.SelectedTab.Controls.Find("txtSQL", true)[0]);
            //文本框文本长度
            int len = txtSQL.Text.Length;
            //在结尾追加文本
            txtSQL.Text += text;
            //选中
            txtSQL.Select(len, text.Length);
            //滚动到光标处
            txtSQL.ScrollToCaret();
        }

        private void 新增列ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string text = @"
ALTER TABLE " + cmbTable.Text + @"
    ADD 
        ID int IDENTITY(1,1) PRIMARY KEY,
        Name nvarchar(100) NOT NULL
";
            TextBox txtSQL = (TextBox)(tabControl1.SelectedTab.Controls.Find("txtSQL", true)[0]);
            //文本框文本长度
            int len = txtSQL.Text.Length;
            //在结尾追加文本
            txtSQL.Text += text;
            //选中
            txtSQL.Select(len, text.Length);
            //滚动到光标处
            txtSQL.ScrollToCaret();
        }

        private void 修改列ToolStripMenuItem_Click(object sender, EventArgs e)
        {

            string text = @"
ALTER TABLE " + cmbTable.Text + @"
    ALTER COLUMN
        column_name nvarchar(100)
";
            TextBox txtSQL = (TextBox)(tabControl1.SelectedTab.Controls.Find("txtSQL", true)[0]);
            //文本框文本长度
            int len = txtSQL.Text.Length;
            //在结尾追加文本
            txtSQL.Text += text;
            //选中
            txtSQL.Select(len, text.Length);
            //滚动到光标处
            txtSQL.ScrollToCaret();
        }

        private void 删除列ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string text = @"
ALTER TABLE " + cmbTable.Text + @"
    DROP COLUMN
        column_name
";
            TextBox txtSQL = (TextBox)(tabControl1.SelectedTab.Controls.Find("txtSQL", true)[0]);
            //文本框文本长度
            int len = txtSQL.Text.Length;
            //在结尾追加文本
            txtSQL.Text += text;
            //选中
            txtSQL.Select(len, text.Length);
            //滚动到光标处
            txtSQL.ScrollToCaret();
        }

        private void 查看表结构ToolStripMenuItem_Click(object sender, EventArgs e)
        {

            string text = @"
SELECT COLUMN_NAME 列名,DATA_TYPE 数据类型,CHARACTER_MAXIMUM_LENGTH 最大长度,IS_NULLABLE 允许Null值 FROM " + cmbDatabase.Text + ".information_schema.columns WHERE table_name = '" + cmbTable.Text + @"'
";
            TextBox txtSQL = (TextBox)(tabControl1.SelectedTab.Controls.Find("txtSQL", true)[0]);
            //文本框文本长度
            int len = txtSQL.Text.Length;
            //在结尾追加文本
            txtSQL.Text += text;
            //选中
            txtSQL.Select(len, text.Length);
            //滚动到光标处
            txtSQL.ScrollToCaret();
        }

        private void 查看ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string text = @"
select a.name,a.[type],b.[definition] from sys.all_objects a,sys.sql_modules b
where a.is_ms_shipped=0 and a.object_id = b.object_id and a.[type] in ('P','V','AF')
order by a.[name] asc
";
            TextBox txtSQL = (TextBox)(tabControl1.SelectedTab.Controls.Find("txtSQL", true)[0]);
            //文本框文本长度
            int len = txtSQL.Text.Length;
            //在结尾追加文本
            txtSQL.Text += text;
            //选中
            txtSQL.Select(len, text.Length);
            //滚动到光标处
            txtSQL.ScrollToCaret();
        }


        private void dataGridView1_DataSourceChanged(object sender, EventArgs e)
        {
            statusStrip1.Items.Clear();
            int rowCount = dataGridView1.RowCount;
            int columnCount = dataGridView1.ColumnCount;
            statusStrip1.Items.Add("     RowCount: " + rowCount + "   ColumnCount: " + columnCount + "");

        }

        private void 新建查询窗口ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SplitContainer splitContainer1 = new SplitContainer();
            TextBox txtSQL = new TextBox();
            DataGridView dataGridView1 = new DataGridView();

            // 
            // splitContainer1
            // 
            splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            splitContainer1.Location = new System.Drawing.Point(3, 3);
            splitContainer1.Name = "splitContainer1";
            splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(txtSQL);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(dataGridView1);
            splitContainer1.Size = new System.Drawing.Size(746, 399);
            splitContainer1.SplitterDistance = 233;
            splitContainer1.SplitterWidth = 5;
            splitContainer1.TabIndex = 0;
            // 
            // txtSQL
            // 
            txtSQL.Dock = System.Windows.Forms.DockStyle.Fill;
            txtSQL.BackColor = System.Drawing.Color.AliceBlue;
            txtSQL.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            txtSQL.ForeColor = System.Drawing.Color.Black;
            txtSQL.Location = new System.Drawing.Point(0, 0);
            txtSQL.Margin = new System.Windows.Forms.Padding(4);
            txtSQL.Multiline = true;
            txtSQL.Name = "txtSQL";
            txtSQL.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            txtSQL.Size = new System.Drawing.Size(997, 219);
            txtSQL.TabIndex = 7;
            txtSQL.AcceptsTab = true;
            txtSQL.KeyDown += new System.Windows.Forms.KeyEventHandler(txtSQL_KeyDown);
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            dataGridView1.Location = new System.Drawing.Point(0, 0);
            dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 23;
            dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new System.Drawing.Size(997, 278);
            dataGridView1.TabIndex = 8;
            dataGridView1.ContextMenuStrip = contextMenuStrip1;

            TabPage tabPage1 = new TabPage();

            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(splitContainer1);
            tabPage1.Location = new System.Drawing.Point(4, 25);
            tabPage1.Margin = new System.Windows.Forms.Padding(4);
            //this.tabPage1.Name = "tabPage1";
            tabPage1.Padding = new System.Windows.Forms.Padding(4);
            tabPage1.Size = new System.Drawing.Size(1005, 510);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "SQL查询";
            tabPage1.UseVisualStyleBackColor = true;


            tabControl1.Controls.Add(tabPage1);

            tabControl1.SelectedTab = tabPage1;


            //foreach (Control control in tabPage1.Controls)
            //{
            //    tabPage.Controls.Add(control);
            //}

            //tabControl1.TabPages.Add(tabPage);

        }

        private void tabControl1_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void tabControl1_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.Control) && (e.KeyCode == Keys.W))
            {

                tabControl1.Controls.Remove(tabControl1.SelectedTab);

                SendKeys.Send("^+{Tab}");
            }


        }

        private void dataGridView1_DataSourceChanged_1(object sender, EventArgs e)
        {
            int rowCount = dataGridView1.RowCount;
            int columnCount = dataGridView1.ColumnCount;

            statusStrip1.Items.Clear();
            statusStrip1.Items.Add("   RowCount: " + --rowCount + "   ColumnCount: " + columnCount + "");
        }


        private void 查找ToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Form form = new Form();
            form.Text = "  查找";
            form.MaximumSize =
            form.Size = new Size(406, 80);
            form.MaximizeBox = false;
            form.Location = new Point(((Width - form.Size.Width) / 2) + Location.X, (Height - form.Size.Height) / 2 + Location.Y);
            form.FormBorderStyle = FormBorderStyle.FixedToolWindow;
            form.StartPosition = FormStartPosition.Manual;
            form.Opacity = 0.9;

            Label label1 = new Label();
            label1.AutoSize = true;
            label1.Text = "查找内容";
            label1.Location = new Point(9, 14);

            TextBox textBox1 = new TextBox();
            textBox1.Name = "txtWord";
            textBox1.Location = new Point(67, 11);
            textBox1.Size = new Size(176, 14);

            Button button1 = new Button();
            button1.Name = "btnPrev";
            button1.Location = new Point(257, 11);
            button1.Size = new Size(60, 21);
            button1.Text = "上一个";
            button1.Click += new EventHandler(btnPrev_Click);

            Button button2 = new Button();
            button2.Name = "btnNext";
            button2.Location = new Point(323, 11);
            button2.Size = new Size(60, 21);
            button2.Text = "下一个";
            button2.Click += new EventHandler(btnNext_Click);

            form.Controls.Add(label1);
            form.Controls.Add(textBox1);
            form.Controls.Add(button1);
            form.Controls.Add(button2);



            form.TopMost = true;
            form.Show();
        }



        private void btnNext_Click(object sender, EventArgs e)

        {
            //查找窗体对象
            Form form = ((Button)sender).FindForm();

            //关键字
            string word = ((TextBox)form.Controls.Find("txtWord", true)[0]).Text;

            TextBox txtSQL = (TextBox)(tabControl1.SelectedTab.Controls.Find("txtSQL", true)[0]);
            string sql = txtSQL.Text;
            try
            {

                int index = sql.IndexOf(word, txtSQL.SelectionStart + 1);

                txtSQL.Select(index, word.Length);

                //滚到光标处
                txtSQL.ScrollToCaret();
            }
            catch (Exception)
            {
                MessageBox.Show("找不到 " + word);

            }

            Focus();
        }



        private void btnPrev_Click(object sender, EventArgs e)

        {

            //查找窗体对象
            Form form = ((Button)sender).FindForm();

            //关键字
            string word = ((TextBox)form.Controls.Find("txtWord", true)[0]).Text;

            TextBox txtSQL = (TextBox)(tabControl1.SelectedTab.Controls.Find("txtSQL", true)[0]);
            string sql = txtSQL.Text;
            try
            {
                int index = sql.LastIndexOf(word, txtSQL.SelectionStart - 1);

                txtSQL.Select(index, word.Length);

                //滚到光标处
                txtSQL.ScrollToCaret();

            }
            catch (Exception)
            {
                MessageBox.Show("找不到 " + word);

            }
            Focus();
        }

        private void 保存ToolStripMenuItem_Click_1(object sender, EventArgs e)
        {

        }

        private void 添加数据ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataGridView dataGridView1 = (DataGridView)(tabControl1.SelectedTab.Controls.Find("dataGridView1", true)[0]);
            if (dataGridView1.Rows.Count < 1) return;
            dataGridView1.FirstDisplayedScrollingRowIndex = dataGridView1.Rows.Count - 1;
            dataGridView1.ClearSelection();
            dataGridView1.Rows[dataGridView1.Rows.Count - 1].Selected = true;
        }

        private void 删除所选ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataGridView dataGridView1 = (DataGridView)(tabControl1.SelectedTab.Controls.Find("dataGridView1", true)[0]);

            foreach (DataGridViewRow‎ row in dataGridView1.SelectedRows)
            {
                dataGridView1.Rows.Remove(row);
            }
        }

        private void 更新到数据库ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridView1.DataSource == null) return;
            statusStrip1.Items.Clear();
            statusStrip1.Items.Add("   AffectedRowCount: " + dBHelper.UpdateToDatabase(cmbTable.Text, (DataTable)dataGridView1.DataSource) + "");
        }

        private void 全选ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataGridView dataGridView1 = (DataGridView)(tabControl1.SelectedTab.Controls.Find("dataGridView1", true)[0]);
            dataGridView1.SelectAll();
        }

        private void 关于ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form form = new Form();
            form.Text = "  关于软件";
            form.MaximumSize =
            form.Size = new Size(300, 176);
            form.MaximizeBox = false;
            form.FormBorderStyle = FormBorderStyle.FixedToolWindow;
            form.StartPosition = FormStartPosition.CenterParent;

            Label label1 = new Label();
            label1.AutoSize = true;
            label1.Text = @"SSMS 1.0.1


作者企鹅：2267719005

个人主页：http://3ghh.cn

项目地址：https://github.com/Jiuzhou-Liu/SSMS

更新日期：2019/8/15
";
            label1.Location = new Point(9, 14);

            form.Controls.Add(label1);

            form.ShowDialog();
        }

        private void 打开ToolStripMenuItem_Click(object sender, EventArgs e)
        {

            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {

                TextBox txtSQL = (TextBox)(tabControl1.SelectedTab.Controls.Find("txtSQL", true)[0]);
                txtSQL.Text = File.ReadAllText(openFileDialog.FileName, Encoding.UTF8);
            }

        }

        private void 保存ToolStripMenuItem_Click_2(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "SQL 文件(*.sql)|*.sql";
            saveFileDialog.FileName = "SQLQuery1.sql";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                TextBox txtSQL = (TextBox)(tabControl1.SelectedTab.Controls.Find("txtSQL", true)[0]);

                File.WriteAllText(saveFileDialog.FileName, txtSQL.Text, Encoding.UTF8);
            }
        }


    }
}

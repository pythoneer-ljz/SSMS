using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace SSMS
{
    public partial class Form1 : Form
    {

        public string tableName;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

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
            string server = txtServer.Text, userID = txtUserID.Text, password = txtPassword.Text;
            DBHelper.connStr = "Data Source=" + server + ";Initial Catalog=;Persist Security Info=True;User ID=" + userID + ";Password=" + password + ";Connect Timeout=1";
            DataTable dt = DBHelper.GetDataTable("select name from sysdatabases");
            cmbDatabase.ValueMember = "name";
            cmbDatabase.DisplayMember = "name";
            cmbDatabase.DataSource = dt;
        }

        private void cmbDatabase_TextChanged(object sender, EventArgs e)
        {
            string database = cmbDatabase.Text;
            string server = txtServer.Text, userID = txtUserID.Text, password = txtPassword.Text;
            DBHelper.connStr = "Data Source=" + server + ";Initial Catalog=" + database + ";Persist Security Info=True;User ID=" + userID + ";Password=" + password + ";Connect Timeout=1";


            DataTable dt = DBHelper.GetDataTable("select name from sysobjects where xtype = 'U'");
            if (dt.Rows.Count > 0)
            {
                cmbTable.ValueMember = "name";
                cmbTable.DisplayMember = "name";
                cmbTable.DataSource = dt;
            }
            else
            {
                cmbTable.DataSource = null;
            }
        }

        private void cmbTable_TextChanged(object sender, EventArgs e)
        {
            tableName = cmbTable.Text;

            //加载实体类
            string sql = "select column_name,data_type from " + cmbDatabase.Text + ".information_schema.columns where table_name='" + tableName + "'";
            DataTable dt = DBHelper.GetDataTable(sql);

            StringBuilder sb = new StringBuilder("public class " + tableName + "\r\n{");

            foreach (DataRow field in dt.Rows)
            {
                string column_name = field["column_name"].ToString();
                string data_type = DBTpyeConvertCSType(field["data_type"].ToString());
                sb.Append("\r\n\tprivate " + data_type + " _" + column_name + ";\r\n\tpublic " + data_type + " " + column_name + "\r\n\t{\r\n\t\tget { return _" + column_name + "; }\r\n\t\tset { _" + column_name + " = value; }\r\n\t}\r\n");
            }

            sb.Append("}");

            txtEntityClass.Text = sb.ToString();

            //private int eID;
            //public int EID
            //{
            //    get { return eID; }
            //    set { eID = value; }
            //}


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

            txtSQL.Text += "\r\nSELECT * FROM " + tableName + "";

            try
            {
                string[] nums = txtSQL.Text.Split('\n');


                dataGridView1.DataSource = DBHelper.GetDataTable(nums[nums.Length - 1]);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void 执行F5ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string sql = "";
            try
            {
                TextBox txtSQL=(TextBox)(tabControl1.SelectedTab.Controls.Find("txtSQL", true)[0]);
                DataGridView dataGridView1 = (DataGridView)(tabControl1.SelectedTab.Controls.Find("dataGridView1", true)[0]);
                if (txtSQL.SelectionLength > 0)
                {
                    sql = txtSQL.SelectedText;
                }
                else
                {
                    sql = txtSQL.Text;
                }

                if (sql.Contains("GO\r\n"))
                {
                    string[] datas = Regex.Split(sql, "GO", RegexOptions.IgnoreCase);
                    foreach (string str in datas)
                    {
                        DBHelper.GetDataTable(str);
                    }
                }
                else dataGridView1.DataSource = DBHelper.GetDataTable(sql);
                
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);

            }
        }

        private void 清空ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //if (MessageBox.Show("是否清空?","清空",MessageBoxButtons.YesNo)==DialogResult.Yes)
            txtSQL.Text = "";
        }

        private void 保存ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DBHelper.UpdateToDatabase(cmbTable.Text, (DataTable)dataGridView1.DataSource);

        }

        private void 删除ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow‎ row in dataGridView1.SelectedRows)
            {
                dataGridView1.Rows.Remove(row);
            }


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
            txtSQL.Text += @"--drop database MyDatabase

create database MyDatabase

on primary --配置主数据文件的选项

(

name = 'MyDatabase',                --主数据文件的逻辑名称


filename = 'D:\MyDatabase.mdf',     --主数据文件的实际保存路径


size = 5MB,                         --主文件的初始大小


maxsize = 150MB,                    --最大容量


filegrowth = 20 %                   --以20 % 扩容

)


log on --配置日志文件的选项

(

name = 'MyDatabase2_log',           --日志文件的逻辑名称


filename = 'D:\MyDatabase_log.ldf', --日志文件的实际保存路径


size = 5mb,                         --日志文件的初始大小


filegrowth = 5mb                    --超过默认值后自动再扩容5mb

)


  ";
        }

        private void 创建表ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtSQL.Text += @"use MyDatabase

--drop table Table_1

create table Table_1                -- 创建表，设置表中列

(

ID int identity(1,1) primary key,   --自增  主键

Name nvarchar(50) not null          --可变长度，每个字符占用两个字节 最多50个字节

)
 ";
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
            splitContainer1.Location = new System.Drawing.Point(4, 4);
            splitContainer1.Margin = new System.Windows.Forms.Padding(4);
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
            splitContainer1.Size = new System.Drawing.Size(997, 502);
            splitContainer1.SplitterDistance = 219;
            splitContainer1.SplitterWidth = 5;
            splitContainer1.TabIndex = 0;
            // 
            // txtSQL
            // 
            txtSQL.Dock = System.Windows.Forms.DockStyle.Fill;
            txtSQL.Location = new System.Drawing.Point(0, 0);
            txtSQL.Margin = new System.Windows.Forms.Padding(4);
            txtSQL.Multiline = true;
            txtSQL.Name = "txtSQL";
            txtSQL.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            txtSQL.Size = new System.Drawing.Size(997, 219);
            txtSQL.TabIndex = 0;
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
            dataGridView1.TabIndex = 0;

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
            if((e.Control) && (e.KeyCode == Keys.W))
            {
                tabControl1.Controls.Remove(tabControl1.SelectedTab);

                SendKeys.Send("^+{Tab}");
            }

            
        }
    }
}

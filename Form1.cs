using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SQL_Tool
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
            else {
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
                sb.Append("\r\n\tprivate "+ data_type + " _" + column_name + ";\r\n\tpublic " + data_type + " " + column_name + "\r\n\t{\r\n\t\tget { return _" + column_name + "; }\r\n\t\tset { _" + column_name + " = value; }\r\n\t}\r\n");
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
        }

        private void 执行F5ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {

                    //if (!txtSQL.Focused) return;
                    if (txtSQL.SelectionLength > 0)
                    {
                        dataGridView1.DataSource = DBHelper.GetDataTable(txtSQL.SelectedText);
                    }
                    else
                    {
                        dataGridView1.DataSource = DBHelper.GetDataTable(txtSQL.Text);
                    }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);

            }
        }

        private void 清空ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("是否清空?","清空",MessageBoxButtons.YesNo)==DialogResult.Yes)
            txtSQL.Text = "";
        }
    }
}

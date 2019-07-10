using System.Data;
using System.Data.SqlClient;

namespace SQL_Tool
{
    /// <summary>
    /// ADO.NET 操作类
    /// </summary>
    public static class DBHelper
    {
        //Windows身份验证 Data Source=.;Initial Catalog=database;Integrated Security=True;Connect Timeout=1
        //SQL Server身份验证 Data Source=.;Initial Catalog=database;Persist Security Info=True;User ID=sa;Password=123;Connect Timeout=1
        public static string connStr= "";

        public static SqlConnection conn = null;

        /// <summary>
        /// 初始化连接
        /// </summary>
        public static void Init()
        {
            if (conn == null)
            {
                conn = new SqlConnection(connStr);
                conn.Open();
            }
            else if (conn.State == ConnectionState.Closed) conn.Open();
            else if (conn.State == ConnectionState.Broken)
            {
                conn.Close();
                conn.Open();
            }

            conn = null;
            conn = new SqlConnection(connStr);
            conn.Open();

        }

        /// <summary>
        /// 增删改
        /// </summary>
        /// <param name="sql"></param>
        /// <returns>受影响行数</returns>
        public static int ExecuteNonQuery(string sql)
        {
            Init();
            int count = new SqlCommand(sql, conn).ExecuteNonQuery();
            conn.Close();
            return count;
        }

        /// <summary>
        /// 查询到DataTable
        /// </summary>
        /// <param name="sql"></param>
        /// <returns></returns>
        public static DataTable GetDataTable(string sql)
        {
            Init();
            DataTable dt = new DataTable();
            SqlDataAdapter dap = new SqlDataAdapter(sql, conn);
            dap.Fill(dt);
            conn.Close();
            return dt;
        }

        /// <summary>
        /// 查询到DataSet
        /// </summary>
        /// <param name="sql"></param>
        /// <returns></returns>
        public static DataSet GetDataSet(string sql)
        {
            Init();
            DataSet ds = new DataSet();
            SqlDataAdapter dap = new SqlDataAdapter(sql, conn);
            dap.Fill(ds);
            conn.Close();
            return ds;
        }




        public static void UpdateToDatabase(string tableName,DataTable dt) {
            SqlDataAdapter dap=new SqlDataAdapter("select * from "+tableName, conn);
            SqlCommandBuilder sqlCommandBuilder = new SqlCommandBuilder(dap);
            dap.Update(dt);
            
        }












    }
}


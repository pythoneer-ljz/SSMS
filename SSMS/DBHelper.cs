using System.Data;
using System.Data.SqlClient;

namespace SSMS
{
    /// <summary>
    /// ADO.NET 操作类
    /// </summary>
    public class DBHelper
    {
        public string connStr = "";
        public SqlConnection conn = null;

        public DBHelper()
        {
        }

        public DBHelper(string connStr)
        {
            this.connStr=connStr;
            Init();
        }

        public void Init()
        {
            // 初始化连接
            conn = new SqlConnection(connStr);
            conn.Open();
        }

        /// <summary>
        /// 增删改
        /// </summary>
        /// <param name="sql"></param>
        /// <returns>受影响行数</returns>
        public int ExecuteNonQuery(string sql)
        {
            int count = new SqlCommand(sql, conn).ExecuteNonQuery();
            return count;
        }

        /// <summary>
        /// 查询到DataTable
        /// </summary>
        /// <param name="sql"></param>
        /// <returns></returns>
        public DataTable GetDataTable(string sql)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter dap = new SqlDataAdapter(sql, conn);
            dap.Fill(dt);
            return dt;
        }

        /// <summary>
        /// 查询到DataSet
        /// </summary>
        /// <param name="sql"></param>
        /// <returns></returns>
        public DataSet GetDataSet(string sql)
        {

            DataSet ds = new DataSet();
            SqlDataAdapter dap = new SqlDataAdapter(sql, conn);
            dap.Fill(ds);
            return ds;
        }

        public int UpdateToDatabase(string tableName, DataTable dt)
        {
            SqlDataAdapter dap = new SqlDataAdapter("select * from " + tableName, conn);
            SqlCommandBuilder sqlCommandBuilder =new SqlCommandBuilder(dap);
            return dap.Update(dt);
        }




        ~DBHelper()
        {
            conn.Close();
        }







    }
}


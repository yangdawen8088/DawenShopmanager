using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basiclibrarycode.Ydw
{
    public class SqlExec
    {
        #region 数据库的执行操作：增、删、查、改
        static string ConnectionString = publicUtility.DESDecrypt(
            ConfigurationManager.AppSettings["MSQLConnectionString"],
            ConfigurationManager.AppSettings["aeskey"]);
        /// <summary>
        /// 增、删、改：执行sql数据库，传入SQL语句，返回数据库受影响行数
        /// </summary>
        /// <param name="sqlStr">SQL语句</param>
        /// <returns>数据库受影响行数，int数据类型</returns>
        public int Executiondatabase_CUD(string sqlStr)
        {
            try
            {
                int result = 0;
                SqlConnection sqlCnt = new SqlConnection(ConnectionString);
                SqlCommand sqlCmd = new SqlCommand(sqlStr, sqlCnt);
                sqlCnt.Open();
                result = sqlCmd.ExecuteNonQuery();
                sqlCnt.Close();
                return result;
            }
            catch (Exception)
            {
                return 0;
            }
        }

        public int Executiondatabase_CUD(string sql, SqlParameter[] parameters)
        {
            try
            {
                int result = 0;
                SqlConnection sqlCnt = new SqlConnection(ConnectionString);
                SqlCommand sqlCmd = new SqlCommand(sql, sqlCnt);
                sqlCmd.Parameters.AddRange(parameters);
                sqlCnt.Open();
                result = sqlCmd.ExecuteNonQuery();
                sqlCnt.Close();
                return result;
            }
            catch (Exception e)
            {
                return 0;
            }
        }

        /// <summary>
        /// 查：执行数据库调用端接口，所有查询数据库执行均往这里进入
        /// </summary>
        /// <param name="Field">查询的字段，多个字段用“,”隔开，数据表所有字段用*表示</param>
        /// <param name="BaseTable">查询的数据表名</param>
        /// <param name="Ordername">排序的字段及排序规则，只有字段名为正序排序，字段空格后加“desc”为倒序排序</param>
        /// <param name="Wheres">查询条件，用“AND() ”包起来，字段值用@加字段名表示</param>
        /// <param name="parameters">参数集合</param>
        /// <param name="count">函数输出值，表示查询的总条数</param>
        /// <returns></returns>
        public DataTable Executiondatabase_R(string Field, string BaseTable, string Ordername, string Wheres, SqlParameter[] parameters, out int count)
        {
            string sql = "";
            sql += "SELECT count(*) FROM " + BaseTable;
            sql += "; SELECT " + Field + " FROM (";
            sql += "        SELECT ROW_NUMBER() OVER(ORDER BY " + Ordername + ") AS RowId, *";
            sql += "        FROM " + BaseTable + " ) AS b WHERE 1=1 ";
            if (!Wheres.Equals(""))
            {
                sql += Wheres;
            }
            sql += " AND (b.RowId BETWEEN (@pageIndex - 1) * @pageNumber + 1 AND @pageIndex * @pageNumber ) ";
            sql += "ORDER BY " + Ordername;
            return Executiondatabase_R(sql, parameters, out count);
        }
        public DataTable Executiondatabase_R(int PageIndex, int PageSize, string Field, string BaseTable, string Ordername, string Wheres, SqlParameter[] parameters, out int count)
        {
            //string sql = "";
            //sql += "SELECT count(*) FROM " + BaseTable +" WHERE 1=1 ";
            //if (!Wheres.Equals(""))
            //{
            //    sql += Wheres;
            //}
            //sql += "; SELECT " + Field + " FROM (";
            //sql += "        SELECT ROW_NUMBER() OVER(ORDER BY " + Ordername + ") AS RowId, *";
            //sql += "        FROM " + BaseTable + " ) AS b WHERE 1=1 ";
            //if (!Wheres.Equals(""))
            //{
            //    sql += Wheres;
            //}
            //sql += "ORDER BY " + Ordername;
            //DataTable tb = Executiondatabase_R(sql, parameters, out count);
            //return GetPagedTable(tb, PageIndex, PageSize);
            string sql = "";
            sql += "SELECT count(*) FROM " + BaseTable + " WHERE 1=1 ";
            if (!Wheres.Equals(""))
            {
                sql += Wheres;
            }
            sql += ";SELECT * FROM ( SELECT ROW_NUMBER () OVER (";
            sql += "ORDER BY " + Ordername + ") AS row_number ,* ";
            sql += "FROM " + BaseTable + " WHERE 1 = 1 ";
            if (!Wheres.Equals(""))
            {
                sql += Wheres;
            }
            sql += ") AS B ";
            if (PageIndex > 0 && PageSize > 0)
            {
                sql += "WHERE B.row_number BETWEEN ((" + PageIndex + " - 1) *" + PageSize + " + 1) AND " + PageIndex + " *" + PageSize;
            }
            sql += " ORDER BY B.row_number";
            return Executiondatabase_R(sql, parameters, out count);
        }
        /// <summary>
        /// 数据库执行底层
        /// </summary>
        /// <param name="sql">SQL语句</param>
        /// <param name="parameters">参数集合</param>
        /// <param name="count">总行数</param>
        /// <returns>返回DataTable数据表</returns>
        private static DataTable Executiondatabase_R(string sql, SqlParameter[] parameters, out int count)
        {
            using (SqlDataAdapter adapter = new SqlDataAdapter(sql, ConnectionString))
            {
                adapter.SelectCommand.Parameters.AddRange(parameters);
                DataSet dataTable = new DataSet();
                adapter.Fill(dataTable);
                adapter.SelectCommand.Parameters.Clear();
                count = Convert.ToInt32(dataTable.Tables[0].Rows[0][0]);
                return dataTable.Tables[1];
            }
        }
        /// <summary>
        /// 查：执行数据库，传入SQL语句，返回数据库中的数据
        /// </summary>
        /// <param name="sqlStr">SQL语句</param>
        /// <returns>数据库中的数据,DataSet数据类型</returns>
        private DataSet Executiondatabase_R(string sqlStr)
        {
            DataSet getsettable = new DataSet();
            SqlConnection sqlCnt = new SqlConnection(ConnectionString);
            SqlCommand sqlCmd = new SqlCommand(sqlStr, sqlCnt);
            SqlDataAdapter dt = new SqlDataAdapter();
            sqlCnt.Open();
            dt.SelectCommand = sqlCmd;
            dt.Fill(getsettable, "table");
            sqlCnt.Close();
            return getsettable;
        }
        #endregion
        public DataTable GetPagedTable(DataTable dt, int PageIndex, int PageSize)//PageIndex表示第几页，PageSize表示每页的记录数
        {
            if (PageIndex == 0)
                return dt;//0页代表每页数据，直接返回

            DataTable newdt = dt.Copy();
            newdt.Clear();//copy dt的框架

            int rowbegin = (PageIndex - 1) * PageSize;
            int rowend = PageIndex * PageSize;

            if (rowbegin >= dt.Rows.Count)
                return newdt;//源数据记录数小于等于要显示的记录，直接返回dt

            if (rowend > dt.Rows.Count)
                rowend = dt.Rows.Count;
            for (int i = rowbegin; i <= rowend - 1; i++)
            {
                DataRow newdr = newdt.NewRow();
                DataRow dr = dt.Rows[i];
                foreach (DataColumn column in dt.Columns)
                {
                    newdr[column.ColumnName] = dr[column.ColumnName];
                }
                newdt.Rows.Add(newdr);
            }
            return newdt;
        }
    }
}
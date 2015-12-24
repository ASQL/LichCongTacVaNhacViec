using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.DataAccessLayer
{
    public class DataAccess
    {
        public SqlConnection conn;
        public SqlDataAdapter da;
        public SqlCommand sc;
        public DataAccess(string connPath)
        {
            if (connPath.Equals(string.Empty))
                throw new Exception("Connection String Is Empty!");
            else
                conn = new SqlConnection(connPath);
        }
        /// <summary>
        /// Truy vấn dữ liệu
        /// </summary>
        /// <param name="_query">Truy vấn/Tên thủ tục</param>
        /// <param name="sp">Bộ Tham Số Của Thủ Tục</param>
        /// <returns>Bảng dữ liệu truy vấn được</returns>
        public DataTable Query(string _query, params SqlParameter[] sp)
        {

            DataTable dt = new DataTable();
            sc = new SqlCommand(_query, conn);
            if (_query.Contains(" "))
            {
                sc.CommandType = CommandType.Text;
            }
            else
            {

                sc.CommandType = CommandType.StoredProcedure;

            }
            if (sp != null)
            {
                foreach (SqlParameter p in sp)
                    sc.Parameters.Add(p);
            }
            da = new SqlDataAdapter(sc);
            da.Fill(dt);

            return dt;
        }

        /// <summary>
        /// Thực thi phi truy vấn
        /// </summary>
        /// <param name="_nonquery">Chuỗi phi truy vấn/Tên thủ tục</param>
        /// <param name="sp">Tham số của thủ tục</param>
        public void NonQuery(string _nonquery, params SqlParameter[] sp)
        {
            conn.Open();
            sc = new SqlCommand(_nonquery, conn);
            if (_nonquery.Contains(" "))
            {
                sc.CommandType = CommandType.Text;
            }
            else
            {
                sc.CommandType = CommandType.StoredProcedure;
                if (sp.Length > 0)
                {
                    foreach (SqlParameter p in sp)
                        sc.Parameters.Add(p);
                }
            }
            sc.ExecuteNonQuery();
            conn.Close();
        }

    }
}

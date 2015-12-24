using DAL.DataAccessLayer;
using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class SubjectBUS
    {
        DataAccess data = new DataAccess(@"Data Source=DESKTOP-KO0VGBI\SQLEXPRESS;Initial Catalog=LichCongTacVaNhacViec;Integrated Security=True");

        public DataTable HienThi()
        {
            return data.Query("select * from BoMon");
        }

        public bool Add(Subject bm)
        {
            try
            {
                data.NonQuery("BoMon_Insert",
                          new SqlParameter("@MaBoMon", bm.MaBoMon),
                          new SqlParameter("@TenBoMon", bm.TenBoMon),
                          new SqlParameter("@MaTruongBoMon", bm.MaTruongBoMon),
                          new SqlParameter("@MaKhoa", bm.MaKhoa));
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        public bool Edit(Subject bm)
        {
            try
            {
                data.NonQuery("BoMon_Update",
                          new SqlParameter("@MaBoMon", bm.MaBoMon),
                          new SqlParameter("@TenBoMon", bm.TenBoMon),
                          new SqlParameter("@MaTruongBoMon", bm.MaTruongBoMon),
                          new SqlParameter("@MaKhoa", bm.MaKhoa));
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        public bool Delete(Subject bm)
        {
            try
            {
                data.NonQuery("BoMon_Delete",
                          new SqlParameter("@MaBoMon", bm.MaBoMon));
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        public string GetLastID(string NameFile, string NameTable)
        {
            string sql = "SELECT TOP 1" + NameFile + " FROM" + NameTable + " ORDER BY " + NameFile + " DESC";
            DataTable dt = data.Query(sql);
            return dt.Rows[0][NameFile].ToString();

        }
        public string get()
        {
            string sql = "SELECT TOP 1 MaBoMon FROM BoMon ORDER BY MaBoMon DESC";
            DataTable dt = data.Query(sql);
            return dt.Rows[0][0].ToString();
        }
        public DataTable GetKhoa()
        {
            string sql = "Select MaKhoa,TenKhoa from Khoa";
            return data.Query(sql);
        }
        public DataTable GetCanBo(/*string MaBoMon*/)
        {
            //string sql = "Select MaCanBo,TenCanBo from CanBo where MaBoMon in ('" + MaBoMon + "')";
            string sql = "Select MaCanBo,TenCanBo from CanBo";
            return data.Query(sql);
        }
        public DataTable GetCanBoBM(string MaBoMon)
        {
            string sql = "Select MaCanBo,TenCanBo from CanBo where MaBoMon in ('" + MaBoMon + "')";
            return data.Query(sql);
        }
    }
}

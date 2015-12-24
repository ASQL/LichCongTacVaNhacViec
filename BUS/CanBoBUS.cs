using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.DataAccessLayer;
using System.Windows;
using System.Data;
using DTO;
using System.Data.SqlClient;

namespace BUS
{
     public class CanBoBUS
    {
        DataAccess data = new DataAccess(@"Data Source=DESKTOP-KO0VGBI\SQLEXPRESS;Initial Catalog=LichCongTacVaNhacViec;Integrated Security=True");

        public DataTable HienThi()
        {
            return data.Query("select * from CanBo");
        }
        public bool Add(CanBo cb)
        {
            try
            {
                data.NonQuery("ThemCanBo",
                          new SqlParameter("@MaCanBo", cb.MaCanBo),
                          new SqlParameter("@TenCanBo", cb.TenCanBo),
                          new SqlParameter("@GioiTinh", cb.GioiTinh),
                          new SqlParameter("@NgaySinh", cb.NgaySinh),
                          new SqlParameter("@Email", cb.Email),
                          new SqlParameter("@SoDienThoai", cb.SDT),
                          new SqlParameter("@DiaChi", cb.DiaChi),
                          new SqlParameter("@MaBoMon", cb.MaBoMon),
                          new SqlParameter("@LoaiTaiKhoan", cb.LoaiTaiKhoan));
                return true;
            }
            catch(Exception ex)
            {
                return false;
            }
        }
        public bool Edit(CanBo cb)
        {
            try
            {
                data.NonQuery("CanBo_Update",
                          new SqlParameter("@MaCanBo", cb.MaCanBo),
                          new SqlParameter("@TenCanBo", cb.TenCanBo),
                          new SqlParameter("@GioiTinh", cb.GioiTinh),
                          new SqlParameter("@NgaySinh", cb.NgaySinh),
                          new SqlParameter("@Email", cb.Email),
                          new SqlParameter("@SoDienThoai", cb.SDT),
                          new SqlParameter("@DiaChi", cb.DiaChi),
                          new SqlParameter("@MaBoMon", cb.MaBoMon));
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        public bool Delete(CanBo cb)
        {
            try
            {
                data.NonQuery("CanBo_Delete",
                 new SqlParameter("@MaCanBo", cb.MaCanBo));
                return true;
            }
            catch(Exception ex)
            {
                return false;
            }
        }
        public DataTable GetMaCanBo()
        {
            string sql = "Select distinct MaCanBo,TenCanBo from CanBo";
            return data.Query(sql);
        }
        public string GetLastID(string NameFile, string NameTable)
        {
            string sql = "SELECT TOP 1" + NameFile + " FROM" + NameTable + " ORDER BY " + NameFile + " DESC";
            DataTable dt = data.Query(sql);
            return dt.Rows[0][NameFile].ToString();

        }
        public string get()
        {
            string sql = "SELECT TOP 1 MaCanBo FROM CanBo ORDER BY MaCanBo DESC";
            DataTable dt = data.Query(sql);
            return dt.Rows[0][0].ToString();
        }
        public DataTable GetBoMon()
        {
            string sql = "Select distinct MaBoMon,TenBoMon from BoMon";
            return data.Query(sql);
        }
        public DataTable GetTaiKhoan()
        {
            string sql = "Select MaTaiKhoan,TenTaiKhoan from TaiKhoan";
            return data.Query(sql);
        }
        public DataTable SearchMa(string MaCanBo)
        {
             return data.Query("CanBo_SearchMa",new SqlParameter("@MaCanBo", MaCanBo));
        }
        public DataTable SearchTen(string TenCanBo)
        {
            return data.Query("CanBo_SearchTen", new SqlParameter("@TenCanBo", TenCanBo));
        }
        public DataTable LoaiTaiKhoan()
        {
            string sql = "Select MaLoai,TenLoai from LoaiTaiKhoan";
            return data.Query(sql);
        }
        public string GetLoaiTaiKhoan(string MaTK)
        {
            string sql = "Select MaLoai from TaiKhoan where MaTaiKhoan in ('"+MaTK+"')";
            DataTable dt = data.Query(sql);
            return dt.Rows[0]["MaLoai"].ToString();
        }
        public DataTable GetTenTaiKhoan(string MaLTK)
        {
            string sql = "Select MaLoai,TenLoai from LoaiTaiKhoan where MaLoai in ('" + MaLTK + "')";
            return data.Query(sql);
        }
    }
}

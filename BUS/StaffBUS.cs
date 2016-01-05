using DAL;
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
    public class StaffBUS
    {
        private StaffDAL staffDAL;

        public StaffBUS()
        {
            staffDAL = new StaffDAL();
        }

        public Staff GetStaffByAccount(String account)
        {
            try
            {
                Staff staff = new Staff();
                DataTable dt = staffDAL.GetStaffByAccount(account);
                if (dt.Rows.Count <= 0)
                {
                    throw new Exception("Tài khoản không tồn tại!");
                }
                else
                {
                    staff.ID = dt.Rows[0][0].ToString();
                    staff.Name = dt.Rows[0][1].ToString();
                    staff.Sex = dt.Rows[0][2].ToString();
                    staff.Birthday = Convert.ToDateTime(dt.Rows[0][3].ToString());
                    staff.Email = dt.Rows[0][4].ToString();
                    staff.PhoneNumber = dt.Rows[0][5].ToString();
                    staff.Address = dt.Rows[0][6].ToString();
                    staff.Subject = dt.Rows[0][7].ToString();
                    staff.Account = dt.Rows[0][8].ToString();
                    staff.Password = dt.Rows[0][9].ToString();
                    if (dt.Rows[0][10].ToString().Equals("Admin"))
                    {
                        staff.Type = 1;
                    }
                    else
                    {
                        if (dt.Rows[0][10].ToString().Equals("Chủ nhiệm khoa"))
                        {
                            staff.Type = 2;
                        }
                        else
                        {
                            if (dt.Rows[0][10].ToString().Equals("Chủ nhiệm bộ môn"))
                            {
                                staff.Type = 3;
                            }
                            else
                            {
                                staff.Type = 4;
                            }
                        }
                    }
                    staff.Faculty = dt.Rows[0][11].ToString();
                    return staff;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool UpdatePassword(String account, String password)
        {
            return staffDAL.UpdatePassword(account, password);
        }
        public DataTable HienThi()
        {
            return DBConnection.Instance.ExecuteSelectQuery("select * from CanBo", null, CommandType.Text);
        }
        public bool Add(Staff cb,string SubjectID,string FacultyID)
        {

            try
            {

                SqlParameter[] sqlParams = new SqlParameter[]{
                          new SqlParameter("@MaCanBo", cb.ID),
                          new SqlParameter("@TenCanBo", cb.Name),
                          new SqlParameter("@GioiTinh", cb.Sex),
                          new SqlParameter("@NgaySinh", cb.Birthday),
                          new SqlParameter("@Email", cb.Email),
                          new SqlParameter("@SoDienThoai", cb.PhoneNumber),
                          new SqlParameter("@DiaChi", cb.Address),
                          new SqlParameter("@MaBoMon", SubjectID),
                          new SqlParameter("@LoaiTaiKhoan", FacultyID)};
                return DBConnection.Instance.ExecuteQuery("ThemCanBo", sqlParams, CommandType.StoredProcedure);
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        public bool Edit(Staff cb, string SubjectID, string FacultyID)
        {
            try
            {

                SqlParameter[] sqlParams = new SqlParameter[]{
                          new SqlParameter("@MaCanBo", cb.ID),
                          new SqlParameter("@TenCanBo", cb.Name),
                          new SqlParameter("@GioiTinh", cb.Sex),
                          new SqlParameter("@NgaySinh", cb.Birthday),
                          new SqlParameter("@Email", cb.Email),
                          new SqlParameter("@SoDienThoai", cb.PhoneNumber),
                          new SqlParameter("@DiaChi", cb.Address),
                          new SqlParameter("@MaBoMon", SubjectID)
            };
                return DBConnection.Instance.ExecuteQuery("Staff_Update", sqlParams, CommandType.StoredProcedure);
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        public bool Delete(Staff cb)
        {
            try
            {

                SqlParameter[] sqlParams = new SqlParameter[]{
                          new SqlParameter("@MaCanBo", cb.ID)
            };
                return DBConnection.Instance.ExecuteQuery("Staff_Delete", sqlParams, CommandType.StoredProcedure);
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        public DataTable GetMaCanBo()
        {
            string sql = "Select distinct MaCanBo,TenCanBo from CanBo";
            return DBConnection.Instance.ExecuteSelectQuery(sql, null, CommandType.Text);
        }
        public string GetLastID(string NameFile, string NameTable)
        {
            string sql = "SELECT TOP 1" + NameFile + " FROM" + NameTable + " ORDER BY " + NameFile + " DESC";
            DataTable dt = DBConnection.Instance.ExecuteSelectQuery(sql, null, CommandType.Text);
            return dt.Rows[0][NameFile].ToString();

        }
        public string get()
        {
            string sql = "SELECT TOP 1 MaCanBo FROM CanBo ORDER BY MaCanBo DESC";
            DataTable dt = DBConnection.Instance.ExecuteSelectQuery(sql, null, CommandType.Text);
            return dt.Rows[0][0].ToString();
        }
        public DataTable GetBoMon()
        {
            string sql = "Select distinct MaBoMon,TenBoMon from BoMon";
            return DBConnection.Instance.ExecuteSelectQuery(sql, null, CommandType.Text);
        }
        public DataTable GetTaiKhoan()
        {
            string sql = "Select MaTaiKhoan,TenTaiKhoan from TaiKhoan";
            return DBConnection.Instance.ExecuteSelectQuery(sql, null, CommandType.Text);
        }
        public DataTable SearchMa(string MaCanBo)
        {
            SqlParameter[] sqlParams = new SqlParameter[]{
                          new SqlParameter("@MaCanBo",MaCanBo) };
            return DBConnection.Instance.ExecuteSelectQuery("Staff_SearchMa", sqlParams, CommandType.StoredProcedure);
        }
        public DataTable SearchTen(string TenCanBo)
        {
            SqlParameter[] sqlParams = new SqlParameter[]{
                          new SqlParameter("@TenCanBo",TenCanBo) };
            return DBConnection.Instance.ExecuteSelectQuery("staff_SearchTen", sqlParams, CommandType.StoredProcedure);
        }
        public DataTable LoaiTaiKhoan()
        {
            string sql = "Select MaLoai,TenLoai from LoaiTaiKhoan";
            return DBConnection.Instance.ExecuteSelectQuery(sql, null, CommandType.Text);
        }
        public string GetLoaiTaiKhoan(string MaTK)
        {
            string sql = "Select MaLoai from TaiKhoan where MaTaiKhoan in ('" + MaTK + "')";
            DataTable dt = DBConnection.Instance.ExecuteSelectQuery(sql, null, CommandType.Text);
            return dt.Rows[0]["MaLoai"].ToString();
        }
        public DataTable GetTenTaiKhoan(string MaLTK)
        {
            string sql = "Select MaLoai,TenLoai from LoaiTaiKhoan where MaLoai in ('" + MaLTK + "')";
            return DBConnection.Instance.ExecuteSelectQuery(sql, null, CommandType.Text);
        }
    }
}

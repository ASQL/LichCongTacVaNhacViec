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
    public class FacultyBUS
    {
        private FacultyDAL facultyDAL;

        public FacultyBUS()
        {
            facultyDAL = new FacultyDAL();
        }

        public List<Faculty> GetList()
        {
            try
            {
                List<Faculty> faculties = new List<Faculty>();
                DataTable dt = facultyDAL.GetAll();
                for(int i=0;i<dt.Rows.Count;i++)
                {
                    Faculty faculty = new Faculty();
                    faculty.ID = dt.Rows[i][0].ToString();
                    faculty.Name = dt.Rows[i][1].ToString();
                    faculties.Add(faculty);
                }
                return faculties;
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
        public DataTable HienThi()
        {
            try
            {
                return facultyDAL.GetAll();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool Add(Faculty khoa,string MaTruongKhoa)
        {
            try
            {

                SqlParameter[] sqlParams = new SqlParameter[]{
                          new SqlParameter("@MaKhoa", khoa.ID),
                          new SqlParameter("@TenKhoa", khoa.Name),
                          new SqlParameter("@MaTruongKhoa", MaTruongKhoa)
                         };
                return DBConnection.Instance.ExecuteQuery("Faculty_Insert", sqlParams, CommandType.StoredProcedure);
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        public bool Edit(Faculty khoa, string MaTruongKhoa)
        {
            try
            {
                SqlParameter[] sqlParams = new SqlParameter[]{
                          new SqlParameter("@MaKhoa", khoa.ID),
                          new SqlParameter("@TenKhoa", khoa.Name),
                          new SqlParameter("@MaTruongKhoa", MaTruongKhoa)
                         };
                return DBConnection.Instance.ExecuteQuery("Faculty_Update", sqlParams, CommandType.StoredProcedure);

            }
            catch (Exception ex)
            {
                return false;
            }
        }
        public bool Delete(Faculty khoa)
        {
            try
            {
                SqlParameter[] sqlParams = new SqlParameter[]{
                            new SqlParameter("@MaKhoa", khoa.ID)
                          };
                return DBConnection.Instance.ExecuteQuery("Faculty_Delete", sqlParams, CommandType.StoredProcedure);

            }
            catch (Exception ex)
            {
                return false;
            }
        }
        public string GetLastID(string NameFile, string NameTable)
        {
            string sql = "SELECT TOP 1" + NameFile + " FROM" + NameTable + " ORDER BY " + NameFile + " DESC";
            DataTable dt = DBConnection.Instance.ExecuteSelectQuery(sql, null, CommandType.Text);
            return dt.Rows[0][NameFile].ToString();

        }
        public string get()
        {
            string sql = "SELECT TOP 1 MaKhoa FROM Khoa ORDER BY MaKhoa DESC";
            DataTable dt = DBConnection.Instance.ExecuteSelectQuery(sql, null, CommandType.Text);
            return dt.Rows[0][0].ToString();
        }
        public DataTable GetCanBo(string MaBoMon)
        {
            string sql = "Select MaCanBo,TenCanBo from CanBo where MaBoMon in ('" + MaBoMon + "')";
           
            return DBConnection.Instance.ExecuteSelectQuery(sql, null, CommandType.Text);
        }
        public string GetBM(string MaKhoa)
        {
            string sql = "Select MaBoMon from BoMon where MaKhoa in ('" + MaKhoa + "')";
            DataTable dt = DBConnection.Instance.ExecuteSelectQuery(sql, null, CommandType.Text);
            return dt.Rows[0]["MaBoMon"].ToString();
        }

        public DataTable GetTruongKhoa()
        {
            string sql = "SELECT MaCanBo, TenCanBo FROM CanBo  WHERE NOT EXISTS(SELECT MaTruongKhoa FROM Khoa where CanBo.MaCanBo = Khoa.MaTruongKhoa)";
             return DBConnection.Instance.ExecuteSelectQuery(sql, null, CommandType.Text);
        }

    }
}

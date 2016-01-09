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
    public class SubjectBUS
    {
        private SubjectDAL subjectDAL;

        public SubjectBUS()
        {
            subjectDAL = new SubjectDAL();
        }

        public DataTable HienThi()
        {
            try
            {
                return subjectDAL.GetAll();
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        public bool Add(Subject bm)
        {
            try
            {

                SqlParameter[] sqlParams = new SqlParameter[]{
                          new SqlParameter("@MaBoMon", bm.MaBoMon),
                          new SqlParameter("@TenBoMon", bm.TenBoMon),
                          new SqlParameter("@MaTruongBoMon", bm.MaTruongBoMon),
                          new SqlParameter("@MaKhoa", bm.MaKhoa)};
                return DBConnection.Instance.ExecuteQuery("BoMon_Insert", sqlParams, CommandType.StoredProcedure);
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
                SqlParameter[] sqlParams = new SqlParameter[]{
                          new SqlParameter("@MaBoMon", bm.MaBoMon),
                          new SqlParameter("@TenBoMon", bm.TenBoMon),
                          new SqlParameter("@MaTruongBoMon", bm.MaTruongBoMon),
                          new SqlParameter("@MaKhoa", bm.MaKhoa)};
                return DBConnection.Instance.ExecuteQuery("BoMon_Update", sqlParams, CommandType.StoredProcedure);
                
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
                SqlParameter[] sqlParams = new SqlParameter[]{
                          new SqlParameter("@MaBoMon", bm.MaBoMon)
                          };
                return DBConnection.Instance.ExecuteQuery("BoMon_Delete", sqlParams, CommandType.StoredProcedure);
              
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
            string sql = "SELECT TOP 1 MaBoMon FROM BoMon ORDER BY MaBoMon DESC";
            DataTable dt = DBConnection.Instance.ExecuteSelectQuery(sql, null, CommandType.Text);
            return dt.Rows[0][0].ToString();
        }
        public DataTable GetKhoa()
        {
            string sql = "Select MaKhoa,TenKhoa from Khoa";
            return DBConnection.Instance.ExecuteSelectQuery(sql, null, CommandType.Text);
        }
        public DataTable GetCanBo(/*string MaBoMon*/)
        {
            //string sql = "Select MaCanBo,TenCanBo from CanBo where MaBoMon in ('" + MaBoMon + "')";
            string sql = "Select MaCanBo,TenCanBo from CanBo";
            return DBConnection.Instance.ExecuteSelectQuery(sql, null, CommandType.Text);
        }
        public DataTable GetCanBoBM(string MaBoMon)
        {
            string sql = "Select MaCanBo,TenCanBo from CanBo where MaBoMon in ('" + MaBoMon + "')";
            DataTable dt = DBConnection.Instance.ExecuteSelectQuery(sql, null, CommandType.Text);
            return dt;
        }

        public DataTable GetSubjectByFaculty(String FacultyID)
        {
            try
            {
                return subjectDAL.GetSubjectByFaculty(FacultyID);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public DataTable GetSubjectKhoa(string tenkhoa)
        {
            string sql = "select * from BoMon,Khoa where BoMon.MaKhoa = Khoa.MaKhoa and TenKhoa like N'%" + tenkhoa + "%'";
            return DBConnection.Instance.ExecuteSelectQuery(sql, null, CommandType.Text);
        }
    }
}

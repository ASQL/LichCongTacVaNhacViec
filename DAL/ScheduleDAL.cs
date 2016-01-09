using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class ScheduleDAL
    {
        public bool AcceptWork(String staffID, String notificationID)
        {
            SqlParameter[] parameters = new SqlParameter[]{
                new SqlParameter("@MaCanBo",staffID),
                new SqlParameter("@MaThongBao",notificationID)
            };
            return DBConnection.Instance.ExecuteQuery("AcceptWork", parameters, CommandType.StoredProcedure);
        }

        public DataTable GetAll()
        {
            return DBConnection.Instance.ExecuteSelectQuery("select * from LichCongTac", null, CommandType.Text);
        }

        public bool Insert(String scheduleId, String work, String detail, String place, DateTime beginDate, DateTime endDate, String facultyId, String subjectId)
        {
            SqlParameter[] parameters = new SqlParameter[]{
                new SqlParameter("@MaLich",scheduleId),
                new SqlParameter("@TenCongViec",work),
                new SqlParameter("@MoTaCongViec",detail),
                new SqlParameter("@DiaDiem",place),
                new SqlParameter("@NgayBatDau",beginDate),
                new SqlParameter("@NgayKetThuc",endDate),
                new SqlParameter("@MaKhoa",facultyId),
                new SqlParameter("@MaBoMon",subjectId)
            };
            return DBConnection.Instance.ExecuteQuery("InsertSchedule", parameters, CommandType.StoredProcedure);
        }

        public bool Update(String scheduleId, String work, String detail, String place, DateTime beginDate, DateTime endDate, String facultyId, String subjectId)
        {
            SqlParameter[] parameters = new SqlParameter[]{
                new SqlParameter("@MaLich",scheduleId),
                new SqlParameter("@TenCongViec",work),
                new SqlParameter("@MoTaCongViec",detail),
                new SqlParameter("@DiaDiem",place),
                new SqlParameter("@NgayBatDau",beginDate),
                new SqlParameter("@NgayKetThuc",endDate),
                new SqlParameter("@MaKhoa",facultyId),
                new SqlParameter("@MaBoMon",subjectId)
            };
            return DBConnection.Instance.ExecuteQuery("UpdateSchedule", parameters, CommandType.StoredProcedure);
        }

        public bool Delete(string scheduleId)
        {
            SqlParameter[] parameters = new SqlParameter[] { 
                new SqlParameter("@MaLich",scheduleId)
            };
            return DBConnection.Instance.ExecuteQuery("DeleteSchedule", parameters, CommandType.StoredProcedure);
        }

        public DataTable findSchedulebyWork(String work)
        {
            return DBConnection.Instance.ExecuteSelectQuery("select * from LichCongTac where TenCongViec =" + work, null, CommandType.Text);
        }

        public string getLastId()
        {
            string sql = "SELECT TOP 1 MaLich FROM LichCongTac ORDER BY MaLich DESC";
            DataTable dt = DBConnection.Instance.ExecuteSelectQuery(sql, null, CommandType.Text);
            return dt.Rows[0][0].ToString();
        }

        public string getLastIdNoti()
        {
            string sql = "SELECT TOP 1 MaThongBao FROM ThongBao ORDER BY MaThongBao DESC";
            DataTable dt = DBConnection.Instance.ExecuteSelectQuery(sql, null, CommandType.Text);
            return dt.Rows[0][0].ToString();
        }

        public string getFacultyId(string staffId)
        {
            string sql = "SELECT * FROM Khoa WHERE MaTruongKhoa = '" + staffId + "'";
            DataTable dt = DBConnection.Instance.ExecuteSelectQuery(sql, null, CommandType.Text);
            if (dt.Rows.Count > 0)
            {
                return dt.Rows[0][0].ToString();
            }
            else
            {
                return "NULL";
            }
        }

        public string getSubjectId(string staffId)
        {
            string sql = "SELECT * fROM BoMon WHERE MaTruongBoMon = '" + staffId + "'";
            DataTable dt = DBConnection.Instance.ExecuteSelectQuery(sql, null, CommandType.Text);
            if (dt.Rows.Count > 0)
            {
                return dt.Rows[0][0].ToString();
            }
            else
            {
                return "NULL";
            }
        }

        public DataTable getStaffinSubject(string staffId)
        {
            string sql = "select * from CanBo where MaBoMon = '" + getSubjectId(staffId) + "'";
            DataTable dt = DBConnection.Instance.ExecuteSelectQuery(sql, null, CommandType.Text);
            return dt;
        }
        public DataTable getStaffinFaculty(string faculty)
        {
            SqlParameter[] parameters = new SqlParameter[]{
                new SqlParameter("@TenKhoa",faculty)
            };
            return DBConnection.Instance.ExecuteSelectQuery("GetStaffByFaculty", parameters, CommandType.StoredProcedure);
        }

        public bool InsertNotification(string staffId,string notiId,string scheId,DateTime sendTime,DateTime endTime,int soLan)
        {
            SqlParameter[] parameters = new SqlParameter[]{
                new SqlParameter("@MaCanBo",staffId),
                new SqlParameter("@MaThongBao",notiId),
                new SqlParameter("@MaLich",scheId),
                new SqlParameter("@ThoiGianGui",sendTime),
                new SqlParameter("@ThoiHan",endTime),
                new SqlParameter("@SoLan",soLan)
            };
            return DBConnection.Instance.ExecuteQuery("InsertNotification", parameters, CommandType.StoredProcedure);
        }
    }
}

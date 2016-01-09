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

        public bool RejectWork(String staffID, String notificationID)
        {
            SqlParameter[] parameters = new SqlParameter[]{
                new SqlParameter("@MaCanBo",staffID),
                new SqlParameter("@MaThongBao",notificationID)
            };
            return DBConnection.Instance.ExecuteQuery("RejectWork", parameters, CommandType.StoredProcedure);
        }

        public DataTable GetAll()
        {
            return DBConnection.Instance.ExecuteSelectQuery("select * from LichCongTac", null, CommandType.Text);
        }

        public bool Insert(String scheduleId, String work, String detail, String place, DateTime beginDate, DateTime endDate,String facultyId,String subjectId)
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

        public bool Update(Schedule schedule)
        {
            SqlParameter[] parameters = new SqlParameter[]{
                new SqlParameter("@MaLich",schedule.ID),
                new SqlParameter("@TenCongViec",schedule.Work),
                new SqlParameter("@MoTaCongViec",schedule.Detail),
                new SqlParameter("@DiaDiem",schedule.Place),
                new SqlParameter("@NgayBatDau",schedule.BeginDate),
                new SqlParameter("@NgayKetThuc",schedule.EndDate),
                new SqlParameter("@MaKhoa",schedule.FaccultyID),
                new SqlParameter("@MaBoMon",schedule.SubjectID)
            };
            return DBConnection.Instance.ExecuteQuery("UpdateSchedule", parameters, CommandType.StoredProcedure);
        }

        //public bool Delete()
        //{
            
        //    return DBConnection.Instance.ExecuteQuery("DeleteSchedule", parameters, CommandType.StoredProcedure);
        //}

        public DataTable findSchedulebyWork(String work)
        {
            return DBConnection.Instance.ExecuteSelectQuery("select * from LichCongTac where TenCongViec ="+ work, null, CommandType.Text);
        }

        public string getLastId()
        {
            string sql = "SELECT TOP 1 MaLich FROM LichCongTac ORDER BY MaLich DESC";
            DataTable dt = DBConnection.Instance.ExecuteSelectQuery(sql, null, CommandType.Text);
            return dt.Rows[0][0].ToString();
        }

        public string getFacultyId(string staffId)
        {
            string sql = "SELECT * FROM Khoa WHERE MaTruongKhoa = '"+staffId+"'";
            DataTable dt = DBConnection.Instance.ExecuteSelectQuery(sql, null, CommandType.Text);
            return dt.Rows[0][0].ToString();
        }

        public string getSubjectId(string staffId)
        {
            string sql = "SELECT * fROM BoMon WHERE MaTruongBoMon = '" + staffId + "'";
            DataTable dt = DBConnection.Instance.ExecuteSelectQuery(sql, null, CommandType.Text);
            return dt.Rows[0][0].ToString();
        }
    }
}

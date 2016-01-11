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
    public class NotificationDAL
    {
        public bool Insert(String staffId, String title, String detail, DateTime sendTime, DateTime deadline, int times)
        {
            SqlParameter[] parameters = new SqlParameter[]{
                new SqlParameter("@MaCanBo",staffId),
                new SqlParameter("@TieuDe",title),
                new SqlParameter("@NoiDung",detail),
                new SqlParameter("@ThoiGianGui",sendTime),
                new SqlParameter("@ThoiHan",deadline),
                new SqlParameter("@SoLan",times)
            };
            return DBConnection.Instance.ExecuteQuery("SendNotification", parameters, CommandType.StoredProcedure); 
        }

        public bool Update(Notification notification)
        {
            SqlParameter[] parameters = new SqlParameter[]{
                new SqlParameter("@MaThongBao",notification.ID),
                new SqlParameter("@ThoiGianGui",notification.ReceiveTime),
                new SqlParameter("@ThoiHan",notification.Deadline),
                new SqlParameter("@SoLan",notification.Times)
            };
            return DBConnection.Instance.ExecuteQuery("UpdateNotification",parameters,CommandType.StoredProcedure);
        }

        public bool Delete(String notificationId, String staffId)
        {
            SqlParameter[] parameters = new SqlParameter[]{
                new SqlParameter("@MaCanBo",staffId),
                new SqlParameter("@MaThongBao",notificationId)
            };
            return DBConnection.Instance.ExecuteQuery("DeleteNotification", parameters, CommandType.StoredProcedure);
        }

        public DataTable GetLastTenRowsByStaffID(String id)
        {
            SqlParameter[] parameters = new SqlParameter[]{
                new SqlParameter("@ID",id)
            };
            return DBConnection.Instance.ExecuteSelectQuery("GetLastTenRowsByStaffID", parameters, CommandType.StoredProcedure);
        }

        public DataTable GetUnrepliedNotificationByStaffId(String id)
        {
            SqlParameter[] parameters = new SqlParameter[]{
                new SqlParameter("@StaffId",id)
            };
            return DBConnection.Instance.ExecuteSelectQuery("GetUnrepliedNotificationByStaffId", parameters, CommandType.StoredProcedure);
        }

        public DataTable GetNotificationByStaffId(String id)
        {
            SqlParameter[] parameters = new SqlParameter[]{
                new SqlParameter("@MaCanBo",id)
            };
            String command = "GetNotificationByStaffID";
            return DBConnection.Instance.ExecuteSelectQuery(command, parameters, CommandType.StoredProcedure);
        }

        public bool SendResponse(String detail, DateTime sendTime, DateTime deadline, String notificationID, int times)
        {
            SqlParameter[] parameters = new SqlParameter[]{
                new SqlParameter("@NoiDung",detail),
                new SqlParameter("@ThoiGianGui",sendTime),
                new SqlParameter("@ThoiHan",deadline),
                new SqlParameter("@MaThongBao",notificationID),
                new SqlParameter("@SoLan",times)
            };
            return DBConnection.Instance.ExecuteQuery("SendResponse", parameters, CommandType.StoredProcedure);
        }

        public bool UpdateNotificationStatus(String staffID, String notificationID, int status)
        {
            SqlParameter[] parameters = new SqlParameter[]{
                new SqlParameter("@MaCanBo",staffID),
                new SqlParameter("@MaThongBao",notificationID),
                new SqlParameter("@TrangThai",status)
            };
            return DBConnection.Instance.ExecuteQuery("UpdateNotificationStatus", parameters, CommandType.StoredProcedure);
        }
    }
}

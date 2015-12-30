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
        public bool Insert()
        {
            return true;
        }

        public bool Update(Notification notification)
        {
            SqlParameter[] parameters = new SqlParameter[]{
                new SqlParameter("@MaThongBao",notification.ID),
                new SqlParameter("@ThoiGianGui",notification.ReceiveTime),
                new SqlParameter("@ThoiHan",notification.Deadline),
                new SqlParameter("@SoLan",notification.Times),
                new SqlParameter("@TrangThai",notification.Status)
            };
            return DBConnection.Instance.ExecuteQuery("UpdateNotification",parameters,CommandType.StoredProcedure);
        }

        public bool Delete(String notificationId)
        {
            return DBConnection.Instance.ExecuteQuery("delete from ThongBao where MaThongBao = '" + notificationId + "'", null, CommandType.Text);
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
                new SqlParameter("@StaffId",id)
            };
            String command = "select tb.* from ThongBao tb, NhanThongBao ntb where MaCanBo=@StaffId and ntb.MaThongBao=tb.MaThongBao";
            return DBConnection.Instance.ExecuteSelectQuery(command, parameters, CommandType.Text);
        }
    }
}

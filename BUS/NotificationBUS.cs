﻿using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class NotificationBUS
    {
        private NotificationDAL notificationDAL;

        public NotificationBUS()
        {
            notificationDAL = new NotificationDAL();
        }

        public bool Insert(String staffId, String title, String detail, DateTime sendTime, DateTime deadline, int times)
        {
            return notificationDAL.Insert(staffId, title, detail, sendTime, deadline, times);
        }

        public bool Update(Notification notification)
        {
            return notificationDAL.Update(notification);
        }

        public bool Delete(String notificationId, String staffId)
        {
            return notificationDAL.Delete(notificationId, staffId);
        }

        public List<Notification> GetLastTenRowsByStaffId(String id)
        {
            try
            {
                List<Notification> notifications = new List<Notification>();
                DataTable dt = notificationDAL.GetLastTenRowsByStaffID(id);
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    Notification notification = new Notification();
                    notification.ID = dt.Rows[i][0].ToString();
                    notification.Detail = dt.Rows[i][1].ToString();
                    notification.ReceiveTime = Convert.ToDateTime(dt.Rows[i][2].ToString());
                    notification.Deadline = Convert.ToDateTime(dt.Rows[i][3].ToString());
                    notification.Times = Convert.ToInt16(dt.Rows[i][4].ToString());
                    notification.Status = Convert.ToInt16(dt.Rows[i][6].ToString());
                    notification.Title = dt.Rows[i][5].ToString();
                    notifications.Add(notification);
                }
                return notifications;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Notification GetUnrepliedNotificationByStaffId(String id)
        {
            Notification notification = new Notification();
            DataTable dt = notificationDAL.GetUnrepliedNotificationByStaffId(id);
            if (dt.Rows.Count > 0)
            {
                notification.ID = dt.Rows[0][0].ToString();
                notification.Detail = dt.Rows[0][1].ToString();
                notification.ReceiveTime = Convert.ToDateTime(dt.Rows[0][2].ToString());
                notification.Deadline = Convert.ToDateTime(dt.Rows[0][3].ToString());
                notification.Times = Convert.ToInt16(dt.Rows[0][4].ToString());
                notification.Status = Convert.ToInt16(dt.Rows[0][6].ToString());
                notification.Title = dt.Rows[0][5].ToString();
            }
            return notification;
        }

        public DataTable GetNotificationByStaffId(String id)
        {
            return notificationDAL.GetNotificationByStaffId(id);
        }

        public bool SendResponse(String detail, DateTime sendTime, DateTime deadline, String notificationID, int times)
        {
            try
            {
                return notificationDAL.SendResponse(detail, sendTime, deadline, notificationID, times);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool UpdateNotificationStatus(String staffID, String notificationID, int status)
        {
            return notificationDAL.UpdateNotificationStatus(staffID, notificationID, status);
        }
    }
}

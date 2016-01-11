using BUS;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class DialogNotification : Form
    {
        private NotificationBUS notificationBUS;
        private ScheduleBUS scheduleBUS;

        private Notification notification;
        private Staff staff;

        public DialogNotification()
        {
            InitializeComponent();
            notification = new Notification();
            staff = new Staff();
            scheduleBUS = new ScheduleBUS();
            notificationBUS = new NotificationBUS();
        }

        public DialogNotification(Notification notification, Staff staff)
        {
            InitializeComponent();
            this.notification = notification;
            notificationBUS = new NotificationBUS();
            scheduleBUS = new ScheduleBUS();
            this.staff = staff;
        }

        private void DialogNotification_Load(object sender, EventArgs e)
        {
            lbTitle.Text = notification.Title;
            lbReceiveTime.Text = notification.ReceiveTime.ToShortDateString() + " " + notification.ReceiveTime.ToShortTimeString();
            lbDeadLine.Text = notification.Deadline.ToShortDateString() + " " + notification.Deadline.ToShortTimeString();
            rtxtbDetail.Text = notification.Detail;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            try
            {
                if (notification.Status == 1)
                {
                    notification.Status = 2;
                    notificationBUS.Update(notification);
                    notificationBUS.UpdateNotificationStatus(staff.ID, notification.ID, notification.Status);
                    String detail = "Nhân viên " + staff.Name + " nhận công việc.";
                    notificationBUS.SendResponse(detail, DateTime.Now, DateTime.Now.AddHours(3), notification.ID, 3);
                    scheduleBUS.AcceptWork(staff.ID, notification.ID);
                }
                this.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        void frmReason_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
        }
    }
}

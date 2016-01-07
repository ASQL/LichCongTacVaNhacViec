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
        private int status;

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
            switch(notification.Status)
            {
                case 1:
                    status = 1;
                    break;
                case 2:
                    status = 2;
                    break;
                default:
                    status = 2;
                    break;
            }
        }

        public DialogNotification(Notification notification, int status, Staff staff)
        {
            InitializeComponent();
            this.notification = notification;
            this.status = status;
            notificationBUS = new NotificationBUS();
            scheduleBUS = new ScheduleBUS();
            this.staff = staff;
        }

        private void DialogNotification_Load(object sender, EventArgs e)
        {
            if(status==1)
            {
                btnOk.Visible = false;
                btnAccept.Visible = true;
                btnReject.Visible = true;
            }
            else
            {
                btnOk.Visible = true;
                btnAccept.Visible = false;
                btnReject.Visible = false;
            }
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
            notification.Status = 3;
            notificationBUS.Update(notification);
            this.Close();
        }

        private void btnReject_Click(object sender, EventArgs e)
        {
            notification.Status = 3;
            notificationBUS.Update(notification);
            FrmReason frmReason = new FrmReason(staff, notification);
            frmReason.Show();
            frmReason.FormClosed += frmReason_FormClosed;
        }

        void frmReason_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            notification.Status = 3;
            notificationBUS.Update(notification);
            scheduleBUS.AcceptWork(staff.ID, notification.ID);
            this.Close();
        }
    }
}

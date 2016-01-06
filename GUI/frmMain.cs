﻿using BUS;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class FrmMain : Form
    {
        private Staff staff;
        private NotificationBUS notificationBUS;
        private int timer1;
        private Thread displayNotificationThread;
        private Thread checkNotificationThread;
        private List<Notification> notifications;

        private FrmNotificationManagement frmNotificationManagement;
        private FrmSubjectManagement frmSubjectManagement;
        private FrmStaffManagement frmStaffManagement;

        private bool checking;
        private int flag;

        public FrmMain()
        {
            InitializeComponent();
        }

        public FrmMain(Staff staff)
        {
            InitializeComponent();
            this.staff = staff;
            timer1 = 0;
            notificationBUS = new NotificationBUS();
            checking = true;
        }

        private void btnNotification_Click(object sender, EventArgs e)
        {
            if (frmNotificationManagement == null)
            {
                frmNotificationManagement = new FrmNotificationManagement(staff);
                frmNotificationManagement.MdiParent = this;
                frmNotificationManagement.Dock = DockStyle.Fill;
                frmNotificationManagement.Show();
            }
            else
            {
                frmNotificationManagement.BringToFront();
            }
            SetAllButtonToNormal();
            btnNotification.BackColor = Color.Turquoise;
        }

        private void lbStaff_Click(object sender, EventArgs e)
        {
            contextMenuStrip1.Show(pnExpandedMenu, lbStaff.Location.X, lbStaff.Location.Y + lbStaff.Size.Height);
        }

        private void tsmiSignOut_Click(object sender, EventArgs e)
        {
            displayNotificationThread.Abort();
            checkNotificationThread.Abort();
            this.Close();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            displayNotificationThread.Abort();
            checkNotificationThread.Abort();
            Application.Exit();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            lbStaff.Text = staff.Name;
            displayNotificationThread = new Thread(DisplayNotification);
            displayNotificationThread.Start();
            checkNotificationThread = new Thread(CheckNotification);
            checkNotificationThread.Start();
        }

        private void LoadList(List<Notification> notifications)
        {
            lvNotification.Items.Clear();
            for (int i = 0; i < notifications.Count; i++)
            {
                ListViewItem lvi = new ListViewItem(notifications[i].Title.ToString());
                lvi.SubItems.Add(notifications[i].Detail.ToString());
                lvNotification.Items.Add(lvi);
            }
        }

        private void DisplayNotification()
        {
            while (timer1 >= 0)
            {
                if (timer1 % 300 == 0)
                {
                    if (notifications != null)
                    {
                        notifications.RemoveRange(0, notifications.Count);
                    }
                    else
                    {
                        notifications = notificationBUS.GetLastTenRowsByStaffId(staff.ID);
                    }
                    if (notifications.Count > 0)
                    {
                        SetList(notifications);
                        if (notifications[0].Status == 1)
                        {
                            ShowNotificationDialog(notifications[0], 1);
                        }
                    }
                }
                timer1++;
                Thread.Sleep(1000);
            }
        }

        delegate void SetListCallBack(List<Notification> notifications);

        private void SetList(List<Notification> notifications)
        {
            if (lvNotification.InvokeRequired)
            {
                SetListCallBack d = new SetListCallBack(SetList);
                this.Invoke(d, new object[] { notifications });
            }
            else
            {
                LoadList(notifications);
            }
        }

        private void ShowNotificationDialog(Notification notification, int status)
        {
            DialogNotification dialog = new DialogNotification(notification, status);
            this.Invoke((MethodInvoker)delegate()
            {
                dialog.Show();
            });
        }

        private void CheckNotification()
        {
            while (checking)
            {
                DateTime today = DateTime.Today;
                Notification notification = notificationBUS.GetUnrepliedNotificationByStaffId(staff.ID);
                if (notification.ID != "")
                {
                    if (today.CompareTo(notification.Deadline) < 0)
                    {
                        if (notification.Times == 0)
                        {
                            notification.Status = 4;
                            if (staff.Type != 1 && staff.Type != 2)
                            {
                                String detail = "Cán bộ " + staff.Name + " chưa trả lời thư!";
                                DateTime deadline = DateTime.Today.AddHours(3);
                                notificationBUS.Insert(staff.ID, "Nhắc nhở", detail, DateTime.Today, deadline, 2);
                            }
                        }
                        else
                        {
                            notification.ReceiveTime = DateTime.Today;
                            notification.Deadline = notification.Deadline.AddMinutes(15);
                            notification.Times--;
                            DialogNotification dialog = new DialogNotification(notification);
                            this.Invoke((MethodInvoker)delegate()
                            {
                                dialog.Show();
                            });
                        }
                        notificationBUS.Update(notification);
                        if (notifications != null)
                        {
                            notifications.RemoveRange(0, notifications.Count);
                        }
                        else
                        {
                            notifications = notificationBUS.GetLastTenRowsByStaffId(staff.ID);
                        }
                        SetList(notifications);
                    }
                }
                Thread.Sleep(30000);
            }
        }

        private void lvNotification_DoubleClick(object sender, EventArgs e)
        {
            DialogNotification dialog = new DialogNotification(notifications[lvNotification.SelectedIndices[0]]);
            dialog.Show();
        }

        private void btnSchedule_Click(object sender, EventArgs e)
        {

        }

        private void btnStaff_Click(object sender, EventArgs e)
        {
            if (frmStaffManagement == null)
            {
                frmStaffManagement = new FrmStaffManagement(staff);
                frmStaffManagement.MdiParent = this;
                frmStaffManagement.Dock = DockStyle.Fill;
                frmStaffManagement.Show();
            }
            else
            {
                frmStaffManagement.BringToFront();
            }
            SetAllButtonToNormal();
            btnStaff.BackColor = Color.Turquoise;
        }

        private void btnSubject_Click(object sender, EventArgs e)
        {
            if (frmSubjectManagement == null)
            {
                frmSubjectManagement = new FrmSubjectManagement(staff);
                frmSubjectManagement.MdiParent = this;
                frmSubjectManagement.Dock = DockStyle.Fill;
                frmSubjectManagement.Show();
            }
            else
            {
                frmSubjectManagement.BringToFront();
            }
            SetAllButtonToNormal();
            btnSubject.BackColor = Color.Turquoise;
        }

        private void btnFaculty_Click(object sender, EventArgs e)
        {

        }

        private void SetAllButtonToNormal()
        {
            btnSchedule.BackColor = Color.Transparent;
            btnNotification.BackColor = Color.Transparent;
            btnStaff.BackColor = Color.Transparent;
            btnSubject.BackColor = Color.Transparent;
            btnFaculty.BackColor = Color.Transparent;
        }
    }
}

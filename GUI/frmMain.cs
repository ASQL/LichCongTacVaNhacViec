using BUS;
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
        private frmNotificationManagement frmNotificationManagement;
        private NotificationBUS notificationBUS;
        private int timer1;
        private int timer2;
        private Thread displayNotificationThread;
        private Thread checkNotificationThread;
        private List<Notification> notifications;
        private bool checking;

        public FrmMain()
        {
            InitializeComponent();
        }

        public FrmMain(Staff staff)
        {
            InitializeComponent();
            this.staff = staff;
            timer1 = 0;
            timer2 = 0;
            notificationBUS = new NotificationBUS();
            checking = true;
        }

        private void btnNotification_Click(object sender, EventArgs e)
        {
            if (frmNotificationManagement == null)
            {
                frmNotificationManagement = new frmNotificationManagement(staff);
            }
            frmNotificationManagement.MdiParent = this;
            frmNotificationManagement.Dock = DockStyle.Fill;
            frmNotificationManagement.Show();
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
                    }
                }
                Thread.Sleep(30000);
            }
        }
    }
}

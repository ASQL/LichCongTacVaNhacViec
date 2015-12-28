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
        private int timer;
        private Thread checkNotificationThread;

        public FrmMain()
        {
            InitializeComponent();
        }

        public FrmMain(Staff staff)
        {
            InitializeComponent();
            this.staff = staff;
            timer = 0;
            notificationBUS = new NotificationBUS();
        }

        private void btnNotification_Click(object sender, EventArgs e)
        {
            if (frmNotificationManagement == null)
            {
                frmNotificationManagement = new frmNotificationManagement();
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
            checkNotificationThread.Abort();
            this.Close();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            checkNotificationThread.Abort();
            Application.Exit();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            lbStaff.Text = staff.Name;
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

        private void CheckNotification()
        {
            while (timer >= 0)
            {
                if (timer % 300 == 0)
                {
                    List<Notification> notifications = notificationBUS.GetLastTenRowsByStaffId(staff.ID);
                    LoadList(notifications);
                    if (notifications.Count > 0)
                    {
                        if (notifications[0].Status == 1)
                        {

                        }
                    }
                }
                timer++;
                Thread.Sleep(1000);
            }
        }
    }
}

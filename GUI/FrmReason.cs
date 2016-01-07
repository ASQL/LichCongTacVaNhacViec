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
    public partial class FrmReason : Form
    {
        private Staff staff;
        private Notification notification;

        private ScheduleBUS scheduleBUS;
        private NotificationBUS notificationBUS;

        public FrmReason()
        {
            InitializeComponent();
            scheduleBUS = new ScheduleBUS();
            notificationBUS = new NotificationBUS();
        }

        public FrmReason(Staff staff, Notification notification)
        {
            InitializeComponent();
            this.staff = staff;
            this.notification = notification;
            scheduleBUS = new ScheduleBUS();
            notificationBUS = new NotificationBUS();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            scheduleBUS.RejectWork(staff.ID, notification.ID);
            this.Close();
        }
    }
}

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
        private Notification notification;
        private int status;

        public DialogNotification()
        {
            InitializeComponent();
        }

        public DialogNotification(Notification notification, int status)
        {
            InitializeComponent();
            this.notification = notification;
            this.status = status;
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
    }
}

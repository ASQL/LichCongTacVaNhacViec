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
    public partial class frmNotificationManagement : Form
    {
        private NotificationBUS notificationBUS;
        private Staff staff;
        private DataTable notificationTable;
        private DataView notificationView;

        public frmNotificationManagement()
        {
            InitializeComponent();
        }

        public frmNotificationManagement(Staff staff)
        {
            InitializeComponent();
            this.staff = staff;
            notificationBUS = new NotificationBUS();
        }

        private void searchBox_SearchClicked()
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvNotification.SelectedRows.Count > 0)
                {
                    DialogResult dr = MessageBox.Show("Bạn có chắc chắn muốn xóa không?", "Xác nhận", MessageBoxButtons.YesNo);
                    if (dr == DialogResult.Yes)
                    {

                    }
                }
                else
                {
                    throw new Exception("Bạn chưa chọn thông báo để xóa!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void frmNotificationManagement_Load(object sender, EventArgs e)
        {
            dgvNotification.AutoGenerateColumns = false;
            LoadData();
            comboBox1.SelectedIndex = 0;
        }

        private void btnRead_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvNotification.SelectedRows.Count == 1)
                {
                    DataRow row = notificationTable.Rows[dgvNotification.SelectedRows[0].Index];
                    DialogNotification dialog = new DialogNotification(GetNotification(row));
                    dialog.Show();
                }
                else
                {
                    if (dgvNotification.SelectedRows.Count > 1)
                    {
                        throw new Exception("Bạn chỉ có thể xem một thông báo một lần!");
                    }
                    else
                    {
                        throw new Exception("Bạn chưa chọn thông báo để xem!");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void LoadData()
        {
            notificationTable = notificationBUS.GetNotificationByStaffId(staff.ID);
            notificationView = new DataView(notificationTable);
            dgvNotification.DataSource = notificationView;
        }

        private Notification GetNotification(DataRow row)
        {
            Notification notification = new Notification();
            notification.ID = row[0].ToString();
            notification.Detail = row[1].ToString();
            notification.ReceiveTime = Convert.ToDateTime(row[2].ToString());
            notification.Deadline = Convert.ToDateTime(row[3].ToString());
            notification.Times = Convert.ToInt16(row[4].ToString());
            notification.Status = Convert.ToInt16(row[5].ToString());
            notification.Title = row[6].ToString();
            return notification;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbFilter.Text = comboBox1.SelectedItem.ToString();
            switch (comboBox1.SelectedIndex)
            {
                case 0:
                    txtbFilter.Visible = true;
                    dtpFilter1.Visible = false;
                    dtpFilter2.Visible = false;
                    break;
                case 1:
                    txtbFilter.Visible = false;
                    dtpFilter1.Visible = true;
                    dtpFilter2.Visible = true;
                    break;
            }
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            try
            {
                String condition = "";
                switch (comboBox1.SelectedIndex)
                {
                    case 0:
                        condition = "TieuDe like '" + txtbFilter.Text + "'";
                        break;
                    case 1:
                        condition = "ThoiGianGui <= '" + dtpFilter1.Value.ToShortDateString() + " " + dtpFilter2.Value.ToShortTimeString()+"'";
                        break;
                }
                notificationView.RowFilter = condition;
                if (notificationView.Count == 0)
                {
                    LoadData();
                    throw new Exception("Không tìm thấy!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}
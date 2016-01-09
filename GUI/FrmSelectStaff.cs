using System;
using BUS;
using DAL;
using DTO;
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
    public partial class FrmSelectStaff : Form
    {
        private Staff staff;
        private Schedule schedule;
        private int statusButton;
        private ScheduleBUS scheduleBus = new ScheduleBUS();
        private DataTable selectStaffTable;
        private DataView selectStaffView;
        public FrmSelectStaff()
        {
            InitializeComponent();
            staff = new Staff();
        }

        public FrmSelectStaff(Staff staff,Schedule schedule,int status) 

        {
            InitializeComponent();
            this.staff = staff;
            this.schedule = schedule;
            this.statusButton = status;
        }

        public FrmSelectStaff(Staff staff, Schedule schedule)
        {
            // TODO: Complete member initialization
            this.staff = staff;
            this.schedule = schedule;
        }

        private void btnSelectStaff_Click(object sender, EventArgs e)
        {
            string notiId = CodeAutomaticID.NextID(scheduleBus.getLastIdNotiBus(), "TB");
            string staffSelectId = dgvSelectStaff.CurrentRow.Cells["MaCanBo"].Value.ToString();
            scheduleBus.InsertNotification(staffSelectId, notiId, schedule.ID, DateTime.Now, DateTime.Now.AddHours(3), 2);
            if (statusButton == 1)
            {
                MessageBox.Show("Tạo lịch công việc thành công","Thông báo");
            }
            else if (statusButton == 2)
            {
                MessageBox.Show("Thay đổi thành công","Thông báo");
            }
            
            this.Close();
        }

        private void FrmSelectStaff_Load(object sender, EventArgs e)
        {
            dgvSelectStaff.AutoGenerateColumns = false;
            LoadDataStaff();
        }

        private void LoadDataStaff()
        {
            if (staff.Type == 2)
            {
                selectStaffTable = scheduleBus.getStaffInFaculty(staff.Faculty);
                selectStaffView = new DataView(selectStaffTable);
                dgvSelectStaff.DataSource = selectStaffView;
            }
            else
            {
                selectStaffTable = scheduleBus.getStaffInSubject(staff.ID);
                selectStaffView = new DataView(selectStaffTable);
                dgvSelectStaff.DataSource = selectStaffView;
            }
        }

        private void btnCancelSelect_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}

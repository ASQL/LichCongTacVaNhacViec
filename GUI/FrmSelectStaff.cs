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
        Staff staff;
        ScheduleBUS scheduleBus = new ScheduleBUS();
        DataTable selectStaffTable;
        DataView selectStaffView;
        public FrmSelectStaff()
        {
            InitializeComponent();
            staff = new Staff();
        }

        public FrmSelectStaff(Staff staff) // da dung cai nay da dung 

        {
            InitializeComponent();
            this.staff = staff;
        }

        private void btnSelectStaff_Click(object sender, EventArgs e)
        {

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

    }
}

using BUS;
using DAL;
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
    public partial class FrmScheduleManagement : Form
    {
        private FrmSelectStaff frmSelectStaff;
        private ScheduleBUS scheduleBus = new ScheduleBUS();
        private Staff staff;
        private Schedule schedule = new Schedule();
        private DataTable scheduleTable;
        private DataView scheduleView;
        private int TEMP = 0;
        private int STATUS_BUTTON = 0;
        public FrmScheduleManagement()
        {
            InitializeComponent();
            staff = new Staff();
        }

        public FrmScheduleManagement(Staff staff)
        {
            InitializeComponent();
            this.staff = staff;
        }
        private void FrmScheduleManagement_Load(object sender, EventArgs e)
        {
            dgvSche.AutoGenerateColumns = false;
            disableText();
            LoadData();
            if (this.staff.Type == 1 || this.staff.Type == 2 || this.staff.Type == 3)
            {
                btnAddSche.Enabled = true;
                btnEditSche.Enabled = true;
                btnDelSche.Enabled = true;
                btnSaveSche.Enabled = true;
            }
            else
            {
                disableButton();
            }

        }

        private void dgvSche_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtScheduleId.Enabled = false;
            txtScheduleId.Text = dgvSche.CurrentRow.Cells["MaLich"].Value.ToString();
            txtWork.Text = dgvSche.CurrentRow.Cells["TenCongViec"].Value.ToString();
            txtPlace.Text = dgvSche.CurrentRow.Cells["DiaDiem"].Value.ToString();
            rtxDetailSche.Text = dgvSche.CurrentRow.Cells["MoTaCongViec"].Value.ToString();
            dtpBeginDate.Value = Convert.ToDateTime(dgvSche.CurrentRow.Cells["NgayBatDau"].Value);
            dtpEndDate.Value = Convert.ToDateTime(dgvSche.CurrentRow.Cells["NgayKetThuc"].Value);

        }
        private void LoadData()
        {
            scheduleTable = scheduleBus.GetAllBus();
            scheduleView = new DataView(scheduleTable);
            dgvSche.DataSource = scheduleView;
        }

        private void enableText()
        {

            txtWork.Enabled = true;
            txtPlace.Enabled = true;
            rtxDetailSche.Enabled = true;
            dtpBeginDate.Enabled = true;
            dtpEndDate.Enabled = true;
        }

        private void disableText()
        {
            txtScheduleId.Enabled = false;
            txtWork.Enabled = false;
            txtPlace.Enabled = false;
            rtxDetailSche.Enabled = false;
            dtpBeginDate.Enabled = false;
            dtpEndDate.Enabled = false;
        }

        private void resetText()
        {

            txtWork.ResetText();
            txtPlace.ResetText();
            rtxDetailSche.ResetText();
            dtpBeginDate.ResetText();
            dtpEndDate.ResetText();
        }

        private void disableButton()
        {
            btnAddSche.Enabled = false;
            btnEditSche.Enabled = false;
            btnDelSche.Enabled = false;
            btnSaveSche.Enabled = false;
        }

        private void btnAddSche_Click(object sender, EventArgs e)
        {
            resetText();
            enableText();
            txtScheduleId.Text = CodeAutomaticID.NextID(scheduleBus.getLastIdBus(), "L");
            TEMP = 1;
        }

        private void btnSaveSche_Click(object sender, EventArgs e)
        {
            if (TEMP == 1)
            {
                if (this.staff.Type == 2)
                {
                    scheduleBus.InsertBus(txtScheduleId.Text, txtWork.Text, rtxDetailSche.Text, txtPlace.Text, dtpBeginDate.Value, dtpEndDate.Value, scheduleBus.getFacultyId(this.staff.ID), "NULL");
                    schedule.ID = txtScheduleId.Text.ToString();
                    schedule.Work = txtWork.Text.ToString();
                    schedule.Detail = rtxDetailSche.Text.ToString();
                    schedule.Place = txtPlace.Text.ToString();
                    schedule.BeginDate = dtpBeginDate.Value;
                    schedule.EndDate = dtpEndDate.Value;
                    STATUS_BUTTON = 1;
                    
                }
                else
                {
                    scheduleBus.InsertBus(txtScheduleId.Text, txtWork.Text, rtxDetailSche.Text, txtPlace.Text, dtpBeginDate.Value, dtpEndDate.Value, "NULL", scheduleBus.getSubjectId(this.staff.ID));
                    schedule.ID = txtScheduleId.Text.ToString();
                    schedule.Work = txtWork.Text.ToString();
                    schedule.Detail = rtxDetailSche.Text.ToString();
                    schedule.Place = txtPlace.Text.ToString();
                    schedule.BeginDate = dtpBeginDate.Value;
                    schedule.EndDate = dtpEndDate.Value;
                    STATUS_BUTTON = 1;
                }
                if (frmSelectStaff == null)
                {
                    frmSelectStaff = new FrmSelectStaff(staff, schedule,STATUS_BUTTON);
                    frmSelectStaff.Show();
                }
                LoadData();
                TEMP = 0;
            }
            else
            {
                if (this.staff.Type == 2)
                {
                    scheduleBus.UpdateBus(txtScheduleId.Text, txtWork.Text, rtxDetailSche.Text, txtPlace.Text, dtpBeginDate.Value, dtpEndDate.Value, scheduleBus.getFacultyId(this.staff.ID), "NULL");
                    schedule.ID = txtScheduleId.Text.ToString();
                    schedule.Work = txtWork.Text.ToString();
                    schedule.Detail = rtxDetailSche.Text.ToString();
                    schedule.Place = txtPlace.Text.ToString();
                    schedule.BeginDate = dtpBeginDate.Value;
                    schedule.EndDate = dtpEndDate.Value;
                    STATUS_BUTTON = 2;
                }
                else
                {
                    scheduleBus.UpdateBus(txtScheduleId.Text, txtWork.Text, rtxDetailSche.Text, txtPlace.Text, dtpBeginDate.Value, dtpEndDate.Value, "NULL", scheduleBus.getSubjectId(this.staff.ID));
                    schedule.ID = txtScheduleId.Text.ToString();
                    schedule.Work = txtWork.Text.ToString();
                    schedule.Detail = rtxDetailSche.Text.ToString();
                    schedule.Place = txtPlace.Text.ToString();
                    schedule.BeginDate = dtpBeginDate.Value;
                    schedule.EndDate = dtpEndDate.Value;
                    STATUS_BUTTON = 2;
                }
                if (frmSelectStaff == null)
                {
                    frmSelectStaff = new FrmSelectStaff(staff, schedule,STATUS_BUTTON);
                    frmSelectStaff.Show();
                }
                LoadData();
                TEMP = 0;
            }

        }

        private void btnEditSche_Click(object sender, EventArgs e)
        {
            resetText();
            enableText();
            txtScheduleId.Text = dgvSche.CurrentRow.Cells["MaLich"].Value.ToString();
            TEMP = 2;
        }

        private void btnDelSche_Click(object sender, EventArgs e)
        {
             if(MessageBox.Show("Bạn có muốn xóa "+txtWork.Text +" không ?","Hỏi",MessageBoxButtons.YesNo
                , MessageBoxIcon.Question) == DialogResult.Yes)
             {
                 string scheduleId = dgvSche.CurrentRow.Cells["MaLich"].Value.ToString();
                 scheduleBus.Delete(scheduleId);
                 MessageBox.Show("Xóa thành công", "Thông báo");
                 LoadData();
             }
        }

    }
}

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
    public partial class FrmPersonalInformation : Form
    {
        private StaffBUS staffBUS;
        private SubjectBUS subjectBUS;
        private FacultyBUS facultyBUS;

        private List<Faculty> faculties;
        private Staff staff;

        public FrmPersonalInformation()
        {
            InitializeComponent();
            staff = new Staff();
            staffBUS = new StaffBUS();
            subjectBUS = new SubjectBUS();
            facultyBUS = new FacultyBUS();

            faculties = facultyBUS.GetList();
        }

        public FrmPersonalInformation(Staff staff)
        {
            InitializeComponent();
            this.staff = staff;
            staffBUS = new StaffBUS();
            subjectBUS = new SubjectBUS();
            facultyBUS = new FacultyBUS();

            faculties = facultyBUS.GetList();
        }

        private void FrmPersonalInformation_Load(object sender, EventArgs e)
        {
            foreach (Faculty faculty in faculties)
            {
                cbxFaculty.Items.Add(faculty.Name);
            }

            DataTable subjectTable = subjectBUS.HienThi();
            for (int i = 0; i < subjectTable.Rows.Count; i++)
            {
                cbxSubject.Items.Add(subjectTable.Rows[i][1]);
            }

            LoadData();
        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            btnCancel.Visible = true;
            btnModify.Visible = false;
            txtbName.Enabled = true;
            txtbAddress.Enabled = true;
            txtbEmail.Enabled = true;
            txtbPhoneNumber.Enabled = true;
            cbxFaculty.Enabled = true;
            cbxSex.Enabled = true;
            cbxSubject.Enabled = true;
            dtpBirthday.Enabled = true;
            btnSave.Enabled = true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dr = MessageBox.Show("Bạn có chắc chắn muốn sửa?", "Cảnh báo!!!", MessageBoxButtons.YesNo);
                if (dr == DialogResult.Yes)
                {
                    staff.Name = txtbName.Text;
                    staff.Address = txtbAddress.Text;
                    staff.Sex = cbxSex.SelectedItem.ToString();
                    staff.PhoneNumber = txtbPhoneNumber.Text;
                    staff.Email = txtbEmail.Text;
                    staff.Birthday = dtpBirthday.Value;
                    staff.Subject = cbxSubject.SelectedItem.ToString();
                    staff.Faculty = cbxFaculty.SelectedItem.ToString();
                    if(staffBUS.UpdateStaffInformation(staff))
                    {
                        Reset();
                        LoadData();
                        throw new Exception("Cập nhật thành công");
                    }
                }
                Reset();
                LoadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Reset();
            LoadData();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cbxFaculty_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable subjectTable = subjectBUS.GetSubjectByFaculty(faculties[cbxFaculty.SelectedIndex].ID);
            for (int i = 0; i < subjectTable.Rows.Count; i++)
            {
                cbxSubject.Items.Add(subjectTable.Rows[i][1]);
            }
        }

        private void LoadData()
        {
            lbID.Text = staff.ID;
            txtbName.Text = staff.Name;
            txtbAddress.Text = staff.Address;
            dtpBirthday.Value = staff.Birthday;
            txtbEmail.Text = staff.Email;
            txtbPhoneNumber.Text = staff.PhoneNumber;
            cbxSex.SelectedItem = staff.Sex;
            cbxFaculty.SelectedItem = staff.Faculty;
            cbxSubject.SelectedItem = staff.Subject;
            switch (staff.Type)
            {
                case 1:
                    lbPosition.Text = "Admin";
                    break;
                case 2:
                    lbPosition.Text = "Trưởng khoa";
                    break;
                case 3:
                    lbPosition.Text = "Trưởng bộ môn";
                    break;
                case 4:
                    lbPosition.Text = "Cán bộ";
                    break;
            }
        }

        private void Reset()
        {
            txtbName.Enabled = false;
            txtbAddress.Enabled = false;
            txtbEmail.Enabled = false;
            txtbPhoneNumber.Enabled = false;
            cbxFaculty.Enabled = false;
            cbxSex.Enabled = false;
            cbxSubject.Enabled = false;
            dtpBirthday.Enabled = false;
            btnSave.Enabled = false;
            btnModify.Visible = true;
            btnCancel.Visible = false;
        }
    }
}

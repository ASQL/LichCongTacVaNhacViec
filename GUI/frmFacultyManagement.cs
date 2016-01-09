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
    public partial class frmFacultyManagement : Form
    {
        private FacultyBUS controllerKhoa = new FacultyBUS();
        private Staff staff;
        public frmFacultyManagement()
        {
            InitializeComponent();
        }

        public frmFacultyManagement(Staff staff)
        {
            InitializeComponent();
            this.staff = staff;
        }
     
        private void frmFacultyManagement_Load(object sender, EventArgs e)
        {
            // Phân quyen

            if(staff.Type==1)
            {
                btnThem.Enabled = true;
                btnSua.Enabled = true;
                btnXoa.Enabled = true;
                btnLuu.Enabled = true;
            }
            else
            {
                btnThem.Enabled = false;
                btnSua.Enabled = false;
                btnXoa.Enabled = false;
                btnLuu.Enabled = false;
            }
            cboMaTruongKhoa.DataSource = controllerKhoa.GetTruongKhoa();
            cboMaTruongKhoa.DisplayMember = "TenCanBo";
            cboMaTruongKhoa.ValueMember = "MaCanBo";
            dtgr.DataSource = controllerKhoa.HienThi();
        }


        private void btnThem_Click(object sender, EventArgs e)
        {
            txtMaKhoa.Enabled = false;
            txtMaKhoa.Text = CodeAutomaticID.NextID(controllerKhoa.get(), "K");

            // Khoa
            btnThem.Enabled = false;

        }
        private bool Kiemtra()
        {
            if (txtMaKhoa.Text.Equals(""))
            {
                MessageBox.Show("Mã Khoa còn trống");
                return false;
            }
            if (txtKhoa.Text.Equals(""))
            {
                MessageBox.Show("Tên Khoa còn trống");
                return false;
            }
            return true;
        }
        public Faculty faculty()
        {
            Faculty khoa = new Faculty();
            khoa.ID = txtMaKhoa.Text;
            khoa.Name = txtKhoa.Text;
            return khoa;
        }
        private void Reset()
        {
            txtMaKhoa.ResetText();
            txtKhoa.ResetText();
        }
        private void btnLuu_Click(object sender, EventArgs e)
        {
            Faculty khoa = faculty();
            if (Kiemtra())
            {
                string MaTruongKhoa = string.IsNullOrEmpty(cboMaTruongKhoa.Text) ? " " : cboMaTruongKhoa.SelectedValue.ToString();
                bool addKhoa = controllerKhoa.Add(khoa, MaTruongKhoa);
                if (addKhoa)
                {
                    MessageBox.Show("Thêm mới thành công !", "Thông báo");
                }
                else
                {
                    MessageBox.Show("Thêm mới không thành công !", "Thông báo");
                }
            }
            dtgr.DataSource = controllerKhoa.HienThi();
            Reset();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            Faculty khoa = faculty();
            if (Kiemtra())
            {
                string MaTruongKhoa = cboMaTruongKhoa.SelectedValue.ToString();
                bool editKhoa = controllerKhoa.Edit(khoa, MaTruongKhoa);
                if (editKhoa)
                {
                    MessageBox.Show("Cập nhật thành công !", "Thông báo");
                }
                else
                {
                    MessageBox.Show("Cập nhật không thành công !", "Thông báo");
                }
            }
            dtgr.DataSource = controllerKhoa.HienThi();
            Reset();
        }

        private void dtgr_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMaKhoa.Text = dtgr.CurrentRow.Cells["MaKhoa"].Value.ToString();
            txtKhoa.Text = dtgr.CurrentRow.Cells["TenKhoa"].Value.ToString();
            string makhoa = txtMaKhoa.Text;
            string mabomon = controllerKhoa.GetBM(makhoa);
            DataTable dt = controllerKhoa.GetCanBo(mabomon);
            if(dt.Rows.Count>0)
            {
                cboMaTruongKhoa.DataSource =controllerKhoa.GetCanBo(mabomon);
                cboMaTruongKhoa.DisplayMember = "TenCanBo";
                cboMaTruongKhoa.ValueMember = "MaCanBo";
                cboMaTruongKhoa.SelectedValue = dtgr.CurrentRow.Cells["MaTruongKhoa"].Value.ToString();
                btnSua.Enabled = true;
            }
            else
            {
                cboMaTruongKhoa.SelectedValue = "";
            }

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn xóa khôa: " + txtKhoa.Text + " không ?", "Hỏi", MessageBoxButtons.YesNo
                , MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Faculty khoa = faculty();
                if (Kiemtra())
                {
                    bool deleteKhoa = controllerKhoa.Delete(khoa);
                    if (deleteKhoa)
                    {
                        MessageBox.Show("Xóa bản ghi thành công !", "Thông báo");
                    }
                    else
                    {
                        MessageBox.Show("Xóa không thành công !", "Thông báo");
                    }
                }
                dtgr.DataSource = controllerKhoa.HienThi();
                Reset();
            }
        }
    }
}

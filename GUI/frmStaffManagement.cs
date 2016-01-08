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
    public partial class FrmStaffManagement : Form
    {
        private StaffBUS controllerCB = new StaffBUS();
        private Staff staff;

        public FrmStaffManagement()
        {
            InitializeComponent();
            staff = new Staff();
        }

        public FrmStaffManagement(Staff staff)
        {

            InitializeComponent();
            this.staff = staff;
        }

        private void frmStaffManagent_Load(object sender, EventArgs e)
        {


            // chia quyen 
            if(staff.Type==1 || staff.Type==2 || staff.Type==3)
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

            cboBoMon.DataSource = controllerCB.GetBoMon();
            cboBoMon.DisplayMember = "TenBoMon";
            cboBoMon.ValueMember = "MaBoMon";

            cboLTaiKhoan.DataSource = controllerCB.LoaiTaiKhoan();
            cboLTaiKhoan.DisplayMember = "TenLoai";
            cboLTaiKhoan.ValueMember = "MaLoai";
            //
            cboGioiTinh.SelectedValue = "Nam";

            // Hiển thị
            dtgr.DataSource = controllerCB.HienThi();
        }

        private void Reset()
        {
            txtMaCanBo.ResetText();
            txtTenCanBo.ResetText();
            txtEmail.ResetText();
            txtSDT.ResetText();
            txtdiachi.ResetText();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            txtMaCanBo.Enabled = false;
            cboLTaiKhoan.Enabled = true;
            txtMaCanBo.Text = CodeAutomaticID.NextID(controllerCB.get(), "CB");
            cboLTaiKhoan.DataSource = controllerCB.LoaiTaiKhoan();
            cboLTaiKhoan.DisplayMember = "TenLoai";
            cboLTaiKhoan.ValueMember = "MaLoai";
        }

        private Staff StaffCB()
        {
            Staff cb = new Staff();
            cb.ID = txtMaCanBo.Text;
            cb.Name = txtTenCanBo.Text;
            cb.Sex = cboGioiTinh.Text;
            cb.Birthday = dtpNgaySinh.Value;
            cb.Email = txtEmail.Text;
            cb.PhoneNumber = txtSDT.Text;
            cb.Address = txtdiachi.Text;
            return cb;

        }

        private bool KiemTra(Staff cb)
        {
            if(txtMaCanBo.Text.Equals(""))
            {
                MessageBox.Show("Mã cán bộ không được để trống !", "Thông Báo");
                return false;
            }
            if (txtTenCanBo.Text.Equals(""))
            {
                MessageBox.Show("Tên cán bộ không được để trống !", "Thông Báo");
                return false;
            }
            if (txtEmail.Text.Equals(""))
            {
                MessageBox.Show("Email không được để trống !", "Thông Báo");
                return false;
            }
            if (txtSDT.Text.Equals(""))
            {
                MessageBox.Show("Số điện thoại không được để trống !", "Thông Báo");
                return false;
            }
            return true;
        }
        
        private void btnLuu_Click(object sender, EventArgs e)
        {
            Staff cb = StaffCB();
            string SubjectID = cboBoMon.SelectedValue.ToString();
            string FacultyID = cboLTaiKhoan.SelectedValue.ToString();
            if (KiemTra(cb))
            {

                bool addcanbo = controllerCB.Add(cb,SubjectID,FacultyID);
                if (addcanbo)
                {
                    MessageBox.Show("Thêm mới thành công !", "Thông báo");
                }
                else
                {
                    MessageBox.Show("Thêm mới không thành công !", "Thông báo");
                }
            }
            dtgr.DataSource = controllerCB.HienThi();
            Reset();
        }

        private void dtgr_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMaCanBo.Enabled = false;
            txtMaCanBo.Text= dtgr.CurrentRow.Cells["MaCanBo"].Value.ToString();
            txtTenCanBo.Text = dtgr.CurrentRow.Cells["TenCanBo"].Value.ToString();
            cboGioiTinh.Text = dtgr.CurrentRow.Cells["GioiTinh"].Value.ToString();
            dtpNgaySinh.Text= dtgr.CurrentRow.Cells["NgaySinh"].Value.ToString();
            txtEmail.Text= dtgr.CurrentRow.Cells["Email"].Value.ToString();
            txtSDT.Text= dtgr.CurrentRow.Cells["SoDienThoai"].Value.ToString();
            txtdiachi.Text= dtgr.CurrentRow.Cells["DiaChi"].Value.ToString();
            cboBoMon.SelectedValue= dtgr.CurrentRow.Cells["MaBoMon"].Value.ToString();
            cboLTaiKhoan.Enabled = false;
            string matk = dtgr.CurrentRow.Cells["MaTaiKhoan"].Value.ToString();
            string maloaitk = controllerCB.GetLoaiTaiKhoan(matk);
            cboLTaiKhoan.DataSource = controllerCB.GetTenTaiKhoan(maloaitk);
            cboLTaiKhoan.DisplayMember = "TenLoai";
            cboLTaiKhoan.ValueMember = "MaLoai";

            //cboLTaiKhoan.SelectedValue= dtgr.CurrentRow.Cells["MaTaiKhoan"].Value.ToString();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            
            Staff cb = StaffCB();
            string SubjectID = cboBoMon.SelectedValue.ToString();
            string FacultyID = cboLTaiKhoan.SelectedValue.ToString();
            if (KiemTra(cb))
            {
                bool editcanbo = controllerCB.Edit(cb,SubjectID,FacultyID);
                if (editcanbo)
                {
                    MessageBox.Show("Sửa thành công !", "Thông báo");
                }
                else
                {
                    MessageBox.Show("Sửa không thành công !", "Thông báo");
                }
            }
            dtgr.DataSource = controllerCB.HienThi();
            Reset();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Bạn có muốn xóa cán bộ: " +txtTenCanBo.Text +" không ?","Hỏi",MessageBoxButtons.YesNo
                ,MessageBoxIcon.Question)==DialogResult.Yes)
            {
                Staff cb = StaffCB();
                if (KiemTra(cb))
                {
                    bool deletecb = controllerCB.Delete(cb);
                    if (deletecb)
                    {
                        MessageBox.Show("Xóa bản ghi thành công !", "Thông báo");
                    }
                    else
                    {
                        MessageBox.Show("Xóa không thành công !", "Thông báo");
                    }
                }
                dtgr.DataSource = controllerCB.HienThi();
                Reset();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(txtTimKiemMa.Text!="")
            {
                DataTable dt = controllerCB.SearchMa(txtTimKiemMa.Text);
               if (dt.Rows.Count>0)
                {
                    dtgr.DataSource = controllerCB.SearchMa(txtTimKiemMa.Text);
                }
               else
                {
                    MessageBox.Show("Không tìm thấy cán bộ có mã " +txtTimKiemMa.Text+".", "Thông báo");
                }
            }
        }

        private void btnTimKiemTen_Click(object sender, EventArgs e)
        {
            if (txtTimKiemTen.Text.Trim() != "")
            {
                DataTable dt = controllerCB.SearchTen(txtTimKiemTen.Text.Trim());
                if (dt.Rows.Count > 0)
                {
                    dtgr.DataSource = dt;
                }
                else
                {
                    MessageBox.Show("Không tìm thấy cán bộ có tên là : " + txtTimKiemTen.Text + ".", "Thông báo");
                }
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát chương trình", "Hỏi", MessageBoxButtons.YesNo
             , MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}

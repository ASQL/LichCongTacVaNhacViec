﻿using BUS;
using DAL.Common;
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
    public partial class frmSubject : Form
    {
        public frmSubject()
        {
            InitializeComponent();
        }
        SubjectBUS controllerBM = new SubjectBUS();
        private void frmSubject_Load(object sender, EventArgs e)
        {

            cboMaKhoa.DataSource = controllerBM.GetKhoa();
            cboMaKhoa.DisplayMember = "TenKhoa";
            cboMaKhoa.ValueMember = "MaKhoa";

            // Hiển thị cán bộ thuộc bộ môn
            cboTruongBoMon.DataSource = controllerBM.GetCanBo();
            cboTruongBoMon.DisplayMember = "TenCanBo";
            cboTruongBoMon.ValueMember = "MaCanBo";
        

            dtgr.DataSource = controllerBM.HienThi();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            txtMaBoMon.Enabled = false;
            txtMaBoMon.Text = CodeAutomaticID.NextID(controllerBM.get(), "BM");
        }

        private void dtgr_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMaBoMon.Text= dtgr.CurrentRow.Cells["MaBoMon"].Value.ToString();
            string mabomon = txtMaBoMon.Text;
            cboTruongBoMon.DataSource = controllerBM.GetCanBoBM(mabomon);
            cboTruongBoMon.DisplayMember = "TenCanBo";
            cboTruongBoMon.ValueMember = "MaCanBo";
            txtTenBoMon.Text= dtgr.CurrentRow.Cells["TenBoMon"].Value.ToString();
            cboTruongBoMon.SelectedValue= dtgr.CurrentRow.Cells["MaTruongBoMon"].Value.ToString();
            cboMaKhoa.SelectedValue= dtgr.CurrentRow.Cells["MaKhoa"].Value.ToString();

        }
        private Subject BoMon()
        {
            Subject bm = new Subject();
            bm.MaBoMon = txtMaBoMon.Text;
            bm.TenBoMon = txtTenBoMon.Text;
            bm.MaTruongBoMon = cboTruongBoMon.SelectedValue.ToString();
            bm.MaKhoa = cboMaKhoa.SelectedValue.ToString();
            return bm;
        }
        private bool Kiemtra()
        {
            if(txtMaBoMon.Text.Equals(""))
            {
                MessageBox.Show("Mã bộ môn còn trống");
                return false;
            }
            if(txtTenBoMon.Text.Equals(""))
            {
                MessageBox.Show("Tên bộ môn còn trống");
                return false;
            }
            return true;
        }
        private void Reset()
        {
            txtMaBoMon.ResetText();
            txtTenBoMon.ResetText();
        }
        private void btnLuu_Click(object sender, EventArgs e)
        {
            Subject bm = BoMon();
            if (Kiemtra())
            {
                bool addbomon = controllerBM.Add(bm);
                if (addbomon)
                {
                    MessageBox.Show("Thêm mới thành công !", "Thông báo");
                }
                else
                {
                    MessageBox.Show("Thêm mới không thành công !", "Thông báo");
                }
            }
            dtgr.DataSource = controllerBM.HienThi();
            Reset();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            Subject bm = BoMon();
            if (Kiemtra())
            {
                bool editbomon = controllerBM.Edit(bm);
                if (editbomon)
                {
                    MessageBox.Show("Sửa thành công !", "Thông báo");
                }
                else
                {
                    MessageBox.Show("Sửa không thành công !", "Thông báo");
                }
            }
            dtgr.DataSource = controllerBM.HienThi();
            Reset();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn xóa cán bộ: " + txtMaBoMon.Text + " không ?", "Hỏi", MessageBoxButtons.YesNo
                , MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Subject bm = BoMon();
                if (Kiemtra())
                {
                    bool deletebm = controllerBM.Delete(bm);
                    if (deletebm)
                    {
                        MessageBox.Show("Xóa bản ghi thành công !", "Thông báo");
                    }
                    else
                    {
                        MessageBox.Show("Xóa không thành công !", "Thông báo");
                    }
                }
                dtgr.DataSource = controllerBM.HienThi();
                Reset();
            }
        }
    }
}

﻿using BUS;
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
    public partial class FrmChangePassword : Form
    {
        private StaffBUS staffBUS;
        private Staff staff;

        public FrmChangePassword()
        {
            InitializeComponent();
            staff = new Staff();
            staffBUS = new StaffBUS();
        }

        public FrmChangePassword(Staff staff)
        {
            InitializeComponent();
            this.staff = staff;
            staffBUS = new StaffBUS();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            try
            {
                if (staffBUS.UpdatePassword(staff.Account, txtbNewPass.Text))
                {
                    DialogResult dialogResult = MessageBox.Show("Đổi mật khẩu thành công!");
                    if (dialogResult == DialogResult.OK)
                    {
                        FrmMain.flag = 1;
                        this.Close();
                    }
                }
                else
                {
                    throw new Exception("Đổi mật khẩu thất bại!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            FrmMain.flag = 0;
            this.Close();
        }

        private void txtbOldPass_Leave(object sender, EventArgs e)
        {
            if (txtbOldPass.Text.Equals(staff.Password))
            {
                lbError2.Visible = false;
            }
            else
            {
                lbError2.Visible = true;
            }
        }

        private void txtbConfirmPass_Leave(object sender, EventArgs e)
        {
            if (txtbConfirmPass.Text.Equals(txtbNewPass.Text))
            {
                lbError2.Visible = false;
            }
            else
            {
                lbError2.Visible = true;
            }
        }
    }
}

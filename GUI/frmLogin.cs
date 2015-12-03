﻿using BUS;
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
    public partial class frmLogin : Form
    {
        private StaffBUS staffBUS;

        public frmLogin()
        {
            InitializeComponent();
            DBConnection.Instance.OpenConnection();
            staffBUS = new StaffBUS();
            
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                if(txtbAccName.Text=="")
                {
                    throw new Exception("Bạn chưa nhập tên tài khoản!");
                }
                else
                {
                    if(txtbPassword.Text=="")
                    {
                        throw new Exception("Bạn chưa nhập mật khẩu!");
                    }
                    else
                    {
                        Staff staff = staffBUS.getStaffByAccount(txtbAccName.Text);
                        if (staff.Password.Equals(txtbPassword.Text))
                        {
                            if (staff.Password.Equals(staff.Account))
                            {
                                frmChangePassword frmChangePassword = new frmChangePassword(staff);
                                frmChangePassword.Show();
                                this.Visible = false;
                                frmChangePassword.FormClosed += frmChangePassword_FormClosed;
                            }
                            else
                            {

                            }
                        }
                        else
                        {
                            throw new Exception("Mật khẩu không đúng!");
                        }
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        void frmChangePassword_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Visible = true;
            Reset();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }

        private void Reset()
        {
            txtbAccName.Text = "";
            txtbPassword.Text = "";
            txtbAccName.Focus();
        }
    }
}
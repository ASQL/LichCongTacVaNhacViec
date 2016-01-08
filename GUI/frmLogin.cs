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
    public partial class FrmLogin : Form
    {
        private StaffBUS staffBUS;
        private bool firstPress1, firstPress2;

        public FrmLogin()
        {
            InitializeComponent();
            staffBUS = new StaffBUS();
            firstPress1 = true;
            firstPress2 = true;
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
                        Staff staff = staffBUS.GetStaffByAccount(txtbAccName.Text);
                        if (staff.Password.Equals(txtbPassword.Text))
                        {
                            if (staff.Password.Equals(staff.Account))
                            {
                                FrmChangePassword frmChangePassword = new FrmChangePassword(staff);
                                frmChangePassword.Show();
                                this.Enabled = false;
                                frmChangePassword.FormClosed += frmChangePassword_FormClosed;
                            }
                            else
                            {
                                FrmMain frmMain = new FrmMain(staff);
                                frmMain.Show();
                                this.Visible = false;
                                frmMain.FormClosed += frmMain_FormClosed;
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

        void frmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Visible = true;
            Reset();
        }

        void frmChangePassword_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Enabled = true;
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

        private void txtbAccName_MouseDown(object sender, MouseEventArgs e)
        {
            txtbAccName.ForeColor = Color.Black;
            txtbAccName.Text = "";
            firstPress1 = false;
        }

        private void txtbPassword_MouseDown(object sender, MouseEventArgs e)
        {
            txtbPassword.ForeColor = Color.Black;
            txtbPassword.PasswordChar = '*';
            txtbPassword.Text = "";
            firstPress2 = false;
        }

        private void txtbAccName_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (firstPress1)
                {
                    txtbAccName.ForeColor = Color.Black;
                    txtbAccName.Text = "";
                    firstPress1 = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtbPassword_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (firstPress2)
                {
                    txtbPassword.ForeColor = Color.Black;
                    txtbPassword.UseSystemPasswordChar = true;
                    txtbPassword.Text = "";
                    firstPress2 = false;
                }
                if (e.KeyCode == Keys.Enter)
                {
                    Staff staff = staffBUS.GetStaffByAccount(txtbAccName.Text);
                    if (staff.Password.Equals(txtbPassword.Text))
                    {
                        if (staff.Password.Equals(staff.Account))
                        {
                            FrmChangePassword frmChangePassword = new FrmChangePassword(staff);
                            frmChangePassword.Show();
                            this.Enabled = false;
                            frmChangePassword.FormClosed += frmChangePassword_FormClosed;
                        }
                        else
                        {
                            FrmMain frmMain = new FrmMain(staff);
                            frmMain.Show();
                            this.Visible = false;
                            frmMain.FormClosed += frmMain_FormClosed;
                        }
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}

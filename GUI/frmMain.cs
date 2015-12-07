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
using CustomControl;

namespace GUI
{
    public partial class frmMain : Form
    {
        private Staff staff;

        public frmMain()
        {
            InitializeComponent();
            staff = new Staff();
        }

        public frmMain(Staff staff)
        {
            InitializeComponent();
            this.staff = staff;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void expandedMenu_Click(object sender, EventArgs e)
        {
            contextMenuStrip1.Show(pnExpandedMenu, lbStaff.Location.X,lbStaff.Location.Y+lbStaff.Size.Height);
        }

        private void tsmiSignOut_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            lbStaff.Text = staff.Name;
            
        }
    }
}

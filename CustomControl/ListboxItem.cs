using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CustomControl
{
    public partial class ListboxItem: UserControl
    {
        private Boolean isRead;

        public Boolean IsRead
        {
            get 
            { 
                return isRead; 
            }
            set 
            { 
                isRead = value; 
                if(isRead)
                {
                    lbTitle.Font = new Font(lbTitle.Font, FontStyle.Regular);
                }
                else
                {
                    lbTitle.Font = new Font(lbTitle.Font, FontStyle.Bold);
                }
                Invalidate();
            }
        }
        

        public ListboxItem()
        {
            InitializeComponent();
        }

        public String Title
        {
            get
            {
                return lbTitle.Text;
            }
            set
            {
                lbTitle.Text = value;
                Invalidate();
            }
        }

        public String Time
        {
            get
            {
                return lbTime.Text;
            }
            set
            {
                lbTime.Text = value;
                Invalidate();
            }
        }

        public String Detail
        {
            get
            {
                return lbDetail.Text;
            }
            set
            {
                lbDetail.Text = value;
                Invalidate();
            }
        }
    }
}

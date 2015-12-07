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
        }
    }
}

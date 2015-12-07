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
    public partial class SearchBox : UserControl
    {
        private Boolean searchByDate;

        public SearchBox()
        {
            InitializeComponent();
        }

        public Boolean SearchByDate
        {
            get { return searchByDate; }
            set 
            { 
                searchByDate = value; 
                if(searchByDate)
                {
                    txtbFilter.Visible = false;
                    dtpFilter.Visible = true;
                }
                else
                {
                    txtbFilter.Visible = true;
                    dtpFilter.Visible = false;
                }
                Invalidate();
            }
        }
        
        public DateTime DateFilter
        {
            get
            {
                return dtpFilter.Value;
            }
        }

        private void cbxFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbFilter.Text = cbxFilter.SelectedItem.ToString();
        }

        public String TextFilter
        {
            get
            {
                return txtbFilter.Text;
            }
        }

        [Description("The items in combo box"),
        DesignerSerializationVisibility(DesignerSerializationVisibility.Content),
        Editor("System.Windows.Forms.Design.StringCollectionEditor, System.Design", typeof(System.Drawing.Design.UITypeEditor))]
        public ComboBox.ObjectCollection Items
        {
            get
            {
                return cbxFilter.Items;
            }
        }

        public delegate void SearchClickedHandler();

        [Category("Action")]
        [Description("Fires when the Search button is clicked.")]
        public event SearchClickedHandler SearchClicked;

        protected virtual void OnSearchClicked()
        {
            if (SearchClicked != null)
            {
                SearchClicked();
            }
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            if(txtbFilter.Text=="")
            {
                MessageBox.Show("Hãy nhập thông tin bạn muốn tìm!");
                txtbFilter.Focus();
            }
            else
            {
                OnSearchClicked();
            }
        }
    }
}

using System;
using System.Windows.Forms;

namespace Purchase_Order
{
    public partial class Index_Form : Form
    {
        public Index_Form()
        {
            InitializeComponent();
        }

        private void btncustomerform_Click(object sender, EventArgs e)
        {
            Customers_Form form1 = new Customers_Form();
            form1.Show();
        }

        private void btnvendorform_Click(object sender, EventArgs e)
        {
            Vendor_Form form3 = new Vendor_Form();
            form3.Show();
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnitemform_Click(object sender, EventArgs e)
        {
            Items_Form form5 = new Items_Form();
            form5.Show();
        }

        private void btnorderform_Click(object sender, EventArgs e)
        {
            Place_Odrer_Form form6 = new Place_Odrer_Form();
            form6.Show();
        }

        private void btnitemsform_Click(object sender, EventArgs e)
        {
            Units_Form form7 = new Units_Form();
            form7.Show();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}

using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Purchase_Order
{
    public partial class Vendor_Form : Form
    {
        public Vendor_Form()
        {
            InitializeComponent();
        }

        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-5C566RK\SQLEXPRESS;Initial Catalog=Purchase_Order;Integrated Security=True");
        public int VendorID;

        private void Form3_Load(object sender, EventArgs e)
        {
            getvendorrecord();
        }

        public void getvendorrecord()
        {

            SqlCommand cmd = new SqlCommand("select * from Vendor", conn);
            DataTable dt = new DataTable();

            conn.Open();

            SqlDataReader sdr = cmd.ExecuteReader();
            dt.Load(sdr);
            conn.Close();

            vendorgridview.DataSource = dt;

        }

        private void btninsertven_Click(object sender, EventArgs e)
        {
            if (IsValid())
            {
                SqlCommand cmd = new SqlCommand("insert into Vendor values (@Vendor_Name, @Vendor_Address, @Vendor_City, @Vendor_Email, @Vendor_Tele_No, @Vendor_Fax_No)", conn);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@Vendor_Name", txtvendorname.Text);
                cmd.Parameters.AddWithValue("@Vendor_Address", txtvendoraddress.Text);
                cmd.Parameters.AddWithValue("@Vendor_City", txtvendorcity.Text);
                cmd.Parameters.AddWithValue("@Vendor_Email", txtvendoremail.Text);
                cmd.Parameters.AddWithValue("@Vendor_Tele_No", txtvendormobile.Text);
                cmd.Parameters.AddWithValue("@Vendor_Fax_No", txtvendorfax.Text);

                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();

                MessageBox.Show("New Vendor Added Successfully ", "Added", MessageBoxButtons.OK, MessageBoxIcon.Information);

                getvendorrecord();
                ResetForm();

            }
        }

        private bool IsValid()
        {
            if (txtvendorname.Text == string.Empty)
            {
                MessageBox.Show("Vendor Name Required ", "Failed ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        private void ResetForm()
        {
            VendorID = 0;
            txtvendorname.Clear();
            txtvendoraddress.Clear();
            txtvendorcity.Clear();
            txtvendoremail.Clear();
            txtvendorfax.Clear();
            txtvendormobile.Clear();

            txtvendorname.Focus();
        }

        private void vendorgridview_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            VendorID = Convert.ToInt32(vendorgridview.SelectedRows[0].Cells[0].Value);
            txtvendorname.Text = vendorgridview.SelectedRows[0].Cells[1].Value.ToString();
            txtvendoraddress.Text = vendorgridview.SelectedRows[0].Cells[2].Value.ToString();
            txtvendorcity.Text = vendorgridview.SelectedRows[0].Cells[3].Value.ToString();
            txtvendoremail.Text = vendorgridview.SelectedRows[0].Cells[4].Value.ToString();
            txtvendormobile.Text = vendorgridview.SelectedRows[0].Cells[5].Value.ToString();
            txtvendorfax.Text = vendorgridview.SelectedRows[0].Cells[6].Value.ToString();
        }

        private void btnupdateven_Click(object sender, EventArgs e)
        {
            if (VendorID > 0)
            {
                SqlCommand cmd = new SqlCommand("update Vendor set Vendor_Name = @Vendor_Name,Vendor_Address = @Vendor_Address,Vendor_City = @Vendor_City,Vendor_Email = @Vendor_Email,Vendor_Tel_No = @Vendor_Tel_No,Vendor_Fax = @Vendor_Fax where Vendor_ID = @Vendor_ID", conn);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@Vendor_Name", txtvendorname.Text);
                cmd.Parameters.AddWithValue("@Vendor_Address", txtvendoraddress.Text);
                cmd.Parameters.AddWithValue("@Vendor_City", txtvendorcity.Text);
                cmd.Parameters.AddWithValue("@Vendor_Email", txtvendoremail.Text);
                cmd.Parameters.AddWithValue("@Vendor_Tel_No", txtvendormobile.Text);
                cmd.Parameters.AddWithValue("@Vendor_Fax", txtvendorfax.Text);
                cmd.Parameters.AddWithValue("@Vendor_ID", this.VendorID);

                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();

                MessageBox.Show("Vendor Details Updated Successfully ", "Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);

                getvendorrecord();
                ResetForm();
            }
            else
            {
                MessageBox.Show("Please Select An Vendor To Update ", "Select?", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void btndeleteven_Click(object sender, EventArgs e)
        {
            if (VendorID > 0)
            {
                SqlCommand cmd = new SqlCommand("delete from Vendor where Vendor_ID = @Vendor_ID", conn);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@Vendor_ID", this.VendorID);

                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();

                MessageBox.Show("Vendor Details Deleted Successfully ", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);

                getvendorrecord();
                ResetForm();
            }
            else
            {
                MessageBox.Show("Please Select An Vendor To Delete ", "Select?", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnresetven_Click(object sender, EventArgs e)
        {
            ResetForm();
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Purchase_Order
{
    public partial class Customers_Form : Form
    {
        public Customers_Form()
        {
            InitializeComponent();
        }

        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-5C566RK\SQLEXPRESS;Initial Catalog=Purchase_Order;Integrated Security=True");
        public int CustomerID;

        private void Form1_Load(object sender, EventArgs e)
        {
            getcustomerrecord();
        }

        public void getcustomerrecord()
        {
            
            SqlCommand cmd = new SqlCommand("select * from Customer", conn);
            DataTable dt = new DataTable();

            conn.Open();

            SqlDataReader sdr = cmd.ExecuteReader();
            dt.Load(sdr);
            conn.Close();

            customergridview.DataSource = dt;

        }

        private void btninsert_Click(object sender, EventArgs e)
        {
            if(IsValid())
            {
                SqlCommand cmd = new SqlCommand("insert into Customer values (@Customer_Name, @Customer_Address, @Customer_City, @Customer_Email, @Customer_Tele_No, @Customer_Fax_No, @Customer_Website, @Customer_PostBox)", conn);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@Customer_Name", txtcstomername.Text);
                cmd.Parameters.AddWithValue("@Customer_Address", txtcustomeraddress.Text);
                cmd.Parameters.AddWithValue("@Customer_City", txtcustomercity.Text);
                cmd.Parameters.AddWithValue("@Customer_Email", txtcustomeremail.Text);
                cmd.Parameters.AddWithValue("@Customer_Tele_No", txtcustomermobile.Text);
                cmd.Parameters.AddWithValue("@Customer_Fax_No", txtcustomerfax.Text);
                cmd.Parameters.AddWithValue("@Customer_Website", txtcustomerwebsite.Text);
                cmd.Parameters.AddWithValue("@Customer_PostBox", txtcustomerpost.Text);

                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();

                MessageBox.Show("New Customer Added Successfully ", "Added",MessageBoxButtons.OK, MessageBoxIcon.Information);

                getcustomerrecord();
                ResetForm();

            }
        }

        private bool IsValid()
        {
            if(txtcstomername.Text == string.Empty)
            {
                MessageBox.Show("Customer Name Required ", "Failed ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        private void btnreset_Click(object sender, EventArgs e)
        {
            ResetForm();
        }

        private void ResetForm()
        {
            CustomerID = 0;
            txtcstomername.Clear();
            txtcustomeraddress.Clear();
            txtcustomercity.Clear();
            txtcustomeremail.Clear();
            txtcustomerfax.Clear();
            txtcustomermobile.Clear();
            txtcustomerpost.Clear();
            txtcustomerwebsite.Clear();

            txtcstomername.Focus();
        }

        private void customergridview_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            CustomerID = Convert.ToInt32(customergridview.SelectedRows[0].Cells[0].Value);
            txtcstomername.Text = customergridview.SelectedRows[0].Cells[1].Value.ToString();
            txtcustomeraddress.Text = customergridview.SelectedRows[0].Cells[2].Value.ToString();
            txtcustomercity.Text = customergridview.SelectedRows[0].Cells[3].Value.ToString();
            txtcustomeremail.Text = customergridview.SelectedRows[0].Cells[4].Value.ToString();
            txtcustomermobile.Text = customergridview.SelectedRows[0].Cells[5].Value.ToString();
            txtcustomerfax.Text = customergridview.SelectedRows[0].Cells[6].Value.ToString();
            txtcustomerwebsite.Text = customergridview.SelectedRows[0].Cells[7].Value.ToString();
            txtcustomerpost.Text = customergridview.SelectedRows[0].Cells[8].Value.ToString();
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            if(CustomerID > 0)
            {
                SqlCommand cmd = new SqlCommand("update Customer set Customer_Name = @Customer_Name,Customer_Address = @Customer_Address,Customer_City = @Customer_City,Customer_Email = @Customer_Email,Customer_Tele_No = @Customer_Tele_No,Customer_Fax_No = @Customer_Fax_No,Customer_Website = @Customer_Website,Customer_PostBox = @Customer_PostBox where Customer_ID = @Customer_ID", conn);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@Customer_Name", txtcstomername.Text);
                cmd.Parameters.AddWithValue("@Customer_Address", txtcustomeraddress.Text);
                cmd.Parameters.AddWithValue("@Customer_City", txtcustomercity.Text);
                cmd.Parameters.AddWithValue("@Customer_Email", txtcustomeremail.Text);
                cmd.Parameters.AddWithValue("@Customer_Tele_No", txtcustomermobile.Text);
                cmd.Parameters.AddWithValue("@Customer_Fax_No", txtcustomerfax.Text);
                cmd.Parameters.AddWithValue("@Customer_Website", txtcustomerwebsite.Text);
                cmd.Parameters.AddWithValue("@Customer_PostBox", txtcustomerpost.Text);
                cmd.Parameters.AddWithValue("@Customer_ID", this.CustomerID);

                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();

                MessageBox.Show("Customer Details Updated Successfully ", "Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);

                getcustomerrecord();
                ResetForm();
            }
            else
            {
                MessageBox.Show("Please Select An Customer To Update ", "Select?", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            if (CustomerID > 0)
            {
                SqlCommand cmd = new SqlCommand("delete from Customer where Customer_ID = @Customer_ID", conn);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@Customer_ID", this.CustomerID);

                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();

                MessageBox.Show("Customer Details Deleted Successfully ", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);

                getcustomerrecord();
                ResetForm();
            }
            else
            {
                MessageBox.Show("Please Select An Customer To Delete ", "Select?", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            Close();
        }

        
    }
}

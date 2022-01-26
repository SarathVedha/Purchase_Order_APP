using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Purchase_Order
{
    public partial class Units_Form : Form
    {
        public Units_Form()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-5C566RK\SQLEXPRESS;Initial Catalog=Purchase_Order;Integrated Security=True");
        public int unitsID;

        private void Form7_Load(object sender, EventArgs e)
        {
            getunitsrecord();
        }

        public void getunitsrecord()
        {
            SqlCommand cmd = new SqlCommand("select * from Units", conn);
            DataTable dt = new DataTable();
            conn.Open();
            SqlDataReader sdr = cmd.ExecuteReader();
            dt.Load(sdr);
            conn.Close();
            unitsgridview.DataSource = dt;
        }

        private void btninsert_Click(object sender, EventArgs e)
        {
            if (IsValid())
            {
                SqlCommand cmd = new SqlCommand("insert into Units values (@Unit_Name)", conn);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@Unit_Name", txtunitsname.Text);

                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();

                MessageBox.Show("New Units Added Successfully ", "Added", MessageBoxButtons.OK, MessageBoxIcon.Information);

                getunitsrecord();
                ResetForm();

            }
        }
        private bool IsValid()
        {
            if (txtunitsname.Text == string.Empty)
            {
                MessageBox.Show("Units Name Required ", "Failed ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        private void ResetForm()
        {
            unitsID = 0;
            txtunitsname.Clear();
            
            txtunitsname.Focus();
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            if (unitsID > 0)
            {
                SqlCommand cmd = new SqlCommand("update Units set Unit_Name = @Unit_Name where Units_ID = @Units_ID", conn);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@Unit_Name", txtunitsname.Text);
                cmd.Parameters.AddWithValue("@Units_ID", this.unitsID);

                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();

                MessageBox.Show("Units Details Updated Successfully ", "Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);

                getunitsrecord();
                ResetForm();
            }
            else
            {
                MessageBox.Show("Please Select An Units To Update ", "Select?", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            if (unitsID > 0)
            {
                SqlCommand cmd = new SqlCommand("delete from Units where Units_ID = @Units_ID", conn);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@Units_ID", this.unitsID);

                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();

                MessageBox.Show("Units Details Deleted Successfully ", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);

                getunitsrecord();
                ResetForm();
            }
            else
            {
                MessageBox.Show("Please Select An Units To Delete ", "Select?", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnreset_Click(object sender, EventArgs e)
        {
            ResetForm();
        }

        private void unitsgridview_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            unitsID = Convert.ToInt32(unitsgridview.SelectedRows[0].Cells[0].Value);
            txtunitsname.Text = unitsgridview.SelectedRows[0].Cells[1].Value.ToString();
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

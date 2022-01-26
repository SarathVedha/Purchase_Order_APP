using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Purchase_Order
{
    public partial class Items_Form : Form
    {
        public Items_Form()
        {
            InitializeComponent();
            
        }
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-5C566RK\SQLEXPRESS;Initial Catalog=Purchase_Order;Integrated Security=True");
        public int ItemsID;
        public string unitname;
        public string unitid;

        private void Form5_Load(object sender, EventArgs e)
        {
            getitemsrecord();
            conn.Open();
            SqlCommand cmd = new SqlCommand("select * from Units",conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            cmd.ExecuteNonQuery();
            conn.Close();

            cmbunitname.DataSource = ds.Tables[0];
            cmbunitname.DisplayMember = "Unit_Name";
            cmbunitname.ValueMember = "Units_ID";

        }

        public void getitemsrecord ()
        {
            SqlCommand cmd = new SqlCommand("select Items_ID,Items_Name,Items_Stock_QTY,Item_Price from Items ", conn);
            DataTable dt = new DataTable();
            conn.Open();
            SqlDataReader sdr = cmd.ExecuteReader();
            dt.Load(sdr);
            conn.Close();
            itemsgridview.DataSource = dt;
        }

        private void btninsert_Click(object sender, EventArgs e)
        {
            if (IsValid())
            {
                getunitid();
                SqlCommand cmd = new SqlCommand("insert into Items values (@Items_Name, @Items_Units,@Item_Price,@Units_ID)", conn);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@Items_Name", txtitemsname.Text);
                cmd.Parameters.AddWithValue("@Items_Units", txtitemstock.Text);
                cmd.Parameters.AddWithValue("@Item_Price", txtitemprice.Text);
                cmd.Parameters.AddWithValue("@Units_ID", this.unitid);

                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();


                MessageBox.Show("Items Added Successfully ", "Added", MessageBoxButtons.OK, MessageBoxIcon.Information);
                getitemsrecord();
                ResetForm();

            }
        }
        private void getunitid ()
        {
            unitname = cmbunitname.Text;
            SqlCommand cmd = new SqlCommand("select Units_ID from Units where Unit_Name=@Units_Name", conn);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@Units_Name", this.unitname);

            conn.Open();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            conn.Close();
            unitid = dt.Rows[0][0].ToString();
        }

        private void ResetForm()
        {
            ItemsID = 0;
            txtitemsname.Clear();
            txtitemstock.Clear();
            txtitemprice.Clear();

            txtitemsname.Focus();
        }

        private bool IsValid()
        {
            if (txtitemsname.Text == string.Empty)
            {
                MessageBox.Show("Items Name Required ", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            if (ItemsID > 0)
            {
                getunitid();
                SqlCommand cmd = new SqlCommand("update Items set Items_Name = @Items_Name, Items_Units = @Items_Units, Item_Price = @Item_Price,Units_ID =@Units_ID   where Items_ID = @Items_ID ", conn);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@Items_Name", txtitemsname.Text);
                cmd.Parameters.AddWithValue("@Items_Units", txtitemstock.Text);
                cmd.Parameters.AddWithValue("@Item_Price", txtitemprice.Text);
                cmd.Parameters.AddWithValue("@Units_ID", this.unitid);
                cmd.Parameters.AddWithValue("@Items_ID", this.ItemsID);

                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();

                MessageBox.Show("Items Updated Successfully", "Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
                getitemsrecord();
                ResetForm();
            }
            else
            {
                MessageBox.Show("Please Select An Items To Update ", "Select?", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void itemsgridview_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            ItemsID = Convert.ToInt32(itemsgridview.SelectedRows[0].Cells[0].Value);
            txtitemsname.Text = itemsgridview.SelectedRows[0].Cells[1].Value.ToString();
            txtitemstock.Text = itemsgridview.SelectedRows[0].Cells[2].Value.ToString();
            txtitemprice.Text = itemsgridview.SelectedRows[0].Cells[3].Value.ToString();


        }

        private void btnreset_Click(object sender, EventArgs e)
        {
            ResetForm();
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            if (ItemsID > 0)
            {
                SqlCommand cmd = new SqlCommand("delete from Items where Items_ID = @Items_ID", conn);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@Items_ID", this.ItemsID);

                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();

                MessageBox.Show("Items Deleted Successfully ", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                getitemsrecord();
                ResetForm();
                
            }
            else
            {
                MessageBox.Show("Please Select An Items To Delete ", "Select?", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }
    }
}

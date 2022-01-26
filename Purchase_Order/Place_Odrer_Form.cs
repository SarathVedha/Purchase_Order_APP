using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Purchase_Order
{
    public partial class Place_Odrer_Form : Form
    {
        public Place_Odrer_Form()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-5C566RK\SQLEXPRESS;Initial Catalog=Purchase_Order;Integrated Security=True");
        public string customername;
        public string customerid;
        public string unitname;
        public string unitid;
        public string itemname;
        public string itemid;
        public string itemprice;
        public string itemqty;
        public float totalprice;
        public string totalprice2;
        public string itemstockqty;
        public int totalstockqty;
        public string customeradd;
        public string FOC = "0";
        public string discount = "0";
        public int rowcount;
        public string itemname2;
        public string date;
        public string orderid;
        public float sumprice = 0;




        private void btplaceorder_Click(object sender, EventArgs e)
        {
            if (IsValid())
            {
                customername = cbcutomerid.Text;
                getitemid();
                getitemprice();
                getitemstockqty();
                getcustomerid();
                getcustomeradd();

                itemname = cbitemname.Text;
                unitname = cbunitsname.Text;
                itemqty = txtorderqty.Text;

                SqlCommand cmd3 = new SqlCommand("insert into Cart values (@Customer_ID, @Items_Name, @Items_Units, @Buyed_Qty, @Price, @Total_Price, @Delivery_To, @Order_Date)", conn);
                cmd3.CommandType = CommandType.Text;
                cmd3.Parameters.AddWithValue("@Delivery_To", this.customeradd);
                cmd3.Parameters.AddWithValue("@Customer_ID", this.customerid);
                cmd3.Parameters.AddWithValue("@Order_Date", orderdate.Value);
                cmd3.Parameters.AddWithValue("@Price", this.itemprice);
                cmd3.Parameters.AddWithValue("@Total_Price", this.totalprice);
                cmd3.Parameters.AddWithValue("@Items_Name", this.itemname);
                cmd3.Parameters.AddWithValue("@Items_Units", this.unitname);
                cmd3.Parameters.AddWithValue("@Buyed_Qty", this.itemqty);

                conn.Open();
                cmd3.ExecuteNonQuery();
                conn.Close();


                MessageBox.Show("Added To Cart Successfully ", "Added", MessageBoxButtons.OK, MessageBoxIcon.Information);
                getorderrecord();


            }

        }

        private void getcustomeradd()
        {
            customername = cbcutomerid.Text;
            SqlCommand cmd = new SqlCommand("select Customer_Address from Customer where Customer_Name=@Customer_Name", conn);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@Customer_Name", this.customername);

            conn.Open();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            conn.Close();
            customeradd = dt.Rows[0][0].ToString();
        }

        private bool IsValid()
        {
            if (txtorderqty.Text == string.Empty)
            {
                MessageBox.Show("Items Qty Required ", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        private void getcustomerid ()
        {
            customername = cbcutomerid.Text;
            SqlCommand cmd = new SqlCommand("select Customer_ID from Customer where Customer_Name=@Customer_Name", conn);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@Customer_Name", this.customername);

            conn.Open();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            conn.Close();
            customerid = dt.Rows[0][0].ToString();
        }


        private void getitemid()
        {
            itemname = cbitemname.Text;
            SqlCommand cmd = new SqlCommand("select Items_ID from Items where Items_Name=@Items_Name", conn);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@Items_Name", this.itemname);

            conn.Open();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            conn.Close();
            itemid = dt.Rows[0][0].ToString();
        }

        private void getitemid2(string itemname2)
        {
            
            SqlCommand cmd = new SqlCommand("select Items_ID from Items where Items_Name=@Items_Name", conn);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@Items_Name", itemname2);

            conn.Open();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            conn.Close();
            itemid = dt.Rows[0][0].ToString();
        }
        private void getitemprice()
        {
            itemname = cbitemname.Text;
            SqlCommand cmd = new SqlCommand("select Item_Price from Items where Items_Name=@Items_Name", conn);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@Items_Name", this.itemname);

            conn.Open();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            conn.Close();
            itemprice = dt.Rows[0][0].ToString();

            itemqty = txtorderqty.Text;
            totalprice = float.Parse(itemqty) * float.Parse(itemprice);


        }

        private void getitemstockqty()
        {
            itemname = cbitemname.Text;
            SqlCommand cmd = new SqlCommand("select Items_Stock_QTY from Items where Items_Name=@Items_Name", conn);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@Items_Name", this.itemname);

            conn.Open();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            conn.Close();
            itemstockqty = dt.Rows[0][0].ToString();

            itemqty = txtorderqty.Text;
            totalstockqty = Convert.ToInt32(itemstockqty) - Convert.ToInt32(itemqty);

            SqlCommand cmd2 = new SqlCommand("update Items set Items_Stock_QTY=@Items_Stock_QTY where Items_Name= @Items_Name ", conn);
            cmd2.CommandType = CommandType.Text;
            cmd2.Parameters.AddWithValue("@Items_Name", this.itemname);
            cmd2.Parameters.AddWithValue("@Items_Stock_QTY", this.totalstockqty);


            conn.Open();
            cmd2.ExecuteNonQuery();
            conn.Close();

        }


        public void getorderrecord()
        {
            SqlCommand cmd = new SqlCommand("select Items_Name, Items_Units, Buyed_Qty, Price, Total_Price, Delivery_To, Order_Date from Cart ", conn);
            DataTable dt = new DataTable();
            conn.Open();
            SqlDataReader sdr = cmd.ExecuteReader();
            dt.Load(sdr);
            conn.Close();
            ordergridview.DataSource = dt;
        }

        private void odergridview_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Place_Odrer_Form_Load(object sender, EventArgs e)
        {
            getorderrecord();
            conn.Open();
            SqlCommand cmd = new SqlCommand("select * from Customer", conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            cmd.ExecuteNonQuery();
            conn.Close();

            cbcutomerid.DataSource = ds.Tables[0];
            cbcutomerid.DisplayMember = "Customer_Name";
            cbcutomerid.ValueMember = "Customer_ID";

            conn.Open();
            SqlCommand cmd2 = new SqlCommand("select * from Items", conn);
            SqlDataAdapter da2 = new SqlDataAdapter(cmd2);
            DataSet ds2 = new DataSet();
            da2.Fill(ds2);
            cmd2.ExecuteNonQuery();
            conn.Close();

            cbitemname.DataSource = ds2.Tables[0];
            cbitemname.DisplayMember = "Items_Name";
            cbitemname.ValueMember = "Items_ID";

            
        }

        
        private void cbitemname_Click(object sender, EventArgs e)
        {
            itemname = cbitemname.Text;
            SqlCommand cmd4 = new SqlCommand("select Items_Stock_QTY from Items where Items_Name=@Items_Name", conn);
            cmd4.CommandType = CommandType.Text;
            cmd4.Parameters.AddWithValue("@Items_Name", this.itemname);

            conn.Open();
            SqlDataAdapter sda4 = new SqlDataAdapter(cmd4);
            DataTable dt4 = new DataTable();
            sda4.Fill(dt4);
            conn.Close();
            itemstockqty = dt4.Rows[0][0].ToString();

            stocklabel.Text = itemstockqty;

            itemname = cbitemname.Text;
            SqlCommand cmd = new SqlCommand("select Item_Price from Items where Items_Name=@Items_Name", conn);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@Items_Name", this.itemname);

            conn.Open();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            conn.Close();
            itemprice = dt.Rows[0][0].ToString();

            pricelabel.Text = itemprice;

        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void cbunitsname_Click(object sender, EventArgs e)
        {
            itemname = cbitemname.Text;
            SqlCommand cmd2 = new SqlCommand("select Units_ID from Items where Items_Name=@Items_Name", conn);
            cmd2.CommandType = CommandType.Text;
            cmd2.Parameters.AddWithValue("@Items_Name", this.itemname);

            conn.Open();
            SqlDataAdapter sda2 = new SqlDataAdapter(cmd2);
            DataTable dt2 = new DataTable();
            sda2.Fill(dt2);
            conn.Close();
            itemid = dt2.Rows[0][0].ToString();


            conn.Open();
            SqlCommand cmd5 = new SqlCommand("select * from Units where Units_ID =@Units_ID", conn);
            cmd5.CommandType = CommandType.Text;
            cmd5.Parameters.AddWithValue("@Units_ID", this.itemid);
            SqlDataAdapter da5 = new SqlDataAdapter(cmd5);
            DataSet ds5 = new DataSet();
            da5.Fill(ds5);
            cmd5.ExecuteNonQuery();
            conn.Close();

            cbunitsname.DataSource = ds5.Tables[0];
            cbunitsname.DisplayMember = "Unit_Name";
            cbunitsname.ValueMember = "Units_ID";
        }

        private void label10_Click(object sender, EventArgs e)
        {
            getitemprice();
            totalpricelabel.Text = totalprice.ToString();
        }

        public void getorderid(string customerid2)
        {
            SqlCommand cmd = new SqlCommand("select Order_ID from Order_Table where Customer_ID=@Customer_ID", conn);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@Customer_ID", customerid2);

            conn.Open();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            conn.Close();
            orderid = dt.Rows[0][0].ToString();
        }
        private void btorder_Click(object sender, EventArgs e)
        {

            if (IsValid())
            {
                rowcount = ordergridview.RowCount;
                if (rowcount == 1)
                {
                    MessageBox.Show("Add Items To Cart ", "Add", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    SqlCommand cmd = new SqlCommand("insert into Order_Table values (@Customer_ID, @OrderDate, @Delivery_To, @Net_Total)", conn);
                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.AddWithValue("@Delivery_To", this.customeradd);
                    cmd.Parameters.AddWithValue("@Customer_ID", this.customerid);
                    cmd.Parameters.AddWithValue("@OrderDate", orderdate.Value);
                    cmd.Parameters.AddWithValue("@Net_Total", "0");
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();

                    rowcount = ordergridview.RowCount-1;



                    for (int i = 0; i<rowcount; i++)
                    {
                        itemname2 = ordergridview.Rows[i].Cells[0].Value.ToString();
                        itemqty = ordergridview.Rows[i].Cells[2].Value.ToString();
                        itemprice = ordergridview.Rows[i].Cells[3].Value.ToString();
                        totalprice2 = ordergridview.Rows[i].Cells[4].Value.ToString();
                        customeradd = ordergridview.Rows[i].Cells[5].Value.ToString();
                        date = ordergridview.Rows[i].Cells[6].Value.ToString();
                        getcustomerid();
                        getorderid(customerid);
                        getitemid2(itemname2);

                        SqlCommand cmd3 = new SqlCommand("insert into Order_Details values (@Order_ID, @Item_ID, @Qty, @FOC, @Price, @Discount, @Vat, @Total, @Delivery_Date)", conn);
                        cmd3.CommandType = CommandType.Text;
                        cmd3.Parameters.AddWithValue("@Order_ID", this.orderid);
                        cmd3.Parameters.AddWithValue("@Qty", this.itemqty);
                        cmd3.Parameters.AddWithValue("@FOC", this.FOC);
                        cmd3.Parameters.AddWithValue("@Price", this.itemprice);
                        cmd3.Parameters.AddWithValue("@Discount", this.discount);
                        cmd3.Parameters.AddWithValue("@Item_ID", this.itemid);
                        cmd3.Parameters.AddWithValue("@Vat", this.discount);
                        cmd3.Parameters.AddWithValue("@Delivery_Date", orderdate.Value);
                        cmd3.Parameters.AddWithValue("@Total", this.totalprice2);
                        sumprice = sumprice + float.Parse(totalprice2);
                        conn.Open();
                        cmd3.ExecuteNonQuery();
                        conn.Close();
                    }

                    
                    getorderid(customerid);

                    SqlCommand cmd4 = new SqlCommand("update Order_Table set Net_Total = @Net_Total where Order_ID = @Order_ID", conn);
                    cmd4.CommandType = CommandType.Text;
                    cmd4.Parameters.AddWithValue("@Order_ID", this.orderid);
                    cmd4.Parameters.AddWithValue("@Net_Total", this.sumprice);

                    conn.Open();
                    cmd4.ExecuteNonQuery();
                    conn.Close();

                    SqlCommand cmd2 = new SqlCommand("truncate table Cart", conn);
                    conn.Open();
                    cmd2.ExecuteNonQuery();
                    conn.Close();
                    getorderrecord();


                    MessageBox.Show("Order Placed SuccessFully", "Placed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
        }

        
    }
}

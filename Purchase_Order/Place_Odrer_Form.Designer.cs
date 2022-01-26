
namespace Purchase_Order
{
    partial class Place_Odrer_Form
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.cbcutomerid = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cbitemname = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbunitsname = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtorderqty = new System.Windows.Forms.TextBox();
            this.ordergridview = new System.Windows.Forms.DataGridView();
            this.btplaceorder = new System.Windows.Forms.Button();
            this.stocklabel = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.pricelabel = new System.Windows.Forms.Label();
            this.btnclose = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.orderdate = new System.Windows.Forms.DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.totalpricelabel = new System.Windows.Forms.Label();
            this.cartbtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ordergridview)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Place Order";
            // 
            // cbcutomerid
            // 
            this.cbcutomerid.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbcutomerid.FormattingEnabled = true;
            this.cbcutomerid.Location = new System.Drawing.Point(140, 49);
            this.cbcutomerid.Name = "cbcutomerid";
            this.cbcutomerid.Size = new System.Drawing.Size(186, 21);
            this.cbcutomerid.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(12, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 23);
            this.label2.TabIndex = 0;
            this.label2.Text = "Customer Name";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.Location = new System.Drawing.Point(12, 102);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 23);
            this.label4.TabIndex = 0;
            this.label4.Text = "Items Name";
            // 
            // cbitemname
            // 
            this.cbitemname.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbitemname.FormattingEnabled = true;
            this.cbitemname.Location = new System.Drawing.Point(140, 102);
            this.cbitemname.Name = "cbitemname";
            this.cbitemname.Size = new System.Drawing.Size(186, 21);
            this.cbitemname.TabIndex = 1;
            this.cbitemname.Click += new System.EventHandler(this.cbitemname_Click);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(12, 157);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 23);
            this.label3.TabIndex = 0;
            this.label3.Text = "Items Units";
            // 
            // cbunitsname
            // 
            this.cbunitsname.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbunitsname.FormattingEnabled = true;
            this.cbunitsname.Location = new System.Drawing.Point(140, 156);
            this.cbunitsname.Name = "cbunitsname";
            this.cbunitsname.Size = new System.Drawing.Size(186, 21);
            this.cbunitsname.TabIndex = 1;
            this.cbunitsname.Click += new System.EventHandler(this.cbunitsname_Click);
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label5.Location = new System.Drawing.Point(437, 51);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 23);
            this.label5.TabIndex = 0;
            this.label5.Text = "Items Qty";
            // 
            // txtorderqty
            // 
            this.txtorderqty.Location = new System.Drawing.Point(536, 50);
            this.txtorderqty.Multiline = true;
            this.txtorderqty.Name = "txtorderqty";
            this.txtorderqty.Size = new System.Drawing.Size(194, 24);
            this.txtorderqty.TabIndex = 2;
            // 
            // ordergridview
            // 
            this.ordergridview.BackgroundColor = System.Drawing.Color.White;
            this.ordergridview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ordergridview.Location = new System.Drawing.Point(12, 273);
            this.ordergridview.Name = "ordergridview";
            this.ordergridview.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ordergridview.Size = new System.Drawing.Size(747, 238);
            this.ordergridview.TabIndex = 4;
            this.ordergridview.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.odergridview_CellClick);
            // 
            // btplaceorder
            // 
            this.btplaceorder.BackColor = System.Drawing.Color.Purple;
            this.btplaceorder.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btplaceorder.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btplaceorder.Location = new System.Drawing.Point(647, 157);
            this.btplaceorder.Name = "btplaceorder";
            this.btplaceorder.Size = new System.Drawing.Size(89, 31);
            this.btplaceorder.TabIndex = 5;
            this.btplaceorder.Text = "Order";
            this.btplaceorder.UseVisualStyleBackColor = false;
            this.btplaceorder.Click += new System.EventHandler(this.btorder_Click);
            // 
            // stocklabel
            // 
            this.stocklabel.AutoSize = true;
            this.stocklabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stocklabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.stocklabel.Location = new System.Drawing.Point(197, 126);
            this.stocklabel.Name = "stocklabel";
            this.stocklabel.Size = new System.Drawing.Size(12, 15);
            this.stocklabel.TabIndex = 6;
            this.stocklabel.Text = "-";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label6.Location = new System.Drawing.Point(137, 126);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 15);
            this.label6.TabIndex = 7;
            this.label6.Text = "Stock : ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label7.Location = new System.Drawing.Point(245, 126);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 15);
            this.label7.TabIndex = 8;
            this.label7.Text = "Price : ";
            // 
            // pricelabel
            // 
            this.pricelabel.AutoSize = true;
            this.pricelabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pricelabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.pricelabel.Location = new System.Drawing.Point(303, 126);
            this.pricelabel.Name = "pricelabel";
            this.pricelabel.Size = new System.Drawing.Size(12, 15);
            this.pricelabel.TabIndex = 9;
            this.pricelabel.Text = "-";
            // 
            // btnclose
            // 
            this.btnclose.BackColor = System.Drawing.Color.Purple;
            this.btnclose.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnclose.Location = new System.Drawing.Point(655, 9);
            this.btnclose.Name = "btnclose";
            this.btnclose.Size = new System.Drawing.Size(79, 30);
            this.btnclose.TabIndex = 10;
            this.btnclose.Text = "Close";
            this.btnclose.UseVisualStyleBackColor = false;
            this.btnclose.Click += new System.EventHandler(this.btnclose_Click);
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label9.Location = new System.Drawing.Point(437, 104);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(93, 23);
            this.label9.TabIndex = 0;
            this.label9.Text = "Order Date";
            // 
            // orderdate
            // 
            this.orderdate.Location = new System.Drawing.Point(536, 105);
            this.orderdate.Name = "orderdate";
            this.orderdate.Size = new System.Drawing.Size(200, 20);
            this.orderdate.TabIndex = 12;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label10.Location = new System.Drawing.Point(536, 81);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(40, 15);
            this.label10.TabIndex = 13;
            this.label10.Text = "Price";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // totalpricelabel
            // 
            this.totalpricelabel.AutoSize = true;
            this.totalpricelabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalpricelabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.totalpricelabel.Location = new System.Drawing.Point(595, 83);
            this.totalpricelabel.Name = "totalpricelabel";
            this.totalpricelabel.Size = new System.Drawing.Size(12, 15);
            this.totalpricelabel.TabIndex = 14;
            this.totalpricelabel.Text = "-";
            // 
            // cartbtn
            // 
            this.cartbtn.BackColor = System.Drawing.Color.Purple;
            this.cartbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cartbtn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.cartbtn.Location = new System.Drawing.Point(539, 157);
            this.cartbtn.Name = "cartbtn";
            this.cartbtn.Size = new System.Drawing.Size(89, 31);
            this.cartbtn.TabIndex = 5;
            this.cartbtn.Text = "Add Cart";
            this.cartbtn.UseVisualStyleBackColor = false;
            this.cartbtn.Click += new System.EventHandler(this.btplaceorder_Click);
            // 
            // Place_Odrer_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(775, 523);
            this.Controls.Add(this.totalpricelabel);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.orderdate);
            this.Controls.Add(this.btnclose);
            this.Controls.Add(this.pricelabel);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.stocklabel);
            this.Controls.Add(this.cartbtn);
            this.Controls.Add(this.btplaceorder);
            this.Controls.Add(this.ordergridview);
            this.Controls.Add(this.txtorderqty);
            this.Controls.Add(this.cbunitsname);
            this.Controls.Add(this.cbitemname);
            this.Controls.Add(this.cbcutomerid);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Place_Odrer_Form";
            this.Text = "Place_Odrer_Form";
            this.Load += new System.EventHandler(this.Place_Odrer_Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ordergridview)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbcutomerid;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbitemname;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbunitsname;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtorderqty;
        private System.Windows.Forms.DataGridView ordergridview;
        private System.Windows.Forms.Button btplaceorder;
        private System.Windows.Forms.Label stocklabel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label pricelabel;
        private System.Windows.Forms.Button btnclose;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker orderdate;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label totalpricelabel;
        private System.Windows.Forms.Button cartbtn;
    }
}
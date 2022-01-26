
namespace Purchase_Order
{
    partial class Customers_Form
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
            this.btninsert = new System.Windows.Forms.Button();
            this.txtcstomername = new System.Windows.Forms.TextBox();
            this.customergridview = new System.Windows.Forms.DataGridView();
            this.btnupdate = new System.Windows.Forms.Button();
            this.btndelete = new System.Windows.Forms.Button();
            this.btnreset = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtcustomercity = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtcustomeraddress = new System.Windows.Forms.TextBox();
            this.txtcustomerwebsite = new System.Windows.Forms.TextBox();
            this.txtcustomeremail = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtcustomermobile = new System.Windows.Forms.TextBox();
            this.txtcustomerfax = new System.Windows.Forms.TextBox();
            this.txtcustomerpost = new System.Windows.Forms.TextBox();
            this.btnclose = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.customergridview)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Customer Details";
            // 
            // btninsert
            // 
            this.btninsert.BackColor = System.Drawing.Color.Purple;
            this.btninsert.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btninsert.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btninsert.Location = new System.Drawing.Point(62, 282);
            this.btninsert.Name = "btninsert";
            this.btninsert.Size = new System.Drawing.Size(119, 31);
            this.btninsert.TabIndex = 1;
            this.btninsert.Text = "Insert";
            this.btninsert.UseVisualStyleBackColor = false;
            this.btninsert.Click += new System.EventHandler(this.btninsert_Click);
            // 
            // txtcstomername
            // 
            this.txtcstomername.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcstomername.Location = new System.Drawing.Point(150, 64);
            this.txtcstomername.Multiline = true;
            this.txtcstomername.Name = "txtcstomername";
            this.txtcstomername.Size = new System.Drawing.Size(220, 25);
            this.txtcstomername.TabIndex = 2;
            // 
            // customergridview
            // 
            this.customergridview.BackgroundColor = System.Drawing.Color.White;
            this.customergridview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.customergridview.Location = new System.Drawing.Point(15, 348);
            this.customergridview.Name = "customergridview";
            this.customergridview.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.customergridview.Size = new System.Drawing.Size(865, 238);
            this.customergridview.TabIndex = 3;
            this.customergridview.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.customergridview_CellClick);
            // 
            // btnupdate
            // 
            this.btnupdate.BackColor = System.Drawing.Color.Purple;
            this.btnupdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnupdate.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnupdate.Location = new System.Drawing.Point(275, 282);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(119, 31);
            this.btnupdate.TabIndex = 1;
            this.btnupdate.Text = "Update";
            this.btnupdate.UseVisualStyleBackColor = false;
            this.btnupdate.Click += new System.EventHandler(this.btnupdate_Click);
            // 
            // btndelete
            // 
            this.btndelete.BackColor = System.Drawing.Color.Purple;
            this.btndelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndelete.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btndelete.Location = new System.Drawing.Point(464, 282);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(119, 31);
            this.btndelete.TabIndex = 1;
            this.btndelete.Text = "Delete";
            this.btndelete.UseVisualStyleBackColor = false;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // btnreset
            // 
            this.btnreset.BackColor = System.Drawing.Color.Purple;
            this.btnreset.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnreset.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnreset.Location = new System.Drawing.Point(677, 282);
            this.btnreset.Name = "btnreset";
            this.btnreset.Size = new System.Drawing.Size(119, 31);
            this.btnreset.TabIndex = 1;
            this.btnreset.Text = "Reset";
            this.btnreset.UseVisualStyleBackColor = false;
            this.btnreset.Click += new System.EventHandler(this.btnreset_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(12, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Customer Name ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(12, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "Customer Address";
            // 
            // txtcustomercity
            // 
            this.txtcustomercity.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcustomercity.Location = new System.Drawing.Point(150, 142);
            this.txtcustomercity.Multiline = true;
            this.txtcustomercity.Name = "txtcustomercity";
            this.txtcustomercity.Size = new System.Drawing.Size(220, 25);
            this.txtcustomercity.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(12, 151);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 16);
            this.label4.TabIndex = 0;
            this.label4.Text = "Customer City";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(12, 192);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(134, 16);
            this.label5.TabIndex = 0;
            this.label5.Text = "Customer Website";
            // 
            // txtcustomeraddress
            // 
            this.txtcustomeraddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcustomeraddress.Location = new System.Drawing.Point(150, 105);
            this.txtcustomeraddress.Multiline = true;
            this.txtcustomeraddress.Name = "txtcustomeraddress";
            this.txtcustomeraddress.Size = new System.Drawing.Size(220, 25);
            this.txtcustomeraddress.TabIndex = 2;
            // 
            // txtcustomerwebsite
            // 
            this.txtcustomerwebsite.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcustomerwebsite.Location = new System.Drawing.Point(150, 183);
            this.txtcustomerwebsite.Multiline = true;
            this.txtcustomerwebsite.Name = "txtcustomerwebsite";
            this.txtcustomerwebsite.Size = new System.Drawing.Size(220, 25);
            this.txtcustomerwebsite.TabIndex = 2;
            // 
            // txtcustomeremail
            // 
            this.txtcustomeremail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcustomeremail.Location = new System.Drawing.Point(657, 64);
            this.txtcustomeremail.Multiline = true;
            this.txtcustomeremail.Name = "txtcustomeremail";
            this.txtcustomeremail.Size = new System.Drawing.Size(223, 25);
            this.txtcustomeremail.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(502, 73);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(116, 16);
            this.label6.TabIndex = 0;
            this.label6.Text = "Customer Email";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.Location = new System.Drawing.Point(502, 110);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(133, 16);
            this.label7.TabIndex = 0;
            this.label7.Text = "Customer Tele No";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label8.Location = new System.Drawing.Point(502, 151);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(126, 16);
            this.label8.TabIndex = 0;
            this.label8.Text = "Customer Fax No";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label9.Location = new System.Drawing.Point(502, 186);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(130, 16);
            this.label9.TabIndex = 0;
            this.label9.Text = "Customer P.O No ";
            // 
            // txtcustomermobile
            // 
            this.txtcustomermobile.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcustomermobile.Location = new System.Drawing.Point(657, 110);
            this.txtcustomermobile.Multiline = true;
            this.txtcustomermobile.Name = "txtcustomermobile";
            this.txtcustomermobile.Size = new System.Drawing.Size(223, 25);
            this.txtcustomermobile.TabIndex = 2;
            // 
            // txtcustomerfax
            // 
            this.txtcustomerfax.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcustomerfax.Location = new System.Drawing.Point(657, 142);
            this.txtcustomerfax.Multiline = true;
            this.txtcustomerfax.Name = "txtcustomerfax";
            this.txtcustomerfax.Size = new System.Drawing.Size(223, 25);
            this.txtcustomerfax.TabIndex = 2;
            // 
            // txtcustomerpost
            // 
            this.txtcustomerpost.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcustomerpost.Location = new System.Drawing.Point(657, 183);
            this.txtcustomerpost.Multiline = true;
            this.txtcustomerpost.Name = "txtcustomerpost";
            this.txtcustomerpost.Size = new System.Drawing.Size(223, 25);
            this.txtcustomerpost.TabIndex = 2;
            // 
            // btnclose
            // 
            this.btnclose.BackColor = System.Drawing.Color.Purple;
            this.btnclose.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnclose.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnclose.Location = new System.Drawing.Point(805, 12);
            this.btnclose.Name = "btnclose";
            this.btnclose.Size = new System.Drawing.Size(75, 23);
            this.btnclose.TabIndex = 4;
            this.btnclose.Text = "Close";
            this.btnclose.UseVisualStyleBackColor = false;
            this.btnclose.Click += new System.EventHandler(this.btnclose_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(892, 598);
            this.Controls.Add(this.btnclose);
            this.Controls.Add(this.customergridview);
            this.Controls.Add(this.txtcustomeraddress);
            this.Controls.Add(this.txtcustomerwebsite);
            this.Controls.Add(this.txtcustomercity);
            this.Controls.Add(this.txtcustomerpost);
            this.Controls.Add(this.txtcustomerfax);
            this.Controls.Add(this.txtcustomermobile);
            this.Controls.Add(this.txtcustomeremail);
            this.Controls.Add(this.txtcstomername);
            this.Controls.Add(this.btnreset);
            this.Controls.Add(this.btndelete);
            this.Controls.Add(this.btnupdate);
            this.Controls.Add(this.btninsert);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Customer Form";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.customergridview)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btninsert;
        private System.Windows.Forms.TextBox txtcstomername;
        private System.Windows.Forms.DataGridView customergridview;
        private System.Windows.Forms.Button btnupdate;
        private System.Windows.Forms.Button btndelete;
        private System.Windows.Forms.Button btnreset;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtcustomercity;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtcustomeraddress;
        private System.Windows.Forms.TextBox txtcustomerwebsite;
        private System.Windows.Forms.TextBox txtcustomeremail;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtcustomermobile;
        private System.Windows.Forms.TextBox txtcustomerfax;
        private System.Windows.Forms.TextBox txtcustomerpost;
        private System.Windows.Forms.Button btnclose;
    }
}


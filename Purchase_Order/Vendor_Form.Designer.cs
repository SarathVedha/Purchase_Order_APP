
namespace Purchase_Order
{
    partial class Vendor_Form
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
            this.txtvendoraddress = new System.Windows.Forms.TextBox();
            this.txtvendorcity = new System.Windows.Forms.TextBox();
            this.txtvendorname = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtvendorfax = new System.Windows.Forms.TextBox();
            this.txtvendormobile = new System.Windows.Forms.TextBox();
            this.txtvendoremail = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.vendorgridview = new System.Windows.Forms.DataGridView();
            this.btnresetven = new System.Windows.Forms.Button();
            this.btndeleteven = new System.Windows.Forms.Button();
            this.btnupdateven = new System.Windows.Forms.Button();
            this.btninsertven = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnclose = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.vendorgridview)).BeginInit();
            this.SuspendLayout();
            // 
            // txtvendoraddress
            // 
            this.txtvendoraddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtvendoraddress.Location = new System.Drawing.Point(150, 106);
            this.txtvendoraddress.Multiline = true;
            this.txtvendoraddress.Name = "txtvendoraddress";
            this.txtvendoraddress.Size = new System.Drawing.Size(220, 25);
            this.txtvendoraddress.TabIndex = 7;
            // 
            // txtvendorcity
            // 
            this.txtvendorcity.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtvendorcity.Location = new System.Drawing.Point(150, 143);
            this.txtvendorcity.Multiline = true;
            this.txtvendorcity.Name = "txtvendorcity";
            this.txtvendorcity.Size = new System.Drawing.Size(220, 25);
            this.txtvendorcity.TabIndex = 9;
            // 
            // txtvendorname
            // 
            this.txtvendorname.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtvendorname.Location = new System.Drawing.Point(150, 65);
            this.txtvendorname.Multiline = true;
            this.txtvendorname.Name = "txtvendorname";
            this.txtvendorname.Size = new System.Drawing.Size(220, 25);
            this.txtvendorname.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(12, 152);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "Vendor City";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(12, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Vendor Address";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(12, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Vendor Name";
            // 
            // txtvendorfax
            // 
            this.txtvendorfax.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtvendorfax.Location = new System.Drawing.Point(627, 143);
            this.txtvendorfax.Multiline = true;
            this.txtvendorfax.Name = "txtvendorfax";
            this.txtvendorfax.Size = new System.Drawing.Size(223, 25);
            this.txtvendorfax.TabIndex = 16;
            // 
            // txtvendormobile
            // 
            this.txtvendormobile.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtvendormobile.Location = new System.Drawing.Point(627, 111);
            this.txtvendormobile.Multiline = true;
            this.txtvendormobile.Name = "txtvendormobile";
            this.txtvendormobile.Size = new System.Drawing.Size(223, 25);
            this.txtvendormobile.TabIndex = 17;
            // 
            // txtvendoremail
            // 
            this.txtvendoremail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtvendoremail.Location = new System.Drawing.Point(627, 65);
            this.txtvendoremail.Multiline = true;
            this.txtvendoremail.Name = "txtvendoremail";
            this.txtvendoremail.Size = new System.Drawing.Size(223, 25);
            this.txtvendoremail.TabIndex = 18;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label8.Location = new System.Drawing.Point(472, 152);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(111, 16);
            this.label8.TabIndex = 12;
            this.label8.Text = "Vendor Fax No";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.Location = new System.Drawing.Point(472, 111);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(118, 16);
            this.label7.TabIndex = 13;
            this.label7.Text = "Vendor Tele No";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(472, 74);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(101, 16);
            this.label6.TabIndex = 14;
            this.label6.Text = "Vendor Email";
            // 
            // vendorgridview
            // 
            this.vendorgridview.BackgroundColor = System.Drawing.Color.White;
            this.vendorgridview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.vendorgridview.GridColor = System.Drawing.Color.Black;
            this.vendorgridview.Location = new System.Drawing.Point(15, 351);
            this.vendorgridview.Name = "vendorgridview";
            this.vendorgridview.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.vendorgridview.Size = new System.Drawing.Size(865, 238);
            this.vendorgridview.TabIndex = 23;
            this.vendorgridview.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.vendorgridview_CellClick);
            // 
            // btnresetven
            // 
            this.btnresetven.BackColor = System.Drawing.Color.Purple;
            this.btnresetven.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnresetven.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnresetven.Location = new System.Drawing.Point(677, 285);
            this.btnresetven.Name = "btnresetven";
            this.btnresetven.Size = new System.Drawing.Size(119, 31);
            this.btnresetven.TabIndex = 19;
            this.btnresetven.Text = "Reset";
            this.btnresetven.UseVisualStyleBackColor = false;
            this.btnresetven.Click += new System.EventHandler(this.btnresetven_Click);
            // 
            // btndeleteven
            // 
            this.btndeleteven.BackColor = System.Drawing.Color.Purple;
            this.btndeleteven.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndeleteven.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btndeleteven.Location = new System.Drawing.Point(464, 285);
            this.btndeleteven.Name = "btndeleteven";
            this.btndeleteven.Size = new System.Drawing.Size(119, 31);
            this.btndeleteven.TabIndex = 20;
            this.btndeleteven.Text = "Delete";
            this.btndeleteven.UseVisualStyleBackColor = false;
            this.btndeleteven.Click += new System.EventHandler(this.btndeleteven_Click);
            // 
            // btnupdateven
            // 
            this.btnupdateven.BackColor = System.Drawing.Color.Purple;
            this.btnupdateven.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnupdateven.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnupdateven.Location = new System.Drawing.Point(275, 285);
            this.btnupdateven.Name = "btnupdateven";
            this.btnupdateven.Size = new System.Drawing.Size(119, 31);
            this.btnupdateven.TabIndex = 21;
            this.btnupdateven.Text = "Update";
            this.btnupdateven.UseVisualStyleBackColor = false;
            this.btnupdateven.Click += new System.EventHandler(this.btnupdateven_Click);
            // 
            // btninsertven
            // 
            this.btninsertven.BackColor = System.Drawing.Color.Purple;
            this.btninsertven.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btninsertven.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btninsertven.Location = new System.Drawing.Point(62, 285);
            this.btninsertven.Name = "btninsertven";
            this.btninsertven.Size = new System.Drawing.Size(119, 31);
            this.btninsertven.TabIndex = 22;
            this.btninsertven.Text = "Insert";
            this.btninsertven.UseVisualStyleBackColor = false;
            this.btninsertven.Click += new System.EventHandler(this.btninsertven_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 16);
            this.label1.TabIndex = 24;
            this.label1.Text = "Vendor Details";
            // 
            // btnclose
            // 
            this.btnclose.BackColor = System.Drawing.Color.Purple;
            this.btnclose.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnclose.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnclose.Location = new System.Drawing.Point(766, 10);
            this.btnclose.Name = "btnclose";
            this.btnclose.Size = new System.Drawing.Size(84, 34);
            this.btnclose.TabIndex = 25;
            this.btnclose.Text = "Close";
            this.btnclose.UseVisualStyleBackColor = false;
            this.btnclose.Click += new System.EventHandler(this.btnclose_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(897, 601);
            this.Controls.Add(this.btnclose);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.vendorgridview);
            this.Controls.Add(this.btnresetven);
            this.Controls.Add(this.btndeleteven);
            this.Controls.Add(this.btnupdateven);
            this.Controls.Add(this.btninsertven);
            this.Controls.Add(this.txtvendorfax);
            this.Controls.Add(this.txtvendormobile);
            this.Controls.Add(this.txtvendoremail);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtvendoraddress);
            this.Controls.Add(this.txtvendorcity);
            this.Controls.Add(this.txtvendorname);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "Form3";
            this.Text = "Vendor Details";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.vendorgridview)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtvendoraddress;
        private System.Windows.Forms.TextBox txtvendorcity;
        private System.Windows.Forms.TextBox txtvendorname;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtvendorfax;
        private System.Windows.Forms.TextBox txtvendormobile;
        private System.Windows.Forms.TextBox txtvendoremail;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView vendorgridview;
        private System.Windows.Forms.Button btnresetven;
        private System.Windows.Forms.Button btndeleteven;
        private System.Windows.Forms.Button btnupdateven;
        private System.Windows.Forms.Button btninsertven;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnclose;
    }
}
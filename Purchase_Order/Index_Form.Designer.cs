
namespace Purchase_Order
{
    partial class Index_Form
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
            this.btncustomerform = new System.Windows.Forms.Button();
            this.btnvendorform = new System.Windows.Forms.Button();
            this.btnitemform = new System.Windows.Forms.Button();
            this.btnorderform = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnclose = new System.Windows.Forms.Button();
            this.btnunitsform = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btncustomerform
            // 
            this.btncustomerform.BackColor = System.Drawing.Color.Purple;
            this.btncustomerform.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncustomerform.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btncustomerform.Location = new System.Drawing.Point(97, 64);
            this.btncustomerform.Name = "btncustomerform";
            this.btncustomerform.Size = new System.Drawing.Size(105, 46);
            this.btncustomerform.TabIndex = 0;
            this.btncustomerform.Text = "Customer";
            this.btncustomerform.UseVisualStyleBackColor = false;
            this.btncustomerform.Click += new System.EventHandler(this.btncustomerform_Click);
            // 
            // btnvendorform
            // 
            this.btnvendorform.BackColor = System.Drawing.Color.Purple;
            this.btnvendorform.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnvendorform.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnvendorform.Location = new System.Drawing.Point(97, 131);
            this.btnvendorform.Name = "btnvendorform";
            this.btnvendorform.Size = new System.Drawing.Size(105, 46);
            this.btnvendorform.TabIndex = 0;
            this.btnvendorform.Text = "Vendor";
            this.btnvendorform.UseVisualStyleBackColor = false;
            this.btnvendorform.Click += new System.EventHandler(this.btnvendorform_Click);
            // 
            // btnitemform
            // 
            this.btnitemform.BackColor = System.Drawing.Color.Purple;
            this.btnitemform.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnitemform.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnitemform.Location = new System.Drawing.Point(97, 200);
            this.btnitemform.Name = "btnitemform";
            this.btnitemform.Size = new System.Drawing.Size(105, 46);
            this.btnitemform.TabIndex = 0;
            this.btnitemform.Text = "Items";
            this.btnitemform.UseVisualStyleBackColor = false;
            this.btnitemform.Click += new System.EventHandler(this.btnitemform_Click);
            // 
            // btnorderform
            // 
            this.btnorderform.BackColor = System.Drawing.Color.Purple;
            this.btnorderform.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnorderform.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnorderform.Location = new System.Drawing.Point(97, 333);
            this.btnorderform.Name = "btnorderform";
            this.btnorderform.Size = new System.Drawing.Size(105, 46);
            this.btnorderform.TabIndex = 0;
            this.btnorderform.Text = "Order";
            this.btnorderform.UseVisualStyleBackColor = false;
            this.btnorderform.Click += new System.EventHandler(this.btnorderform_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(277, 30);
            this.label1.TabIndex = 1;
            this.label1.Text = "Welcome To Purchase Order";
            // 
            // btnclose
            // 
            this.btnclose.BackColor = System.Drawing.Color.Purple;
            this.btnclose.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnclose.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnclose.Location = new System.Drawing.Point(223, 6);
            this.btnclose.Name = "btnclose";
            this.btnclose.Size = new System.Drawing.Size(75, 33);
            this.btnclose.TabIndex = 2;
            this.btnclose.Text = "Close";
            this.btnclose.UseVisualStyleBackColor = false;
            this.btnclose.Click += new System.EventHandler(this.btnclose_Click);
            // 
            // btnunitsform
            // 
            this.btnunitsform.BackColor = System.Drawing.Color.Purple;
            this.btnunitsform.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnunitsform.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnunitsform.Location = new System.Drawing.Point(97, 267);
            this.btnunitsform.Name = "btnunitsform";
            this.btnunitsform.Size = new System.Drawing.Size(105, 46);
            this.btnunitsform.TabIndex = 0;
            this.btnunitsform.Text = "Units";
            this.btnunitsform.UseVisualStyleBackColor = false;
            this.btnunitsform.Click += new System.EventHandler(this.btnitemsform_Click);
            // 
            // Index_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(301, 418);
            this.Controls.Add(this.btnclose);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnunitsform);
            this.Controls.Add(this.btnorderform);
            this.Controls.Add(this.btnitemform);
            this.Controls.Add(this.btnvendorform);
            this.Controls.Add(this.btncustomerform);
            this.Name = "Index_Form";
            this.Text = "Purchase Order";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btncustomerform;
        private System.Windows.Forms.Button btnvendorform;
        private System.Windows.Forms.Button btnitemform;
        private System.Windows.Forms.Button btnorderform;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnclose;
        private System.Windows.Forms.Button btnunitsform;
    }
}
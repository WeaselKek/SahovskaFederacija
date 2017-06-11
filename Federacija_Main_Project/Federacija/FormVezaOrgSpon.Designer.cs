namespace Federacija
{
    partial class FormVezaOrgSpon
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
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnPotvrdi = new System.Windows.Forms.Button();
            this.btnDodajOrg = new System.Windows.Forms.Button();
            this.btnDodajSpon = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(45, 370);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 0;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnPotvrdi
            // 
            this.btnPotvrdi.Location = new System.Drawing.Point(541, 366);
            this.btnPotvrdi.Name = "btnPotvrdi";
            this.btnPotvrdi.Size = new System.Drawing.Size(75, 23);
            this.btnPotvrdi.TabIndex = 1;
            this.btnPotvrdi.Text = "Potvrdi";
            this.btnPotvrdi.UseVisualStyleBackColor = true;
            this.btnPotvrdi.Click += new System.EventHandler(this.btnPotvrdi_Click);
            // 
            // btnDodajOrg
            // 
            this.btnDodajOrg.Location = new System.Drawing.Point(456, 60);
            this.btnDodajOrg.Name = "btnDodajOrg";
            this.btnDodajOrg.Size = new System.Drawing.Size(130, 25);
            this.btnDodajOrg.TabIndex = 17;
            this.btnDodajOrg.Text = "Dodaj Organizatora";
            this.btnDodajOrg.UseVisualStyleBackColor = true;
            this.btnDodajOrg.Click += new System.EventHandler(this.btnDodajOrg_Click);
            // 
            // btnDodajSpon
            // 
            this.btnDodajSpon.Location = new System.Drawing.Point(456, 124);
            this.btnDodajSpon.Name = "btnDodajSpon";
            this.btnDodajSpon.Size = new System.Drawing.Size(117, 23);
            this.btnDodajSpon.TabIndex = 18;
            this.btnDodajSpon.Text = "Dodaj Sponzora";
            this.btnDodajSpon.UseVisualStyleBackColor = true;
            this.btnDodajSpon.Click += new System.EventHandler(this.btnDodajSpon_Click);
            // 
            // FormVezaOrgSpon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(653, 399);
            this.Controls.Add(this.btnDodajSpon);
            this.Controls.Add(this.btnDodajOrg);
            this.Controls.Add(this.btnPotvrdi);
            this.Controls.Add(this.btnCancel);
            this.Name = "FormVezaOrgSpon";
            this.Text = "FormVezaOrgSpon";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormVezaOrgSpon_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnPotvrdi;
        private System.Windows.Forms.Button btnDodajOrg;
        private System.Windows.Forms.Button btnDodajSpon;
    }
}
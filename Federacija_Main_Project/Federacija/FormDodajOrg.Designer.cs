namespace Federacija
{
    partial class FormDodajOrg
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
            this.btnPotvrdi = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txbIme = new System.Windows.Forms.TextBox();
            this.txbPrezime = new System.Windows.Forms.TextBox();
            this.txbUlica = new System.Windows.Forms.TextBox();
            this.txbGrad = new System.Windows.Forms.TextBox();
            this.txbMatBr = new System.Windows.Forms.TextBox();
            this.txbBroj = new System.Windows.Forms.TextBox();
            this.cbxSudija = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnPotvrdi
            // 
            this.btnPotvrdi.Location = new System.Drawing.Point(274, 261);
            this.btnPotvrdi.Name = "btnPotvrdi";
            this.btnPotvrdi.Size = new System.Drawing.Size(75, 23);
            this.btnPotvrdi.TabIndex = 0;
            this.btnPotvrdi.Text = "Potvrdi";
            this.btnPotvrdi.UseVisualStyleBackColor = true;
            this.btnPotvrdi.Click += new System.EventHandler(this.btnPotvrdi_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ime";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Prezime";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 172);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Maticni broj";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(160, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Grad";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(160, 98);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(25, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Broj";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(160, 172);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Ulica";
            // 
            // txbIme
            // 
            this.txbIme.Location = new System.Drawing.Point(23, 57);
            this.txbIme.Name = "txbIme";
            this.txbIme.Size = new System.Drawing.Size(100, 20);
            this.txbIme.TabIndex = 7;
            this.txbIme.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxIme_KeyPress);
            // 
            // txbPrezime
            // 
            this.txbPrezime.Location = new System.Drawing.Point(23, 127);
            this.txbPrezime.Name = "txbPrezime";
            this.txbPrezime.Size = new System.Drawing.Size(100, 20);
            this.txbPrezime.TabIndex = 8;
            this.txbPrezime.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbPrezime_KeyPress);
            // 
            // txbUlica
            // 
            this.txbUlica.Location = new System.Drawing.Point(163, 197);
            this.txbUlica.Name = "txbUlica";
            this.txbUlica.Size = new System.Drawing.Size(100, 20);
            this.txbUlica.TabIndex = 9;
            this.txbUlica.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbUlica_KeyPress);
            // 
            // txbGrad
            // 
            this.txbGrad.Location = new System.Drawing.Point(163, 57);
            this.txbGrad.Name = "txbGrad";
            this.txbGrad.Size = new System.Drawing.Size(100, 20);
            this.txbGrad.TabIndex = 10;
            this.txbGrad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbGrad_KeyPress);
            // 
            // txbMatBr
            // 
            this.txbMatBr.Location = new System.Drawing.Point(23, 197);
            this.txbMatBr.Name = "txbMatBr";
            this.txbMatBr.Size = new System.Drawing.Size(100, 20);
            this.txbMatBr.TabIndex = 11;
            this.txbMatBr.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbMatBr_KeyPress);
            // 
            // txbBroj
            // 
            this.txbBroj.Location = new System.Drawing.Point(163, 127);
            this.txbBroj.Name = "txbBroj";
            this.txbBroj.Size = new System.Drawing.Size(100, 20);
            this.txbBroj.TabIndex = 12;
            this.txbBroj.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbBroj_KeyPress);
            // 
            // cbxSudija
            // 
            this.cbxSudija.AutoSize = true;
            this.cbxSudija.Location = new System.Drawing.Point(294, 200);
            this.cbxSudija.Name = "cbxSudija";
            this.cbxSudija.Size = new System.Drawing.Size(55, 17);
            this.cbxSudija.TabIndex = 13;
            this.cbxSudija.Text = "Sudija";
            this.cbxSudija.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(23, 261);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(77, 23);
            this.button1.TabIndex = 14;
            this.button1.Text = "Cancel";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FormDodajOrg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(372, 296);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cbxSudija);
            this.Controls.Add(this.txbBroj);
            this.Controls.Add(this.txbMatBr);
            this.Controls.Add(this.txbGrad);
            this.Controls.Add(this.txbUlica);
            this.Controls.Add(this.txbPrezime);
            this.Controls.Add(this.txbIme);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnPotvrdi);
            this.Name = "FormDodajOrg";
            this.Text = "FormDodajOrg";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormDodajOrg_FormClosing);
            this.Load += new System.EventHandler(this.FormDodajOrg_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPotvrdi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txbIme;
        private System.Windows.Forms.TextBox txbPrezime;
        private System.Windows.Forms.TextBox txbUlica;
        private System.Windows.Forms.TextBox txbGrad;
        private System.Windows.Forms.TextBox txbMatBr;
        private System.Windows.Forms.TextBox txbBroj;
        private System.Windows.Forms.CheckBox cbxSudija;
        private System.Windows.Forms.Button button1;
    }
}
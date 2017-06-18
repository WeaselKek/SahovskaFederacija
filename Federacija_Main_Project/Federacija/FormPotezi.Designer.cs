namespace Federacija
{
    partial class FormPotezi
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
            this.dgvPotezi = new System.Windows.Forms.DataGridView();
            this.lblPartija = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnZatvori = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPotezi)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPotezi
            // 
            this.dgvPotezi.AllowUserToAddRows = false;
            this.dgvPotezi.AllowUserToDeleteRows = false;
            this.dgvPotezi.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvPotezi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPotezi.Location = new System.Drawing.Point(10, 205);
            this.dgvPotezi.Name = "dgvPotezi";
            this.dgvPotezi.ReadOnly = true;
            this.dgvPotezi.Size = new System.Drawing.Size(546, 246);
            this.dgvPotezi.TabIndex = 0;
            // 
            // lblPartija
            // 
            this.lblPartija.AutoSize = true;
            this.lblPartija.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPartija.Location = new System.Drawing.Point(30, 53);
            this.lblPartija.Name = "lblPartija";
            this.lblPartija.Size = new System.Drawing.Size(57, 20);
            this.lblPartija.TabIndex = 1;
            this.lblPartija.Text = "Partija:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 182);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Potezi";
            // 
            // btnZatvori
            // 
            this.btnZatvori.Location = new System.Drawing.Point(271, 512);
            this.btnZatvori.Name = "btnZatvori";
            this.btnZatvori.Size = new System.Drawing.Size(75, 23);
            this.btnZatvori.TabIndex = 3;
            this.btnZatvori.Text = "Zatvori";
            this.btnZatvori.UseVisualStyleBackColor = true;
            this.btnZatvori.Click += new System.EventHandler(this.btnZatvori_Click);
            // 
            // FormPotezi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(680, 565);
            this.Controls.Add(this.btnZatvori);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblPartija);
            this.Controls.Add(this.dgvPotezi);
            this.Name = "FormPotezi";
            this.Text = "FormPotezi";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormPotezi_FormClosing);
            this.Load += new System.EventHandler(this.FormPotezi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPotezi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPotezi;
        private System.Windows.Forms.Label lblPartija;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnZatvori;
    }
}
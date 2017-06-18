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
            this.label1 = new System.Windows.Forms.Label();
            this.btnZatvori = new System.Windows.Forms.Button();
            this.lblBeliVSCrni = new System.Windows.Forms.Label();
            this.lblDatumVreme = new System.Windows.Forms.Label();
            this.lblIshod = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPotezi)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPotezi
            // 
            this.dgvPotezi.AllowUserToAddRows = false;
            this.dgvPotezi.AllowUserToDeleteRows = false;
            this.dgvPotezi.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvPotezi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPotezi.Location = new System.Drawing.Point(51, 185);
            this.dgvPotezi.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvPotezi.Name = "dgvPotezi";
            this.dgvPotezi.ReadOnly = true;
            this.dgvPotezi.Size = new System.Drawing.Size(680, 358);
            this.dgvPotezi.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(46, 156);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Potezi";
            // 
            // btnZatvori
            // 
            this.btnZatvori.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnZatvori.Location = new System.Drawing.Point(328, 584);
            this.btnZatvori.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnZatvori.Name = "btnZatvori";
            this.btnZatvori.Size = new System.Drawing.Size(110, 35);
            this.btnZatvori.TabIndex = 3;
            this.btnZatvori.Text = "Zatvori";
            this.btnZatvori.UseVisualStyleBackColor = true;
            this.btnZatvori.Click += new System.EventHandler(this.btnZatvori_Click);
            // 
            // lblBeliVSCrni
            // 
            this.lblBeliVSCrni.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBeliVSCrni.Location = new System.Drawing.Point(51, 65);
            this.lblBeliVSCrni.Name = "lblBeliVSCrni";
            this.lblBeliVSCrni.Size = new System.Drawing.Size(680, 38);
            this.lblBeliVSCrni.TabIndex = 4;
            this.lblBeliVSCrni.Text = "lblBeliVSCrni";
            this.lblBeliVSCrni.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDatumVreme
            // 
            this.lblDatumVreme.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDatumVreme.Location = new System.Drawing.Point(51, 30);
            this.lblDatumVreme.Name = "lblDatumVreme";
            this.lblDatumVreme.Size = new System.Drawing.Size(680, 23);
            this.lblDatumVreme.TabIndex = 5;
            this.lblDatumVreme.Text = "lblDatumVreme";
            this.lblDatumVreme.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblIshod
            // 
            this.lblIshod.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIshod.Location = new System.Drawing.Point(52, 112);
            this.lblIshod.Name = "lblIshod";
            this.lblIshod.Size = new System.Drawing.Size(680, 23);
            this.lblIshod.TabIndex = 6;
            this.lblIshod.Text = "lblIshod";
            this.lblIshod.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormPotezi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(798, 638);
            this.Controls.Add(this.lblIshod);
            this.Controls.Add(this.lblDatumVreme);
            this.Controls.Add(this.lblBeliVSCrni);
            this.Controls.Add(this.btnZatvori);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvPotezi);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FormPotezi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Informacije o partiji";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormPotezi_FormClosing);
            this.Load += new System.EventHandler(this.FormPotezi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPotezi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPotezi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnZatvori;
        private System.Windows.Forms.Label lblBeliVSCrni;
        private System.Windows.Forms.Label lblDatumVreme;
        private System.Windows.Forms.Label lblIshod;
    }
}
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
            this.dgvPostojeciOrganizatori = new System.Windows.Forms.DataGridView();
            this.dgvPostojeciSponzori = new System.Windows.Forms.DataGridView();
            this.dgvSviOrganizatori = new System.Windows.Forms.DataGridView();
            this.dgvSviSponzori = new System.Windows.Forms.DataGridView();
            this.btnPoveziOrganizatora = new System.Windows.Forms.Button();
            this.btnPoveziSponzora = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnUcitaj = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPostojeciOrganizatori)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPostojeciSponzori)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSviOrganizatori)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSviSponzori)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(27, 495);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 0;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnPotvrdi
            // 
            this.btnPotvrdi.Location = new System.Drawing.Point(576, 495);
            this.btnPotvrdi.Name = "btnPotvrdi";
            this.btnPotvrdi.Size = new System.Drawing.Size(75, 23);
            this.btnPotvrdi.TabIndex = 1;
            this.btnPotvrdi.Text = "Potvrdi";
            this.btnPotvrdi.UseVisualStyleBackColor = true;
            this.btnPotvrdi.Click += new System.EventHandler(this.btnPotvrdi_Click);
            // 
            // btnDodajOrg
            // 
            this.btnDodajOrg.Location = new System.Drawing.Point(27, 439);
            this.btnDodajOrg.Name = "btnDodajOrg";
            this.btnDodajOrg.Size = new System.Drawing.Size(173, 25);
            this.btnDodajOrg.TabIndex = 17;
            this.btnDodajOrg.Text = "Dodaj Novog Organizatora";
            this.btnDodajOrg.UseVisualStyleBackColor = true;
            this.btnDodajOrg.Click += new System.EventHandler(this.btnDodajOrg_Click);
            // 
            // btnDodajSpon
            // 
            this.btnDodajSpon.Location = new System.Drawing.Point(255, 439);
            this.btnDodajSpon.Name = "btnDodajSpon";
            this.btnDodajSpon.Size = new System.Drawing.Size(173, 23);
            this.btnDodajSpon.TabIndex = 18;
            this.btnDodajSpon.Text = "Dodaj Novog Sponzora";
            this.btnDodajSpon.UseVisualStyleBackColor = true;
            this.btnDodajSpon.Click += new System.EventHandler(this.btnDodajSpon_Click);
            // 
            // dgvPostojeciOrganizatori
            // 
            this.dgvPostojeciOrganizatori.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPostojeciOrganizatori.Location = new System.Drawing.Point(24, 56);
            this.dgvPostojeciOrganizatori.Name = "dgvPostojeciOrganizatori";
            this.dgvPostojeciOrganizatori.ReadOnly = true;
            this.dgvPostojeciOrganizatori.Size = new System.Drawing.Size(475, 153);
            this.dgvPostojeciOrganizatori.TabIndex = 19;
            // 
            // dgvPostojeciSponzori
            // 
            this.dgvPostojeciSponzori.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPostojeciSponzori.Location = new System.Drawing.Point(24, 259);
            this.dgvPostojeciSponzori.Name = "dgvPostojeciSponzori";
            this.dgvPostojeciSponzori.ReadOnly = true;
            this.dgvPostojeciSponzori.Size = new System.Drawing.Size(262, 134);
            this.dgvPostojeciSponzori.TabIndex = 20;
            // 
            // dgvSviOrganizatori
            // 
            this.dgvSviOrganizatori.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSviOrganizatori.Location = new System.Drawing.Point(560, 56);
            this.dgvSviOrganizatori.Name = "dgvSviOrganizatori";
            this.dgvSviOrganizatori.ReadOnly = true;
            this.dgvSviOrganizatori.Size = new System.Drawing.Size(475, 153);
            this.dgvSviOrganizatori.TabIndex = 21;
            // 
            // dgvSviSponzori
            // 
            this.dgvSviSponzori.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSviSponzori.Location = new System.Drawing.Point(560, 259);
            this.dgvSviSponzori.Name = "dgvSviSponzori";
            this.dgvSviSponzori.ReadOnly = true;
            this.dgvSviSponzori.Size = new System.Drawing.Size(262, 134);
            this.dgvSviSponzori.TabIndex = 22;
            // 
            // btnPoveziOrganizatora
            // 
            this.btnPoveziOrganizatora.Location = new System.Drawing.Point(851, 279);
            this.btnPoveziOrganizatora.Name = "btnPoveziOrganizatora";
            this.btnPoveziOrganizatora.Size = new System.Drawing.Size(166, 23);
            this.btnPoveziOrganizatora.TabIndex = 23;
            this.btnPoveziOrganizatora.Text = "Povezi oznacenog organizatora";
            this.btnPoveziOrganizatora.UseVisualStyleBackColor = true;
            // 
            // btnPoveziSponzora
            // 
            this.btnPoveziSponzora.Location = new System.Drawing.Point(851, 333);
            this.btnPoveziSponzora.Name = "btnPoveziSponzora";
            this.btnPoveziSponzora.Size = new System.Drawing.Size(166, 23);
            this.btnPoveziSponzora.TabIndex = 24;
            this.btnPoveziSponzora.Text = "Povezi oznacenog sponzora";
            this.btnPoveziSponzora.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(24, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(246, 20);
            this.label1.TabIndex = 25;
            this.label1.Text = "Organizatori i sponzori turnira";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(557, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(215, 20);
            this.label2.TabIndex = 26;
            this.label2.Text = "Svi organizatori i sponzori";
            // 
            // btnUcitaj
            // 
            this.btnUcitaj.Location = new System.Drawing.Point(807, 26);
            this.btnUcitaj.Name = "btnUcitaj";
            this.btnUcitaj.Size = new System.Drawing.Size(75, 23);
            this.btnUcitaj.TabIndex = 27;
            this.btnUcitaj.Text = "Ucitaj";
            this.btnUcitaj.UseVisualStyleBackColor = true;
            this.btnUcitaj.Click += new System.EventHandler(this.btnUcitaj_Click);
            // 
            // FormVezaOrgSpon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1047, 534);
            this.Controls.Add(this.btnUcitaj);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnPoveziSponzora);
            this.Controls.Add(this.btnPoveziOrganizatora);
            this.Controls.Add(this.dgvSviSponzori);
            this.Controls.Add(this.dgvSviOrganizatori);
            this.Controls.Add(this.dgvPostojeciSponzori);
            this.Controls.Add(this.dgvPostojeciOrganizatori);
            this.Controls.Add(this.btnDodajSpon);
            this.Controls.Add(this.btnDodajOrg);
            this.Controls.Add(this.btnPotvrdi);
            this.Controls.Add(this.btnCancel);
            this.Name = "FormVezaOrgSpon";
            this.Text = "FormVezaOrgSpon";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormVezaOrgSpon_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPostojeciOrganizatori)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPostojeciSponzori)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSviOrganizatori)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSviSponzori)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnPotvrdi;
        private System.Windows.Forms.Button btnDodajOrg;
        private System.Windows.Forms.Button btnDodajSpon;
        private System.Windows.Forms.DataGridView dgvPostojeciOrganizatori;
        private System.Windows.Forms.DataGridView dgvPostojeciSponzori;
        private System.Windows.Forms.Button btnPoveziOrganizatora;
        private System.Windows.Forms.Button btnPoveziSponzora;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnUcitaj;
        public System.Windows.Forms.DataGridView dgvSviOrganizatori;
        public System.Windows.Forms.DataGridView dgvSviSponzori;
    }
}
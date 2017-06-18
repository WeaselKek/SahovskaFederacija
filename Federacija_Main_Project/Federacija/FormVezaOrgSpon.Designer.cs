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
            this.btnDone = new System.Windows.Forms.Button();
            this.btnDodajOrg = new System.Windows.Forms.Button();
            this.btnDodajSpon = new System.Windows.Forms.Button();
            this.dgvPostojeciOrganizatori = new System.Windows.Forms.DataGridView();
            this.dgvPostojeciSponzori = new System.Windows.Forms.DataGridView();
            this.dgvSviOrganizatori = new System.Windows.Forms.DataGridView();
            this.dgvSviSponzori = new System.Windows.Forms.DataGridView();
            this.btnPoveziOrganizatora = new System.Windows.Forms.Button();
            this.btnPoveziSponzora = new System.Windows.Forms.Button();
            this.lblOrgTurnira = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnUkloniOrganizatora = new System.Windows.Forms.Button();
            this.btnUkloniSponzora = new System.Windows.Forms.Button();
            this.lblSponzTurnira = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPostojeciOrganizatori)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPostojeciSponzori)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSviOrganizatori)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSviSponzori)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDone
            // 
            this.btnDone.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDone.Location = new System.Drawing.Point(953, 487);
            this.btnDone.Name = "btnDone";
            this.btnDone.Size = new System.Drawing.Size(82, 28);
            this.btnDone.TabIndex = 0;
            this.btnDone.Text = "Done";
            this.btnDone.UseVisualStyleBackColor = true;
            this.btnDone.Click += new System.EventHandler(this.btnDone_Click);
            // 
            // btnDodajOrg
            // 
            this.btnDodajOrg.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDodajOrg.Location = new System.Drawing.Point(560, 215);
            this.btnDodajOrg.Name = "btnDodajOrg";
            this.btnDodajOrg.Size = new System.Drawing.Size(198, 28);
            this.btnDodajOrg.TabIndex = 17;
            this.btnDodajOrg.Text = "Dodaj novog organizatora";
            this.btnDodajOrg.UseVisualStyleBackColor = true;
            this.btnDodajOrg.Click += new System.EventHandler(this.btnDodajOrg_Click);
            // 
            // btnDodajSpon
            // 
            this.btnDodajSpon.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDodajSpon.Location = new System.Drawing.Point(561, 431);
            this.btnDodajSpon.Name = "btnDodajSpon";
            this.btnDodajSpon.Size = new System.Drawing.Size(198, 28);
            this.btnDodajSpon.TabIndex = 18;
            this.btnDodajSpon.Text = "Dodaj novog sponzora";
            this.btnDodajSpon.UseVisualStyleBackColor = true;
            this.btnDodajSpon.Click += new System.EventHandler(this.btnDodajSpon_Click);
            // 
            // dgvPostojeciOrganizatori
            // 
            this.dgvPostojeciOrganizatori.AllowUserToAddRows = false;
            this.dgvPostojeciOrganizatori.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvPostojeciOrganizatori.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPostojeciOrganizatori.Location = new System.Drawing.Point(24, 56);
            this.dgvPostojeciOrganizatori.Name = "dgvPostojeciOrganizatori";
            this.dgvPostojeciOrganizatori.ReadOnly = true;
            this.dgvPostojeciOrganizatori.Size = new System.Drawing.Size(475, 153);
            this.dgvPostojeciOrganizatori.TabIndex = 19;
            // 
            // dgvPostojeciSponzori
            // 
            this.dgvPostojeciSponzori.AllowUserToAddRows = false;
            this.dgvPostojeciSponzori.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvPostojeciSponzori.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPostojeciSponzori.Location = new System.Drawing.Point(24, 291);
            this.dgvPostojeciSponzori.Name = "dgvPostojeciSponzori";
            this.dgvPostojeciSponzori.ReadOnly = true;
            this.dgvPostojeciSponzori.Size = new System.Drawing.Size(262, 134);
            this.dgvPostojeciSponzori.TabIndex = 20;
            // 
            // dgvSviOrganizatori
            // 
            this.dgvSviOrganizatori.AllowUserToAddRows = false;
            this.dgvSviOrganizatori.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvSviOrganizatori.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSviOrganizatori.Location = new System.Drawing.Point(561, 56);
            this.dgvSviOrganizatori.Name = "dgvSviOrganizatori";
            this.dgvSviOrganizatori.ReadOnly = true;
            this.dgvSviOrganizatori.Size = new System.Drawing.Size(475, 153);
            this.dgvSviOrganizatori.TabIndex = 21;
            // 
            // dgvSviSponzori
            // 
            this.dgvSviSponzori.AllowUserToAddRows = false;
            this.dgvSviSponzori.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvSviSponzori.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSviSponzori.Location = new System.Drawing.Point(561, 291);
            this.dgvSviSponzori.Name = "dgvSviSponzori";
            this.dgvSviSponzori.ReadOnly = true;
            this.dgvSviSponzori.Size = new System.Drawing.Size(262, 134);
            this.dgvSviSponzori.TabIndex = 22;
            // 
            // btnPoveziOrganizatora
            // 
            this.btnPoveziOrganizatora.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPoveziOrganizatora.Location = new System.Drawing.Point(777, 215);
            this.btnPoveziOrganizatora.Name = "btnPoveziOrganizatora";
            this.btnPoveziOrganizatora.Size = new System.Drawing.Size(179, 28);
            this.btnPoveziOrganizatora.TabIndex = 23;
            this.btnPoveziOrganizatora.Text = "Dodeli oznacenog turniru";
            this.btnPoveziOrganizatora.UseVisualStyleBackColor = true;
            this.btnPoveziOrganizatora.Click += new System.EventHandler(this.btnPoveziOrganizatora_Click);
            // 
            // btnPoveziSponzora
            // 
            this.btnPoveziSponzora.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPoveziSponzora.Location = new System.Drawing.Point(777, 431);
            this.btnPoveziSponzora.Name = "btnPoveziSponzora";
            this.btnPoveziSponzora.Size = new System.Drawing.Size(179, 28);
            this.btnPoveziSponzora.TabIndex = 24;
            this.btnPoveziSponzora.Text = "Dodeli oznacenog turniru";
            this.btnPoveziSponzora.UseVisualStyleBackColor = true;
            this.btnPoveziSponzora.Click += new System.EventHandler(this.btnPoveziSponzora_Click);
            // 
            // lblOrgTurnira
            // 
            this.lblOrgTurnira.AutoSize = true;
            this.lblOrgTurnira.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblOrgTurnira.Location = new System.Drawing.Point(20, 32);
            this.lblOrgTurnira.Name = "lblOrgTurnira";
            this.lblOrgTurnira.Size = new System.Drawing.Size(164, 20);
            this.lblOrgTurnira.TabIndex = 25;
            this.lblOrgTurnira.Text = "Organizatori turnira";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(557, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 20);
            this.label2.TabIndex = 26;
            this.label2.Text = "Svi organizatori";
            // 
            // btnUkloniOrganizatora
            // 
            this.btnUkloniOrganizatora.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUkloniOrganizatora.Location = new System.Drawing.Point(24, 215);
            this.btnUkloniOrganizatora.Name = "btnUkloniOrganizatora";
            this.btnUkloniOrganizatora.Size = new System.Drawing.Size(205, 28);
            this.btnUkloniOrganizatora.TabIndex = 28;
            this.btnUkloniOrganizatora.Text = "Ukloni organizatora iz turnira";
            this.btnUkloniOrganizatora.UseVisualStyleBackColor = true;
            this.btnUkloniOrganizatora.Click += new System.EventHandler(this.btnUkloniOrganizatora_Click);
            // 
            // btnUkloniSponzora
            // 
            this.btnUkloniSponzora.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUkloniSponzora.Location = new System.Drawing.Point(24, 431);
            this.btnUkloniSponzora.Name = "btnUkloniSponzora";
            this.btnUkloniSponzora.Size = new System.Drawing.Size(205, 28);
            this.btnUkloniSponzora.TabIndex = 29;
            this.btnUkloniSponzora.Text = "Ukloni sponzora iz turnira";
            this.btnUkloniSponzora.UseVisualStyleBackColor = true;
            this.btnUkloniSponzora.Click += new System.EventHandler(this.btnUkloniSponzora_Click);
            // 
            // lblSponzTurnira
            // 
            this.lblSponzTurnira.AutoSize = true;
            this.lblSponzTurnira.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblSponzTurnira.Location = new System.Drawing.Point(20, 267);
            this.lblSponzTurnira.Name = "lblSponzTurnira";
            this.lblSponzTurnira.Size = new System.Drawing.Size(137, 20);
            this.lblSponzTurnira.TabIndex = 30;
            this.lblSponzTurnira.Text = "Sponzori turnira";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(557, 267);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 20);
            this.label4.TabIndex = 31;
            this.label4.Text = "Svi sponzori";
            // 
            // FormVezaOrgSpon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1056, 534);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblSponzTurnira);
            this.Controls.Add(this.btnUkloniSponzora);
            this.Controls.Add(this.btnUkloniOrganizatora);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblOrgTurnira);
            this.Controls.Add(this.btnPoveziSponzora);
            this.Controls.Add(this.btnPoveziOrganizatora);
            this.Controls.Add(this.dgvSviSponzori);
            this.Controls.Add(this.dgvSviOrganizatori);
            this.Controls.Add(this.dgvPostojeciSponzori);
            this.Controls.Add(this.dgvPostojeciOrganizatori);
            this.Controls.Add(this.btnDodajSpon);
            this.Controls.Add(this.btnDodajOrg);
            this.Controls.Add(this.btnDone);
            this.Name = "FormVezaOrgSpon";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormVezaOrgSpon";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormVezaOrgSpon_FormClosing);
            this.Load += new System.EventHandler(this.FormVezaOrgSpon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPostojeciOrganizatori)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPostojeciSponzori)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSviOrganizatori)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSviSponzori)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDone;
        private System.Windows.Forms.Button btnDodajOrg;
        private System.Windows.Forms.Button btnDodajSpon;
        private System.Windows.Forms.DataGridView dgvPostojeciOrganizatori;
        private System.Windows.Forms.DataGridView dgvPostojeciSponzori;
        private System.Windows.Forms.Button btnPoveziOrganizatora;
        private System.Windows.Forms.Button btnPoveziSponzora;
        private System.Windows.Forms.Label lblOrgTurnira;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.DataGridView dgvSviOrganizatori;
        public System.Windows.Forms.DataGridView dgvSviSponzori;
        private System.Windows.Forms.Button btnUkloniOrganizatora;
        private System.Windows.Forms.Button btnUkloniSponzora;
        private System.Windows.Forms.Label lblSponzTurnira;
        private System.Windows.Forms.Label label4;
    }
}
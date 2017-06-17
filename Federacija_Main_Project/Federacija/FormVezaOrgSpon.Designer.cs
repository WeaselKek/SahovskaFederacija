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
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(1271, 599);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(110, 35);
            this.btnCancel.TabIndex = 0;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnDodajOrg
            // 
            this.btnDodajOrg.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDodajOrg.Location = new System.Drawing.Point(747, 265);
            this.btnDodajOrg.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDodajOrg.Name = "btnDodajOrg";
            this.btnDodajOrg.Size = new System.Drawing.Size(232, 28);
            this.btnDodajOrg.TabIndex = 17;
            this.btnDodajOrg.Text = "Dodaj novog organizatora";
            this.btnDodajOrg.UseVisualStyleBackColor = true;
            this.btnDodajOrg.Click += new System.EventHandler(this.btnDodajOrg_Click);
            // 
            // btnDodajSpon
            // 
            this.btnDodajSpon.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDodajSpon.Location = new System.Drawing.Point(748, 531);
            this.btnDodajSpon.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDodajSpon.Name = "btnDodajSpon";
            this.btnDodajSpon.Size = new System.Drawing.Size(231, 28);
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
            this.dgvPostojeciOrganizatori.Location = new System.Drawing.Point(32, 69);
            this.dgvPostojeciOrganizatori.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvPostojeciOrganizatori.Name = "dgvPostojeciOrganizatori";
            this.dgvPostojeciOrganizatori.ReadOnly = true;
            this.dgvPostojeciOrganizatori.Size = new System.Drawing.Size(633, 188);
            this.dgvPostojeciOrganizatori.TabIndex = 19;
            // 
            // dgvPostojeciSponzori
            // 
            this.dgvPostojeciSponzori.AllowUserToAddRows = false;
            this.dgvPostojeciSponzori.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvPostojeciSponzori.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPostojeciSponzori.Location = new System.Drawing.Point(32, 358);
            this.dgvPostojeciSponzori.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvPostojeciSponzori.Name = "dgvPostojeciSponzori";
            this.dgvPostojeciSponzori.ReadOnly = true;
            this.dgvPostojeciSponzori.Size = new System.Drawing.Size(349, 165);
            this.dgvPostojeciSponzori.TabIndex = 20;
            // 
            // dgvSviOrganizatori
            // 
            this.dgvSviOrganizatori.AllowUserToAddRows = false;
            this.dgvSviOrganizatori.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvSviOrganizatori.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSviOrganizatori.Location = new System.Drawing.Point(748, 69);
            this.dgvSviOrganizatori.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvSviOrganizatori.Name = "dgvSviOrganizatori";
            this.dgvSviOrganizatori.ReadOnly = true;
            this.dgvSviOrganizatori.Size = new System.Drawing.Size(633, 188);
            this.dgvSviOrganizatori.TabIndex = 21;
            // 
            // dgvSviSponzori
            // 
            this.dgvSviSponzori.AllowUserToAddRows = false;
            this.dgvSviSponzori.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvSviSponzori.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSviSponzori.Location = new System.Drawing.Point(748, 358);
            this.dgvSviSponzori.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvSviSponzori.Name = "dgvSviSponzori";
            this.dgvSviSponzori.ReadOnly = true;
            this.dgvSviSponzori.Size = new System.Drawing.Size(349, 165);
            this.dgvSviSponzori.TabIndex = 22;
            // 
            // btnPoveziOrganizatora
            // 
            this.btnPoveziOrganizatora.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPoveziOrganizatora.Location = new System.Drawing.Point(1000, 265);
            this.btnPoveziOrganizatora.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnPoveziOrganizatora.Name = "btnPoveziOrganizatora";
            this.btnPoveziOrganizatora.Size = new System.Drawing.Size(221, 28);
            this.btnPoveziOrganizatora.TabIndex = 23;
            this.btnPoveziOrganizatora.Text = "Dodeli oznacenog turniru";
            this.btnPoveziOrganizatora.UseVisualStyleBackColor = true;
            this.btnPoveziOrganizatora.Click += new System.EventHandler(this.btnPoveziOrganizatora_Click);
            // 
            // btnPoveziSponzora
            // 
            this.btnPoveziSponzora.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPoveziSponzora.Location = new System.Drawing.Point(1000, 531);
            this.btnPoveziSponzora.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnPoveziSponzora.Name = "btnPoveziSponzora";
            this.btnPoveziSponzora.Size = new System.Drawing.Size(221, 28);
            this.btnPoveziSponzora.TabIndex = 24;
            this.btnPoveziSponzora.Text = "Dodeli oznacenog turniru";
            this.btnPoveziSponzora.UseVisualStyleBackColor = true;
            this.btnPoveziSponzora.Click += new System.EventHandler(this.btnPoveziSponzora_Click);
            // 
            // lblOrgTurnira
            // 
            this.lblOrgTurnira.AutoSize = true;
            this.lblOrgTurnira.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblOrgTurnira.Location = new System.Drawing.Point(27, 40);
            this.lblOrgTurnira.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblOrgTurnira.Name = "lblOrgTurnira";
            this.lblOrgTurnira.Size = new System.Drawing.Size(197, 25);
            this.lblOrgTurnira.TabIndex = 25;
            this.lblOrgTurnira.Text = "Organizatori turnira";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(743, 40);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(162, 25);
            this.label2.TabIndex = 26;
            this.label2.Text = "Svi organizatori";
            // 
            // btnUkloniOrganizatora
            // 
            this.btnUkloniOrganizatora.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUkloniOrganizatora.Location = new System.Drawing.Point(32, 265);
            this.btnUkloniOrganizatora.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnUkloniOrganizatora.Name = "btnUkloniOrganizatora";
            this.btnUkloniOrganizatora.Size = new System.Drawing.Size(268, 28);
            this.btnUkloniOrganizatora.TabIndex = 28;
            this.btnUkloniOrganizatora.Text = "Ukloni organizatora iz turnira";
            this.btnUkloniOrganizatora.UseVisualStyleBackColor = true;
            this.btnUkloniOrganizatora.Click += new System.EventHandler(this.btnUkloniOrganizatora_Click);
            // 
            // btnUkloniSponzora
            // 
            this.btnUkloniSponzora.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUkloniSponzora.Location = new System.Drawing.Point(32, 531);
            this.btnUkloniSponzora.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnUkloniSponzora.Name = "btnUkloniSponzora";
            this.btnUkloniSponzora.Size = new System.Drawing.Size(221, 28);
            this.btnUkloniSponzora.TabIndex = 29;
            this.btnUkloniSponzora.Text = "Ukloni sponzora iz turnira";
            this.btnUkloniSponzora.UseVisualStyleBackColor = true;
            this.btnUkloniSponzora.Click += new System.EventHandler(this.btnUkloniSponzora_Click);
            // 
            // lblSponzTurnira
            // 
            this.lblSponzTurnira.AutoSize = true;
            this.lblSponzTurnira.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblSponzTurnira.Location = new System.Drawing.Point(27, 329);
            this.lblSponzTurnira.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSponzTurnira.Name = "lblSponzTurnira";
            this.lblSponzTurnira.Size = new System.Drawing.Size(165, 25);
            this.lblSponzTurnira.TabIndex = 30;
            this.lblSponzTurnira.Text = "Sponzori turnira";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(743, 329);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(131, 25);
            this.label4.TabIndex = 31;
            this.label4.Text = "Svi sponzori";
            // 
            // FormVezaOrgSpon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1408, 657);
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
            this.Controls.Add(this.btnCancel);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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

        private System.Windows.Forms.Button btnCancel;
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
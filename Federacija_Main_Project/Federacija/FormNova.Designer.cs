namespace Federacija
{
    partial class FormNova
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
            this.dgv1 = new System.Windows.Forms.DataGridView();
            this.showSahista = new System.Windows.Forms.Button();
            this.chkSah = new System.Windows.Forms.CheckedListBox();
            this.btnIzmeni = new System.Windows.Forms.Button();
            this.showOrgan = new System.Windows.Forms.Button();
            this.showSpon = new System.Windows.Forms.Button();
            this.showTurnir = new System.Windows.Forms.Button();
            this.chkNacin = new System.Windows.Forms.CheckedListBox();
            this.chkTak = new System.Windows.Forms.CheckBox();
            this.chkEgz = new System.Windows.Forms.CheckBox();
            this.chkTipT = new System.Windows.Forms.CheckedListBox();
            this.chkTipE = new System.Windows.Forms.CheckedListBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnVezaOrgSpon = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.dodajToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sahistaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.turnirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblNaslov = new System.Windows.Forms.Label();
            this.btnDodajPartiju = new System.Windows.Forms.Button();
            this.btnPrikazPartije = new System.Windows.Forms.Button();
            this.btnPromovisi = new System.Windows.Forms.Button();
            this.btnOtpusti = new System.Windows.Forms.Button();
            this.showPotez = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv1
            // 
            this.dgv1.AllowUserToAddRows = false;
            this.dgv1.AllowUserToDeleteRows = false;
            this.dgv1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgv1.ColumnHeadersHeight = 36;
            this.dgv1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgv1.Location = new System.Drawing.Point(24, 302);
            this.dgv1.Name = "dgv1";
            this.dgv1.Size = new System.Drawing.Size(1233, 378);
            this.dgv1.TabIndex = 0;
            this.dgv1.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgv1_ColumnHeaderMouseClick);
            // 
            // showSahista
            // 
            this.showSahista.Location = new System.Drawing.Point(24, 43);
            this.showSahista.Name = "showSahista";
            this.showSahista.Size = new System.Drawing.Size(182, 34);
            this.showSahista.TabIndex = 1;
            this.showSahista.Text = "Prikazi Sahiste";
            this.showSahista.UseVisualStyleBackColor = true;
            this.showSahista.Click += new System.EventHandler(this.showSahista_Click);
            // 
            // chkSah
            // 
            this.chkSah.BackColor = System.Drawing.SystemColors.Control;
            this.chkSah.CheckOnClick = true;
            this.chkSah.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkSah.FormattingEnabled = true;
            this.chkSah.Items.AddRange(new object[] {
            "Majstor",
            "Majstorski kandidat",
            "Obican clan"});
            this.chkSah.Location = new System.Drawing.Point(24, 91);
            this.chkSah.Name = "chkSah";
            this.chkSah.Size = new System.Drawing.Size(162, 67);
            this.chkSah.TabIndex = 2;
            // 
            // btnIzmeni
            // 
            this.btnIzmeni.Location = new System.Drawing.Point(160, 268);
            this.btnIzmeni.Name = "btnIzmeni";
            this.btnIzmeni.Size = new System.Drawing.Size(162, 28);
            this.btnIzmeni.TabIndex = 4;
            this.btnIzmeni.Text = "Izmeni Selektovani Podatak";
            this.btnIzmeni.UseVisualStyleBackColor = true;
            this.btnIzmeni.Click += new System.EventHandler(this.btnIzmeni_Click);
            // 
            // showOrgan
            // 
            this.showOrgan.Location = new System.Drawing.Point(498, 43);
            this.showOrgan.Name = "showOrgan";
            this.showOrgan.Size = new System.Drawing.Size(120, 34);
            this.showOrgan.TabIndex = 5;
            this.showOrgan.Text = "Prikazi organizatore";
            this.showOrgan.UseVisualStyleBackColor = true;
            this.showOrgan.Click += new System.EventHandler(this.showOrgan_Click);
            // 
            // showSpon
            // 
            this.showSpon.Location = new System.Drawing.Point(660, 43);
            this.showSpon.Name = "showSpon";
            this.showSpon.Size = new System.Drawing.Size(120, 34);
            this.showSpon.TabIndex = 6;
            this.showSpon.Text = "Prikazi sponzore";
            this.showSpon.UseVisualStyleBackColor = true;
            this.showSpon.Click += new System.EventHandler(this.showSpon_Click);
            // 
            // showTurnir
            // 
            this.showTurnir.Location = new System.Drawing.Point(262, 43);
            this.showTurnir.Name = "showTurnir";
            this.showTurnir.Size = new System.Drawing.Size(182, 34);
            this.showTurnir.TabIndex = 7;
            this.showTurnir.Text = "Prikazi turnire";
            this.showTurnir.UseVisualStyleBackColor = true;
            this.showTurnir.Click += new System.EventHandler(this.showTurnir_Click);
            // 
            // chkNacin
            // 
            this.chkNacin.BackColor = System.Drawing.SystemColors.Menu;
            this.chkNacin.CheckOnClick = true;
            this.chkNacin.FormattingEnabled = true;
            this.chkNacin.Items.AddRange(new object[] {
            "Normalan",
            "Brzopotezni"});
            this.chkNacin.Location = new System.Drawing.Point(262, 88);
            this.chkNacin.Name = "chkNacin";
            this.chkNacin.Size = new System.Drawing.Size(102, 34);
            this.chkNacin.TabIndex = 8;
            // 
            // chkTak
            // 
            this.chkTak.AutoSize = true;
            this.chkTak.BackColor = System.Drawing.SystemColors.Menu;
            this.chkTak.Location = new System.Drawing.Point(262, 128);
            this.chkTak.Name = "chkTak";
            this.chkTak.Size = new System.Drawing.Size(83, 17);
            this.chkTak.TabIndex = 9;
            this.chkTak.Text = "Takmicarski";
            this.chkTak.UseVisualStyleBackColor = false;
            this.chkTak.CheckStateChanged += new System.EventHandler(this.chkTak_CheckStateChanged);
            // 
            // chkEgz
            // 
            this.chkEgz.AutoSize = true;
            this.chkEgz.BackColor = System.Drawing.SystemColors.Menu;
            this.chkEgz.Location = new System.Drawing.Point(382, 128);
            this.chkEgz.Name = "chkEgz";
            this.chkEgz.Size = new System.Drawing.Size(76, 17);
            this.chkEgz.TabIndex = 10;
            this.chkEgz.Text = "Egzibicioni";
            this.chkEgz.UseVisualStyleBackColor = false;
            this.chkEgz.CheckStateChanged += new System.EventHandler(this.chkEgz_CheckStateChanged);
            // 
            // chkTipT
            // 
            this.chkTipT.BackColor = System.Drawing.SystemColors.Menu;
            this.chkTipT.CheckOnClick = true;
            this.chkTipT.FormattingEnabled = true;
            this.chkTipT.Items.AddRange(new object[] {
            "Nacionalni",
            "Regionalni",
            "Internacionalni"});
            this.chkTipT.Location = new System.Drawing.Point(262, 162);
            this.chkTipT.Name = "chkTipT";
            this.chkTipT.Size = new System.Drawing.Size(102, 49);
            this.chkTipT.TabIndex = 11;
            // 
            // chkTipE
            // 
            this.chkTipE.BackColor = System.Drawing.SystemColors.Menu;
            this.chkTipE.CheckOnClick = true;
            this.chkTipE.FormattingEnabled = true;
            this.chkTipE.Items.AddRange(new object[] {
            "Promotivni",
            "Humanitarni"});
            this.chkTipE.Location = new System.Drawing.Point(378, 162);
            this.chkTipE.Name = "chkTipE";
            this.chkTipE.Size = new System.Drawing.Size(95, 34);
            this.chkTipE.TabIndex = 12;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(344, 268);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(111, 28);
            this.btnDelete.TabIndex = 13;
            this.btnDelete.Text = "Izbrisi podatak";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnVezaOrgSpon
            // 
            this.btnVezaOrgSpon.Location = new System.Drawing.Point(470, 268);
            this.btnVezaOrgSpon.Name = "btnVezaOrgSpon";
            this.btnVezaOrgSpon.Size = new System.Drawing.Size(239, 28);
            this.btnVezaOrgSpon.TabIndex = 18;
            this.btnVezaOrgSpon.Text = "Rukovodi organizatore i sponzore";
            this.btnVezaOrgSpon.UseVisualStyleBackColor = true;
            this.btnVezaOrgSpon.Click += new System.EventHandler(this.btnVezaOrgSpon_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dodajToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1269, 24);
            this.menuStrip1.TabIndex = 23;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // dodajToolStripMenuItem
            // 
            this.dodajToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sahistaToolStripMenuItem,
            this.turnirToolStripMenuItem});
            this.dodajToolStripMenuItem.Name = "dodajToolStripMenuItem";
            this.dodajToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.dodajToolStripMenuItem.Text = "Dodaj";
            // 
            // sahistaToolStripMenuItem
            // 
            this.sahistaToolStripMenuItem.Name = "sahistaToolStripMenuItem";
            this.sahistaToolStripMenuItem.Size = new System.Drawing.Size(111, 22);
            this.sahistaToolStripMenuItem.Text = "Sahista";
            this.sahistaToolStripMenuItem.Click += new System.EventHandler(this.sahistaToolStripMenuItem_Click);
            // 
            // turnirToolStripMenuItem
            // 
            this.turnirToolStripMenuItem.Name = "turnirToolStripMenuItem";
            this.turnirToolStripMenuItem.Size = new System.Drawing.Size(111, 22);
            this.turnirToolStripMenuItem.Text = "Turnir";
            this.turnirToolStripMenuItem.Click += new System.EventHandler(this.turnirToolStripMenuItem_Click);
            // 
            // lblNaslov
            // 
            this.lblNaslov.AutoSize = true;
            this.lblNaslov.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNaslov.Location = new System.Drawing.Point(20, 266);
            this.lblNaslov.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNaslov.Name = "lblNaslov";
            this.lblNaslov.Size = new System.Drawing.Size(113, 29);
            this.lblNaslov.TabIndex = 24;
            this.lblNaslov.Text = "lblNaslov";
            // 
            // btnDodajPartiju
            // 
            this.btnDodajPartiju.Location = new System.Drawing.Point(848, 268);
            this.btnDodajPartiju.Name = "btnDodajPartiju";
            this.btnDodajPartiju.Size = new System.Drawing.Size(113, 28);
            this.btnDodajPartiju.TabIndex = 25;
            this.btnDodajPartiju.Text = "Dodaj partiju";
            this.btnDodajPartiju.UseVisualStyleBackColor = true;
            this.btnDodajPartiju.Click += new System.EventHandler(this.btnDodajPartiju_Click);
            // 
            // btnPrikazPartije
            // 
            this.btnPrikazPartije.Location = new System.Drawing.Point(722, 268);
            this.btnPrikazPartije.Name = "btnPrikazPartije";
            this.btnPrikazPartije.Size = new System.Drawing.Size(113, 28);
            this.btnPrikazPartije.TabIndex = 26;
            this.btnPrikazPartije.Text = "Prikazi partije";
            this.btnPrikazPartije.UseVisualStyleBackColor = true;
            this.btnPrikazPartije.Click += new System.EventHandler(this.btnPrikazPartije_Click);
            // 
            // btnPromovisi
            // 
            this.btnPromovisi.Location = new System.Drawing.Point(470, 268);
            this.btnPromovisi.Name = "btnPromovisi";
            this.btnPromovisi.Size = new System.Drawing.Size(113, 28);
            this.btnPromovisi.TabIndex = 27;
            this.btnPromovisi.Text = "Promovisi u sudiju";
            this.btnPromovisi.UseVisualStyleBackColor = true;
            this.btnPromovisi.Click += new System.EventHandler(this.btnPromovisi_Click);
            // 
            // btnOtpusti
            // 
            this.btnOtpusti.Location = new System.Drawing.Point(596, 268);
            this.btnOtpusti.Name = "btnOtpusti";
            this.btnOtpusti.Size = new System.Drawing.Size(113, 28);
            this.btnOtpusti.TabIndex = 28;
            this.btnOtpusti.Text = "Otpusti sudiju";
            this.btnOtpusti.UseVisualStyleBackColor = true;
            this.btnOtpusti.Click += new System.EventHandler(this.btnOtpusti_Click);
            // 
            // showPotez
            // 
            this.showPotez.Location = new System.Drawing.Point(478, 268);
            this.showPotez.Name = "showPotez";
            this.showPotez.Size = new System.Drawing.Size(106, 28);
            this.showPotez.TabIndex = 29;
            this.showPotez.Text = "Prikazi Poteze";
            this.showPotez.UseVisualStyleBackColor = true;
            this.showPotez.Visible = false;
            this.showPotez.Click += new System.EventHandler(this.showPotez_Click);
            // 
            // FormNova
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1269, 692);
            this.Controls.Add(this.showPotez);
            this.Controls.Add(this.btnPromovisi);
            this.Controls.Add(this.btnOtpusti);
            this.Controls.Add(this.btnDodajPartiju);
            this.Controls.Add(this.btnPrikazPartije);
            this.Controls.Add(this.btnVezaOrgSpon);
            this.Controls.Add(this.lblNaslov);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.chkTipE);
            this.Controls.Add(this.chkTipT);
            this.Controls.Add(this.chkEgz);
            this.Controls.Add(this.chkTak);
            this.Controls.Add(this.chkNacin);
            this.Controls.Add(this.showTurnir);
            this.Controls.Add(this.showSpon);
            this.Controls.Add(this.showOrgan);
            this.Controls.Add(this.btnIzmeni);
            this.Controls.Add(this.chkSah);
            this.Controls.Add(this.showSahista);
            this.Controls.Add(this.dgv1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormNova";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Šahovska Federacija";
            this.Load += new System.EventHandler(this.FormNova_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv1;
        private System.Windows.Forms.Button showSahista;
        private System.Windows.Forms.CheckedListBox chkSah;
        private System.Windows.Forms.Button btnIzmeni;
        private System.Windows.Forms.Button showOrgan;
        private System.Windows.Forms.Button showSpon;
        private System.Windows.Forms.Button showTurnir;
        private System.Windows.Forms.CheckedListBox chkNacin;
        private System.Windows.Forms.CheckBox chkTak;
        private System.Windows.Forms.CheckBox chkEgz;
        private System.Windows.Forms.CheckedListBox chkTipT;
        private System.Windows.Forms.CheckedListBox chkTipE;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnVezaOrgSpon;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem dodajToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sahistaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem turnirToolStripMenuItem;
        private System.Windows.Forms.Label lblNaslov;
        private System.Windows.Forms.Button btnDodajPartiju;
        private System.Windows.Forms.Button btnPrikazPartije;
        private System.Windows.Forms.Button btnPromovisi;
        private System.Windows.Forms.Button btnOtpusti;
        private System.Windows.Forms.Button showPotez;
    }
}
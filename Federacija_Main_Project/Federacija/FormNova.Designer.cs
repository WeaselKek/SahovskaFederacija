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
            this.btnDodajSahistu = new System.Windows.Forms.Button();
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
            this.btnDodajPartiju = new System.Windows.Forms.Button();
            this.btnDodajTurnir = new System.Windows.Forms.Button();
            this.btnVezaOrgSpon = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btnPromovisi = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv1
            // 
            this.dgv1.AllowUserToAddRows = false;
            this.dgv1.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgv1.ColumnHeadersHeight = 36;
            this.dgv1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgv1.Location = new System.Drawing.Point(24, 302);
            this.dgv1.Name = "dgv1";
            this.dgv1.Size = new System.Drawing.Size(1274, 378);
            this.dgv1.TabIndex = 0;
            this.dgv1.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgv1_ColumnHeaderMouseClick);
            // 
            // showSahista
            // 
            this.showSahista.Location = new System.Drawing.Point(24, 12);
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
            this.chkSah.Location = new System.Drawing.Point(24, 52);
            this.chkSah.Name = "chkSah";
            this.chkSah.Size = new System.Drawing.Size(162, 67);
            this.chkSah.TabIndex = 2;
            // 
            // btnDodajSahistu
            // 
            this.btnDodajSahistu.Location = new System.Drawing.Point(24, 125);
            this.btnDodajSahistu.Name = "btnDodajSahistu";
            this.btnDodajSahistu.Size = new System.Drawing.Size(182, 34);
            this.btnDodajSahistu.TabIndex = 3;
            this.btnDodajSahistu.Text = "Dodaj Novog Sahistu";
            this.btnDodajSahistu.UseVisualStyleBackColor = true;
            this.btnDodajSahistu.Click += new System.EventHandler(this.btnDodajSahistu_Click);
            // 
            // btnIzmeni
            // 
            this.btnIzmeni.Location = new System.Drawing.Point(24, 268);
            this.btnIzmeni.Name = "btnIzmeni";
            this.btnIzmeni.Size = new System.Drawing.Size(162, 28);
            this.btnIzmeni.TabIndex = 4;
            this.btnIzmeni.Text = "Izmeni Selektovani Podatak";
            this.btnIzmeni.UseVisualStyleBackColor = true;
            this.btnIzmeni.Click += new System.EventHandler(this.btnIzmeni_Click);
            // 
            // showOrgan
            // 
            this.showOrgan.Location = new System.Drawing.Point(1003, 7);
            this.showOrgan.Name = "showOrgan";
            this.showOrgan.Size = new System.Drawing.Size(111, 31);
            this.showOrgan.TabIndex = 5;
            this.showOrgan.Text = "Prikazi organizatore";
            this.showOrgan.UseVisualStyleBackColor = true;
            this.showOrgan.Click += new System.EventHandler(this.showOrgan_Click);
            // 
            // showSpon
            // 
            this.showSpon.Location = new System.Drawing.Point(1133, 6);
            this.showSpon.Name = "showSpon";
            this.showSpon.Size = new System.Drawing.Size(111, 31);
            this.showSpon.TabIndex = 6;
            this.showSpon.Text = "Prikazi sponzore";
            this.showSpon.UseVisualStyleBackColor = true;
            this.showSpon.Click += new System.EventHandler(this.showSpon_Click);
            // 
            // showTurnir
            // 
            this.showTurnir.Location = new System.Drawing.Point(659, 4);
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
            this.chkNacin.Location = new System.Drawing.Point(659, 49);
            this.chkNacin.Name = "chkNacin";
            this.chkNacin.Size = new System.Drawing.Size(102, 34);
            this.chkNacin.TabIndex = 8;
            // 
            // chkTak
            // 
            this.chkTak.AutoSize = true;
            this.chkTak.BackColor = System.Drawing.SystemColors.Menu;
            this.chkTak.Location = new System.Drawing.Point(659, 89);
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
            this.chkEgz.Location = new System.Drawing.Point(779, 89);
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
            this.chkTipT.Location = new System.Drawing.Point(659, 123);
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
            this.chkTipE.Location = new System.Drawing.Point(775, 123);
            this.chkTipE.Name = "chkTipE";
            this.chkTipE.Size = new System.Drawing.Size(95, 34);
            this.chkTipE.TabIndex = 12;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(273, 268);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(162, 28);
            this.btnDelete.TabIndex = 13;
            this.btnDelete.Text = "Izbrisi podatak";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnDodajPartiju
            // 
            this.btnDodajPartiju.Location = new System.Drawing.Point(273, 12);
            this.btnDodajPartiju.Name = "btnDodajPartiju";
            this.btnDodajPartiju.Size = new System.Drawing.Size(182, 34);
            this.btnDodajPartiju.TabIndex = 14;
            this.btnDodajPartiju.Text = "Dodaj partiju u turnir(WIP)";
            this.btnDodajPartiju.UseVisualStyleBackColor = true;
            this.btnDodajPartiju.Click += new System.EventHandler(this.btnDodajPartiju_Click);
            // 
            // btnDodajTurnir
            // 
            this.btnDodajTurnir.Location = new System.Drawing.Point(659, 187);
            this.btnDodajTurnir.Name = "btnDodajTurnir";
            this.btnDodajTurnir.Size = new System.Drawing.Size(137, 45);
            this.btnDodajTurnir.TabIndex = 15;
            this.btnDodajTurnir.Text = "DodajTurnir(Update se treba doda)";
            this.btnDodajTurnir.UseVisualStyleBackColor = true;
            this.btnDodajTurnir.Click += new System.EventHandler(this.btnDodajTurnir_Click);
            // 
            // btnVezaOrgSpon
            // 
            this.btnVezaOrgSpon.Location = new System.Drawing.Point(1023, 105);
            this.btnVezaOrgSpon.Name = "btnVezaOrgSpon";
            this.btnVezaOrgSpon.Size = new System.Drawing.Size(154, 38);
            this.btnVezaOrgSpon.TabIndex = 18;
            this.btnVezaOrgSpon.Text = "Menadzuj Organizatore i Sponzore u turnir";
            this.btnVezaOrgSpon.UseVisualStyleBackColor = true;
            this.btnVezaOrgSpon.Click += new System.EventHandler(this.btnVezaOrgSpon_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1020, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 21;
            this.label3.Text = "MARE";
            // 
            // btnPromovisi
            // 
            this.btnPromovisi.Location = new System.Drawing.Point(269, 126);
            this.btnPromovisi.Name = "btnPromovisi";
            this.btnPromovisi.Size = new System.Drawing.Size(182, 34);
            this.btnPromovisi.TabIndex = 22;
            this.btnPromovisi.Text = "Promovisi u sudiju";
            this.btnPromovisi.UseVisualStyleBackColor = true;
            this.btnPromovisi.Click += new System.EventHandler(this.btnPromovisi_Click);
            // 
            // FormNova
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1310, 692);
            this.Controls.Add(this.btnPromovisi);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnVezaOrgSpon);
            this.Controls.Add(this.btnDodajTurnir);
            this.Controls.Add(this.btnDodajPartiju);
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
            this.Controls.Add(this.btnDodajSahistu);
            this.Controls.Add(this.chkSah);
            this.Controls.Add(this.showSahista);
            this.Controls.Add(this.dgv1);
            this.Name = "FormNova";
            this.Text = "Šahovska Federacija";
            this.Load += new System.EventHandler(this.FormNova_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv1;
        private System.Windows.Forms.Button showSahista;
        private System.Windows.Forms.CheckedListBox chkSah;
        private System.Windows.Forms.Button btnDodajSahistu;
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
        private System.Windows.Forms.Button btnDodajPartiju;
        private System.Windows.Forms.Button btnDodajTurnir;
        private System.Windows.Forms.Button btnVezaOrgSpon;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnPromovisi;
    }
}
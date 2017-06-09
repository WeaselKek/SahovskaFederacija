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
            this.btnSahAdd = new System.Windows.Forms.Button();
            this.btnIzmeni = new System.Windows.Forms.Button();
            this.showOrgan = new System.Windows.Forms.Button();
            this.showSpon = new System.Windows.Forms.Button();
            this.showTurnir = new System.Windows.Forms.Button();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkedListBox2 = new System.Windows.Forms.CheckedListBox();
            this.checkedListBox3 = new System.Windows.Forms.CheckedListBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv1
            // 
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
            this.showSahista.Size = new System.Drawing.Size(142, 26);
            this.showSahista.TabIndex = 1;
            this.showSahista.Text = "Prikazi Sahiste";
            this.showSahista.UseVisualStyleBackColor = true;
            this.showSahista.Click += new System.EventHandler(this.showSahista_Click);
            // 
            // chkSah
            // 
            this.chkSah.CheckOnClick = true;
            this.chkSah.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkSah.FormattingEnabled = true;
            this.chkSah.Items.AddRange(new object[] {
            "Majstor",
            "Majstorski kandidat",
            "Obican clan"});
            this.chkSah.Location = new System.Drawing.Point(24, 44);
            this.chkSah.Name = "chkSah";
            this.chkSah.Size = new System.Drawing.Size(162, 67);
            this.chkSah.TabIndex = 2;
            // 
            // btnSahAdd
            // 
            this.btnSahAdd.Location = new System.Drawing.Point(29, 131);
            this.btnSahAdd.Name = "btnSahAdd";
            this.btnSahAdd.Size = new System.Drawing.Size(137, 28);
            this.btnSahAdd.TabIndex = 3;
            this.btnSahAdd.Text = "Dodaj Novog Sahistu";
            this.btnSahAdd.UseVisualStyleBackColor = true;
            this.btnSahAdd.Click += new System.EventHandler(this.btnSahAdd_Click);
            // 
            // btnIzmeni
            // 
            this.btnIzmeni.Location = new System.Drawing.Point(44, 268);
            this.btnIzmeni.Name = "btnIzmeni";
            this.btnIzmeni.Size = new System.Drawing.Size(162, 28);
            this.btnIzmeni.TabIndex = 4;
            this.btnIzmeni.Text = "Izmeni Selektovani Podatak";
            this.btnIzmeni.UseVisualStyleBackColor = true;
            this.btnIzmeni.Click += new System.EventHandler(this.btnIzmeni_Click);
            // 
            // showOrgan
            // 
            this.showOrgan.Location = new System.Drawing.Point(1023, 32);
            this.showOrgan.Name = "showOrgan";
            this.showOrgan.Size = new System.Drawing.Size(111, 31);
            this.showOrgan.TabIndex = 5;
            this.showOrgan.Text = "Prikazi organizatore";
            this.showOrgan.UseVisualStyleBackColor = true;
            this.showOrgan.Click += new System.EventHandler(this.showOrgan_Click);
            // 
            // showSpon
            // 
            this.showSpon.Location = new System.Drawing.Point(1187, 30);
            this.showSpon.Name = "showSpon";
            this.showSpon.Size = new System.Drawing.Size(111, 33);
            this.showSpon.TabIndex = 6;
            this.showSpon.Text = "Prikazi sponzore";
            this.showSpon.UseVisualStyleBackColor = true;
            this.showSpon.Click += new System.EventHandler(this.showSpon_Click);
            // 
            // showTurnir
            // 
            this.showTurnir.Location = new System.Drawing.Point(665, 32);
            this.showTurnir.Name = "showTurnir";
            this.showTurnir.Size = new System.Drawing.Size(182, 34);
            this.showTurnir.TabIndex = 7;
            this.showTurnir.Text = "Prikazi turnire";
            this.showTurnir.UseVisualStyleBackColor = true;
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.BackColor = System.Drawing.SystemColors.Menu;
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Items.AddRange(new object[] {
            "Normalan",
            "Brzopotezni"});
            this.checkedListBox1.Location = new System.Drawing.Point(665, 77);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(102, 34);
            this.checkedListBox1.TabIndex = 8;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.BackColor = System.Drawing.SystemColors.Menu;
            this.checkBox1.Location = new System.Drawing.Point(665, 117);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(83, 17);
            this.checkBox1.TabIndex = 9;
            this.checkBox1.Text = "Takmicarski";
            this.checkBox1.UseVisualStyleBackColor = false;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.BackColor = System.Drawing.SystemColors.Menu;
            this.checkBox2.Location = new System.Drawing.Point(785, 117);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(76, 17);
            this.checkBox2.TabIndex = 10;
            this.checkBox2.Text = "Egzibicioni";
            this.checkBox2.UseVisualStyleBackColor = false;
            // 
            // checkedListBox2
            // 
            this.checkedListBox2.BackColor = System.Drawing.SystemColors.Menu;
            this.checkedListBox2.FormattingEnabled = true;
            this.checkedListBox2.Items.AddRange(new object[] {
            "Nacionalni",
            "Regionalni",
            "Internacionalni"});
            this.checkedListBox2.Location = new System.Drawing.Point(665, 151);
            this.checkedListBox2.Name = "checkedListBox2";
            this.checkedListBox2.Size = new System.Drawing.Size(102, 79);
            this.checkedListBox2.TabIndex = 11;
            // 
            // checkedListBox3
            // 
            this.checkedListBox3.BackColor = System.Drawing.SystemColors.Menu;
            this.checkedListBox3.FormattingEnabled = true;
            this.checkedListBox3.Items.AddRange(new object[] {
            "Promotivni",
            "Humanitarni"});
            this.checkedListBox3.Location = new System.Drawing.Point(781, 151);
            this.checkedListBox3.Name = "checkedListBox3";
            this.checkedListBox3.Size = new System.Drawing.Size(95, 79);
            this.checkedListBox3.TabIndex = 12;
            // 
            // FormNova
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1310, 692);
            this.Controls.Add(this.checkedListBox3);
            this.Controls.Add(this.checkedListBox2);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.checkedListBox1);
            this.Controls.Add(this.showTurnir);
            this.Controls.Add(this.showSpon);
            this.Controls.Add(this.showOrgan);
            this.Controls.Add(this.btnIzmeni);
            this.Controls.Add(this.btnSahAdd);
            this.Controls.Add(this.chkSah);
            this.Controls.Add(this.showSahista);
            this.Controls.Add(this.dgv1);
            this.Name = "FormNova";
            this.Text = "Šahovska Federacija";
            ((System.ComponentModel.ISupportInitialize)(this.dgv1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv1;
        private System.Windows.Forms.Button showSahista;
        private System.Windows.Forms.CheckedListBox chkSah;
        private System.Windows.Forms.Button btnSahAdd;
        private System.Windows.Forms.Button btnIzmeni;
        private System.Windows.Forms.Button showOrgan;
        private System.Windows.Forms.Button showSpon;
        private System.Windows.Forms.Button showTurnir;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckedListBox checkedListBox2;
        private System.Windows.Forms.CheckedListBox checkedListBox3;
    }
}
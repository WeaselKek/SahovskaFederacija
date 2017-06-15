namespace Federacija
{
    partial class FormDodajPartija
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpDat = new System.Windows.Forms.DateTimePicker();
            this.txtPartVreme = new System.Windows.Forms.TextBox();
            this.txtPartTrajanje = new System.Windows.Forms.TextBox();
            this.grpIshod = new System.Windows.Forms.GroupBox();
            this.rdbCrni = new System.Windows.Forms.RadioButton();
            this.rdbRemi = new System.Windows.Forms.RadioButton();
            this.rdbBeli = new System.Windows.Forms.RadioButton();
            this.pnlPotez = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.lstPotez = new System.Windows.Forms.ListBox();
            this.btnObrisiPotez = new System.Windows.Forms.Button();
            this.btnIzmeniPotez = new System.Windows.Forms.Button();
            this.btnDodajPotez = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtVreme = new System.Windows.Forms.TextBox();
            this.txtKraj = new System.Windows.Forms.TextBox();
            this.txtPoc = new System.Windows.Forms.TextBox();
            this.lblRbr = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.dgvSahista = new System.Windows.Forms.DataGridView();
            this.btnBeli = new System.Windows.Forms.Button();
            this.btnCrni = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lblBeli = new System.Windows.Forms.Label();
            this.lblCrni = new System.Windows.Forms.Label();
            this.dgvSudija = new System.Windows.Forms.DataGridView();
            this.lblSudija = new System.Windows.Forms.Label();
            this.btnSudija = new System.Windows.Forms.Button();
            this.grpIshod.SuspendLayout();
            this.pnlPotez.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSahista)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSudija)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(35, 594);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 0;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnPotvrdi
            // 
            this.btnPotvrdi.Location = new System.Drawing.Point(846, 603);
            this.btnPotvrdi.Name = "btnPotvrdi";
            this.btnPotvrdi.Size = new System.Drawing.Size(82, 23);
            this.btnPotvrdi.TabIndex = 1;
            this.btnPotvrdi.Text = "Potvrdi";
            this.btnPotvrdi.UseVisualStyleBackColor = true;
            this.btnPotvrdi.Click += new System.EventHandler(this.btnPotvrdi_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(31, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "Turnir za koji se dodaje:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(216, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "label2";
            // 
            // dtpDat
            // 
            this.dtpDat.CustomFormat = "dd.MM.yyyy";
            this.dtpDat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDat.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDat.Location = new System.Drawing.Point(34, 61);
            this.dtpDat.Name = "dtpDat";
            this.dtpDat.Size = new System.Drawing.Size(149, 26);
            this.dtpDat.TabIndex = 4;
            // 
            // txtPartVreme
            // 
            this.txtPartVreme.Location = new System.Drawing.Point(34, 106);
            this.txtPartVreme.Name = "txtPartVreme";
            this.txtPartVreme.Size = new System.Drawing.Size(149, 20);
            this.txtPartVreme.TabIndex = 5;
            // 
            // txtPartTrajanje
            // 
            this.txtPartTrajanje.Location = new System.Drawing.Point(34, 156);
            this.txtPartTrajanje.Name = "txtPartTrajanje";
            this.txtPartTrajanje.Size = new System.Drawing.Size(149, 20);
            this.txtPartTrajanje.TabIndex = 6;
            // 
            // grpIshod
            // 
            this.grpIshod.Controls.Add(this.rdbCrni);
            this.grpIshod.Controls.Add(this.rdbRemi);
            this.grpIshod.Controls.Add(this.rdbBeli);
            this.grpIshod.Location = new System.Drawing.Point(37, 196);
            this.grpIshod.Name = "grpIshod";
            this.grpIshod.Size = new System.Drawing.Size(110, 109);
            this.grpIshod.TabIndex = 7;
            this.grpIshod.TabStop = false;
            this.grpIshod.Text = "Ishod";
            // 
            // rdbCrni
            // 
            this.rdbCrni.AutoSize = true;
            this.rdbCrni.Location = new System.Drawing.Point(11, 74);
            this.rdbCrni.Name = "rdbCrni";
            this.rdbCrni.Size = new System.Drawing.Size(40, 17);
            this.rdbCrni.TabIndex = 2;
            this.rdbCrni.TabStop = true;
            this.rdbCrni.Text = "0-1";
            this.rdbCrni.UseVisualStyleBackColor = true;
            // 
            // rdbRemi
            // 
            this.rdbRemi.AutoSize = true;
            this.rdbRemi.Location = new System.Drawing.Point(11, 51);
            this.rdbRemi.Name = "rdbRemi";
            this.rdbRemi.Size = new System.Drawing.Size(49, 17);
            this.rdbRemi.TabIndex = 1;
            this.rdbRemi.TabStop = true;
            this.rdbRemi.Text = "Remi";
            this.rdbRemi.UseVisualStyleBackColor = true;
            // 
            // rdbBeli
            // 
            this.rdbBeli.AutoSize = true;
            this.rdbBeli.Location = new System.Drawing.Point(11, 28);
            this.rdbBeli.Name = "rdbBeli";
            this.rdbBeli.Size = new System.Drawing.Size(40, 17);
            this.rdbBeli.TabIndex = 0;
            this.rdbBeli.TabStop = true;
            this.rdbBeli.Text = "1-0";
            this.rdbBeli.UseVisualStyleBackColor = true;
            // 
            // pnlPotez
            // 
            this.pnlPotez.Controls.Add(this.label9);
            this.pnlPotez.Controls.Add(this.lstPotez);
            this.pnlPotez.Controls.Add(this.btnObrisiPotez);
            this.pnlPotez.Controls.Add(this.btnIzmeniPotez);
            this.pnlPotez.Controls.Add(this.btnDodajPotez);
            this.pnlPotez.Controls.Add(this.label5);
            this.pnlPotez.Controls.Add(this.label4);
            this.pnlPotez.Controls.Add(this.label3);
            this.pnlPotez.Controls.Add(this.txtVreme);
            this.pnlPotez.Controls.Add(this.txtKraj);
            this.pnlPotez.Controls.Add(this.txtPoc);
            this.pnlPotez.Controls.Add(this.lblRbr);
            this.pnlPotez.Location = new System.Drawing.Point(487, 326);
            this.pnlPotez.Name = "pnlPotez";
            this.pnlPotez.Size = new System.Drawing.Size(477, 271);
            this.pnlPotez.TabIndex = 8;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(14, 17);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(59, 13);
            this.label9.TabIndex = 11;
            this.label9.Text = "Redni Broj:";
            // 
            // lstPotez
            // 
            this.lstPotez.FormattingEnabled = true;
            this.lstPotez.Location = new System.Drawing.Point(192, 16);
            this.lstPotez.Name = "lstPotez";
            this.lstPotez.Size = new System.Drawing.Size(238, 199);
            this.lstPotez.TabIndex = 10;
            this.lstPotez.SelectedIndexChanged += new System.EventHandler(this.lstPotez_SelectedIndexChanged);
            // 
            // btnObrisiPotez
            // 
            this.btnObrisiPotez.Location = new System.Drawing.Point(284, 229);
            this.btnObrisiPotez.Name = "btnObrisiPotez";
            this.btnObrisiPotez.Size = new System.Drawing.Size(109, 22);
            this.btnObrisiPotez.TabIndex = 9;
            this.btnObrisiPotez.Text = "Obrisi Poslednji";
            this.btnObrisiPotez.UseVisualStyleBackColor = true;
            this.btnObrisiPotez.Click += new System.EventHandler(this.btnObrisiPotez_Click);
            // 
            // btnIzmeniPotez
            // 
            this.btnIzmeniPotez.Location = new System.Drawing.Point(130, 229);
            this.btnIzmeniPotez.Name = "btnIzmeniPotez";
            this.btnIzmeniPotez.Size = new System.Drawing.Size(80, 23);
            this.btnIzmeniPotez.TabIndex = 8;
            this.btnIzmeniPotez.Text = "Izmeni Potez";
            this.btnIzmeniPotez.UseVisualStyleBackColor = true;
            this.btnIzmeniPotez.Click += new System.EventHandler(this.btnIzmeniPotez_Click);
            // 
            // btnDodajPotez
            // 
            this.btnDodajPotez.Location = new System.Drawing.Point(26, 229);
            this.btnDodajPotez.Name = "btnDodajPotez";
            this.btnDodajPotez.Size = new System.Drawing.Size(75, 23);
            this.btnDodajPotez.TabIndex = 7;
            this.btnDodajPotez.Text = "Dodaj Potez";
            this.btnDodajPotez.UseVisualStyleBackColor = true;
            this.btnDodajPotez.Click += new System.EventHandler(this.btnDodajPotez_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 156);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Vreme";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Krajnje polje";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Pocetno polje";
            // 
            // txtVreme
            // 
            this.txtVreme.Location = new System.Drawing.Point(17, 172);
            this.txtVreme.MaxLength = 10;
            this.txtVreme.Name = "txtVreme";
            this.txtVreme.Size = new System.Drawing.Size(99, 20);
            this.txtVreme.TabIndex = 3;
            // 
            // txtKraj
            // 
            this.txtKraj.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txtKraj.Location = new System.Drawing.Point(18, 116);
            this.txtKraj.MaxLength = 5;
            this.txtKraj.Name = "txtKraj";
            this.txtKraj.Size = new System.Drawing.Size(98, 20);
            this.txtKraj.TabIndex = 2;
            // 
            // txtPoc
            // 
            this.txtPoc.Location = new System.Drawing.Point(18, 64);
            this.txtPoc.MaxLength = 2;
            this.txtPoc.Name = "txtPoc";
            this.txtPoc.Size = new System.Drawing.Size(98, 20);
            this.txtPoc.TabIndex = 1;
            // 
            // lblRbr
            // 
            this.lblRbr.AutoSize = true;
            this.lblRbr.Location = new System.Drawing.Point(79, 17);
            this.lblRbr.Name = "lblRbr";
            this.lblRbr.Size = new System.Drawing.Size(37, 13);
            this.lblRbr.TabIndex = 0;
            this.lblRbr.Text = "Actual";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(40, 47);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Datum";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(34, 90);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "Vreme";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(34, 131);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(45, 13);
            this.label8.TabIndex = 11;
            this.label8.Text = "Trajanje";
            // 
            // dgvSahista
            // 
            this.dgvSahista.AllowUserToAddRows = false;
            this.dgvSahista.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvSahista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSahista.Location = new System.Drawing.Point(479, 21);
            this.dgvSahista.Name = "dgvSahista";
            this.dgvSahista.Size = new System.Drawing.Size(374, 194);
            this.dgvSahista.TabIndex = 12;
            // 
            // btnBeli
            // 
            this.btnBeli.Location = new System.Drawing.Point(485, 236);
            this.btnBeli.Name = "btnBeli";
            this.btnBeli.Size = new System.Drawing.Size(75, 23);
            this.btnBeli.TabIndex = 13;
            this.btnBeli.Text = "Dodaj Belog";
            this.btnBeli.UseVisualStyleBackColor = true;
            this.btnBeli.Click += new System.EventHandler(this.btnBeli_Click);
            // 
            // btnCrni
            // 
            this.btnCrni.Location = new System.Drawing.Point(794, 236);
            this.btnCrni.Name = "btnCrni";
            this.btnCrni.Size = new System.Drawing.Size(75, 23);
            this.btnCrni.TabIndex = 14;
            this.btnCrni.Text = "Dodaj Crnog";
            this.btnCrni.UseVisualStyleBackColor = true;
            this.btnCrni.Click += new System.EventHandler(this.btnCrni_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(476, 272);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(80, 13);
            this.label10.TabIndex = 15;
            this.label10.Text = "Trenutan Igrac:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(791, 272);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(80, 13);
            this.label11.TabIndex = 16;
            this.label11.Text = "Trenutan Igrac:";
            // 
            // lblBeli
            // 
            this.lblBeli.AutoSize = true;
            this.lblBeli.Location = new System.Drawing.Point(476, 291);
            this.lblBeli.Name = "lblBeli";
            this.lblBeli.Size = new System.Drawing.Size(62, 13);
            this.lblBeli.TabIndex = 17;
            this.lblBeli.Text = "Nije izabran";
            // 
            // lblCrni
            // 
            this.lblCrni.AutoSize = true;
            this.lblCrni.Location = new System.Drawing.Point(791, 291);
            this.lblCrni.Name = "lblCrni";
            this.lblCrni.Size = new System.Drawing.Size(62, 13);
            this.lblCrni.TabIndex = 18;
            this.lblCrni.Text = "Nije izabran";
            // 
            // dgvSudija
            // 
            this.dgvSudija.AllowUserToAddRows = false;
            this.dgvSudija.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvSudija.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSudija.Location = new System.Drawing.Point(34, 326);
            this.dgvSudija.Name = "dgvSudija";
            this.dgvSudija.Size = new System.Drawing.Size(405, 153);
            this.dgvSudija.TabIndex = 20;
            // 
            // lblSudija
            // 
            this.lblSudija.AutoSize = true;
            this.lblSudija.Location = new System.Drawing.Point(40, 528);
            this.lblSudija.Name = "lblSudija";
            this.lblSudija.Size = new System.Drawing.Size(63, 13);
            this.lblSudija.TabIndex = 21;
            this.lblSudija.Text = "Nije Izabran";
            // 
            // btnSudija
            // 
            this.btnSudija.Location = new System.Drawing.Point(48, 496);
            this.btnSudija.Name = "btnSudija";
            this.btnSudija.Size = new System.Drawing.Size(75, 23);
            this.btnSudija.TabIndex = 22;
            this.btnSudija.Text = "Dodaj Sudiju";
            this.btnSudija.UseVisualStyleBackColor = true;
            this.btnSudija.Click += new System.EventHandler(this.btnSudija_Click);
            // 
            // FormDodajPartija
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(992, 638);
            this.Controls.Add(this.btnSudija);
            this.Controls.Add(this.lblSudija);
            this.Controls.Add(this.dgvSudija);
            this.Controls.Add(this.lblCrni);
            this.Controls.Add(this.lblBeli);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.btnCrni);
            this.Controls.Add(this.btnBeli);
            this.Controls.Add(this.dgvSahista);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.pnlPotez);
            this.Controls.Add(this.grpIshod);
            this.Controls.Add(this.txtPartTrajanje);
            this.Controls.Add(this.txtPartVreme);
            this.Controls.Add(this.dtpDat);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnPotvrdi);
            this.Controls.Add(this.btnCancel);
            this.Name = "FormDodajPartija";
            this.Text = "FormDodajPartija";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormDodajPartija_FormClosing);
            this.Load += new System.EventHandler(this.FormDodajPartija_Load);
            this.grpIshod.ResumeLayout(false);
            this.grpIshod.PerformLayout();
            this.pnlPotez.ResumeLayout(false);
            this.pnlPotez.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSahista)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSudija)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnPotvrdi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpDat;
        private System.Windows.Forms.TextBox txtPartVreme;
        private System.Windows.Forms.TextBox txtPartTrajanje;
        private System.Windows.Forms.GroupBox grpIshod;
        private System.Windows.Forms.RadioButton rdbCrni;
        private System.Windows.Forms.RadioButton rdbRemi;
        private System.Windows.Forms.RadioButton rdbBeli;
        private System.Windows.Forms.Panel pnlPotez;
        private System.Windows.Forms.Label lblRbr;
        private System.Windows.Forms.ListBox lstPotez;
        private System.Windows.Forms.Button btnObrisiPotez;
        private System.Windows.Forms.Button btnIzmeniPotez;
        private System.Windows.Forms.Button btnDodajPotez;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtVreme;
        private System.Windows.Forms.TextBox txtKraj;
        private System.Windows.Forms.TextBox txtPoc;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridView dgvSahista;
        private System.Windows.Forms.Button btnBeli;
        private System.Windows.Forms.Button btnCrni;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lblBeli;
        private System.Windows.Forms.Label lblCrni;
        private System.Windows.Forms.DataGridView dgvSudija;
        private System.Windows.Forms.Label lblSudija;
        private System.Windows.Forms.Button btnSudija;
    }
}
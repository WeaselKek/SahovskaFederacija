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
            this.label18 = new System.Windows.Forms.Label();
            this.rdbCrni = new System.Windows.Forms.RadioButton();
            this.rdbRemi = new System.Windows.Forms.RadioButton();
            this.rdbBeli = new System.Windows.Forms.RadioButton();
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
            this.lblRbr = new System.Windows.Forms.Label();
            this.txtPoc = new System.Windows.Forms.TextBox();
            this.txtKraj = new System.Windows.Forms.TextBox();
            this.txtVreme = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnDodajPotez = new System.Windows.Forms.Button();
            this.btnIzmeniPotez = new System.Windows.Forms.Button();
            this.btnObrisiPotez = new System.Windows.Forms.Button();
            this.lstPotez = new System.Windows.Forms.ListBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.grpIshod.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSahista)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSudija)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(32, 596);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(82, 28);
            this.btnCancel.TabIndex = 0;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnPotvrdi
            // 
            this.btnPotvrdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPotvrdi.Location = new System.Drawing.Point(723, 596);
            this.btnPotvrdi.Name = "btnPotvrdi";
            this.btnPotvrdi.Size = new System.Drawing.Size(82, 28);
            this.btnPotvrdi.TabIndex = 1;
            this.btnPotvrdi.Text = "Potvrdi";
            this.btnPotvrdi.UseVisualStyleBackColor = true;
            this.btnPotvrdi.Click += new System.EventHandler(this.btnPotvrdi_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(31, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "Turnir: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(92, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 24);
            this.label2.TabIndex = 3;
            this.label2.Text = "label2";
            // 
            // dtpDat
            // 
            this.dtpDat.CustomFormat = "dd.MM.yyyy";
            this.dtpDat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDat.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDat.Location = new System.Drawing.Point(33, 92);
            this.dtpDat.Name = "dtpDat";
            this.dtpDat.Size = new System.Drawing.Size(149, 26);
            this.dtpDat.TabIndex = 4;
            // 
            // txtPartVreme
            // 
            this.txtPartVreme.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPartVreme.Location = new System.Drawing.Point(32, 149);
            this.txtPartVreme.MaxLength = 5;
            this.txtPartVreme.Name = "txtPartVreme";
            this.txtPartVreme.Size = new System.Drawing.Size(149, 23);
            this.txtPartVreme.TabIndex = 5;
            // 
            // txtPartTrajanje
            // 
            this.txtPartTrajanje.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPartTrajanje.Location = new System.Drawing.Point(32, 200);
            this.txtPartTrajanje.MaxLength = 5;
            this.txtPartTrajanje.Name = "txtPartTrajanje";
            this.txtPartTrajanje.Size = new System.Drawing.Size(149, 23);
            this.txtPartTrajanje.TabIndex = 6;
            // 
            // grpIshod
            // 
            this.grpIshod.Controls.Add(this.label18);
            this.grpIshod.Controls.Add(this.rdbCrni);
            this.grpIshod.Controls.Add(this.rdbRemi);
            this.grpIshod.Controls.Add(this.rdbBeli);
            this.grpIshod.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpIshod.Location = new System.Drawing.Point(218, 100);
            this.grpIshod.Name = "grpIshod";
            this.grpIshod.Size = new System.Drawing.Size(110, 109);
            this.grpIshod.TabIndex = 7;
            this.grpIshod.TabStop = false;
            this.grpIshod.Text = "Ishod";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.Color.Red;
            this.label18.Location = new System.Drawing.Point(43, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(15, 20);
            this.label18.TabIndex = 40;
            this.label18.Text = "*";
            // 
            // rdbCrni
            // 
            this.rdbCrni.AutoSize = true;
            this.rdbCrni.Location = new System.Drawing.Point(11, 74);
            this.rdbCrni.Name = "rdbCrni";
            this.rdbCrni.Size = new System.Drawing.Size(47, 21);
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
            this.rdbRemi.Size = new System.Drawing.Size(58, 21);
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
            this.rdbBeli.Size = new System.Drawing.Size(47, 21);
            this.rdbBeli.TabIndex = 0;
            this.rdbBeli.TabStop = true;
            this.rdbBeli.Text = "1-0";
            this.rdbBeli.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(32, 72);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 17);
            this.label6.TabIndex = 9;
            this.label6.Text = "Datum";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(32, 129);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 17);
            this.label7.TabIndex = 10;
            this.label7.Text = "Vreme";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(32, 180);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(60, 17);
            this.label8.TabIndex = 11;
            this.label8.Text = "Trajanje";
            // 
            // dgvSahista
            // 
            this.dgvSahista.AllowUserToAddRows = false;
            this.dgvSahista.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvSahista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSahista.Location = new System.Drawing.Point(32, 345);
            this.dgvSahista.Name = "dgvSahista";
            this.dgvSahista.Size = new System.Drawing.Size(386, 244);
            this.dgvSahista.TabIndex = 12;
            // 
            // btnBeli
            // 
            this.btnBeli.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBeli.Location = new System.Drawing.Point(32, 314);
            this.btnBeli.Name = "btnBeli";
            this.btnBeli.Size = new System.Drawing.Size(109, 23);
            this.btnBeli.TabIndex = 13;
            this.btnBeli.Text = "Izaberi Belog";
            this.btnBeli.UseVisualStyleBackColor = true;
            this.btnBeli.Click += new System.EventHandler(this.btnBeli_Click);
            // 
            // btnCrni
            // 
            this.btnCrni.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCrni.Location = new System.Drawing.Point(322, 314);
            this.btnCrni.Name = "btnCrni";
            this.btnCrni.Size = new System.Drawing.Size(96, 23);
            this.btnCrni.TabIndex = 14;
            this.btnCrni.Text = "Izaberi Crnog";
            this.btnCrni.UseVisualStyleBackColor = true;
            this.btnCrni.Click += new System.EventHandler(this.btnCrni_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(32, 258);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(70, 17);
            this.label10.TabIndex = 15;
            this.label10.Text = "Beli Igrac:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(346, 258);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(72, 17);
            this.label11.TabIndex = 16;
            this.label11.Text = "Crni Igrac:";
            // 
            // lblBeli
            // 
            this.lblBeli.AutoSize = true;
            this.lblBeli.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBeli.Location = new System.Drawing.Point(31, 275);
            this.lblBeli.Name = "lblBeli";
            this.lblBeli.Size = new System.Drawing.Size(109, 24);
            this.lblBeli.TabIndex = 17;
            this.lblBeli.Text = "Nije izabran";
            // 
            // lblCrni
            // 
            this.lblCrni.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblCrni.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCrni.Location = new System.Drawing.Point(182, 275);
            this.lblCrni.Name = "lblCrni";
            this.lblCrni.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblCrni.Size = new System.Drawing.Size(236, 24);
            this.lblCrni.TabIndex = 18;
            this.lblCrni.Text = "Nije izabran";
            this.lblCrni.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // dgvSudija
            // 
            this.dgvSudija.AllowUserToAddRows = false;
            this.dgvSudija.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvSudija.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSudija.Location = new System.Drawing.Point(472, 59);
            this.dgvSudija.Name = "dgvSudija";
            this.dgvSudija.Size = new System.Drawing.Size(306, 120);
            this.dgvSudija.TabIndex = 20;
            // 
            // lblSudija
            // 
            this.lblSudija.AutoSize = true;
            this.lblSudija.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSudija.Location = new System.Drawing.Point(564, 211);
            this.lblSudija.Name = "lblSudija";
            this.lblSudija.Size = new System.Drawing.Size(85, 18);
            this.lblSudija.TabIndex = 21;
            this.lblSudija.Text = "Nije Izabran";
            // 
            // btnSudija
            // 
            this.btnSudija.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSudija.Location = new System.Drawing.Point(472, 186);
            this.btnSudija.Name = "btnSudija";
            this.btnSudija.Size = new System.Drawing.Size(98, 23);
            this.btnSudija.TabIndex = 22;
            this.btnSudija.Text = "Izaberi Sudiju";
            this.btnSudija.UseVisualStyleBackColor = true;
            this.btnSudija.Click += new System.EventHandler(this.btnSudija_Click);
            // 
            // lblRbr
            // 
            this.lblRbr.AutoSize = true;
            this.lblRbr.Location = new System.Drawing.Point(76, 48);
            this.lblRbr.Name = "lblRbr";
            this.lblRbr.Size = new System.Drawing.Size(40, 15);
            this.lblRbr.TabIndex = 0;
            this.lblRbr.Text = "Actual";
            // 
            // txtPoc
            // 
            this.txtPoc.Location = new System.Drawing.Point(12, 96);
            this.txtPoc.MaxLength = 2;
            this.txtPoc.Name = "txtPoc";
            this.txtPoc.Size = new System.Drawing.Size(98, 21);
            this.txtPoc.TabIndex = 1;
            // 
            // txtKraj
            // 
            this.txtKraj.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txtKraj.Location = new System.Drawing.Point(12, 148);
            this.txtKraj.MaxLength = 5;
            this.txtKraj.Name = "txtKraj";
            this.txtKraj.Size = new System.Drawing.Size(98, 21);
            this.txtKraj.TabIndex = 2;
            // 
            // txtVreme
            // 
            this.txtVreme.Location = new System.Drawing.Point(11, 204);
            this.txtVreme.MaxLength = 10;
            this.txtVreme.Name = "txtVreme";
            this.txtVreme.Size = new System.Drawing.Size(99, 21);
            this.txtVreme.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Pocetno polje";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 132);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 15);
            this.label4.TabIndex = 5;
            this.label4.Text = "Krajnje polje";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 188);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 15);
            this.label5.TabIndex = 6;
            this.label5.Text = "Vreme";
            // 
            // btnDodajPotez
            // 
            this.btnDodajPotez.Location = new System.Drawing.Point(11, 258);
            this.btnDodajPotez.Name = "btnDodajPotez";
            this.btnDodajPotez.Size = new System.Drawing.Size(75, 23);
            this.btnDodajPotez.TabIndex = 7;
            this.btnDodajPotez.Text = "Dodaj Potez";
            this.btnDodajPotez.UseVisualStyleBackColor = true;
            this.btnDodajPotez.Click += new System.EventHandler(this.btnDodajPotez_Click);
            // 
            // btnIzmeniPotez
            // 
            this.btnIzmeniPotez.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIzmeniPotez.Location = new System.Drawing.Point(102, 257);
            this.btnIzmeniPotez.Name = "btnIzmeniPotez";
            this.btnIzmeniPotez.Size = new System.Drawing.Size(85, 23);
            this.btnIzmeniPotez.TabIndex = 8;
            this.btnIzmeniPotez.Text = "Izmeni Potez";
            this.btnIzmeniPotez.UseVisualStyleBackColor = true;
            this.btnIzmeniPotez.Click += new System.EventHandler(this.btnIzmeniPotez_Click);
            // 
            // btnObrisiPotez
            // 
            this.btnObrisiPotez.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnObrisiPotez.Location = new System.Drawing.Point(204, 258);
            this.btnObrisiPotez.Name = "btnObrisiPotez";
            this.btnObrisiPotez.Size = new System.Drawing.Size(109, 22);
            this.btnObrisiPotez.TabIndex = 9;
            this.btnObrisiPotez.Text = "Obrisi Poslednji";
            this.btnObrisiPotez.UseVisualStyleBackColor = true;
            this.btnObrisiPotez.Click += new System.EventHandler(this.btnObrisiPotez_Click);
            // 
            // lstPotez
            // 
            this.lstPotez.FormattingEnabled = true;
            this.lstPotez.ItemHeight = 15;
            this.lstPotez.Location = new System.Drawing.Point(152, 48);
            this.lstPotez.Name = "lstPotez";
            this.lstPotez.Size = new System.Drawing.Size(162, 184);
            this.lstPotez.TabIndex = 10;
            this.lstPotez.SelectedIndexChanged += new System.EventHandler(this.lstPotez_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(11, 48);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(68, 15);
            this.label9.TabIndex = 11;
            this.label9.Text = "Redni Broj:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(149, 25);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(50, 18);
            this.label12.TabIndex = 13;
            this.label12.Text = "Potezi";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(469, 212);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(89, 17);
            this.label13.TabIndex = 23;
            this.label13.Text = "Sudija meca:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.btnDodajPotez);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.lstPotez);
            this.groupBox1.Controls.Add(this.txtVreme);
            this.groupBox1.Controls.Add(this.txtKraj);
            this.groupBox1.Controls.Add(this.btnObrisiPotez);
            this.groupBox1.Controls.Add(this.btnIzmeniPotez);
            this.groupBox1.Controls.Add(this.txtPoc);
            this.groupBox1.Controls.Add(this.lblRbr);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(472, 275);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(334, 314);
            this.groupBox1.TabIndex = 24;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Potezi";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.Red;
            this.label14.Location = new System.Drawing.Point(187, 96);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(15, 20);
            this.label14.TabIndex = 36;
            this.label14.Text = "*";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.Red;
            this.label15.Location = new System.Drawing.Point(335, 258);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(15, 20);
            this.label15.TabIndex = 37;
            this.label15.Text = "*";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.Red;
            this.label16.Location = new System.Drawing.Point(20, 259);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(15, 20);
            this.label16.TabIndex = 38;
            this.label16.Text = "*";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.Red;
            this.label17.Location = new System.Drawing.Point(456, 210);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(15, 20);
            this.label17.TabIndex = 39;
            this.label17.Text = "*";
            // 
            // FormDodajPartija
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(854, 680);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label13);
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
            this.Controls.Add(this.grpIshod);
            this.Controls.Add(this.txtPartTrajanje);
            this.Controls.Add(this.txtPartVreme);
            this.Controls.Add(this.dtpDat);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnPotvrdi);
            this.Controls.Add(this.btnCancel);
            this.Name = "FormDodajPartija";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormDodajPartija";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormDodajPartija_FormClosing);
            this.Load += new System.EventHandler(this.FormDodajPartija_Load);
            this.grpIshod.ResumeLayout(false);
            this.grpIshod.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSahista)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSudija)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
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
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
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
        private System.Windows.Forms.Label lblRbr;
        private System.Windows.Forms.TextBox txtPoc;
        private System.Windows.Forms.TextBox txtKraj;
        private System.Windows.Forms.TextBox txtVreme;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnDodajPotez;
        private System.Windows.Forms.Button btnIzmeniPotez;
        private System.Windows.Forms.Button btnObrisiPotez;
        private System.Windows.Forms.ListBox lstPotez;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
    }
}
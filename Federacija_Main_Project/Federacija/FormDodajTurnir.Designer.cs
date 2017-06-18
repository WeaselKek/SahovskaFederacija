namespace Federacija
{
    partial class FormDodajTurnir
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
            this.txtNaziv = new System.Windows.Forms.TextBox();
            this.txtGodina = new System.Windows.Forms.TextBox();
            this.txtDrzava = new System.Windows.Forms.TextBox();
            this.txtGrad = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.grbZnacaj = new System.Windows.Forms.GroupBox();
            this.rbEgzibicioni = new System.Windows.Forms.RadioButton();
            this.rbTakmicarski = new System.Windows.Forms.RadioButton();
            this.grbEgzibicioni = new System.Windows.Forms.GroupBox();
            this.rbHumanitarni = new System.Windows.Forms.RadioButton();
            this.rbPromotivni = new System.Windows.Forms.RadioButton();
            this.grbNacinOdigravanja = new System.Windows.Forms.GroupBox();
            this.rbNormalan = new System.Windows.Forms.RadioButton();
            this.rbBrzopotezni = new System.Windows.Forms.RadioButton();
            this.grbTakmicarski = new System.Windows.Forms.GroupBox();
            this.rbInternacionalni = new System.Windows.Forms.RadioButton();
            this.rbNacionalni = new System.Windows.Forms.RadioButton();
            this.rbRegionalni = new System.Windows.Forms.RadioButton();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtNamena = new System.Windows.Forms.TextBox();
            this.txtNovac = new System.Windows.Forms.TextBox();
            this.panelNovacNamena = new System.Windows.Forms.Panel();
            this.dtpDatumOD = new System.Windows.Forms.DateTimePicker();
            this.dtpDatumDO = new System.Windows.Forms.DateTimePicker();
            this.panelTrajanjePartije = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.txtTrajanje = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.grbZnacaj.SuspendLayout();
            this.grbEgzibicioni.SuspendLayout();
            this.grbNacinOdigravanja.SuspendLayout();
            this.grbTakmicarski.SuspendLayout();
            this.panelNovacNamena.SuspendLayout();
            this.panelTrajanjePartije.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(48, 433);
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
            this.btnPotvrdi.Location = new System.Drawing.Point(418, 433);
            this.btnPotvrdi.Name = "btnPotvrdi";
            this.btnPotvrdi.Size = new System.Drawing.Size(82, 28);
            this.btnPotvrdi.TabIndex = 1;
            this.btnPotvrdi.Text = "Potvrdi";
            this.btnPotvrdi.UseVisualStyleBackColor = true;
            this.btnPotvrdi.Click += new System.EventHandler(this.btnPotvrdi_Click);
            // 
            // txtNaziv
            // 
            this.txtNaziv.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNaziv.Location = new System.Drawing.Point(48, 49);
            this.txtNaziv.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtNaziv.MaxLength = 30;
            this.txtNaziv.Name = "txtNaziv";
            this.txtNaziv.Size = new System.Drawing.Size(162, 23);
            this.txtNaziv.TabIndex = 2;
            // 
            // txtGodina
            // 
            this.txtGodina.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGodina.Location = new System.Drawing.Point(48, 111);
            this.txtGodina.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtGodina.MaxLength = 4;
            this.txtGodina.Name = "txtGodina";
            this.txtGodina.Size = new System.Drawing.Size(92, 23);
            this.txtGodina.TabIndex = 3;
            this.txtGodina.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtGodina_KeyPress);
            // 
            // txtDrzava
            // 
            this.txtDrzava.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDrzava.Location = new System.Drawing.Point(48, 232);
            this.txtDrzava.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtDrzava.MaxLength = 30;
            this.txtDrzava.Name = "txtDrzava";
            this.txtDrzava.Size = new System.Drawing.Size(162, 23);
            this.txtDrzava.TabIndex = 4;
            // 
            // txtGrad
            // 
            this.txtGrad.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGrad.Location = new System.Drawing.Point(48, 169);
            this.txtGrad.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtGrad.MaxLength = 30;
            this.txtGrad.Name = "txtGrad";
            this.txtGrad.Size = new System.Drawing.Size(162, 23);
            this.txtGrad.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(46, 30);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "Naziv turnira";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(46, 93);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 17);
            this.label2.TabIndex = 9;
            this.label2.Text = "Godina odrzavanja";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(46, 150);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 17);
            this.label3.TabIndex = 10;
            this.label3.Text = "Grad";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(47, 213);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 17);
            this.label4.TabIndex = 11;
            this.label4.Text = "Drzava";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(46, 272);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 17);
            this.label5.TabIndex = 12;
            this.label5.Text = "Datum od";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(47, 328);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 17);
            this.label6.TabIndex = 13;
            this.label6.Text = "Datum do";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(338, 15);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 18);
            this.label7.TabIndex = 14;
            this.label7.Text = "Tip turnira";
            // 
            // grbZnacaj
            // 
            this.grbZnacaj.Controls.Add(this.rbEgzibicioni);
            this.grbZnacaj.Controls.Add(this.rbTakmicarski);
            this.grbZnacaj.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbZnacaj.Location = new System.Drawing.Point(254, 135);
            this.grbZnacaj.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grbZnacaj.Name = "grbZnacaj";
            this.grbZnacaj.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grbZnacaj.Size = new System.Drawing.Size(248, 58);
            this.grbZnacaj.TabIndex = 15;
            this.grbZnacaj.TabStop = false;
            this.grbZnacaj.Text = "Znacaj";
            // 
            // rbEgzibicioni
            // 
            this.rbEgzibicioni.AutoSize = true;
            this.rbEgzibicioni.Location = new System.Drawing.Point(8, 29);
            this.rbEgzibicioni.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rbEgzibicioni.Name = "rbEgzibicioni";
            this.rbEgzibicioni.Size = new System.Drawing.Size(85, 19);
            this.rbEgzibicioni.TabIndex = 1;
            this.rbEgzibicioni.TabStop = true;
            this.rbEgzibicioni.Text = "Egzibicioni";
            this.rbEgzibicioni.UseVisualStyleBackColor = true;
            this.rbEgzibicioni.CheckedChanged += new System.EventHandler(this.rbEgzibicioni_CheckedChanged);
            // 
            // rbTakmicarski
            // 
            this.rbTakmicarski.AutoSize = true;
            this.rbTakmicarski.Location = new System.Drawing.Point(136, 29);
            this.rbTakmicarski.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rbTakmicarski.Name = "rbTakmicarski";
            this.rbTakmicarski.Size = new System.Drawing.Size(91, 19);
            this.rbTakmicarski.TabIndex = 0;
            this.rbTakmicarski.TabStop = true;
            this.rbTakmicarski.Text = "Takmicarski";
            this.rbTakmicarski.UseVisualStyleBackColor = true;
            this.rbTakmicarski.CheckedChanged += new System.EventHandler(this.rbTakmicarski_CheckedChanged);
            // 
            // grbEgzibicioni
            // 
            this.grbEgzibicioni.Controls.Add(this.rbHumanitarni);
            this.grbEgzibicioni.Controls.Add(this.rbPromotivni);
            this.grbEgzibicioni.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbEgzibicioni.Location = new System.Drawing.Point(254, 197);
            this.grbEgzibicioni.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grbEgzibicioni.Name = "grbEgzibicioni";
            this.grbEgzibicioni.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grbEgzibicioni.Size = new System.Drawing.Size(123, 87);
            this.grbEgzibicioni.TabIndex = 16;
            this.grbEgzibicioni.TabStop = false;
            this.grbEgzibicioni.EnabledChanged += new System.EventHandler(this.grbEgzibicioni_EnabledChanged);
            // 
            // rbHumanitarni
            // 
            this.rbHumanitarni.AutoSize = true;
            this.rbHumanitarni.Location = new System.Drawing.Point(9, 39);
            this.rbHumanitarni.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rbHumanitarni.Name = "rbHumanitarni";
            this.rbHumanitarni.Size = new System.Drawing.Size(93, 19);
            this.rbHumanitarni.TabIndex = 1;
            this.rbHumanitarni.TabStop = true;
            this.rbHumanitarni.Text = "Humanitarni";
            this.rbHumanitarni.UseVisualStyleBackColor = true;
            this.rbHumanitarni.CheckedChanged += new System.EventHandler(this.rbHumanitarni_CheckedChanged);
            // 
            // rbPromotivni
            // 
            this.rbPromotivni.AutoSize = true;
            this.rbPromotivni.Location = new System.Drawing.Point(9, 17);
            this.rbPromotivni.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rbPromotivni.Name = "rbPromotivni";
            this.rbPromotivni.Size = new System.Drawing.Size(83, 19);
            this.rbPromotivni.TabIndex = 0;
            this.rbPromotivni.TabStop = true;
            this.rbPromotivni.Text = "Promotivni";
            this.rbPromotivni.UseVisualStyleBackColor = true;
            // 
            // grbNacinOdigravanja
            // 
            this.grbNacinOdigravanja.Controls.Add(this.rbNormalan);
            this.grbNacinOdigravanja.Controls.Add(this.rbBrzopotezni);
            this.grbNacinOdigravanja.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbNacinOdigravanja.Location = new System.Drawing.Point(254, 46);
            this.grbNacinOdigravanja.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grbNacinOdigravanja.Name = "grbNacinOdigravanja";
            this.grbNacinOdigravanja.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grbNacinOdigravanja.Size = new System.Drawing.Size(123, 84);
            this.grbNacinOdigravanja.TabIndex = 16;
            this.grbNacinOdigravanja.TabStop = false;
            this.grbNacinOdigravanja.Text = "Nacin odigravanja";
            // 
            // rbNormalan
            // 
            this.rbNormalan.AutoSize = true;
            this.rbNormalan.Location = new System.Drawing.Point(9, 26);
            this.rbNormalan.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rbNormalan.Name = "rbNormalan";
            this.rbNormalan.Size = new System.Drawing.Size(80, 19);
            this.rbNormalan.TabIndex = 1;
            this.rbNormalan.TabStop = true;
            this.rbNormalan.Text = "Normalan";
            this.rbNormalan.UseVisualStyleBackColor = true;
            // 
            // rbBrzopotezni
            // 
            this.rbBrzopotezni.AutoSize = true;
            this.rbBrzopotezni.Location = new System.Drawing.Point(9, 57);
            this.rbBrzopotezni.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rbBrzopotezni.Name = "rbBrzopotezni";
            this.rbBrzopotezni.Size = new System.Drawing.Size(90, 19);
            this.rbBrzopotezni.TabIndex = 0;
            this.rbBrzopotezni.TabStop = true;
            this.rbBrzopotezni.Text = "Brzopotezni";
            this.rbBrzopotezni.UseVisualStyleBackColor = true;
            this.rbBrzopotezni.CheckedChanged += new System.EventHandler(this.rbBrzopotezni_CheckedChanged);
            // 
            // grbTakmicarski
            // 
            this.grbTakmicarski.Controls.Add(this.rbInternacionalni);
            this.grbTakmicarski.Controls.Add(this.rbNacionalni);
            this.grbTakmicarski.Controls.Add(this.rbRegionalni);
            this.grbTakmicarski.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbTakmicarski.Location = new System.Drawing.Point(381, 197);
            this.grbTakmicarski.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grbTakmicarski.Name = "grbTakmicarski";
            this.grbTakmicarski.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grbTakmicarski.Size = new System.Drawing.Size(121, 87);
            this.grbTakmicarski.TabIndex = 17;
            this.grbTakmicarski.TabStop = false;
            this.grbTakmicarski.EnabledChanged += new System.EventHandler(this.grbTakmicarski_EnabledChanged);
            // 
            // rbInternacionalni
            // 
            this.rbInternacionalni.AutoSize = true;
            this.rbInternacionalni.Location = new System.Drawing.Point(9, 62);
            this.rbInternacionalni.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rbInternacionalni.Name = "rbInternacionalni";
            this.rbInternacionalni.Size = new System.Drawing.Size(106, 19);
            this.rbInternacionalni.TabIndex = 4;
            this.rbInternacionalni.TabStop = true;
            this.rbInternacionalni.Text = "Internacionalni";
            this.rbInternacionalni.UseVisualStyleBackColor = true;
            // 
            // rbNacionalni
            // 
            this.rbNacionalni.AutoSize = true;
            this.rbNacionalni.Location = new System.Drawing.Point(9, 40);
            this.rbNacionalni.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rbNacionalni.Name = "rbNacionalni";
            this.rbNacionalni.Size = new System.Drawing.Size(84, 19);
            this.rbNacionalni.TabIndex = 3;
            this.rbNacionalni.TabStop = true;
            this.rbNacionalni.Text = "Nacionalni";
            this.rbNacionalni.UseVisualStyleBackColor = true;
            // 
            // rbRegionalni
            // 
            this.rbRegionalni.AutoSize = true;
            this.rbRegionalni.Location = new System.Drawing.Point(9, 18);
            this.rbRegionalni.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rbRegionalni.Name = "rbRegionalni";
            this.rbRegionalni.Size = new System.Drawing.Size(85, 19);
            this.rbRegionalni.TabIndex = 2;
            this.rbRegionalni.TabStop = true;
            this.rbRegionalni.Text = "Regionalni";
            this.rbRegionalni.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(8, 54);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(90, 15);
            this.label8.TabIndex = 26;
            this.label8.Text = "Namena novca";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(8, 6);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(41, 15);
            this.label9.TabIndex = 25;
            this.label9.Text = "Novac";
            // 
            // txtNamena
            // 
            this.txtNamena.Location = new System.Drawing.Point(8, 70);
            this.txtNamena.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtNamena.MaxLength = 30;
            this.txtNamena.Name = "txtNamena";
            this.txtNamena.Size = new System.Drawing.Size(135, 21);
            this.txtNamena.TabIndex = 24;
            // 
            // txtNovac
            // 
            this.txtNovac.Location = new System.Drawing.Point(8, 22);
            this.txtNovac.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtNovac.MaxLength = 10;
            this.txtNovac.Name = "txtNovac";
            this.txtNovac.Size = new System.Drawing.Size(135, 21);
            this.txtNovac.TabIndex = 23;
            this.txtNovac.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNovac_KeyPress);
            // 
            // panelNovacNamena
            // 
            this.panelNovacNamena.Controls.Add(this.label8);
            this.panelNovacNamena.Controls.Add(this.label9);
            this.panelNovacNamena.Controls.Add(this.txtNamena);
            this.panelNovacNamena.Controls.Add(this.txtNovac);
            this.panelNovacNamena.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelNovacNamena.Location = new System.Drawing.Point(254, 289);
            this.panelNovacNamena.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panelNovacNamena.Name = "panelNovacNamena";
            this.panelNovacNamena.Size = new System.Drawing.Size(248, 109);
            this.panelNovacNamena.TabIndex = 27;
            this.panelNovacNamena.EnabledChanged += new System.EventHandler(this.panelNovacNamena_EnabledChanged);
            // 
            // dtpDatumOD
            // 
            this.dtpDatumOD.CustomFormat = "dd.MMM.yyyy.";
            this.dtpDatumOD.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDatumOD.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDatumOD.Location = new System.Drawing.Point(48, 295);
            this.dtpDatumOD.Name = "dtpDatumOD";
            this.dtpDatumOD.Size = new System.Drawing.Size(142, 23);
            this.dtpDatumOD.TabIndex = 30;
            // 
            // dtpDatumDO
            // 
            this.dtpDatumDO.CustomFormat = "dd.MMM.yyyy.";
            this.dtpDatumDO.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDatumDO.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDatumDO.Location = new System.Drawing.Point(48, 351);
            this.dtpDatumDO.Name = "dtpDatumDO";
            this.dtpDatumDO.Size = new System.Drawing.Size(142, 23);
            this.dtpDatumDO.TabIndex = 31;
            // 
            // panelTrajanjePartije
            // 
            this.panelTrajanjePartije.Controls.Add(this.label10);
            this.panelTrajanjePartije.Controls.Add(this.txtTrajanje);
            this.panelTrajanjePartije.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelTrajanjePartije.Location = new System.Drawing.Point(386, 55);
            this.panelTrajanjePartije.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panelTrajanjePartije.Name = "panelTrajanjePartije";
            this.panelTrajanjePartije.Size = new System.Drawing.Size(116, 42);
            this.panelTrajanjePartije.TabIndex = 32;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(2, 2);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(89, 15);
            this.label10.TabIndex = 1;
            this.label10.Text = "Trajanje partije";
            // 
            // txtTrajanje
            // 
            this.txtTrajanje.Location = new System.Drawing.Point(4, 18);
            this.txtTrajanje.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtTrajanje.MaxLength = 3;
            this.txtTrajanje.Name = "txtTrajanje";
            this.txtTrajanje.Size = new System.Drawing.Size(92, 21);
            this.txtTrajanje.TabIndex = 0;
            this.txtTrajanje.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTrajanje_KeyPress);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.Red;
            this.label13.Location = new System.Drawing.Point(214, 50);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(15, 20);
            this.label13.TabIndex = 33;
            this.label13.Text = "*";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Red;
            this.label11.Location = new System.Drawing.Point(144, 113);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(15, 20);
            this.label11.TabIndex = 34;
            this.label11.Text = "*";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Red;
            this.label12.Location = new System.Drawing.Point(214, 171);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(15, 20);
            this.label12.TabIndex = 35;
            this.label12.Text = "*";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.Red;
            this.label14.Location = new System.Drawing.Point(214, 233);
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
            this.label15.Location = new System.Drawing.Point(195, 297);
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
            this.label16.Location = new System.Drawing.Point(195, 353);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(15, 20);
            this.label16.TabIndex = 38;
            this.label16.Text = "*";
            // 
            // FormDodajTurnir
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(542, 472);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.panelTrajanjePartije);
            this.Controls.Add(this.dtpDatumDO);
            this.Controls.Add(this.dtpDatumOD);
            this.Controls.Add(this.panelNovacNamena);
            this.Controls.Add(this.grbTakmicarski);
            this.Controls.Add(this.grbNacinOdigravanja);
            this.Controls.Add(this.grbEgzibicioni);
            this.Controls.Add(this.grbZnacaj);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtGrad);
            this.Controls.Add(this.txtDrzava);
            this.Controls.Add(this.txtGodina);
            this.Controls.Add(this.txtNaziv);
            this.Controls.Add(this.btnPotvrdi);
            this.Controls.Add(this.btnCancel);
            this.Name = "FormDodajTurnir";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dodaj Turnir";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormDodajTurnir_FormClosing);
            this.Load += new System.EventHandler(this.FormDodajTurnir_Load);
            this.grbZnacaj.ResumeLayout(false);
            this.grbZnacaj.PerformLayout();
            this.grbEgzibicioni.ResumeLayout(false);
            this.grbEgzibicioni.PerformLayout();
            this.grbNacinOdigravanja.ResumeLayout(false);
            this.grbNacinOdigravanja.PerformLayout();
            this.grbTakmicarski.ResumeLayout(false);
            this.grbTakmicarski.PerformLayout();
            this.panelNovacNamena.ResumeLayout(false);
            this.panelNovacNamena.PerformLayout();
            this.panelTrajanjePartije.ResumeLayout(false);
            this.panelTrajanjePartije.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnPotvrdi;
        private System.Windows.Forms.TextBox txtNaziv;
        private System.Windows.Forms.TextBox txtGodina;
        private System.Windows.Forms.TextBox txtDrzava;
        private System.Windows.Forms.TextBox txtGrad;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox grbZnacaj;
        private System.Windows.Forms.RadioButton rbEgzibicioni;
        private System.Windows.Forms.RadioButton rbTakmicarski;
        private System.Windows.Forms.GroupBox grbEgzibicioni;
        private System.Windows.Forms.GroupBox grbNacinOdigravanja;
        private System.Windows.Forms.RadioButton rbNormalan;
        private System.Windows.Forms.RadioButton rbBrzopotezni;
        private System.Windows.Forms.GroupBox grbTakmicarski;
        private System.Windows.Forms.RadioButton rbHumanitarni;
        private System.Windows.Forms.RadioButton rbPromotivni;
        private System.Windows.Forms.RadioButton rbInternacionalni;
        private System.Windows.Forms.RadioButton rbNacionalni;
        private System.Windows.Forms.RadioButton rbRegionalni;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtNamena;
        private System.Windows.Forms.TextBox txtNovac;
        private System.Windows.Forms.Panel panelNovacNamena;
        private System.Windows.Forms.DateTimePicker dtpDatumOD;
        private System.Windows.Forms.DateTimePicker dtpDatumDO;
        private System.Windows.Forms.Panel panelTrajanjePartije;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtTrajanje;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
    }
}
namespace Federacija
{
    partial class FormDodajSah
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtIme = new System.Windows.Forms.TextBox();
            this.txtPrezime = new System.Windows.Forms.TextBox();
            this.txtDrz = new System.Windows.Forms.TextBox();
            this.txtPasos = new System.Windows.Forms.TextBox();
            this.txtUlica = new System.Windows.Forms.TextBox();
            this.txtBroj = new System.Windows.Forms.TextBox();
            this.txtGrad = new System.Windows.Forms.TextBox();
            this.dtpUcl = new System.Windows.Forms.DateTimePicker();
            this.dtpRod = new System.Windows.Forms.DateTimePicker();
            this.rdbM = new System.Windows.Forms.RadioButton();
            this.rdbMK = new System.Windows.Forms.RadioButton();
            this.rdbOC = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtBrp = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.dtpStic = new System.Windows.Forms.DateTimePicker();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnPot = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(53, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(299, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Unesite podatke o novom sahisti:";
            // 
            // txtIme
            // 
            this.txtIme.Location = new System.Drawing.Point(41, 92);
            this.txtIme.Name = "txtIme";
            this.txtIme.Size = new System.Drawing.Size(142, 20);
            this.txtIme.TabIndex = 1;
            // 
            // txtPrezime
            // 
            this.txtPrezime.Location = new System.Drawing.Point(41, 152);
            this.txtPrezime.Name = "txtPrezime";
            this.txtPrezime.Size = new System.Drawing.Size(142, 20);
            this.txtPrezime.TabIndex = 2;
            // 
            // txtDrz
            // 
            this.txtDrz.Location = new System.Drawing.Point(381, 92);
            this.txtDrz.Name = "txtDrz";
            this.txtDrz.Size = new System.Drawing.Size(126, 20);
            this.txtDrz.TabIndex = 3;
            // 
            // txtPasos
            // 
            this.txtPasos.Location = new System.Drawing.Point(382, 152);
            this.txtPasos.MaxLength = 9;
            this.txtPasos.Name = "txtPasos";
            this.txtPasos.Size = new System.Drawing.Size(129, 20);
            this.txtPasos.TabIndex = 4;
            this.txtPasos.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPasos_KeyPress);
            // 
            // txtUlica
            // 
            this.txtUlica.Location = new System.Drawing.Point(382, 329);
            this.txtUlica.Name = "txtUlica";
            this.txtUlica.Size = new System.Drawing.Size(129, 20);
            this.txtUlica.TabIndex = 5;
            // 
            // txtBroj
            // 
            this.txtBroj.Location = new System.Drawing.Point(382, 368);
            this.txtBroj.MaxLength = 9;
            this.txtBroj.Name = "txtBroj";
            this.txtBroj.Size = new System.Drawing.Size(129, 20);
            this.txtBroj.TabIndex = 6;
            this.txtBroj.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBroj_KeyPress);
            // 
            // txtGrad
            // 
            this.txtGrad.Location = new System.Drawing.Point(382, 411);
            this.txtGrad.Name = "txtGrad";
            this.txtGrad.Size = new System.Drawing.Size(129, 20);
            this.txtGrad.TabIndex = 7;
            // 
            // dtpUcl
            // 
            this.dtpUcl.CustomFormat = "dd.MMM.yyyy.";
            this.dtpUcl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpUcl.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpUcl.Location = new System.Drawing.Point(41, 329);
            this.dtpUcl.Name = "dtpUcl";
            this.dtpUcl.Size = new System.Drawing.Size(142, 26);
            this.dtpUcl.TabIndex = 8;
            // 
            // dtpRod
            // 
            this.dtpRod.CustomFormat = "dd.MMM.yyyy.";
            this.dtpRod.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpRod.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpRod.Location = new System.Drawing.Point(41, 405);
            this.dtpRod.Name = "dtpRod";
            this.dtpRod.Size = new System.Drawing.Size(142, 26);
            this.dtpRod.TabIndex = 9;
            // 
            // rdbM
            // 
            this.rdbM.AutoSize = true;
            this.rdbM.Location = new System.Drawing.Point(17, 19);
            this.rdbM.Name = "rdbM";
            this.rdbM.Size = new System.Drawing.Size(59, 17);
            this.rdbM.TabIndex = 10;
            this.rdbM.TabStop = true;
            this.rdbM.Text = "Majstor";
            this.rdbM.UseVisualStyleBackColor = true;
            this.rdbM.CheckedChanged += new System.EventHandler(this.rdbM_CheckedChanged);
            // 
            // rdbMK
            // 
            this.rdbMK.AutoSize = true;
            this.rdbMK.Location = new System.Drawing.Point(17, 42);
            this.rdbMK.Name = "rdbMK";
            this.rdbMK.Size = new System.Drawing.Size(111, 17);
            this.rdbMK.TabIndex = 11;
            this.rdbMK.TabStop = true;
            this.rdbMK.Text = "Majtorski kandidat";
            this.rdbMK.UseVisualStyleBackColor = true;
            this.rdbMK.CheckedChanged += new System.EventHandler(this.rdbMK_CheckedChanged);
            // 
            // rdbOC
            // 
            this.rdbOC.AutoSize = true;
            this.rdbOC.Location = new System.Drawing.Point(17, 65);
            this.rdbOC.Name = "rdbOC";
            this.rdbOC.Size = new System.Drawing.Size(82, 17);
            this.rdbOC.TabIndex = 12;
            this.rdbOC.TabStop = true;
            this.rdbOC.Text = "Obican clan";
            this.rdbOC.UseVisualStyleBackColor = true;
            this.rdbOC.CheckedChanged += new System.EventHandler(this.rdbOC_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 313);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Datum Uclanjenja";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 389);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Datum Rodjenja";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(379, 313);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Ulica";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(379, 352);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(25, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "Broj";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(379, 395);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(30, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "Grad";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(379, 76);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 13);
            this.label7.TabIndex = 18;
            this.label7.Text = "Drzava";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(379, 136);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(63, 13);
            this.label8.TabIndex = 19;
            this.label8.Text = "Broj Pasosa";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(38, 136);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(44, 13);
            this.label9.TabIndex = 20;
            this.label9.Text = "Prezime";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(38, 76);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(24, 13);
            this.label10.TabIndex = 21;
            this.label10.Text = "Ime";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdbM);
            this.groupBox1.Controls.Add(this.rdbMK);
            this.groupBox1.Controls.Add(this.rdbOC);
            this.groupBox1.Location = new System.Drawing.Point(41, 193);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(160, 101);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Rang";
            // 
            // txtBrp
            // 
            this.txtBrp.Location = new System.Drawing.Point(257, 209);
            this.txtBrp.MaxLength = 9;
            this.txtBrp.Name = "txtBrp";
            this.txtBrp.Size = new System.Drawing.Size(125, 20);
            this.txtBrp.TabIndex = 23;
            this.txtBrp.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBrp_KeyPress);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(254, 193);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(110, 13);
            this.label11.TabIndex = 24;
            this.label11.Text = "Broj partija do sticanja";
            // 
            // dtpStic
            // 
            this.dtpStic.CustomFormat = "dd.MMM.yyyy.";
            this.dtpStic.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpStic.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpStic.Location = new System.Drawing.Point(257, 274);
            this.dtpStic.Name = "dtpStic";
            this.dtpStic.Size = new System.Drawing.Size(125, 26);
            this.dtpStic.TabIndex = 25;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(254, 258);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(79, 13);
            this.label12.TabIndex = 26;
            this.label12.Text = "Datum Sticanja";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.Red;
            this.label13.Location = new System.Drawing.Point(189, 92);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(15, 20);
            this.label13.TabIndex = 27;
            this.label13.Text = "*";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.Red;
            this.label14.Location = new System.Drawing.Point(189, 152);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(15, 20);
            this.label14.TabIndex = 28;
            this.label14.Text = "*";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.Red;
            this.label15.Location = new System.Drawing.Point(189, 329);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(15, 20);
            this.label15.TabIndex = 29;
            this.label15.Text = "*";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.Red;
            this.label16.Location = new System.Drawing.Point(189, 405);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(15, 20);
            this.label16.TabIndex = 30;
            this.label16.Text = "*";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.Red;
            this.label17.Location = new System.Drawing.Point(513, 92);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(15, 20);
            this.label17.TabIndex = 31;
            this.label17.Text = "*";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.Color.Red;
            this.label18.Location = new System.Drawing.Point(517, 152);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(15, 20);
            this.label18.TabIndex = 32;
            this.label18.Text = "*";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.ForeColor = System.Drawing.Color.Red;
            this.label19.Location = new System.Drawing.Point(389, 207);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(15, 20);
            this.label19.TabIndex = 33;
            this.label19.Text = "*";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.ForeColor = System.Drawing.Color.Red;
            this.label20.Location = new System.Drawing.Point(389, 274);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(15, 20);
            this.label20.TabIndex = 34;
            this.label20.Text = "*";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(38, 464);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 35;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnPot
            // 
            this.btnPot.Location = new System.Drawing.Point(397, 462);
            this.btnPot.Name = "btnPot";
            this.btnPot.Size = new System.Drawing.Size(75, 23);
            this.btnPot.TabIndex = 36;
            this.btnPot.Text = "Potvrdi";
            this.btnPot.UseVisualStyleBackColor = true;
            this.btnPot.Click += new System.EventHandler(this.btnPot_Click);
            // 
            // FormDodajSah
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(607, 490);
            this.Controls.Add(this.btnPot);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.dtpStic);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtBrp);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtpRod);
            this.Controls.Add(this.dtpUcl);
            this.Controls.Add(this.txtGrad);
            this.Controls.Add(this.txtBroj);
            this.Controls.Add(this.txtUlica);
            this.Controls.Add(this.txtPasos);
            this.Controls.Add(this.txtDrz);
            this.Controls.Add(this.txtPrezime);
            this.Controls.Add(this.txtIme);
            this.Controls.Add(this.label1);
            this.Name = "FormDodajSah";
            this.Text = "FormDodajSah";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormDodajSah_FormClosing);
            this.Load += new System.EventHandler(this.FormDodajSah_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtIme;
        private System.Windows.Forms.TextBox txtPrezime;
        private System.Windows.Forms.TextBox txtDrz;
        private System.Windows.Forms.TextBox txtPasos;
        private System.Windows.Forms.TextBox txtUlica;
        private System.Windows.Forms.TextBox txtBroj;
        private System.Windows.Forms.TextBox txtGrad;
        private System.Windows.Forms.DateTimePicker dtpUcl;
        private System.Windows.Forms.DateTimePicker dtpRod;
        private System.Windows.Forms.RadioButton rdbM;
        private System.Windows.Forms.RadioButton rdbMK;
        private System.Windows.Forms.RadioButton rdbOC;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtBrp;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DateTimePicker dtpStic;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnPot;
    }
}
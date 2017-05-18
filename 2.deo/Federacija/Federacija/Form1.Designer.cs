namespace Federacija
{
    partial class Form1
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
            this.btnSahistaR = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSahistaC = new System.Windows.Forms.Button();
            this.btnTurnirR = new System.Windows.Forms.Button();
            this.btnPartijaR = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnSahistaR
            // 
            this.btnSahistaR.Location = new System.Drawing.Point(26, 23);
            this.btnSahistaR.Name = "btnSahistaR";
            this.btnSahistaR.Size = new System.Drawing.Size(153, 24);
            this.btnSahistaR.TabIndex = 0;
            this.btnSahistaR.Text = "Ucitaj podatke o majstoru";
            this.btnSahistaR.UseVisualStyleBackColor = true;
            this.btnSahistaR.Click += new System.EventHandler(this.btnSahistaR_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(164, 428);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "txt";
            // 
            // btnSahistaC
            // 
            this.btnSahistaC.Location = new System.Drawing.Point(26, 63);
            this.btnSahistaC.Name = "btnSahistaC";
            this.btnSahistaC.Size = new System.Drawing.Size(153, 27);
            this.btnSahistaC.TabIndex = 2;
            this.btnSahistaC.Text = "Dodavanje novog majstora";
            this.btnSahistaC.UseVisualStyleBackColor = true;
            this.btnSahistaC.Click += new System.EventHandler(this.btnSahistaC_Click);
            // 
            // btnTurnirR
            // 
            this.btnTurnirR.Location = new System.Drawing.Point(26, 109);
            this.btnTurnirR.Name = "btnTurnirR";
            this.btnTurnirR.Size = new System.Drawing.Size(153, 30);
            this.btnTurnirR.TabIndex = 3;
            this.btnTurnirR.Text = "Ucitaj Turnir";
            this.btnTurnirR.UseVisualStyleBackColor = true;
            this.btnTurnirR.Click += new System.EventHandler(this.btnTurnirR_Click);
            // 
            // btnPartijaR
            // 
            this.btnPartijaR.Location = new System.Drawing.Point(26, 173);
            this.btnPartijaR.Name = "btnPartijaR";
            this.btnPartijaR.Size = new System.Drawing.Size(153, 37);
            this.btnPartijaR.TabIndex = 4;
            this.btnPartijaR.Text = "Ucitaj Partiju";
            this.btnPartijaR.UseVisualStyleBackColor = true;
            this.btnPartijaR.Click += new System.EventHandler(this.btnPartijaR_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(788, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "label2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(717, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 18);
            this.label3.TabIndex = 6;
            this.label3.Text = "Beli";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(865, 63);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 18);
            this.label4.TabIndex = 7;
            this.label4.Text = "Crni";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1002, 478);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnPartijaR);
            this.Controls.Add(this.btnTurnirR);
            this.Controls.Add(this.btnSahistaC);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSahistaR);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSahistaR;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSahistaC;
        private System.Windows.Forms.Button btnTurnirR;
        private System.Windows.Forms.Button btnPartijaR;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}


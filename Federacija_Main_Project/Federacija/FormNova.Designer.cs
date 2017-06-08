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
            ((System.ComponentModel.ISupportInitialize)(this.dgv1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv1
            // 
            this.dgv1.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgv1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
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
            this.chkSah.FormattingEnabled = true;
            this.chkSah.Items.AddRange(new object[] {
            "Majstor",
            "Majstorski kandidat",
            "Obican clan"});
            this.chkSah.Location = new System.Drawing.Point(24, 44);
            this.chkSah.Name = "chkSah";
            this.chkSah.Size = new System.Drawing.Size(113, 64);
            this.chkSah.TabIndex = 2;
            // 
            // FormNova
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1310, 692);
            this.Controls.Add(this.chkSah);
            this.Controls.Add(this.showSahista);
            this.Controls.Add(this.dgv1);
            this.Name = "FormNova";
            this.Text = "Šahovska Federacija";
            ((System.ComponentModel.ISupportInitialize)(this.dgv1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv1;
        private System.Windows.Forms.Button showSahista;
        private System.Windows.Forms.CheckedListBox chkSah;
    }
}
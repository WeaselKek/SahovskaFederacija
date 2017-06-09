using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NHibernate;
using Federacija.Entiteti;
using Federacija.Mapiranja;

namespace Federacija
{
    public partial class FormDodajSah : Form
    {
        bool closenow = false;
        bool updaterino = false;
        public FormDodajSah()
        {
            InitializeComponent();
        }
        public Sahista UpdateItem
        {
            get;
            set;
        }

        private void FormDodajSah_Load(object sender, EventArgs e)
        {
            rdbM.Checked = true;
            if (UpdateItem != null)
            {
                ucitajKontrole();
            }
        }

        private void ucitajKontrole()
        {
            ISession s = DataLayer.GetSession();



            if (UpdateItem is Majstor)
            {
                rdbM.Checked = true;
                dtpStic.Value = ((Majstor)UpdateItem).DatSticanja;
            }
            else if (UpdateItem is MajstorskiKandidat)
            {
                rdbMK.Checked = true;
                txtBrp.Text = ((MajstorskiKandidat)UpdateItem).BrojPartijaDoSticanja.ToString();
            }
            else
            {
                rdbOC.Checked = true;
            }
            groupBox1.Enabled = false;

            txtIme.Text = UpdateItem.Ime;
            txtPrezime.Text = UpdateItem.Prezime;
            dtpRod.Value = UpdateItem.DatRodj;
            dtpUcl.Value = UpdateItem.DatUclanjenja;

            txtPasos.Text = UpdateItem.BrojPasosa.ToString();
            txtDrz.Text = UpdateItem.Drzava;
            txtUlica.Text = UpdateItem.Ulica;
            if (UpdateItem.Broj != 0) txtBroj.Text = UpdateItem.Broj.ToString();
            txtGrad.Text = UpdateItem.Grad;
            updaterino = true;

        }

        private void rdbM_CheckedChanged(object sender, EventArgs e)
        {
            dtpStic.Enabled = true;
            txtBrp.Enabled = false;
        }

        private void rdbMK_CheckedChanged(object sender, EventArgs e)
        {
            dtpStic.Enabled = false;
            txtBrp.Enabled = true;
        }

        private void rdbOC_CheckedChanged(object sender, EventArgs e)
        {
            dtpStic.Enabled = false;
            txtBrp.Enabled = false;
        }

        private void btnPot_Click(object sender, EventArgs e)
        {

            ISession s = DataLayer.GetSession();

            //Validacija
            if ((txtIme.Text == "") || (txtPrezime.Text == "") || (txtPasos.Text == "") || (txtDrz.Text == ""))
            {
                MessageBox.Show("Zgresili ste");
                return;
            }
            Sahista p;
            if (!updaterino)
            {
                
                if (rdbM.Checked)
                {
                    p = new Majstor();
                    ((Majstor)p).DatSticanja = dtpStic.Value;
                }
                else if (rdbMK.Checked)
                {
                    if (txtBrp.Text == "")
                    {
                        MessageBox.Show("Zgresili ste");
                        return;
                    }
                    p = new MajstorskiKandidat();
                    ((MajstorskiKandidat)p).BrojPartijaDoSticanja = Int32.Parse(txtBrp.Text);
                }
                else
                {
                    p = new ObicanClan();
                }
            }
            else
            {
               p = s.Load<Sahista>(UpdateItem.RegBr);
            }
            int num;
            p.Ime = txtIme.Text;
            p.Prezime = txtPrezime.Text;
            p.DatRodj = dtpRod.Value;
            p.DatUclanjenja = dtpUcl.Value;
            p.BrojPasosa = Int32.Parse(txtPasos.Text);
            p.Drzava = txtDrz.Text;
            p.Ulica = txtUlica.Text;
            if (Int32.TryParse(txtBroj.Text, out num))
                p.Broj = num;
            p.Grad = txtGrad.Text;

            s.SaveOrUpdate(p);

            s.Flush();
            s.Close();
            MessageBox.Show("Uspesno dodat Sahista");
            closenow = true;
            this.Close();

        }

        private void txtPasos_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtBrp_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtBroj_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormDodajSah_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (closenow)
                return;
            DialogResult r = MessageBox.Show("Da li ste sigurni", "Upozorenje", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (r == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
    }
}

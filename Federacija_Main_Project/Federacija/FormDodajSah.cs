using Federacija.Entiteti;
using NHibernate;
using System;
using System.Windows.Forms;
using Federacija.Functions;

namespace Federacija
{
    public partial class FormDodajSah : Form
    {
        private bool closenow = false;
        private bool updaterino = false;

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
                this.Text = "Izmeni sahistu";
                ucitajKontrole();
            }
        }

        private void ucitajKontrole()
        {
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
            grpRang.Enabled = false;

            txtIme.Text = UpdateItem.Ime;
            txtPrezime.Text = UpdateItem.Prezime;
            dtpRod.Value = UpdateItem.DatRodj;
            dtpUcl.Value = UpdateItem.DatUclanjenja;
            txtPasos.Text = UpdateItem.BrojPasosa.ToString();
            txtDrz.Text = UpdateItem.Drzava;
            txtUlica.Text = UpdateItem.Ulica;
            if (UpdateItem.Broj != 0)
                txtBroj.Text = UpdateItem.Broj.ToString();
            txtGrad.Text = UpdateItem.Grad;
            updaterino = true;
        }

        private void btnPot_Click(object sender, EventArgs e)
        {
            int num;
            //Validacija
            if ((txtIme.Text == "") || (txtPrezime.Text == "") || (txtPasos.Text == "") || (txtDrz.Text == ""))
            {
                MessageBox.Show("Niste uneli sva potrebna polja");
                return;
            }

            try
            {
                ISession s = DataLayer.GetSession();
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
                        p = new MajstorskiKandidat();

                        if (Int32.TryParse(txtBrp.Text, out num))
                            ((MajstorskiKandidat)p).BrojPartijaDoSticanja = num;
                    }
                    else
                    {
                        p = new ObicanClan();
                    }
                }
                else
                {
                    s.Update(UpdateItem);
                    p = UpdateItem;
                    if (p is Majstor)
                    {
                        ((Majstor)p).DatSticanja = dtpStic.Value;
                    }
                    else if (p is MajstorskiKandidat)
                    {
                        if (Int32.TryParse(txtBrp.Text, out num))
                            ((MajstorskiKandidat)p).BrojPartijaDoSticanja = num;
                    }
                }
                p.Ime = txtIme.Text;
                p.Prezime = txtPrezime.Text;
                p.DatRodj = dtpRod.Value;
                p.DatUclanjenja = dtpUcl.Value;
                if (Int32.TryParse(txtPasos.Text, out num))
                    p.BrojPasosa = num;
                p.Drzava = txtDrz.Text;
                p.Ulica = txtUlica.Text;
                if (Int32.TryParse(txtBroj.Text, out num))
                    p.Broj = num;
                p.Grad = txtGrad.Text;

                s.SaveOrUpdate(p);

                s.Flush();
                s.Close();


                if (!updaterino)
                    MessageBox.Show("Uspesno dodat Sahista");
                else
                    MessageBox.Show("Uspesno izmenjen Sahista");
                closenow = true;
                this.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
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
            {
                return;
            }
            Provera.Zatvaranje(e);
        }
    }
}
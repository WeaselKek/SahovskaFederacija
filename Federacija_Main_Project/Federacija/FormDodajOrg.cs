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
using NHibernate.Linq;
using Federacija.Entiteti;
using Federacija.Mapiranja;
using Federacija.BindList;

namespace Federacija
{
    public partial class FormDodajOrg : Form
    {
        FormVezaOrgSpon CaleForma;

        public FormDodajOrg()
        {
            InitializeComponent();
        }
        public FormDodajOrg(FormVezaOrgSpon c)
        {
            InitializeComponent();
            this.CaleForma = c;
        }

        private void btnPotvrdi_Click(object sender, EventArgs e)
        {
            if (txbIme.Text == "" || txbPrezime.Text == "" || txbMatBr.Text == "" || txbMatBr.Text.Length != 13)
            {
                MessageBox.Show("Zgresili ste");
                return;
            }

            try
            {
                ISession s = DataLayer.GetSession();

                Organizator o = new Organizator();
                Sudija sud = new Sudija();

                if (cbxSudija.Checked)
                {
                    sud.FlagOrganizator = 1;

                    s.Save(sud);
                }

                o.Ime = txbIme.Text;
                o.Prezime = txbPrezime.Text;
                o.MatBr = txbMatBr.Text;
                o.Grad = txbGrad.Text;
                o.Ulica = txbUlica.Text;
                if (txbBroj.TextLength != 0)
                    o.Broj = Int32.Parse(txbBroj.Text);
                if (cbxSudija.Checked)
                    o.SudijaId = sud;
                else
                    o.SudijaId = null;

                s.Save(o);
                s.Flush();

                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
                return;
            }

            MessageBox.Show("Uspesno dodat organizator");
        }

        private void tbxIme_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txbGrad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txbPrezime_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txbBroj_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txbMatBr_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar) || txbMatBr.TextLength > 12 && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txbUlica_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}

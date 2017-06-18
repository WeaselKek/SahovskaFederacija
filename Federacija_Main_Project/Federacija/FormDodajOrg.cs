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
using Federacija.Functions;

namespace Federacija
{
    public partial class FormDodajOrg : Form
    {

        bool closenow = false;
        bool updaterino = false;

        public Organizator UpdateItem
        {
            get;
            set;
        }
        public FormDodajOrg()
        {
            InitializeComponent();
        }


        private void btnPotvrdi_Click(object sender, EventArgs e)
        {
            if (txbIme.Text == "" || txbPrezime.Text == "" || txbMatBr.Text == "")
            {
                MessageBox.Show("Niste uneli sva potrebna polja");
                return;
            }
            if (txbMatBr.Text.Length != 13)
            {
                MessageBox.Show("Maticni broj mora imati 13 cifara");
                return;
            }

            try
            {
                ISession s = DataLayer.GetSession();

                Organizator o;

                if (updaterino)
                {
                    s.Update(UpdateItem);
                    o = UpdateItem;
                }
                else
                    o = new Organizator();

                if (cbxSudija.Checked && cbxSudija.Enabled == true)
                {
                    Sudija sud = new Sudija();
                    sud.FlagOrganizator = 1;
                    sud.FlagMajstor = 0;
                    o.SudijaId = sud;
                    s.Save(sud);
                }
                else if (cbxSudija.Enabled == true)
                {
                    o.SudijaId = null;
                }

                o.Ime = txbIme.Text;
                o.Prezime = txbPrezime.Text;
                o.MatBr = txbMatBr.Text;
                o.Grad = txbGrad.Text;
                o.Ulica = txbUlica.Text;
                if (txbBroj.TextLength != 0)
                    o.Broj = Int32.Parse(txbBroj.Text);

                s.SaveOrUpdate(o);

                s.Flush();
                s.Close();
                closenow = true;
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
                return;
            }
            if (!updaterino)
                MessageBox.Show("Uspesno dodat organizator");
            else
                MessageBox.Show("Uspesno azuriran organizator");
            this.Close();
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

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormDodajOrg_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (closenow)
            {
                return;
            }
            Provera.Zatvaranje(e);
        }

        private void FormDodajOrg_Load(object sender, EventArgs e)
        {
            if (UpdateItem != null)
            {
                txbIme.Text = UpdateItem.Ime;
                txbPrezime.Text = UpdateItem.Prezime;
                txbMatBr.Text = UpdateItem.MatBr;
                txbMatBr.Enabled = false;
                txbUlica.Text = UpdateItem.Ulica;
                txbGrad.Text = UpdateItem.Grad;
                txbBroj.Text = UpdateItem.Broj.ToString();
                if (UpdateItem.SudijaId != null)
                {
                    cbxSudija.Checked = true;
                    cbxSudija.Enabled = false;
                }

                updaterino = true;
            }
        }
    }
}

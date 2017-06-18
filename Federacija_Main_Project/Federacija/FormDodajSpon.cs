using Federacija.Entiteti;
using Federacija.Functions;
using NHibernate;
using System;
using System.Windows.Forms;

namespace Federacija
{
    public partial class FormDodajSpon : Form
    {
        private bool closenow = false;

        public FormDodajSpon()
        {
            InitializeComponent();
        }

        private void btnPotvrdi_Click(object sender, EventArgs e)
        {
            if (txbIme.Text == "")
            {
                MessageBox.Show("Unesite naziv sponzora");
                return;
            }

            try
            {
                ISession s = DataLayer.GetSession();

                Sponzor sp = new Sponzor();

                sp.Naziv = txbIme.Text;

                s.SaveOrUpdate(sp);
                s.Flush();

                s.Close();
                closenow = true;
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
                return;
            }

            MessageBox.Show("Uspesno dodat sponzor");
            this.Close();
        }

        private void btnZatvori_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormDodajSpon_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (closenow)
            {
                return;
            }
            Provera.Zatvaranje(e);
        }

        private void FormDodajSpon_Load(object sender, EventArgs e)
        {
        }
    }
}
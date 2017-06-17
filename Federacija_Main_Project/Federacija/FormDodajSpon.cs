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
    public partial class FormDodajSpon : Form
    {
        bool closenow = false;
        bool updaterino = false;
        FormVezaOrgSpon CaleForma;
        public Sponzor UpdateItem
        {
            get;
            set;
        }
        public FormDodajSpon()
        {
            InitializeComponent();
        }
        public FormDodajSpon(FormVezaOrgSpon c)
        {
            InitializeComponent();
            this.CaleForma = c;
        }

        private void btnPotvrdi_Click(object sender, EventArgs e)
        {
            if (txbIme.Text == "")
            {
                return;
            }

            try
            {
                ISession s = DataLayer.GetSession();

                Sponzor sp;

                if (updaterino)
                    sp = UpdateItem;
                else
                    sp = new Sponzor();

                sp.Naziv = txbIme.Text;

                s.SaveOrUpdate(sp);
                s.Flush();

                s.Close();
                closenow = true;
            }
            catch(Exception ec)
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
            if (UpdateItem != null)
            {
                txbIme.Text = UpdateItem.Naziv;

                updaterino = true;
            }
        }
    }
}

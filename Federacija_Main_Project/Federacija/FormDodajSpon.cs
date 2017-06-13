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
    public partial class FormDodajSpon : Form
    {
        FormVezaOrgSpon CaleForma;
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

                Sponzor sp = new Sponzor();
                sp.Naziv = txbIme.Text;

                s.Save(sp);
                s.Flush();

                s.Close();
            }
            catch(Exception ec)
            {
                MessageBox.Show(ec.Message);
                return;
            }

            MessageBox.Show("Uspesno dodat sponzor");
        }

        private void btnZatvori_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("Da li ste sigurni", "Upozorenje", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (r == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}

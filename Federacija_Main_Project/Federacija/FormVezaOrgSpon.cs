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
    public partial class FormVezaOrgSpon : Form
    {
        bool updaterino = false;
        bool closenow = false;
        public FormVezaOrgSpon(Turnir t)
        {
            InitializeComponent();
            Turn = t;

            try
            {
                ISession s = DataLayer.GetSession();

                IList<Organizator> listaOrganizatora = new List<Organizator>();
                IList<Sponzor> listaSponzora = new List<Sponzor>();

                //var query = from o in s.Query<Organizator>()
                //            where o.OrganizujeTurnir.Select(x => x.OrganizujeTurnir.Id).Equals(t.Id)
                //            select o;

                //listaOrganizatora = listaOrganizatora.Concat(from o in s.Query<Organizator>()
                //                                     where o == o.OrganizujeTurnir.Select(x => x.OrganizujeTurnir.Id == t.Id)
                //                                     select o).ToList<Organizator>();

                listaOrganizatora = listaOrganizatora.Concat(from o in s.Query<Organizator>()
                                                             where o.OrganizujeTurnir.Any(x => x.OrganizujeTurnir.Id == t.Id)
                                                             select o).ToList<Organizator>();

                listaSponzora = listaSponzora.Concat(from o in s.Query<Sponzor>()
                                                     where o.SponzoriseTurnir.Any(x => x.SponzoriseTurnir.Id == t.Id)
                                                     select o).ToList<Sponzor>();

                SortableBindingList<Organizator> prva = new SortableBindingList<Organizator>(listaOrganizatora);
                SortableBindingList<Sponzor> druga = new SortableBindingList<Sponzor>(listaSponzora);

                s.Close();

                dgvPostojeciOrganizatori.DataSource = prva;
                dgvPostojeciSponzori.DataSource = druga;

                dgvPostojeciOrganizatori.Columns["OrganizujeTurnir"].Visible = false;
                dgvPostojeciOrganizatori.Columns["SudijaId"].Visible = false;
                dgvPostojeciOrganizatori.Columns["Broj"].Visible = false;
                dgvPostojeciOrganizatori.Columns["MatBr"].Visible = false;

                dgvPostojeciSponzori.Columns["SponzoriseTurnir"].Visible = false;
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
                this.Close();
            }


        }

        public IList<Organizuje> ListaOrg
        {
            get;
            set;
        }
        public IList<Sponzorise> ListaSpon
        {
            get;
            set;
        }
        protected Turnir Turn
        {
            get;
            set;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormVezaOrgSpon_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (closenow)
                return;
            DialogResult r = MessageBox.Show("Da li ste sigurni", "Upozorenje", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (r == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void btnDodajOrg_Click(object sender, EventArgs e)
        {
            FormDodajOrg f = new FormDodajOrg(this);
            f.ShowDialog();
        }

        private void btnDodajSpon_Click(object sender, EventArgs e)
        {
            FormDodajSpon f = new FormDodajSpon(this);
            f.ShowDialog();
        }

        private void btnPotvrdi_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnUcitaj_Click(object sender, EventArgs e)
        {
            try
            {
                dgvSviOrganizatori.Columns.Clear();
                dgvSviSponzori.Columns.Clear();

                ISession s = DataLayer.GetSession();

                IList<Organizator> listaOrganizatora = new List<Organizator>();
                IList<Sponzor> listaSponzora = new List<Sponzor>();

                listaOrganizatora = listaOrganizatora.Concat(from o in s.Query<Organizator>()
                                                             select o).ToList<Organizator>();

                listaSponzora = listaSponzora.Concat(from o in s.Query<Sponzor>()
                                                     select o).ToList<Sponzor>();

                SortableBindingList<Organizator> prva = new SortableBindingList<Organizator>(listaOrganizatora);
                SortableBindingList<Sponzor> druga = new SortableBindingList<Sponzor>(listaSponzora);

                s.Close();

                dgvSviOrganizatori.DataSource = prva;
                dgvSviSponzori.DataSource = druga;

                dgvSviOrganizatori.Columns["OrganizujeTurnir"].Visible = false;
                dgvSviOrganizatori.Columns["SudijaId"].Visible = false;
                dgvSviOrganizatori.Columns["Broj"].Visible = false;
                dgvSviOrganizatori.Columns["MatBr"].Visible = false;

                dgvSviSponzori.Columns["SponzoriseTurnir"].Visible = false;
            }
            catch(Exception ec)
            {
                MessageBox.Show(ec.Message);
                return;
            }
        }
    }
}

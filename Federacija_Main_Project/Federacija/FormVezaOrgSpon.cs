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
    public partial class FormVezaOrgSpon : Form
    {
        bool closenow = false;
        public FormVezaOrgSpon(Turnir t)
        {
            InitializeComponent();
            Turn = t;

            this.Text = "Organizatori i sponzori turnira: " + Turn.Naziv;

            OsveziPostojeceGridove();
        }

        protected Turnir Turn
        {
            get;
            set;
        }

        private void FormVezaOrgSpon_Load(object sender, EventArgs e)
        {
            this.Text = Turn.ToString();
            lblOrgTurnira.Text += " \"" + Turn.ToString() + "\"";
            lblSponzTurnira.Text += " \"" + Turn.ToString() + "\"";
            Ucitaj();
        }

        private void btnDone_Click(object sender, EventArgs e)
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
            FormDodajOrg f = new FormDodajOrg();
            f.ShowDialog();
            Ucitaj();
        }

        private void btnDodajSpon_Click(object sender, EventArgs e)
        {
            FormDodajSpon f = new FormDodajSpon();
            f.ShowDialog();
            Ucitaj();
        }

        private void Ucitaj()
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

        private void btnPoveziOrganizatora_Click(object sender, EventArgs e)
        {
            if (!Provera.chkIfSelected(dgvSviOrganizatori))
                return;

            try
            {
                ISession s = DataLayer.GetSession();

                Organizator o = dgvSviOrganizatori.CurrentRow.DataBoundItem as Organizator;

                Organizuje org = new Organizuje();
                org.OrganizujeOrganizator = o;
                org.OrganizujeTurnir = Turn;

                //if ((from z in s.Query<Organizuje>()
                //     where z.OrganizujeOrganizator == o && z.OrganizujeTurnir == Turn
                //     select z).Count() == 0)
                if ((from z in s.Query<Turnir>()
                     where z.Id == Turn.Id && z.OrganizujeOrganizator.All(x => x.OrganizujeOrganizator.MatBr != o.MatBr)
                     select z).Count() == 1)
                    s.Save(org);
                else
                {
                    MessageBox.Show("Ovaj organizator je vec prisutan");
                }
                s.Flush();

                OsveziPostojeceGridove();

                s.Close();
            }
            catch(Exception ec)
            {
                MessageBox.Show(ec.Message);
                return;
            }
        }

        private void btnPoveziSponzora_Click(object sender, EventArgs e)
        {
            if (!Provera.chkIfSelected(dgvSviSponzori))
                return;

            try
            {
                ISession s = DataLayer.GetSession();

                Sponzor sp = dgvSviSponzori.CurrentRow.DataBoundItem as Sponzor;

                Sponzorise spon = new Sponzorise();
                spon.SponzoriseSponzor = sp;
                spon.SponzoriseTurnir = Turn;

                //if ((from z in s.Query<Sponzorise>()
                //    where z.SponzoriseSponzor == sp && z.SponzoriseTurnir == Turn
                //    select z).Count() == 0)
                if ((from z in s.Query<Turnir>()
                     where z.Id == Turn.Id && z.SponzoriseSponzor.All(x => x.SponzoriseSponzor.Naziv != sp.Naziv)
                     select z).Count() == 1)
                    s.Save(spon);
                else
                {
                    MessageBox.Show("Ovaj sponzor je vec prisutan");
                }
                s.Flush();

                OsveziPostojeceGridove();

                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
                return;
            }
        }

        private void OsveziPostojeceGridove()
        {
            try
            {
                ISession s = DataLayer.GetSession();

                IList<Organizator> listaOrganizatora = new List<Organizator>();
                IList<Sponzor> listaSponzora = new List<Sponzor>();

                listaOrganizatora = listaOrganizatora.Concat(from o in s.Query<Organizator>()
                                                             where o.OrganizujeTurnir.Any(x => x.OrganizujeTurnir.Id == Turn.Id)
                                                             select o).ToList<Organizator>();

                listaSponzora = listaSponzora.Concat(from o in s.Query<Sponzor>()
                                                     where o.SponzoriseTurnir.Any(x => x.SponzoriseTurnir.Id == Turn.Id)
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

        private void btnUkloniOrganizatora_Click(object sender, EventArgs e)
        {
            if (!Provera.chkIfSelected(dgvPostojeciOrganizatori))
                return;

            try
            {
                ISession s = DataLayer.GetSession();

                Organizator o = dgvPostojeciOrganizatori.CurrentRow.DataBoundItem as Organizator;

                Organizuje org = (from z in s.Query<Organizuje>()
                 where z.OrganizujeOrganizator == o && z.OrganizujeTurnir == Turn
                 select z).First();
                s.Delete(org);
                s.Flush();

                OsveziPostojeceGridove();

                MessageBox.Show("Organizator vise ne organizuje turnir: " + Turn.Naziv);
                s.Close();
            }
            catch(Exception ec)
            {
                MessageBox.Show(ec.Message);
                return;
            }
        }

        private void btnUkloniSponzora_Click(object sender, EventArgs e)
        {
            if (!Provera.chkIfSelected(dgvPostojeciSponzori))
                return;

            try
            {
                ISession s = DataLayer.GetSession();

                Sponzor spon = dgvPostojeciSponzori.CurrentRow.DataBoundItem as Sponzor;

                Sponzorise sp = (from z in s.Query<Sponzorise>()
                                  where z.SponzoriseSponzor == spon && z.SponzoriseTurnir == Turn
                                  select z).First();
                s.Delete(sp);
                s.Flush();

                OsveziPostojeceGridove();

                MessageBox.Show("Sponzor vise ne sponzorise turnir: " + Turn.Naziv);
                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
                return;
            }
        }


    }
}

using Federacija.BindList;
using Federacija.Entiteti;
using Federacija.Functions;
using NHibernate;
using NHibernate.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Federacija
{
    public partial class FormNova : Form
    {
        public FormNova()
        {
            InitializeComponent();
        }

        private void FormNova_Load(object sender, EventArgs e)
        {
            chkTak.Checked = true;
            chkEgz.Checked = true;
            for (int i = 0; i < chkNacin.Items.Count; i++)
            {
                chkNacin.SetItemChecked(i, true);
                chkTipE.SetItemChecked(i, true);
                chkTipT.SetItemChecked(i, true);
            }
            chkTipT.SetItemChecked(2, true);
        }

        private void showSahista_Click(object sender, EventArgs e)
        {
            try
            {
                dgv1.Columns.Clear();
                ISession s = DataLayer.GetSession();

                IList<Sahista> shl = new List<Sahista>();

                if (chkSah.GetItemChecked(0))
                {
                    shl = shl.Concat(from o in s.Query<Majstor>()
                                     select o).ToList<Sahista>();
                }
                if (chkSah.GetItemChecked(1))
                {
                    shl = shl.Concat(from o in s.Query<MajstorskiKandidat>()
                                     select o).ToList<Sahista>();
                }
                if (chkSah.GetItemChecked(2))
                {
                    shl = shl.Concat(from o in s.Query<ObicanClan>()
                                     select o).ToList<Sahista>();
                }

                SortableBindingList<Sahista> a = new SortableBindingList<Sahista>(shl);

                s.Close();

                dgv1.DataSource = a;

                dgv1.Columns["RegBr"].Visible = false;
                dgv1.Columns["BrojPasosa"].Visible = false;
                dgv1.Columns["Ulica"].Visible = false;
                dgv1.Columns["Broj"].Visible = false;
                dgv1.Columns["Grad"].Visible = false;
                //dgv1.Columns["Partije"].Visible = false;

                dgv1.Columns["DatRodj"].HeaderText = "Datum Rodjenja";
                dgv1.Columns["DatUclanjenja"].HeaderText = "Datum Uclanjenja";
                dgv1.Columns.Add("Rang", "Rang");

                if (chkSah.GetItemChecked(0))
                {
                    dgv1.Columns.Add("ds", "Datum sticanja");
                }
                if (chkSah.GetItemChecked(1))
                {
                    dgv1.Columns.Add("brds", "Broj partija do sticanja");
                }

                SahistaIzvedeni(a);
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private void showOrgan_Click(object sender, EventArgs e)
        {
            try
            {
                dgv1.Columns.Clear();
                ISession s = DataLayer.GetSession();

                IQuery q = s.CreateQuery("from Organizator");

                SortableBindingList<Organizator> a = new SortableBindingList<Organizator>(q.List<Organizator>());

                s.Close();

                dgv1.DataSource = a;

                dgv1.Columns["OrganizujeTurnir"].Visible = false;
                dgv1.Columns["SudijaId"].Visible = false;
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private void showSpon_Click(object sender, EventArgs e)
        {
            try
            {
                dgv1.Columns.Clear();
                ISession s = DataLayer.GetSession();

                IQuery q = s.CreateQuery("from Sponzor");

                SortableBindingList<Sponzor> a = new SortableBindingList<Sponzor>(q.List<Sponzor>());

                s.Close();

                dgv1.DataSource = a;

                dgv1.Columns["SponzoriseTurnir"].Visible = false;
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private void showTurnir_Click(object sender, EventArgs e)
        {
            try
            {
                dgv1.Columns.Clear();
                ISession s = DataLayer.GetSession();

                string nacin = string.Empty;
                IList<Turnir> trl = new List<Turnir>();

                //filtriranje za nacin odigravanja
                foreach (string v in chkNacin.CheckedItems)
                {
                    nacin += v.ToUpper();
                }

                //filtriranje za tip turnira
                if (chkTak.Checked)
                {
                    if (chkTipT.GetItemChecked(0))
                    {
                        trl = trl.Concat(from o in s.Query<TurnirTakmicarskiNacionalni>()
                                         where (nacin.Contains(o.NacinOdigravanja))
                                         select o).ToList<Turnir>();
                    }
                    if (chkTipT.GetItemChecked(1))
                    {
                        trl = trl.Concat(from o in s.Query<TurnirTakmicarskiRegionalni>()
                                         where (nacin.Contains(o.NacinOdigravanja))
                                         select o).ToList<Turnir>();
                    }
                    if (chkTipT.GetItemChecked(2))
                    {
                        trl = trl.Concat(from o in s.Query<TurnirTakmicarskiInternacionalni>()
                                         where (nacin.Contains(o.NacinOdigravanja))
                                         select o).ToList<Turnir>();
                    }
                }
                if (chkEgz.Checked)
                {
                    if (chkTipE.GetItemChecked(0))
                    {
                        trl = trl.Concat(from o in s.Query<TurnirEgzibicioniPromotivni>()
                                         where (nacin.Contains(o.NacinOdigravanja))
                                         select o).ToList<Turnir>();
                    }
                    if (chkTipE.GetItemChecked(1))
                    {
                        trl = trl.Concat(from o in s.Query<TurnirEgzibicioniHumanitarni>()
                                         where (nacin.Contains(o.NacinOdigravanja))
                                         select o).ToList<Turnir>();
                    }
                }

                SortableBindingList<Turnir> a = new SortableBindingList<Turnir>(trl);

                s.Close();

                dgv1.DataSource = a;

                dgv1.Columns["Id"].Visible = false;
                dgv1.Columns["TPartije"].Visible = false;
                dgv1.Columns["OrganizujeOrganizator"].Visible = false;
                dgv1.Columns["SponzoriseSponzor"].Visible = false;
                dgv1.Columns["TrajanjePartije"].Visible = false;
                dgv1.Columns["Novac"].Visible = false;
                dgv1.Columns["Namena"].Visible = false;

                if (!chkEgz.Checked)
                {
                    dgv1.Columns["PoZnacaju"].Visible = false;
                    dgv1.Columns["TipEgzibicionog"].Visible = false;
                }
                if (!chkTak.Checked)
                {
                    dgv1.Columns["PoZnacaju"].Visible = false;
                    dgv1.Columns["TipTakmicarskog"].Visible = false;
                }
                if (chkTipE.GetItemChecked(1) && chkTipE.Enabled)
                {
                    dgv1.Columns["Novac"].Visible = true;
                    dgv1.Columns["Namena"].Visible = true;
                }
                if (chkNacin.GetItemChecked(1))
                {
                    dgv1.Columns["TrajanjePartije"].Visible = true;
                }
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private void SahistaIzvedeni(SortableBindingList<Sahista> a)
        {
            int i = 0;
            foreach (Sahista value in a)
            {
                if (value is Majstor)
                {
                    dgv1.Rows[i].Cells["Rang"].Value = "Majstor";
                    dgv1.Rows[i].Cells["ds"].Value = ((Majstor)value).DatSticanja.ToShortDateString();
                }
                else if (value is MajstorskiKandidat)
                {
                    dgv1.Rows[i].Cells["Rang"].Value = "Majstorski kandidat";
                    dgv1.Rows[i].Cells["brds"].Value = ((MajstorskiKandidat)value).BrojPartijaDoSticanja;
                }
                else if (value is ObicanClan)
                {
                    dgv1.Rows[i].Cells["Rang"].Value = "Obican clan";
                }
                i++;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (!Provera.chkIfSelected(dgv1))
                    return;

                DialogResult r = MessageBox.Show("Da li ste sigurni", "Upozorenje", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (r == DialogResult.No)
                {
                    return;
                }

                ISession s = DataLayer.GetSession();

                if (dgv1.CurrentRow.DataBoundItem is Sahista)
                {
                    var item = dgv1.CurrentRow.DataBoundItem as Sahista;
                    s.Update(item);
                    delSahista(item, s);
                }
                else if (dgv1.CurrentRow.DataBoundItem is Turnir)
                {
                    var id = ((Turnir)dgv1.CurrentRow.DataBoundItem).Id;
                    Turnir p = s.Load<Turnir>(id);
                    s.Delete(p);
                    s.Flush();
                    s.Close();
                    MessageBox.Show("Uspesno ste izbrisali turnir");
                    showTurnir_Click(sender, e);
                }
                else if (dgv1.CurrentRow.DataBoundItem is Organizator)
                {
                    var id = ((Organizator)dgv1.CurrentRow.DataBoundItem).MatBr;
                    Organizator p = s.Load<Organizator>(id);
                    if (p.SudijaId != null)
                    {
                        Sudija sud = s.Load<Sudija>(p.SudijaId.Id);
                        s.Delete(sud);
                        s.Flush();
                    }
                    s.Delete(p);
                    s.Flush();
                    s.Close();
                    MessageBox.Show("Uspesno ste izbrisali organizatora");
                    showOrgan_Click(sender, e);
                }
                else if (dgv1.CurrentRow.DataBoundItem is Sponzor)
                {
                    var id = ((Sponzor)dgv1.CurrentRow.DataBoundItem).Naziv;
                    Sponzor p = s.Load<Sponzor>(id);
                    s.Delete(p);
                    s.Flush();
                    s.Close();
                    MessageBox.Show("Uspesno ste izbrisali sponzora");
                    showSpon_Click(sender, e);
                }
                else
                {
                    s.Close();
                }

                dgv1.Rows.Remove(this.dgv1.CurrentRow);
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private void delSahista(Sahista item, ISession s)
        {
            int cnt = (from o in s.Query<Partija>()
                       where (o.BeliIgrac == item || o.CrniIgrac == item)
                       select o).Count();

            if (cnt > 0)
            {
                s.Close();
                MessageBox.Show("Ne mozete izbrisati sahistu koji ima odigrane partije");
                return;
            }

            s.Delete(item);
            s.Flush();
            s.Close();
            MessageBox.Show("Uspesno ste izbrisali sahistu");
        }

        private void btnIzmeni_Click(object sender, EventArgs e)
        {
            if (!Provera.chkIfSelected(dgv1))
                return;

            if (dgv1.CurrentRow.DataBoundItem is Sahista)
            {
                var item = dgv1.CurrentRow.DataBoundItem;
                FormDodajSah f = new FormDodajSah();
                f.UpdateItem = item as Sahista;
                f.ShowDialog();
                             
            }
            else if (dgv1.CurrentRow.DataBoundItem is Turnir)
            {
                var item = dgv1.CurrentRow.DataBoundItem as Turnir;
                FormDodajTurnir f = new FormDodajTurnir();
                f.UpdateItem = item;
                f.ShowDialog();
                
            }
            else if (dgv1.CurrentRow.DataBoundItem is Organizator)
            {
                var item = dgv1.CurrentRow.DataBoundItem as Organizator;
                FormDodajOrg f = new FormDodajOrg();
                f.UpdateItem = item;
                f.ShowDialog();
                
            }
            else if (dgv1.CurrentRow.DataBoundItem is Sponzor)
            {
                MessageBox.Show("Ne mozete azurirati sponzor");               
            }
            else if (dgv1.CurrentRow.DataBoundItem is Partija)
            {
                var item = dgv1.CurrentRow.DataBoundItem as Partija;
                FormDodajPartija f = new FormDodajPartija();               
                f.UpdateItem = item;
                f.ShowDialog();
                
            }
            dgv1.Update();
            dgv1.Refresh();
        }

        private void btnVezaOrgSpon_Click(object sender, EventArgs e)
        {
            if (!Provera.chkIfSelected(dgv1))
                return;

            if (!(dgv1.CurrentRow.DataBoundItem is Turnir))
            {
                MessageBox.Show("Niste selektovali turnir");
                return;
            }
            FormVezaOrgSpon f = new FormVezaOrgSpon(dgv1.CurrentRow.DataBoundItem as Turnir);
            f.ShowDialog();
        }

        private void chkEgz_CheckStateChanged(object sender, EventArgs e)
        {
            if (chkEgz.Checked)
            {
                chkTipE.Enabled = true;
            }
            else
            {
                chkTipE.Enabled = false;
            }
        }

        private void chkTak_CheckStateChanged(object sender, EventArgs e)
        {
            if (chkTak.Checked)
            {
                chkTipT.Enabled = true;
            }
            else
            {
                chkTipT.Enabled = false;
            }
        }

        private void dgv1_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            Sortiranje.SortDGV(e.ColumnIndex, dgv1);

            if (dgv1.DataSource is SortableBindingList<Sahista>)
                SahistaIzvedeni((SortableBindingList<Sahista>)dgv1.DataSource);
        }

        private void sahistaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormDodajSah f = new FormDodajSah();
            f.ShowDialog();
            showSahista_Click(sender, e);
        }

        private void turnirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormDodajTurnir f = new FormDodajTurnir();
            f.ShowDialog();
            showTurnir_Click(sender, e);
        }

        private void promovisiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!Provera.chkIfSelected(dgv1))
                return;
            try
            {
                if (dgv1.CurrentRow.DataBoundItem is Majstor)
                {
                    var m = dgv1.CurrentRow.DataBoundItem as Majstor;
                    ISession s = DataLayer.GetSession();
                    s.Update(m);
                   
                    if (m.SudijaId == null)
                    {
                        Sudija sud = new Sudija();
                        sud.FlagMajstor = 1;
                        sud.FlagOrganizator = 0;

                        m.SudijaId = sud;
                        s.SaveOrUpdate(sud);

                        s.Flush();
                        s.Close();
                        MessageBox.Show("Uspeno promovisan majstor u sudiju");
                    }
                    else
                    {
                        MessageBox.Show("Majstor je vec sudija");
                        s.Close();
                    }
                    dgv1.Update();
                    dgv1.Refresh();

                }
                else if (dgv1.CurrentRow.DataBoundItem is Organizator)
                {
                    var m = dgv1.CurrentRow.DataBoundItem as Organizator;
                    ISession s = DataLayer.GetSession();
                    s.Update(m);
                    if (m.SudijaId == null)
                    {
                        Sudija sud = new Sudija();
                        sud.FlagMajstor = 0;
                        sud.FlagOrganizator = 1;

                        m.SudijaId = sud;
                        s.SaveOrUpdate(sud);

                        s.Flush();
                        s.Close();
                        MessageBox.Show("Uspeno promovisan organizator u sudiju");
                    }
                    else
                    {
                        MessageBox.Show("Organizator je vec sudija");
                        s.Close();
                    }
                }
                else
                {
                    MessageBox.Show("Nije selektovan odgovarajuci podatak");
                }
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private void otpustiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!Provera.chkIfSelected(dgv1))
                return;
            try
            {
                if (dgv1.CurrentRow.DataBoundItem is Majstor)
                {
                    var m = dgv1.CurrentRow.DataBoundItem as Majstor;
                    if (m.SudijaId != null)
                    {
                        ISession s = DataLayer.GetSession();
                        s.Update(m);
                        s.Delete(m.SudijaId);
                        m.SudijaId = null;
                        s.Flush();
                        s.Close();

                        MessageBox.Show("Uspesno otpusten sudija");
                    }
                    else
                    {
                        MessageBox.Show("Izabrani majstor nije sudija");
                    }
                }
                else if (dgv1.CurrentRow.DataBoundItem is Organizator)
                {
                    var m = dgv1.CurrentRow.DataBoundItem as Organizator;
                    if (m.SudijaId != null)
                    {
                        ISession s = DataLayer.GetSession();
                        s.Update(m);
                        s.Delete(m.SudijaId);
                        m.SudijaId = null;

                        s.Flush();
                        s.Close();

                        MessageBox.Show("Uspesno otpusten sudija");
                    }
                    else
                    {
                        MessageBox.Show("Izabrani organizator nije sudija");
                    }
                }
                else
                {
                    MessageBox.Show("Nije selektovan odgovarajuci podatak");
                }
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private void prikaziPartijeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!Provera.chkIfSelected(dgv1))
                return;
            try
            {
                if (dgv1.CurrentRow.DataBoundItem is Sahista)
                {
                    ISession s = DataLayer.GetSession();
                    Sahista sah = dgv1.CurrentRow.DataBoundItem as Sahista;

                    IList<Partija> lsp = (from o in s.Query<Partija>()
                                          where (o.BeliIgrac == sah || o.CrniIgrac == sah)
                                          select o).ToList<Partija>();

                    SortableBindingList<Partija> a = new SortableBindingList<Partija>(lsp);

                    dgv1.Columns.Clear();
                    dgv1.DataSource = a;

                    dgv1.Columns["Potezi"].Visible = false;
                    dgv1.Columns["Sudija"].Visible = false;

                    dgv1.Update();
                    dgv1.Refresh();

                    s.Close();
                }
                else if (dgv1.CurrentRow.DataBoundItem is Turnir)
                {
                    ISession s = DataLayer.GetSession();
                    Turnir trn = dgv1.CurrentRow.DataBoundItem as Turnir;

                    IList<Partija> lsp = (from o in s.Query<Partija>()
                                          where (o.Turnir == trn)
                                          select o).ToList<Partija>();

                    SortableBindingList<Partija> a = new SortableBindingList<Partija>(lsp);

                    dgv1.Columns.Clear();
                    dgv1.DataSource = a;

                    dgv1.Columns["Potezi"].Visible = false;
                    dgv1.Columns["Sudija"].Visible = false;
                    dgv1.Columns["Turnir"].Visible = false;

                    dgv1.Update();
                    dgv1.Refresh();

                    s.Close();
                }
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private void dodajPartijuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!Provera.chkIfSelected(dgv1))
                return;

            if (!(dgv1.CurrentRow.DataBoundItem is Turnir))
            {
                MessageBox.Show("Niste selektovali turnir");
                return;
            }
            FormDodajPartija f = new FormDodajPartija();
            f.Turn = dgv1.CurrentRow.DataBoundItem as Turnir;
            f.ShowDialog();
        }
    }
}
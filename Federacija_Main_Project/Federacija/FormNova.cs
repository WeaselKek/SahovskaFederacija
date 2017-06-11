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
    public partial class FormNova : Form
    {
        public FormNova()
        {
            InitializeComponent();
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

                //dgv1.AutoGenerateColumns = false;
                dgv1.AllowUserToAddRows = false;

                dgv1.Columns["RegBr"].Visible = false;
                dgv1.Columns["BrojPasosa"].Visible = false;
                dgv1.Columns["Ulica"].Visible = false;
                dgv1.Columns["Broj"].Visible = false;
                dgv1.Columns["Grad"].Visible = false;
                dgv1.Columns["Partije"].Visible = false;

                dgv1.Columns["DatRodj"].HeaderText = "Datum Rodjenja";
                dgv1.Columns["DatUclanjenja"].HeaderText = "Datum Uclanjenja";
                dgv1.Columns.Add("Rang", "Rang");

                if (chkSah.GetItemCheckState(0).Equals(CheckState.Checked))
                {                  
                    dgv1.Columns.Add("ds", "Datum sticanja");
                }
                if (chkSah.GetItemCheckState(1).Equals(CheckState.Checked))
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


        public void SahistaIzvedeni(SortableBindingList<Sahista> a)
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
        public void SortDGV(int index)
        {

            DataGridViewColumn newColumn = dgv1.Columns[index];
            DataGridViewColumn oldColumn = dgv1.SortedColumn;
            ListSortDirection direction;

            if (oldColumn != null)
            {
                // Sort the same column again, reversing the SortOrder.
                if (oldColumn == newColumn &&
                    dgv1.SortOrder == SortOrder.Ascending)
                {
                    direction = ListSortDirection.Descending;
                }
                else
                {
                    // Sort a new column and remove the old SortGlyph.
                    direction = ListSortDirection.Ascending;
                    oldColumn.HeaderCell.SortGlyphDirection = SortOrder.None;
                }
            }
            else
            {
                direction = ListSortDirection.Ascending;
            }

            dgv1.Sort(newColumn, direction);
            newColumn.HeaderCell.SortGlyphDirection =
                direction == ListSortDirection.Ascending ?
                SortOrder.Ascending : SortOrder.Descending;

        }

        private void dgv1_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {

            if (!dgv1.Columns[e.ColumnIndex].IsDataBound)
                return;

            dgv1.Columns[e.ColumnIndex].SortMode = DataGridViewColumnSortMode.Programmatic;
            SortDGV(e.ColumnIndex);
            if (dgv1.DataSource is SortableBindingList<Sahista>)
                SahistaIzvedeni((SortableBindingList<Sahista>)dgv1.DataSource);
        }

        private void btnSahAdd_Click(object sender, EventArgs e)
        {
            FormDodajSah f = new FormDodajSah();
            f.ShowDialog();
            showSahista_Click(sender, e);
        }

        private void btnIzmeni_Click(object sender, EventArgs e)
        {
            if (dgv1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Molimo selektujte neki podatak");
                return;
            }
            if (dgv1.CurrentRow.DataBoundItem is Sahista)
            {
                var item = dgv1.CurrentRow.DataBoundItem;
                FormDodajSah f = new FormDodajSah();
                f.UpdateItem = item as Sahista;
                f.ShowDialog();
                showSahista_Click(sender, e);
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

                dgv1.AllowUserToAddRows = false;
                dgv1.Columns["SponzoriseTurnir"].Visible = false;

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

                dgv1.AllowUserToAddRows = false;
                dgv1.Columns["OrganizujeTurnir"].Visible = false;
                dgv1.Columns["SudijaId"].Visible = false;

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

                string nac=string.Empty;
                IList<Turnir> trl = new List<Turnir>();

                foreach (string v in chkNacin.CheckedItems)
                {
                    nac += v.ToUpper();
                }
   

                if(chkTak.Checked){
                    if (chkTipT.GetItemChecked(0))
                    {
                        trl = trl.Concat(from o in s.Query<TurnirTakmicarskiNacionalni>()
                                         where (nac.Contains(o.NacinOdigravanja))
                                         select o).ToList<Turnir>();  
                    }
                    if (chkTipT.GetItemChecked(1))
                    {
                        trl = trl.Concat(from o in s.Query<TurnirTakmicarskiRegionalni>()
                                         where (nac.Contains(o.NacinOdigravanja))
                                         select o).ToList<Turnir>();
                    }
                    if (chkTipT.GetItemChecked(2))
                    {
                        trl = trl.Concat(from o in s.Query<TurnirTakmicarskiInternacionalni>()
                                         where (nac.Contains(o.NacinOdigravanja))
                                         select o).ToList<Turnir>();
                    }
                }
                if (chkEgz.Checked)
                {
                    if (chkTipE.GetItemChecked(0))
                    {
                        trl = trl.Concat(from o in s.Query<TurnirEgzibicioniPromotivni>()
                                         where (nac.Contains(o.NacinOdigravanja))
                                         select o).ToList<Turnir>();
                    }
                    if (chkTipE.GetItemChecked(1))
                    {
                        trl = trl.Concat(from o in s.Query<TurnirEgzibicioniHumanitarni>()
                                         where (nac.Contains(o.NacinOdigravanja))
                                         select o).ToList<Turnir>();
                    }
                   
                }

               
                SortableBindingList<Turnir> a = new SortableBindingList<Turnir>(trl);

                s.Close();

                dgv1.DataSource = a;

                dgv1.AllowUserToAddRows = false;

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
                    dgv1.Columns["PoZnacaju"].Visible = false;
                }
                if (!chkTak.Checked)
                {
                    dgv1.Columns["TipTakmicarskog"].Visible = false;
                }
                if (chkTipE.GetItemChecked(1))
                {
                    dgv1.Columns["Novac"].Visible = true;
                    dgv1.Columns["Namena"].Visible = true;
                }
                if (chkNacin.GetItemChecked(1)){
                    dgv1.Columns["TrajanjePartije"].Visible = true;
                }


                




            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgv1.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Molimo selktujte neki podatak");
                    return;
                }

                ISession s = DataLayer.GetSession();

                if (dgv1.CurrentRow.DataBoundItem is Sahista)
                {
                    var id = ((Sahista)dgv1.CurrentRow.DataBoundItem).RegBr;
                    Sahista p = s.Load<Sahista>(id);
                    s.Delete(p);
                    MessageBox.Show("Uspesno ste izbrisali sahistu");
                    s.Flush();
                    s.Close();
                    showSahista_Click(sender, e);
                }

            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private void chkTak_CheckStateChanged(object sender, EventArgs e)
        {
            if (chkTak.CheckState==CheckState.Checked){
                chkTipT.Enabled = true;
            }
            else
            {
                chkTipT.Enabled = false;
            }
        }

        private void FormNova_Load(object sender, EventArgs e)
        {
            chkTipT.Enabled = false;
            chkTipE.Enabled = false;
        }

        private void chkEgz_CheckStateChanged(object sender, EventArgs e)
        {
            if (chkEgz.CheckState == CheckState.Checked)
            {
                chkTipE.Enabled = true;
            }
            else
            {
                chkTipE.Enabled = false;
            }
        }

        private void btnDodajPartiju_Click(object sender, EventArgs e)
        {
            if (!(dgv1.DataSource is SortableBindingList<Turnir>) || dgv1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Niste selektovali turnir");
                return;
            }
            MessageBox.Show("bravo");
        }

        private void btnDodajTurnir_Click(object sender, EventArgs e)
        {
            FormDodajTurnir f = new FormDodajTurnir();
            f.ShowDialog();
        }

        private void btnDodajOrg_Click(object sender, EventArgs e)
        {
            FormDodajOrg f = new FormDodajOrg();
            f.ShowDialog();
        }

        private void btnDodajSpon_Click(object sender, EventArgs e)
        {
            FormDodajSpon f = new FormDodajSpon();
            f.ShowDialog();
        }

        private void btnVezaOrgSpon_Click(object sender, EventArgs e)
        {

            if (!(dgv1.DataSource is SortableBindingList<Turnir>) || dgv1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Niste selektovali turnir");
                return;
            }
            FormVezaOrgSpon f = new FormVezaOrgSpon();
            f.Turn = dgv1.CurrentRow.DataBoundItem as Turnir;
            f.ShowDialog();

        }
    }
}

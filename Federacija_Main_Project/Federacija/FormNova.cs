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
                ISession s = DataLayer.GetSession();

                IQuery q = s.CreateQuery("from Sahista");


                SortableBindingList<Sahista> a = new SortableBindingList<Sahista>(q.List<Sahista>());
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
                if (dgv1.Columns["Rang"] == null)
                {
                    dgv1.Columns.Add("Rang", "Rang");
                    dgv1.Columns.Add("ds", "Datum sticanja");
                    dgv1.Columns.Add("brds", "Broj partija do sticanja");
                }



                SahistaIzvedeni(a);
                

                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }


        public void SahistaIzvedeni(SortableBindingList<Sahista> a)
        {
            CurrencyManager cm1 = (CurrencyManager)BindingContext[dgv1.DataSource];
            int i = 0;
            foreach (Sahista value in a)
            {

                if (value is Majstor && chkSah.GetItemCheckState(0) == CheckState.Checked)
                {
                    dgv1.Rows[i].Cells["Rang"].Value = "Majstor";
                    dgv1.Rows[i].Cells["ds"].Value = ((Majstor)value).DatSticanja.ToShortDateString();
                }
                else if (value is MajstorskiKandidat && chkSah.GetItemCheckState(1) == CheckState.Checked)
                {
                    dgv1.Rows[i].Cells["Rang"].Value = "Majstorski kandidat";
                    dgv1.Rows[i].Cells["brds"].Value = ((MajstorskiKandidat)value).BrojPartijaDoSticanja;
                }
                else if (value is ObicanClan && chkSah.GetItemCheckState(2) == CheckState.Checked)
                {
                    dgv1.Rows[i].Cells["Rang"].Value = "Obican clan";
                }
                else
                {              
                    cm1.SuspendBinding();
                    dgv1.Rows[i].Visible = false;
                    cm1.ResumeBinding();
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
            if (dgv1.SelectedRows.Count==0)
            {
                MessageBox.Show("Molimo selktujte neki podatak");
                return;
            }
            if (dgv1.CurrentRow.DataBoundItem is Sahista)
            {
                var item = dgv1.CurrentRow.DataBoundItem;
                FormDodajSah f = new FormDodajSah();
                f.UpdateItem = item as Sahista;
                f.ShowDialog();
            }
        }
    }
}

using Federacija.BindList;
using Federacija.Entiteti;
using NHibernate;
using System;
using System.Windows.Forms;
using Federacija.Functions;

namespace Federacija
{
    public partial class FormPotezi : Form
    {
        public FormPotezi()
        {
            InitializeComponent();
        }

        public Partija Part
        {
            get;
            set;
        }

        private void FormPotezi_Load(object sender, EventArgs e)
        {
            ucitajPartiju();
            ucitajPoteze();
        }

        private void ucitajPartiju()
        {
            lblBeliVSCrni.Text = Part.BeliIgrac.ToString() + " vs " + Part.CrniIgrac.ToString();
            lblDatumVreme.Text = Part.Datum.ToShortDateString() +"  "+ Part.Vreme;
            lblIshod.Text = Part.Ishod;
        }

        private void ucitajPoteze()
        {
            try
            {
                ISession s = DataLayer.GetSession();
                s.Update(Part);

                SortableBindingList<Potez> a = new SortableBindingList<Potez>(Part.Potezi);

                dgvPotezi.Columns.Clear();
                dgvPotezi.DataSource = a;
                dgvPotezi.Columns["Partija"].Visible = false;
                dgvPotezi.Columns["Id"].Visible=false;

                dgvPotezi.Update();
                dgvPotezi.Refresh();
                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private void btnZatvori_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormPotezi_FormClosing(object sender, FormClosingEventArgs e)
        {
            Provera.Zatvaranje(e);
        }
    }
}
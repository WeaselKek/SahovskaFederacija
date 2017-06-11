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
    public partial class FormDodajPartija : Form
    {
        bool updaterino = false;
        bool closenow = false;
        public FormDodajPartija()
        {
            InitializeComponent();
        }

        public Turnir Turn
        {
            set;
            get;
        }
        public Partija UpdateItem
        {
            get;
            set;
        }
        Sahista Beli = null;
        Sahista Crni = null;
        IList<Potez> Ptz;
        private void FormDodajPartija_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (closenow)
            {
                return;
            }
            DialogResult r = MessageBox.Show("Da li ste sigurni", "Upozorenje", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (r == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormDodajPartija_Load(object sender, EventArgs e)
        {
            Ptz = new List<Potez>();
            label2.Text = Turn.Naziv + "  " + Turn.Godina.ToString() + "  " + Turn.Grad;
            lblRbr.Text = (Ptz.Count() + 1).ToString();
            ucitajDGV();

        }

        private void ucitajDGV()
        {

            dgvSahista.Columns.Clear();
            ISession s = DataLayer.GetSession();

            IList<Sahista> shl = new List<Sahista>();


            shl = (from o in s.Query<Sahista>()
                             select o).ToList<Sahista>();


            SortableBindingList<Sahista> a = new SortableBindingList<Sahista>(shl);

            s.Close();

            dgvSahista.DataSource = a;

            //dgv1.AutoGenerateColumns = false;
            dgvSahista.AllowUserToAddRows = false;
            foreach (DataGridViewColumn v in dgvSahista.Columns)
            {
                v.Visible = false;
            }
            dgvSahista.Columns["Ime"].Visible = true;
            dgvSahista.Columns["Prezime"].Visible = true;
            dgvSahista.Columns["Drzava"].Visible = true;
        }

        private void btnDodajPotez_Click(object sender, EventArgs e)
        {
            Potez p = new Potez();
            p.RedniBr = Ptz.Count() + 1;
            p.PocetnoPolje = txtPoc.Text;
            p.KrajnjePolje = txtKraj.Text;
            p.Vreme = txtVreme.Text;
            Ptz.Add(p);
            lstPotez.Items.Add(p);

            //ciscenje textboxa i inkrement labele
            txtPoc.Text = txtKraj.Text = txtVreme.Text = string.Empty;
            lblRbr.Text = (Ptz.Count() + 1).ToString();
        }

        private void btnIzmeniPotez_Click(object sender, EventArgs e)
        {
            if (lstPotez.SelectedItems.Count == 0)
                return;
            Potez p = (Potez)lstPotez.SelectedItems[0];
            p.PocetnoPolje = txtPoc.Text;
            p.KrajnjePolje = txtKraj.Text;
            p.Vreme = txtVreme.Text;

            //refresh listboxa
            lstPotez.Items.Clear();
            lstPotez.Items.AddRange(Ptz.ToArray());

            //ciscenje textboxa
            txtPoc.Text = txtKraj.Text = txtVreme.Text = string.Empty;


        }

        private void lstPotez_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtPoc.Text = Ptz[lstPotez.SelectedIndex].PocetnoPolje;
            txtKraj.Text = Ptz[lstPotez.SelectedIndex].KrajnjePolje;
            txtVreme.Text = Ptz[lstPotez.SelectedIndex].Vreme;
        }

        private void btnObrisiPotez_Click(object sender, EventArgs e)
        {
            if (lstPotez.Items.Count == 0)
                return;
            Potez p = (Potez)lstPotez.Items[lstPotez.Items.Count - 1];
            Ptz.Remove(p);

            //refresh listboxa
            lstPotez.Items.Clear();
            lstPotez.Items.AddRange(Ptz.ToArray());

            //inkrement labele
            lblRbr.Text = (Ptz.Count() + 1).ToString();
        }

        private void btnBeli_Click(object sender, EventArgs e)
        {
            
            if (dgvSahista.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selektujte Sahistu");
                return;
            }
            Sahista item = dgvSahista.SelectedRows[0].DataBoundItem as Sahista;
            if (Crni != null)
                if (item.RegBr == Crni.RegBr)
                {
                    MessageBox.Show("Sahista ne moze igrati sa samim sobom");
                    return;
                }
            Beli = item;
            lblBeli.Text = Beli.Ime + " " + Beli.Prezime;
        }

        private void btnCrni_Click(object sender, EventArgs e)
        {
            
            if (dgvSahista.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selektujte Sahistu");
                return;
            }
            Sahista item = dgvSahista.SelectedRows[0].DataBoundItem as Sahista;
            if (Beli != null)
                if (item.RegBr == Beli.RegBr)
                {
                    MessageBox.Show("Sahista ne moze igrati sa samim sobom");
                    return;
                }
            Crni = item;
            lblCrni.Text = Crni.Ime + " " + Crni.Prezime;
        }
    }
}

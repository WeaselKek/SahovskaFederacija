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
        Sahista Beli;
        Sahista Crni;
        IList<Potez> Ptz;
        Sudija Sudac;
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
            rdbBeli.Checked = true;
            label2.Text = Turn.Naziv + "  " + Turn.Godina.ToString() + "  " + Turn.Grad;
            lblRbr.Text = (Ptz.Count() + 1).ToString();
            ucitajDGV();

        }

        private void ucitajDGV()
        {
            try
            {
                dgvSahista.Columns.Clear();
                ISession s = DataLayer.GetSession();

                int i = 0;
                Organizator or;
                Majstor m;
                IList<Sudija> sud = new List<Sudija>();

                sud = (from o in s.Query<Sudija>()
                       select o).ToList<Sudija>();


                SortableBindingList<Sudija> a1 = new SortableBindingList<Sudija>(sud);


                IList<Sahista> shl = new List<Sahista>();

                shl = (from o in s.Query<Sahista>()
                       select o).ToList<Sahista>();


                SortableBindingList<Sahista> a2 = new SortableBindingList<Sahista>(shl);

                //s.Close();

                dgvSudija.DataSource=a1;
                dgvSahista.DataSource = a2;

                //dgvSahista kod
                dgvSahista.AllowUserToAddRows = false;
                foreach (DataGridViewColumn v in dgvSahista.Columns)
                {
                    v.Visible = false;
                }
                dgvSahista.Columns["Ime"].Visible = true;
                dgvSahista.Columns["Prezime"].Visible = true;
                dgvSahista.Columns["Drzava"].Visible = true;

                //dgvSudija kod
                dgvSudija.AllowUserToAddRows = false;
                dgvSudija.Columns["Id"].Visible = false;
                dgvSudija.Columns["FlagMajstor"].Visible = false;
                dgvSudija.Columns["FlagOrganizator"].Visible = false;
                dgvSudija.Columns.Add("tip","Tip");
                dgvSudija.Columns.Add("ime", "Ime");
                dgvSudija.Columns.Add("prezime", "Prezime");
              
               
                foreach (Sudija value in a1)
                {
                    if (value.FlagMajstor == 1)
                    {
                        m = (from o in s.Query<Majstor>()
                             where (o.SudijaId == value)
                             select o).Single();
                        dgvSudija.Rows[i].Cells["tip"].Value = "Majstor";
                        dgvSudija.Rows[i].Cells["ime"].Value = m.Ime;
                        dgvSudija.Rows[i].Cells["prezime"].Value = m.Prezime;
                    }
                    else
                    {
                        or = (from o in s.Query<Organizator>()
                              where (o.SudijaId == value)
                              select o).Single();
                        dgvSudija.Rows[i].Cells["tip"].Value = "Organizator";
                        dgvSudija.Rows[i].Cells["ime"].Value = or.Ime;
                        dgvSudija.Rows[i].Cells["prezime"].Value = or.Prezime;
                    }
                    i++;
                }

                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
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
            
                if (item == Crni)
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
           
                if (item == Beli)
                {
                    MessageBox.Show("Sahista ne moze igrati sa samim sobom");
                    return;
                }
            Crni = item;
            lblCrni.Text = Crni.Ime + " " + Crni.Prezime;
        }

        private void btnPotvrdi_Click(object sender, EventArgs e)
        {
            try
            {
                if (Beli == null || Crni == null || Sudac == null || txtPartTrajanje.Text == "" || txtPartVreme.Text == "")
                {
                    MessageBox.Show("Niste pravilno uneli podatke");
                    return;
                }

                ISession s = DataLayer.GetSession();

                Partija p = new Partija();

                int num;
                p.Datum = dtpDat.Value;
                p.Vreme = txtPartVreme.Text;
                if(Int32.TryParse(txtPartTrajanje.Text,out num))
                    p.Trajanje=num;
                p.Ishod=grpIshod.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked).Text.ToUpper();
                p.BeliIgrac = Beli;
                p.CrniIgrac = Crni;
                foreach (Potez pt in Ptz)
                {
                    pt.Partija = p;
                } 
                p.Potezi = Ptz;
                p.Turnir = Turn;
                p.Sudija = Sudac;

                s.SaveOrUpdate(p);

                s.Flush();
                s.Close();

                if (!updaterino)
                    MessageBox.Show("Uspesno dodata Partija");
                else
                    MessageBox.Show("Uspesno izmenjena Partija");
                closenow = true;
                this.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private void btnSudija_Click(object sender, EventArgs e)
        {
            if (dgvSudija.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selektujte Sudiju");
                return;
            }
            Sudija Item = dgvSudija.SelectedRows[0].DataBoundItem as Sudija;
            lblSudija.Text = dgvSudija.SelectedRows[0].Cells["ime"].Value + "  " + dgvSudija.SelectedRows[0].Cells["prezime"].Value;
            Sudac = Item;
        }
    }
}

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
    public partial class FormDodajPartija : Form
    {
        private bool updaterino = false;
        private bool closenow = false;

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

        private Sahista Beli;
        private Sahista Crni;
        private IList<Potez> Ptz;
        private Sudija Sudac;

        private void FormDodajPartija_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (closenow)
            {
                return;
            }
            Provera.Zatvaranje(e);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormDodajPartija_Load(object sender, EventArgs e)
        {
            if (UpdateItem != null)
            {
                updaterino = true;
                ucitajKontrole();
            }
            else
            {
                this.Text = "Dodaj partiju";
                Ptz = new List<Potez>();
                rdbBeli.Checked = true;
                label2.Text = "\"" + Turn.Naziv + "\"" + "  " + Turn.Godina.ToString() + "  " + Turn.Grad;
                lblRbr.Text = (Ptz.Count() + 1).ToString();
            }
            ucitajDGV();
        }

        private void ucitajKontrole()
        {
            ISession s = DataLayer.GetSession();
            ITransaction t = s.BeginTransaction();
            s.Update(UpdateItem);
            t.Commit();
            dtpDat.Value = UpdateItem.Datum;
            foreach (RadioButton r in grpIshod.Controls.OfType<RadioButton>())
            {
                if (r.Text.ToUpper() == UpdateItem.Ishod)
                    r.Checked = true;
            }
            txtPartVreme.Text = UpdateItem.Vreme;
            txtPartTrajanje.Text = UpdateItem.Trajanje.ToString();
            Beli = UpdateItem.BeliIgrac;
            Crni = UpdateItem.CrniIgrac;
            Sudac = UpdateItem.Sudija;
            Turn = UpdateItem.Turnir;
            Ptz = UpdateItem.Potezi;
            refreshLBX();
            lblCrni.Text = Crni.Ime + " " + Crni.Prezime;
            lblBeli.Text = Beli.Ime + " " + Beli.Prezime;
            label2.Text = Turn.Naziv + "  " + Turn.Godina.ToString() + "  " + Turn.Grad;
            lblRbr.Text = (Ptz.Count() + 1).ToString();
            string sudtext = SudOP.ucitajSudiju(s, Sudac);
            lblSudija.Text = sudtext;
            s.Close();
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
                dgvSudija.DataSource = a1;

                IList<Sahista> shl = new List<Sahista>();
                shl = (from o in s.Query<Sahista>()
                       select o).ToList<Sahista>();

                SortableBindingList<Sahista> a2 = new SortableBindingList<Sahista>(shl);
                dgvSahista.DataSource = a2;

                //dgvSahista kod
                foreach (DataGridViewColumn v in dgvSahista.Columns)
                {
                    v.Visible = false;
                }
                dgvSahista.Columns["Ime"].Visible = true;
                dgvSahista.Columns["Prezime"].Visible = true;
                dgvSahista.Columns["Drzava"].Visible = true;

                //dgvSudija kod
                dgvSudija.Columns["Id"].Visible = false;
                dgvSudija.Columns["FlagMajstor"].Visible = false;
                dgvSudija.Columns["FlagOrganizator"].Visible = false;
                dgvSudija.Columns.Add("tip", "Tip");
                dgvSudija.Columns.Add("ime", "Ime i prezime");

                foreach (Sudija value in a1)
                {
                    string sts = SudOP.ucitajSudiju(s, value);
                    if (value.FlagMajstor == 1)
                    {
                        m = (from o in s.Query<Majstor>()
                             where (o.SudijaId == value)
                             select o).Single();
                        dgvSudija.Rows[i].Cells["tip"].Value = "Majstor";
                        dgvSudija.Rows[i].Cells["ime"].Value = m.Ime + " " + m.Prezime;
                    }
                    else if (value.FlagOrganizator == 1)
                    {
                        or = (from o in s.Query<Organizator>()
                              where (o.SudijaId == value)
                              select o).Single();
                        dgvSudija.Rows[i].Cells["tip"].Value = "Organizator";
                        dgvSudija.Rows[i].Cells["ime"].Value = or.Ime + " " + or.Prezime;
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
            refreshLBX();
        }

        private void btnIzmeniPotez_Click(object sender, EventArgs e)
        {
            if (lstPotez.SelectedItems.Count == 0)
                return;
            Potez p = (Potez)lstPotez.SelectedItems[0];
            p.PocetnoPolje = txtPoc.Text;
            p.KrajnjePolje = txtKraj.Text;
            p.Vreme = txtVreme.Text;

            refreshLBX();
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

            refreshLBX();
        }

        private void refreshLBX()
        {
            lstPotez.Items.Clear();
            lstPotez.Items.AddRange(Ptz.ToArray());
            txtPoc.Text = txtKraj.Text = txtVreme.Text = string.Empty;
            lblRbr.Text = (Ptz.Count() + 1).ToString();
        }

        private void btnBeli_Click(object sender, EventArgs e)
        {
            if (!Provera.chkIfSelected(dgvSahista))
                return;

            Sahista item = dgvSahista.CurrentRow.DataBoundItem as Sahista;
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
            if (!Provera.chkIfSelected(dgvSahista))
                return;

            Sahista item = dgvSahista.CurrentRow.DataBoundItem as Sahista;
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
                Partija p;
                if (!updaterino)
                {
                    p = new Partija();
                }
                else
                {
                    s.Update(UpdateItem);
                    p = UpdateItem;
                }
                int num;
                p.Datum = dtpDat.Value;
                p.Vreme = txtPartVreme.Text;
                if (Int32.TryParse(txtPartTrajanje.Text, out num))
                    p.Trajanje = num;
                p.Ishod = grpIshod.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked).Text.ToUpper();
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
            if (!Provera.chkIfSelected(dgvSudija))
                return;

            Sudija item = dgvSudija.CurrentRow.DataBoundItem as Sudija;
            lblSudija.Text = dgvSudija.CurrentRow.Cells["ime"].Value.ToString();
            Sudac = item;
        }
    }
}
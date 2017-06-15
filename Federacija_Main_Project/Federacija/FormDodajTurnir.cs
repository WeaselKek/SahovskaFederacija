using Federacija.Entiteti;
using Federacija.Functions;
using NHibernate;
using System;
using System.Linq;
using System.Windows.Forms;

namespace Federacija
{
    public partial class FormDodajTurnir : Form
    {
        private bool updaterino = false;
        private bool closenow = false;

        public Turnir UpdateItem
        {
            get;
            set;
        }

        public FormDodajTurnir()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormDodajTurnir_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (closenow)
            {
                return;
            }
            Provera.Zatvaranje(e);
        }

        private void FormDodajTurnir_Load(object sender, EventArgs e)
        {
            rbNormalan.Checked = true;
            rbTakmicarski.Checked = true;
            grbEgzibicioni.Enabled = false;
            panelNovacNamena.Enabled = false;
            panelTrajanjePartije.Enabled = false;

            if (UpdateItem != null)
            {
                ucitajKotrole();
            }
        }

        private void ucitajKotrole()
        {
            // ovde treba da se ucitaju podaci iz UpdateItem iz textboxa
            updaterino = true;
        }

        private void rbEgzibicioni_CheckedChanged(object sender, EventArgs e)
        {
            if (rbEgzibicioni.Checked)
            {
                grbEgzibicioni.Enabled = true;
                rbPromotivni.Checked = true;
            }
            else
            {
                grbEgzibicioni.Enabled = false;
            }
        }

        private void rbTakmicarski_CheckedChanged(object sender, EventArgs e)
        {
            if (rbTakmicarski.Checked)
            {
                grbTakmicarski.Enabled = true;
                rbRegionalni.Checked = true;
            }
            else
            {
                grbTakmicarski.Enabled = false;
            }
        }

        private void rbHumanitarni_CheckedChanged(object sender, EventArgs e)
        {
            if (rbHumanitarni.Checked)
            {
                panelNovacNamena.Enabled = true;
            }
            else
            {
                panelNovacNamena.Enabled = false;
            }
        }

        private void grbEgzibicioni_EnabledChanged(object sender, EventArgs e)
        {
            if (grbEgzibicioni.Enabled == false)
            {
                var radioButtons = grbEgzibicioni.Controls.OfType<RadioButton>();
                foreach (RadioButton rb in radioButtons)
                {
                    rb.Checked = false;
                }
            }
        }

        private void grbTakmicarski_EnabledChanged(object sender, EventArgs e)
        {
            if (grbTakmicarski.Enabled == false)
            {
                var radioButtons = grbTakmicarski.Controls.OfType<RadioButton>();
                foreach (RadioButton rb in radioButtons)
                {
                    rb.Checked = false;
                }
            }
        }

        private void panelNovacNamena_EnabledChanged(object sender, EventArgs e)
        {
            if (panelNovacNamena.Enabled == false)
            {
                var textBoxes = panelNovacNamena.Controls.OfType<TextBox>();
                foreach (TextBox txt in textBoxes)
                {
                    txt.Clear();
                }
            }
        }

        private void rbBrzopotezni_CheckedChanged(object sender, EventArgs e)
        {
            if (rbBrzopotezni.Checked)
            {
                panelTrajanjePartije.Enabled = true;
            }
            else
            {
                panelTrajanjePartije.Enabled = false;
            }
        }

        private bool validacija()
        {
            if ((txtNaziv.Text == "") || (txtGrad.Text == "") || (txtDrzava.Text == "") || (txtGodina.Text == ""))
            {
                MessageBox.Show("Zgresili ste");
                return false;
            }
            if (panelNovacNamena.Enabled && (txtNovac.Text == "" || txtNamena.Text == ""))
            {
                MessageBox.Show("Unesite novac i namenu");
                return false;
            }
            if (panelTrajanjePartije.Enabled && txtTrajanje.Text == "")
            {
                MessageBox.Show("Unesite trajanje partije");
                return false;
            }

            return true;
        }

        private void btnPotvrdi_Click(object sender, EventArgs e)
        {
            //Validacija
            if (!validacija())
                return;

            try
            {
                ISession s = DataLayer.GetSession();
                Turnir t;

                if (!updaterino)
                {
                    if (rbInternacionalni.Checked)
                        t = new TurnirTakmicarskiInternacionalni();
                    else if (rbNacionalni.Checked)
                        t = new TurnirTakmicarskiNacionalni();
                    else if (rbRegionalni.Checked)
                        t = new TurnirTakmicarskiRegionalni();
                    else if (rbPromotivni.Checked)
                        t = new TurnirEgzibicioniPromotivni();
                    else
                    {
                        t = new TurnirEgzibicioniHumanitarni();
                        ((TurnirEgzibicioniHumanitarni)t).Novac = Int32.Parse(txtNovac.Text);
                        ((TurnirEgzibicioniHumanitarni)t).Namena = txtNamena.Text;
                    }
                }
                else
                {
                    t = s.Get<Turnir>(UpdateItem.Id);
                    //itditd...
                }

                if (rbBrzopotezni.Checked)
                {
                    t.NacinOdigravanja = "BRZOPOTEZNI";
                    t.TrajanjePartije = Int32.Parse(txtTrajanje.Text);
                }
                else
                {
                    t.NacinOdigravanja = "NORMALAN";
                }
                t.Naziv = txtNaziv.Text;
                t.Godina = Int32.Parse(txtGodina.Text);
                t.Grad = txtGrad.Text;
                t.Drzava = txtDrzava.Text;
                t.DatumOd = dtpDatumOD.Value;
                t.DatumDo = dtpDatumDO.Value;

                s.SaveOrUpdate(t);

                s.Flush();
                s.Close();

                if (!updaterino)
                    MessageBox.Show("Uspesno dodat Turnir");
                else
                    MessageBox.Show("Uspesno izmenjen Turnir");
                closenow = true;
                this.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }
    }
}
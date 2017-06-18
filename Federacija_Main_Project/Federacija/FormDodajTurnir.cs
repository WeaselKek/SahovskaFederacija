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
            if (UpdateItem != null)
            {
                this.Text = "Izmeni turnir";
                updaterino = true;
                panelNovacNamena.Enabled = false;
                panelTrajanjePartije.Enabled = false;
                ucitajKotrole();
            }
            else
            {

                rbNormalan.Checked = true;
                rbTakmicarski.Checked = true;
                grbEgzibicioni.Enabled = false;
                panelNovacNamena.Enabled = false;
                panelTrajanjePartije.Enabled = false;
            }
        }

        private void ucitajKotrole()
        {
            txtNaziv.Text = UpdateItem.Naziv;
            txtGodina.Text = UpdateItem.Godina.ToString();
            txtGrad.Text = UpdateItem.Grad;
            txtDrzava.Text = UpdateItem.Drzava;
            dtpDatumOD.Value = UpdateItem.DatumOd;
            dtpDatumDO.Value = UpdateItem.DatumDo;

            if (UpdateItem.NacinOdigravanja == "NORMALAN")
            {
                rbNormalan.Checked = true;
            }
            else
            {
                rbBrzopotezni.Checked = true;
                panelTrajanjePartije.Enabled = true;
                txtTrajanje.Text = UpdateItem.TrajanjePartije.ToString();
            }
            Type tip = UpdateItem.GetType();

            switch (tip.Name)
            {
                case "TurnirTakmicarskiInternacionalni":
                    rbTakmicarski.Checked = true;
                    rbInternacionalni.Checked = true;
                    break;
                case "TurnirTakmicarskiNacionalni":
                    rbTakmicarski.Checked = true;
                    rbNacionalni.Checked = true;
                    break;
                case "TurnirTakmicarskiRegionalni":
                    rbTakmicarski.Checked = true;
                    rbRegionalni.Checked = true;
                    break;
                case "TurnirEgzibicioniHumanitarni":
                    rbEgzibicioni.Checked = true;
                    rbHumanitarni.Checked = true;
                    panelNovacNamena.Enabled = true;
                    txtNovac.Text = UpdateItem.Novac.ToString();
                    txtNamena.Text = UpdateItem.Namena;
                    break;
                case "TurnirEgzibicioniPromotivni":
                    rbEgzibicioni.Checked = true;
                    rbPromotivni.Checked = true;
                    break;
            }
            grbZnacaj.Enabled = false;
            grbEgzibicioni.Enabled = false;
            grbTakmicarski.Enabled = false;


        }

        private void rbEgzibicioni_CheckedChanged(object sender, EventArgs e)
        {
            if (rbEgzibicioni.Checked && updaterino == false)
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
            if (rbTakmicarski.Checked && updaterino == false)
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
            if (grbEgzibicioni.Enabled == false && updaterino == false)
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
            if (grbTakmicarski.Enabled == false && updaterino == false)
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
                MessageBox.Show("Niste uneli sve potrebne podatke");
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
                    t = UpdateItem;
                    if (t is TurnirEgzibicioniHumanitarni)
                    {
                        t.Novac = Int32.Parse(txtNovac.Text);
                        t.Namena = txtNamena.Text;
                    }
                }

                if (rbBrzopotezni.Checked)
                {
                    t.NacinOdigravanja = "BRZOPOTEZNI";
                    t.TrajanjePartije = Int32.Parse(txtTrajanje.Text);
                }
                else
                {
                    t.NacinOdigravanja = "NORMALAN";
                    t.TrajanjePartije = 0;
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

        private void txtGodina_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtTrajanje_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtNovac_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
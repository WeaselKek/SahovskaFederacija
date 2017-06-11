using Federacija.Entiteti;
using NHibernate;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Federacija
{
    public partial class FormDodajTurnir : Form
    {
        bool updaterino = false;

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
            DialogResult r = MessageBox.Show("Da li ste sigurni", "Upozorenje", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (r == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void FormDodajTurnir_Load(object sender, EventArgs e)
        {
            grbEgzibicioni.Enabled = false;
            grbTakmicarski.Enabled = false;
            panelNovacNamena.Enabled = false;
            panelTrajanjePartije.Enabled = false;
        }

        private void rbEgzibicioni_CheckedChanged(object sender, EventArgs e)
        {
            if (rbEgzibicioni.Checked)
            {
                grbEgzibicioni.Enabled = true;
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

                    if (rbTakmicarski.Checked)
                    {
                        if (rbInternacionalni.Checked)
                            t = new TurnirTakmicarskiInternacionalni();
                        else if (rbNacionalni.Checked)
                            t = new TurnirTakmicarskiNacionalni();
                        else
                            t = new TurnirTakmicarskiRegionalni();
                    }
                    else if (rbEgzibicioni.Checked)
                    {
                        if (rbPromotivni.Checked)
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
                        t = new TurnirTakmicarskiRegionalni();
                    }
                }
                else
                {
                    //azuriranje... 
                    //
                    //
                    //
                    t = new TurnirTakmicarskiRegionalni();
                    //
                    //
                }

                if (rbNormalan.Checked)
                {
                    t.NacinOdigravanja = "NORMALAN";
                    t.TrajanjePartije = Int32.Parse(txtTrajanje.Text);
                }
                else
                    t.NacinOdigravanja = "BRZOPOTEZNI";
                t.Naziv = txtNaziv.Text;
                t.Godina = Int32.Parse(txtGodina.Text);
                t.Grad = txtGrad.Text;
                t.Drzava = txtDrzava.Text;
                t.DatumOd = dtpDatumOD.Value;
                t.DatumDo = dtpDatumDO.Value;


                s.SaveOrUpdate(t);

                s.Flush();
                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }

            if (!updaterino)
                MessageBox.Show("Uspesno dodat Turnir");
            else
                MessageBox.Show("Uspesno izmenjen Sahista");
            //closenow = true;
            this.Close();
        }

    }
}

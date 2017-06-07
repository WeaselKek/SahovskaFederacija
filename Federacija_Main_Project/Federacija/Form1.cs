using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using NHibernate;
using Federacija.Entiteti;
using Federacija.Mapiranja;

namespace Federacija
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSahistaR_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();


                Majstor p = s.Load<Majstor>(1001);

                label1.Text = p.RegBr.ToString() + " " + p.Ime.ToString() + " " + p.Prezime.ToString() + " " + p.DatSticanja.ToString("yyyy-mm-dd");

                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Text = "";
            label2.Text = "Potezi";
            label5.Text = "";
        }

        private void btnSahistaC_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();


                Entiteti.Majstor p = new Entiteti.Majstor();



                p.Ime = "Deki";
                p.Prezime = "Sukic";
                p.DatRodj = new DateTime(2000, 5, 21);
                p.DatUclanjenja = new DateTime(2007, 5, 21);
                p.DatSticanja = new DateTime(2009, 5, 21);
                p.BrojPasosa = 663253;
                p.Drzava = "Tanzanija";



                s.SaveOrUpdate(p);

                s.Flush();
                s.Close();
                MessageBox.Show("Uspesno dodat majstor");
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
                MessageBox.Show("Desila se greska");
            }
        }

        private void btnTurnirR_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                TurnirEgzibicioniHumanitarni p = s.Load<TurnirEgzibicioniHumanitarni>(503);

                label1.Text = p.Id.ToString() + " " + p.Naziv.ToString() + " " + p.Drzava.ToString() + " " + p.Grad + " " + p.Novac + " " + p.Namena;

                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
                MessageBox.Show("Desila se greska");
            }
        }

        private void btnPartijaR_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Partija p = s.Load<Partija>(10001);
                int br = 1;
                bool ts = true;

                foreach (Potez value in p.Potezi)
                {
                    if (ts)
                    {
                        label3.Text += "\n" + br + ".  " + value.PocetnoPolje + "    " + value.KrajnjePolje;
                        br++;
                        ts = false;
                    }
                    else
                    {
                        label4.Text += "\n" + value.PocetnoPolje + "    " + value.KrajnjePolje;
                        ts = true;
                    }
                }



                label1.Text = p.Id.ToString() + " " + p.Trajanje.ToString() + " " + p.Ishod.ToString() + "\n" + p.BeliIgrac.Prezime + " vs " + p.CrniIgrac.Prezime + "\n";

                if (p.Sudija.FlagMajstor == 1)
                {
                    IQuery q = s.CreateQuery("from Majstor as o where o.SudijaId.Id=" + p.Sudija.Id);
                    Majstor d = q.UniqueResult<Majstor>();
                    label1.Text += "na ovom mecu sudio je   " + d.Ime + " " + d.Prezime;
                }
                else
                {
                    IQuery q = s.CreateQuery("from Organizator as o where o.SudijaId.Id=" + p.Sudija.Id);
                    Organizator d = q.UniqueResult<Organizator>();
                    label1.Text += "na ovom mecu sudio je   " + d.Ime + " " + d.Prezime;
                }

                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
                MessageBox.Show("Desila se greska");
            }
        }

        private void btnSahistaLS_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                IQuery q = s.CreateQuery("from Sahista");

                IList<Sahista> p = q.List<Sahista>();
                label5.Text = "";

                foreach (Sahista value in p)
                {
                    if (value is Majstor)
                    {
                        label5.Text += value.RegBr.ToString() + "   " + value.Ime.ToString() + "  " + value.Prezime.ToString() + "  " + value.DatUclanjenja.ToString("yyyy-mm-dd") + "   " + ((Majstor)value).DatSticanja.ToString("yyyy-mm-dd") + "\n";
                    }
                    else if (value is MajstorskiKandidat)
                    {
                        label5.Text += value.RegBr.ToString() + "  " + value.Ime.ToString() + "  " + value.Prezime.ToString() + "  " + value.DatUclanjenja.ToString("yyyy-mm-dd") + "   " + ((MajstorskiKandidat)value).BrojPartijaDoSticanja + "\n";
                    }
                    else
                    {
                        label5.Text += value.RegBr.ToString() + "   " + value.Ime.ToString() + "  " + value.Prezime.ToString() + "  " + value.DatUclanjenja.ToString("yyyy-mm-dd") + "\n";
                    }
                }


                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
                MessageBox.Show("Desila se greska");
            }
        }

        private void btnTurnirC_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                TurnirTakmicarskiRegionalni p = new TurnirTakmicarskiRegionalni();

                p.DatumOd = new DateTime(2001, 6, 21);
                p.DatumDo = new DateTime(2001, 6, 24);
                p.Naziv = "Sejic Open";
                p.Drzava = "Kanada";
                p.Godina = 2001;
                p.Grad = "Otawa";
                p.NacinOdigravanja = "NORMALAN";


                s.SaveOrUpdate(p);

                s.Flush();
                s.Close();
                MessageBox.Show("Uspesno dodat turnir");
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
                MessageBox.Show("Desila se greska");
            }
        }

        private void btnOrgC_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Organizator p = new Organizator();

                p.Ime = "Jim";
                p.Prezime = "Hoxworth";
                p.MatBr = "734234";
                p.Ulica = "Jerotijeva";
                p.Grad = "NewYork";
                p.Broj = 20;




                s.SaveOrUpdate(p);

                s.Flush();
                s.Close();
                MessageBox.Show("Uspesno dodat organizator");
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
                MessageBox.Show("Desila se greska");
            }
        }

        private void btnMTM_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Organizuje o = new Organizuje();

                Turnir t = s.Load<TurnirEgzibicioniHumanitarni>(503);

                Organizator r = s.Load<Organizator>("734234");

                o.OrganizujeOrganizator = r;
                o.OrganizujeTurnir = t;






                s.SaveOrUpdate(o);
                //s.SaveOrUpdate(t);
                // s.SaveOrUpdate(r);

                s.Flush();
                s.Close();

                MessageBox.Show("Uspesno dodata veza Many to many");
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
                MessageBox.Show("Desila se greska");
            }
        }

        private void btnOrgaLS_Click(object sender, EventArgs e)
        {
            try
            {

                ISession s = DataLayer.GetSession();
                label5.Text = "";
                Organizator r = s.Load<Organizator>("4684237944893");

                label5.Text = r.MatBr + " " + r.Ime + "  " + r.Prezime + "\n";



                foreach (Organizuje value in r.OrganizujeTurnir)
                {
                    label5.Text += value.OrganizujeTurnir.Naziv + "\n";
                }


                s.Flush();
                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
                MessageBox.Show("Desila se greska");
            }
        }

        private void btnTppC_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                TurnirTakmicarskiRegionalni p = new TurnirTakmicarskiRegionalni();

                p.Naziv = "Morlat Vombat";
                p.DatumOd = new DateTime(2001, 6, 21);
                p.DatumDo = new DateTime(2001, 6, 24);
                p.Drzava = "Kanada";
                p.Godina = 2001;
                p.Grad = "Otawa";
                p.NacinOdigravanja = "NORMALAN";
             

                s.SaveOrUpdate(p);



                Partija j = new Partija();
                j.Ishod = "REMI";
                j.Trajanje = 32323;
                j.Vreme = "56:27";
                j.Datum = new DateTime(2001, 6, 24);
                j.BeliIgrac = s.Load<Sahista>(1007);
                j.CrniIgrac = s.Load<Sahista>(1008);
                j.Sudija = s.Load<Sudija>(103);
                j.Turnir = p;

                s.SaveOrUpdate(j);

                Potez k1 = new Potez();
                k1.KrajnjePolje = "a8";
                k1.PocetnoPolje = "g7";
                k1.RedniBr = 1;
                k1.Vreme = "01:11";
                k1.Partija = j;

                s.SaveOrUpdate(k1);

                Potez k2 = new Potez();
                k2.KrajnjePolje = "c4";
                k2.PocetnoPolje = "h3";
                k2.RedniBr = 2;
                k2.Vreme = "57";
                k2.Partija = j;

                s.SaveOrUpdate(k2);

                Potez k3 = new Potez();
                k3.KrajnjePolje = "e1";
                k3.PocetnoPolje = "d7";
                k3.RedniBr = 3;
                k3.Vreme = "024";
                k3.Partija = j;

                s.SaveOrUpdate(k3);

                s.Flush();
                s.Close();
                MessageBox.Show("Uspesno ubacen turnir sa partijama");
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
                MessageBox.Show("Desila se greska");
            }
        }

        private void btnTurnirD_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                //Najbolje ubaciti ID novoubacenog turnira
                Turnir p = s.Load<Turnir>(521);

                s.Delete(p);



                s.Flush();
                s.Close();
                MessageBox.Show("Uspesno obrisan turnir");
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
                MessageBox.Show("Desila se greska");
            }
        }

        private void btnTtiR_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();



                IQuery q = s.CreateQuery("from TurnirTakmicarskiInternacionalni");

                IList<TurnirTakmicarskiInternacionalni> l = q.List<TurnirTakmicarskiInternacionalni>();

                label5.Text = "";

                foreach (Turnir value in l)
                {
                    label5.Text += value.Naziv + "\n";
                }



                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
                MessageBox.Show("Desila se greska");
            }
        }

        private void btnPromC_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                Organizator r = s.Load<Organizator>("5415557532792");
                Partija p = s.Load<Partija>(10007);

                Sudija t = new Sudija();
                t.FlagOrganizator = 1;
                t.FlagMajstor = 0;

                s.SaveOrUpdate(t);

                r.SudijaId = t;
                p.Sudija = t;

                s.SaveOrUpdate(r);
                s.SaveOrUpdate(p);

                s.Flush();
                s.Close();
                MessageBox.Show("Sudija uspesno izmenjen");

            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
                MessageBox.Show("Desila se greska");
            }
        }
    }
}


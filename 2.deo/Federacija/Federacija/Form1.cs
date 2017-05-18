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

                label1.Text = p.RegBr.ToString() + " " + p.Ime.ToString() + " " + p.Prezime.ToString() + " " + p.DatSticanja;

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
        }

        private void btnSahistaC_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();


                Entiteti.Majstor p = new Entiteti.Majstor();

                

                p.Ime = "Deki";
                p.Prezime = "Sukic";
                p.DatRodj = new DateTime(2000,5,21);
                p.DatUclanjenja=new DateTime(2007,5,21);
                p.DatSticanja=new DateTime(2009,5,21);
                p.BrojPasosa = 663253;
                p.Drzava = "Tanzanija";


                //s.Save(p);
                s.SaveOrUpdate(p);

                s.Flush();
                s.Close();
                MessageBox.Show("Uspesno dodat deki");
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
                MessageBox.Show("Nije uspesno dodat deki");
            }
        }

        private void btnTurnirR_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Turnir p = s.Load<Turnir>(503);

                label1.Text = p.Id.ToString() + " " + p.Naziv.ToString() + " " + p.Drzava.ToString() + " " + p.Grad + " " + p.TipEgzibicionog+" " +p.TipTakmicarskog+" " +p.Novac+" " +p.Namena;

                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
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



                label1.Text = p.Id.ToString() + " " + p.Trajanje.ToString() + " " + p.Ishod.ToString() + "\n" + p.BeliIgrac.Prezime + " vs " + p.CrniIgrac.Prezime;

                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }
    }
}


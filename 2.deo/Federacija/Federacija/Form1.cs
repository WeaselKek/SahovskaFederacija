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
        }

        private void button1_Click(object sender, EventArgs e)
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
    }
}


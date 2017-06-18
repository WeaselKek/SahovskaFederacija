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
using Federacija.BindList;
using Federacija.Entiteti;
using Federacija.Mapiranja;

namespace Federacija.Functions
{
   

    public class Provera
    {
        public static bool chkIfSelected(DataGridView d)
        {
            if (d.SelectedRows.Count == 0)
            {
                MessageBox.Show("Molimo selektujte neki podatak");
                return false;
            }
            if (d.SelectedRows.Count > 1)
            {
                MessageBox.Show("Molimo selektujte samo jedan red");
                return false;
            }
            return true;

        }
        public static void Zatvaranje(FormClosingEventArgs a)
        {
            DialogResult r = MessageBox.Show("Da li ste sigurni", "Upozorenje", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (r == DialogResult.No)
            {
                a.Cancel = true;
            }
        }
    }
    public class SudOP
    {
        public static string ucitajSudiju(ISession s, Sudija sud)
        {

            Majstor m;
            Organizator or;
            string st;
            if (sud.FlagMajstor == 1)
            {

                m = (from o in s.Query<Majstor>()
                     where (o.SudijaId == sud)
                     select o).Single();
               st = m.Ime + " " + m.Prezime;
            }
            else
            {
                or = (from o in s.Query<Organizator>()
                      where (o.SudijaId == sud)
                      select o).Single();
               st = or.Ime + " " + or.Prezime;
            }
            return st;

        }
    }

}
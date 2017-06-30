using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Federacija.Entiteti;
using NHibernate;
using Federacija.Functions;

namespace Federacija.DTO
{
    public class PartijaView
    {
        public DateTime Datum { get; set; }
        public int Trajanje { get; set; }
        public string Ishod { get; set; }
        public string BeliIgrac { get; set; }
        public string CrniIgrac { get; set; }
        public IList<PotezView> Potezi { get; set; }
        public string Turnir { get; set; }
        public string Sudija { get; set; }

        public PartijaView(Partija o)
        {
            this.Datum = o.Datum;
            this.Trajanje = o.Trajanje;
            this.Ishod = o.Ishod;
            this.BeliIgrac = o.BeliIgrac.ToString();
            this.CrniIgrac = o.CrniIgrac.ToString();
            this.Turnir = o.Turnir.ToString();

            ISession s = DataLayer.GetSession();
            this.Sudija = SudOP.ucitajSudiju(s, o.Sudija);
            s.Close();

            Potezi = new List<PotezView>();

            foreach (Potez value in o.Potezi)
            {
                this.Potezi.Add(new PotezView(value));
            }

        }

        public PartijaView()
        {
        }
    }
}

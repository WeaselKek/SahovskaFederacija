using System;
using System.Collections.Generic;

namespace SBP_2deo.Entiteti
{
    public class Partija
    {
        public virtual int Id { get; set; }
        public virtual DateTime Datum { get; set; }
        public virtual string Vreme { get; set; }
        public virtual int Trajanje { get; set; }
        public virtual string Ishod { get; set; }
        public Sahista BeliIgrac { get; set; }
        public Sahista CrniIgrac { get; set; }
        public IList<Potez> Potezi { get; set; }
        public Turnir Turnir { get; set; }
        public Sudija Sudija { get; set; }

        public Partija()
        {
            Potezi = new List<Potez>();
        }
    }
}

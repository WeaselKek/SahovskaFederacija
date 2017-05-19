using System;
using System.Collections.Generic;

namespace Federacija.Entiteti
{
    public class Partija
    {
        public virtual int Id { get; set; }
        public virtual DateTime Datum { get; set; }
        public virtual string Vreme { get; set; }
        public virtual int Trajanje { get; set; }
        public virtual string Ishod { get; set; }
        public virtual Sahista BeliIgrac { get; set; }
        public virtual Sahista CrniIgrac { get; set; }
        public virtual IList<Potez> Potezi { get; set; }
        public virtual Turnir Turnir { get; set; }
        public virtual Sudija Sudija { get; set; }

        public Partija()
        {
            Potezi = new List<Potez>();
        }
    }
}

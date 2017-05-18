using System;
using System.Collections.Generic;

namespace Federacija.Entiteti
{
    public class Organizator
    {
        public virtual string MatBr { get; set; }
        public virtual string Ime { get; set; }
        public virtual string Prezime { get; set; }
        public virtual string Ulica { get; set; }
        public virtual int Broj { get; set; }
        public virtual string Grad { get; set; }
        public virtual Sudija SudijaId { get; set; }
        public virtual IList<Organizuje> OrganizujeTurnir { get; set; }

        public Organizator()
        {
            OrganizujeTurnir = new List<Organizuje>();
        }
    }
}

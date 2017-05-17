using System;
using System.Collections.Generic;

namespace SBP_2deo.Entiteti
{
    public class Sahista
    {
        public virtual int RegBr { get; set; }
        public virtual string Ime { get; set; }
        public virtual string Prezime { get; set; }
        public virtual DateTime DatRodj { get; set; }
        public virtual DateTime DatUclanjenja { get; set; }
        public virtual int BrojPasosa { get; set; }
        public virtual string Drzava { get; set; }
        public virtual string Ulica { get; set; }
        public virtual int Broj { get; set; }
        public virtual string Grad { get; set; }
        public IList<Partija> Partije { get; set; }

        public Sahista()
        {
            Partije = new List<Partija>();
        }
    }
}
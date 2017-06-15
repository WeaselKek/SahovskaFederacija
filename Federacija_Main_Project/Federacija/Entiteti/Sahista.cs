using System;
using System.Collections.Generic;

namespace Federacija.Entiteti
{
    public abstract class Sahista
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
        //public virtual IList<Partija> Partije { get; set; }

        public Sahista()
        {
            //Partije = new List<Partija>();
        }
        public override string ToString()
        {
            return Prezime;
        }
    }
        public class ObicanClan : Sahista
        {
            
        }

        public class Majstor : Sahista
        {
            public virtual DateTime DatSticanja { get; set; }
            public virtual Sudija SudijaId { get; set; }
        }

        public class MajstorskiKandidat : Sahista
        {
            public virtual int BrojPartijaDoSticanja { get; set; }
        }
    }

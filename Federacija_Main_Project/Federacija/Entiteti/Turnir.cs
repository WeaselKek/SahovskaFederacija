using System;
using System.Collections.Generic;

namespace Federacija.Entiteti
{
    public abstract class Turnir
    {
        public virtual int Id { get; set; }
        public virtual string Naziv { get; set; }
        public virtual string Drzava { get; set; }
        public virtual string Grad { get; set; }
        public virtual int Godina { get; set; }
        public virtual DateTime DatumOd { get; set; }
        public virtual DateTime DatumDo { get; set; }
        public virtual IList<Partija> TPartije { get; set; }
        public virtual IList<Organizuje> OrganizujeOrganizator { get; set; }
        public virtual IList<Sponzorise> SponzoriseSponzor { get; set; }
        public virtual string NacinOdigravanja { get; set; }
        public virtual int TrajanjePartije { get; set; }
        public virtual string PoZnacaju { get; set; }
        public virtual string TipTakmicarskog { get; set; }
        public virtual string TipEgzibicionog { get; set; }
        public virtual int Novac { get; set; }
        public virtual string Namena { get; set; }

        public Turnir()
        {
            TPartije = new List<Partija>();
            OrganizujeOrganizator = new List<Organizuje>();
            SponzoriseSponzor = new List<Sponzorise>();
        }
        public override string ToString()
        {
            return Naziv;
        }
    }

    public class TurnirTakmicarskiNacionalni : Turnir
    {
        public TurnirTakmicarskiNacionalni()
        {
            this.PoZnacaju = "TAKMICARSKI";

            this.TipTakmicarskog = "NACIONALNI";
        }
    }

    public class TurnirTakmicarskiRegionalni : Turnir
    {
        public TurnirTakmicarskiRegionalni()
        {
            this.PoZnacaju = "TAKMICARSKI";

            this.TipTakmicarskog = "REGIONALNI";
        }
    }

    public class TurnirTakmicarskiInternacionalni : Turnir
    {
        public TurnirTakmicarskiInternacionalni()
        {
            this.PoZnacaju = "TAKMICARSKI";

            this.TipTakmicarskog = "INTERNACIONALNI";
        }
    
    }

    public class TurnirEgzibicioniPromotivni : Turnir
    {
        public TurnirEgzibicioniPromotivni()
        {
            this.PoZnacaju = "EGZIBICIONI";

            this.TipEgzibicionog = "PROMOTIVNI";
        }
    }

    public class TurnirEgzibicioniHumanitarni : Turnir
    {
        public TurnirEgzibicioniHumanitarni()
        {
            this.PoZnacaju = "EGZIBICIONI";

            this.TipEgzibicionog = "HUMANITARNI";
        }
    }
}

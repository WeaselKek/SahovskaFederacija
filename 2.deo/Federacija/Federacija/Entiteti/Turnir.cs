using System;
using System.Collections.Generic;

namespace Federacija.Entiteti {
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

        public Turnir()
        {
            TPartije = new List<Partija>();
            OrganizujeOrganizator = new List<Organizuje>();
            SponzoriseSponzor = new List<Sponzorise>();
        }
    }

    public class TurnirNormalni : Turnir
    { }

    public class TurnirBrzopotezni : Turnir
    {
        public virtual int TrajanjePartije { get; set; }
    }

    public class TurnirTakmicarski : Turnir
    { }

    public class TakmicarskiNacionalni : TurnirTakmicarski
    { }

    public class TakmicarskiRegionalni : TurnirTakmicarski
    { }

    public class TakmicarskiInternacionalni : TurnirTakmicarski
    { }

    public class TurnirEgzibicioni : Turnir
    { }

    public class EgzibicioniPromotivni : TurnirEgzibicioni
    { }

    public class EgzibicioniHumanitarni : TurnirEgzibicioni
    {
        public virtual int PrikupljeniNovac { get; set; }
        public virtual string NamenaNovca { get; set; }
    }
}

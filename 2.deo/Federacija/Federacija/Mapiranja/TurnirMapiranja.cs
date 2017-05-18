using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Federacija.Entiteti;
using FluentNHibernate.Mapping;

namespace Federacija.Mapiranja
{
    public class TurnirMapiranja : ClassMap<Turnir>
    {
        public TurnirMapiranja()
        {
            Table("TURNIR");

            Id(x => x.Id, "ID").GeneratedBy.TriggerIdentity();

            DiscriminateSubClassesOnColumn("NACIN_ODIGRAVANJA");
            DiscriminateSubClassesOnColumn("PO_ZNACAJU");

            Map(x => x.Naziv, "NAZIV");
            Map(x => x.Drzava, "DRZAVA");
            Map(x => x.Grad, "GRAD");
            Map(x => x.Godina, "GODINA");
            Map(x => x.DatumOd, "DATUM_OD").CustomType("Date");
            Map(x => x.DatumDo, "DATUM_DO").CustomType("Date");

            HasMany(x => x.TPartije).KeyColumn("TURNIR_ID");
            HasMany(x => x.OrganizujeOrganizator).KeyColumn("TURNIR_ID").Cascade.All().Inverse();
            HasMany(x => x.SponzoriseSponzor).KeyColumn("TURNIR_ID");
        }
    }

    public class TurnirNormalniMapiranja : SubclassMap<TurnirNormalni>
    {
        public TurnirNormalniMapiranja()
        {
            DiscriminatorValue("NORMALAN");
        }
    }

    public class TurnirBrzopotezniMapiranja : SubclassMap<TurnirBrzopotezni>
    {
        public TurnirBrzopotezniMapiranja()
        {
            DiscriminatorValue("BRZOPOTEZNI");

            Map(x => x.TrajanjePartije, "TRAJANJE_PARTIJE").Nullable();
        }
    }

    public class TurnirTakmicarskiMapiranja : SubclassMap<TurnirTakmicarski>
    {
        public TurnirTakmicarskiMapiranja()
        {
            DiscriminatorValue("TAKMICARSKI");
        }
    }
}

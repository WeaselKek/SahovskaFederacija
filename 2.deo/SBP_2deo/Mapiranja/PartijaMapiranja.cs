using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SBP_2deo.Entiteti;
using FluentNHibernate.Mapping;

namespace SBP_2deo.Mapiranja
{
    public class PartijaMapiranja : ClassMap<Partija>
    {
        public PartijaMapiranja()
        {
            Table("PARTIJA");

            Id(x => x.Id, "ID").GeneratedBy.TriggerIdentity();

            Map(x => x.Datum, "DATUM").CustomType("Date");
            Map(x => x.Vreme, "VREME").Nullable();
            Map(x => x.Trajanje, "TRAJANJE").Nullable();
            Map(x => x.Ishod, "ISHOD");

            References(x => x.BeliIgrac).Column("BELI_IGRAC");
            References(x => x.CrniIgrac).Column("CRNI_IGRAC");
            References(x => x.Sudija).Column("SUDIJA_ID");
            References(x => x.Turnir).Column("TURNIR_ID");

            HasMany(x => x.Potezi).KeyColumn("PARTIJA_ID").Cascade.All();
        }
    }
}

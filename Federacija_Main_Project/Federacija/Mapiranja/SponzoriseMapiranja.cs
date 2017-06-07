using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Federacija.Entiteti;
using FluentNHibernate.Mapping;

namespace Federacija.Mapiranja
{
    public class SponzoriseMapiranja : ClassMap<Sponzorise>
    {
        public SponzoriseMapiranja()
        {
            Table("SPONZORISE");

            Id(x => x.Id, "ID").GeneratedBy.TriggerIdentity();

            References(x => x.SponzoriseSponzor).Column("NAZIV_SPONZORA");
            References(x => x.SponzoriseTurnir).Column("TURNIR_ID");
        }
    }
}

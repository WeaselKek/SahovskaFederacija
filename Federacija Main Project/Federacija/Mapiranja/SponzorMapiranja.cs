using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Federacija.Entiteti;
using FluentNHibernate.Mapping;

namespace Federacija.Mapiranja
{
    public class SponzorMapiranja : ClassMap<Sponzor>
    {
        public SponzorMapiranja()
        {
            Table("SPONZOR");

            Id(x => x.Naziv, "NAZIV").GeneratedBy.Assigned();

            HasMany(x => x.SponzoriseTurnir).KeyColumn("NAZIV_SPONZORA");
        }
    }
}

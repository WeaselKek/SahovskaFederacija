using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Federacija.Entiteti;
using FluentNHibernate.Mapping;

namespace Federacija.Mapiranja
{
    public class PotezMapiranja : ClassMap<Potez>
    {
        public PotezMapiranja()
        {
            Table("POTEZ");

            Id(x => x.Id, "ID").GeneratedBy.TriggerIdentity();

            Map(x => x.RedniBr, "REDNI_BROJ");
            Map(x => x.PocetnoPolje, "POCETNO_POLJE");
            Map(x => x.KrajnjePolje, "KRAJNJE_POLJE");
            Map(x => x.Vreme, "VREME");

            References(x => x.Partija).Column("ID");
        }
    }
}

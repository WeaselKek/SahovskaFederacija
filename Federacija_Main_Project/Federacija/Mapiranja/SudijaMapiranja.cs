using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Federacija.Entiteti;
using FluentNHibernate.Mapping;


namespace Federacija.Mapiranja
{
    public class SudijaMapiranja : ClassMap<Sudija>
    {

        public SudijaMapiranja()
        {
            Table("SUDIJA");
            Id(x => x.Id, "SUDIJA_ID").GeneratedBy.TriggerIdentity();
            Map(x => x.FlagMajstor, "F_MAJSTOR");
            Map(x => x.FlagOrganizator, "F_ORGANIZATOR");

        }
    }
}

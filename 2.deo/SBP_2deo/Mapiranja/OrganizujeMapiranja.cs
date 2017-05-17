using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SBP_2deo.Entiteti;
using FluentNHibernate.Mapping;

namespace SBP_2deo.Mapiranja
{
    public class OrganizujeMapiranja : ClassMap<Organizuje>
    {
        public OrganizujeMapiranja()
        {
            Table("ORGANIZUJE");

            Id(x => x.Id, "ID").GeneratedBy.TriggerIdentity();

            References(x => x.OrganizujeTurnir).Column("TURNIR_ID");
            References(x => x.OrganizujeOrganizator).Column("ORGANIZATOR_MBR");
        }
    }
}

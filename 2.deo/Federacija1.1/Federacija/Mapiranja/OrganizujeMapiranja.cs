using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Federacija.Entiteti;
using FluentNHibernate.Mapping;

namespace Federacija.Mapiranja
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

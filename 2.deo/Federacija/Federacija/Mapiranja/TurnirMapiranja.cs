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
           
            Map(x => x.Naziv, "NAZIV");
            Map(x => x.Drzava, "DRZAVA");
            Map(x => x.Grad, "GRAD");
            Map(x => x.Godina, "GODINA");
            Map(x => x.DatumOd, "DATUM_OD").CustomType("Date");
            Map(x => x.DatumDo, "DATUM_DO").CustomType("Date");
            Map(x => x.NacinOdigravanja, "NACIN_ODIGRAVANJA");
            Map(x => x.TrajanjePartije, "TRAJANJE_PARTIJE").Nullable();
            Map(x => x.PoZnacaju, "PO_ZNACAJU");
            Map(x => x.TipTakmicarskog, "TIP_TAKMICARSKOG").Nullable();
            Map(x => x.TipEgzibicionog, "TIP_EGZIBICIONOG").Nullable();
            Map(x => x.Novac, "NOVAC").Nullable();
            Map(x => x.Namena, "NAMENA_NOVCA").Nullable();

            HasMany(x => x.TPartije).KeyColumn("TURNIR_ID");
            HasMany(x => x.OrganizujeOrganizator).KeyColumn("TURNIR_ID").Cascade.All().Inverse();
            HasMany(x => x.SponzoriseSponzor).KeyColumn("TURNIR_ID");
        }
    }

    
}

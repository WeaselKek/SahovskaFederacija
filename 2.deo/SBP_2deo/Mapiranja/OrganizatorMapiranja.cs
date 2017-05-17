﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SBP_2deo.Entiteti;
using FluentNHibernate.Mapping;

namespace SBP_2deo.Mapiranja
{
    public class OrganizatorMapiranja : ClassMap<Organizator>
    {
        public OrganizatorMapiranja()
        {
            Table("ORGANIZATOR");

            Id(x => x.MatBr, "MAT_BR").GeneratedBy.TriggerIdentity();

            Map(x => x.Ime, "IME");
            Map(x => x.Prezime, "PREZIME");
            Map(x => x.Ulica, "ULICA");
            Map(x => x.Grad, "GRAD");
            Map(x => x.Broj, "BROJ");

            References(x => x.SudijaId).Column("SUDIJA_ID");
            HasMany(x => x.OrganizujeTurnir).KeyColumn("ORGANIZATOR_MBR").Cascade.All().Inverse();
        }
    }
}
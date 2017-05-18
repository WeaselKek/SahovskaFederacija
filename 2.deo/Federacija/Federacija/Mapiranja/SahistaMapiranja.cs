using System;
using FluentNHibernate.Mapping;
using Federacija.Entiteti;

namespace Federacija.Mapiranja
{
    public class SahistaMapiranja : ClassMap<Sahista>
    {
        public SahistaMapiranja()
        {
            Table("SAHISTA");

            Id(x => x.RegBr, "REG_BR").GeneratedBy.TriggerIdentity();

            Map(x => x.Ime, "IME");
            Map(x => x.Prezime, "PREZIME");
            Map(x => x.DatRodj, "DAT_RODJ").CustomType("Date");
            Map(x => x.DatUclanjenja, "DAT_UCLANJENJA").CustomType("Date");
            Map(x => x.BrojPasosa, "BROJ_PASOSA");
            Map(x => x.Drzava, "DRZAVA");
            Map(x => x.Ulica, "ULICA").Nullable();
            Map(x => x.Broj, "BROJ").Nullable();
            Map(x => x.Grad, "GRAD").Nullable();

            HasMany(x => x.Partije).KeyColumn("CRNI_IGRAC").KeyColumn("BELI_IGRAC").Cascade.All().Inverse();
            //HasMany(x => x.Partije).KeyColumn("BELI_IGRAC").Cascade.All().Inverse();
            //HasMany(x => x.Partije).KeyColumn("CRNI_IGRAC").Cascade.All().Inverse();
        }

        public class ObicanClanMapiranja : SubclassMap<ObicanClan>
        {
            public ObicanClanMapiranja()
            {
                Table("OBICAN_CLAN");
                KeyColumn("REG_BR");
            }
        }

        public class MajstorskiKandidatMapiranja : SubclassMap<MajstorskiKandidat>
        {
            public MajstorskiKandidatMapiranja()
            {
                Table("MAJSTORSKI_KANDIDAT");
                KeyColumn("REG_BR");
                Map(x => x.BrojPartijaDoSticanja, "BROJ_PARTIJA_DO_STICANJA");
            }
        }

        public class MajstorMapiranja : SubclassMap<Majstor>
        {
            public MajstorMapiranja()
            {
                Table("MAJSTOR");
                KeyColumn("REG_BR");
                Map(x => x.DatSticanja, "DAT_STICANJA").CustomType("Date");

                References(x => x.SudijaId).Column("SUDIJA_ID");
            }
        }
    }
}

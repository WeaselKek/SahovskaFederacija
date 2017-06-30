using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Federacija.Entiteti;
using Federacija.DTO;
using NHibernate;
using NHibernate.Linq;

namespace Federacija
{
    public class DataProvider
    {
        public SahistaView GetSahista(int x)
        {
            ISession s = DataLayer.GetSession();

            SahistaView sv = new SahistaView(s.Get<Sahista>(x));

            return sv;
        }

        public IList<ObicanClanView> GetObicanClanovi()
        {
            ISession s = DataLayer.GetSession();

            IList<ObicanClanView> niz = new List<ObicanClanView>();
            IList<ObicanClan> pom = new List<ObicanClan>();

            pom = s.Query<ObicanClan>().Select(x => x).ToList<ObicanClan>();

            foreach (ObicanClan sp in pom)
            {
                niz.Add(new ObicanClanView(sp));
            }

            return niz;
        }

        public IList<KandidatView> GetKandidati()
        {
            ISession s = DataLayer.GetSession();

            IList<KandidatView> niz = new List<KandidatView>();
            IList<MajstorskiKandidat> pom = new List<MajstorskiKandidat>();

            pom = s.Query<MajstorskiKandidat>().Select(x => x).ToList<MajstorskiKandidat>();

            foreach (MajstorskiKandidat sp in pom)
            {
                niz.Add(new KandidatView(sp));
            }

            return niz;
        }

        public int UpdateMajstor(int id, Majstor value)
        {
            ISession s = DataLayer.GetSession();

            Majstor m = s.Get<Majstor>(id);

            if (value.Broj != 0)
                m.Broj = value.Broj;
            if (value.BrojPasosa != 0)
                m.BrojPasosa = value.BrojPasosa;
            if (value.DatRodj != null)
                m.DatRodj = value.DatRodj;
            if (value.DatSticanja != null)
                m.DatSticanja = value.DatSticanja;
            if (value.DatUclanjenja != null)
                m.DatUclanjenja = value.DatUclanjenja;
            if (value.Drzava != null)
                m.Drzava = value.Drzava;
            if (value.Grad != null)
                m.Grad = value.Grad;
            if (value.Ime != null)
                m.Ime = value.Ime;
            if (value.Prezime != null)
                m.Prezime = value.Prezime;
            if (value.SudijaId != null)
                m.SudijaId = value.SudijaId;
            if (value.Ulica != null)
                m.Ulica = value.Ulica;

            s.SaveOrUpdate(m);

            s.Flush();
            s.Close();

            return 1;
        }

        public int UpdatePartija(int id, Partija value)
        {
            ISession s = DataLayer.GetSession();

            s.Update(value);

            s.Flush();
            s.Close();

            return 1;
        }

        public int AddObicanClan(ObicanClan value)
        {
            ISession s = DataLayer.GetSession();

            s.Save(value);

            s.Flush();
            s.Close();

            return 1;
        }

        public int DeleteObicanClan(int id)
        {
            ISession s = DataLayer.GetSession();

            s.Delete(s.Get<Sahista>(id));

            s.Flush();
            s.Close();

            return 1;
        }

        public ObicanClanView GetObicanClan(int id)
        {
            ISession s = DataLayer.GetSession();

            ObicanClanView obc = new ObicanClanView(s.Get<ObicanClan>(id));

            return obc;
        }

        public IList<MajstorView> GetMajstori()
        {
            ISession s = DataLayer.GetSession();

            IList<MajstorView> niz = new List<MajstorView>();
            IList<Majstor> pom = new List<Majstor>();

            pom = s.Query<Majstor>().Select(x => x).ToList<Majstor>();

            foreach (Majstor sp in pom)
            {
                niz.Add(new MajstorView(sp));
            }

            return niz;
        }

        public int AddKandidat(MajstorskiKandidat value)
        {
            ISession s = DataLayer.GetSession();

            s.Save(value);

            s.Flush();
            s.Close();

            return 1;
        }

        public int DeleteKandidat(int id)
        {
            ISession s = DataLayer.GetSession();

            s.Delete(s.Get<Sahista>(id));

            s.Flush();
            s.Close();

            return 1;
        }

        public KandidatView GetKandidat(int id)
        {
            ISession s = DataLayer.GetSession();

            KandidatView kv = new KandidatView(s.Get<MajstorskiKandidat>(id));

            return kv;
        }

        public IList<PartijaView> GetPartije()
        {
            ISession s = DataLayer.GetSession();

            IList<PartijaView> partije = new List<PartijaView>();
            IList<Partija> pom = new List<Partija>();

            pom = s.Query<Partija>().Select(x => x).ToList<Partija>();

            foreach (Partija sp in pom)
            {
                partije.Add(new PartijaView(sp));
            }

            return partije;
        }

        public int DeleteSahista(int id)
        {
            ISession s = DataLayer.GetSession();

            s.Delete(s.Get<Sahista>(id));

            s.Flush();
            s.Close();

            return 1;
        }

        public MajstorView GetMajstor(int id)
        {
            ISession s = DataLayer.GetSession();

            MajstorView mv = new MajstorView(s.Get<Majstor>(id));

            return mv;
        }

        public int AddMajstor(Majstor value)
        {
            ISession s = DataLayer.GetSession();

            s.Save(value);

            s.Flush();
            s.Close();

            return 1;
        }

        public int DeleteMajstor(int id)
        {
            ISession s = DataLayer.GetSession();

            s.Delete(s.Get<Sahista>(id));

            s.Flush();
            s.Close();

            return 1;
        }

        public IList<TurnirView> GetTurniri()
        {
            ISession s = DataLayer.GetSession();

            IList<TurnirView> turniri = new List<TurnirView>();
            IList<Turnir> pom = new List<Turnir>();

            pom = s.Query<Turnir>().Select(x => x).ToList<Turnir>();

            foreach (Turnir sp in pom)
            {
                turniri.Add(new TurnirView(sp));
            }

            return turniri;
        }

        public int AddPartija(Partija value)
        {
            ISession s = DataLayer.GetSession();

            s.Save(value);

            s.Flush();
            s.Close();

            return 1;
        }

        public int DeletePartija(int id)
        {
            ISession s = DataLayer.GetSession();

            s.Delete(s.Get<Partija>(id));

            s.Flush();
            s.Close();

            return 1;
        }

        public PartijaView GetPartija(int id)
        {
            ISession s = DataLayer.GetSession();

            PartijaView pv = new PartijaView(s.Get<Partija>(id));

            return pv;
        }

        public IList<PotezView> GetPotezi()
        {
            ISession s = DataLayer.GetSession();

            IList<PotezView> potezi = new List<PotezView>();
            IList<Potez> pom = new List<Potez>();

            pom = s.Query<Potez>().Select(x => x).ToList<Potez>();

            foreach (Potez sp in pom)
            {
                potezi.Add(new PotezView(sp));
            }

            return potezi;
        }

        public int AddTurnir(Turnir value)
        {
            ISession s = DataLayer.GetSession();

            //if (value.PoZnacaju == "TAKMICARSKI")
            //{
            //    if (value.TipTakmicarskog == "REGIONALNI")
            //        pom = new TurnirTakmicarskiRegionalni();
            //    else if (value.TipTakmicarskog == "INTERNACIONALNI")
            //        pom = new TurnirTakmicarskiInternacionalni();
            //    else if (value.TipTakmicarskog == "NACIONALNI")
            //        pom = new TurnirTakmicarskiNacionalni();
            //}
            //else if (value.PoZnacaju == "EGZIBICIONI")
            //{
            //    if (value.TipEgzibicionog == "PROMOTIVNI")
            //        pom = new TurnirEgzibicioniPromotivni();
            //    else
            //        pom = new TurnirEgzibicioniHumanitarni();
            //}
            //else
            //{
            //    pom = new TurnirTakmicarskiInternacionalni();
            //}

            s.Save(value);

            s.Flush();
            s.Close();

            return 1;
        }

        public int DeleteTurnir(int id)
        {
            ISession s = DataLayer.GetSession();

            s.Delete(s.Get<Turnir>(id));

            s.Flush();
            s.Close();

            return 1;
        }

        public TurnirView GetTurnir(int id)
        {
            ISession s = DataLayer.GetSession();

            TurnirView tv = new TurnirView(s.Get<Turnir>(id));

            return tv;
        }

        public IList<OrganizatorView> GetOrganizatori()
        {
            ISession s = DataLayer.GetSession();

            IList<OrganizatorView> organizatori = new List<OrganizatorView>();
            IList<Organizator> pom = new List<Organizator>();

            pom = s.Query<Organizator>().Select(x => x).ToList<Organizator>();

            foreach (Organizator sp in pom)
            {
                organizatori.Add(new OrganizatorView(sp));
            }

            return organizatori;
        }

        public int DeletePotez(int id)
        {
            ISession s = DataLayer.GetSession();

            s.Delete(s.Get<Potez>(id));

            s.Flush();
            s.Close();

            return 1;
        }

        public int AddPotez(Potez value)
        {
            ISession s = DataLayer.GetSession();

            s.Save(value);

            s.Flush();
            s.Close();

            return 1;
        }

        public PotezView GetPotez(int id)
        {
            ISession s = DataLayer.GetSession();

            PotezView pv = new PotezView(s.Get<Potez>(id));

            return pv;
        }

        public int AddOrganizator(Organizator value)
        {
            ISession s = DataLayer.GetSession();

            s.Save(value);

            s.Flush();
            s.Close();

            return 1;
        }

        public int DeleteSponzor(string id)
        {
            ISession s = DataLayer.GetSession();

            s.Delete(s.Query<Sponzor>().Where(x => x.Naziv == id).First());

            s.Flush();
            s.Close();

            return 1;
        }

        public int DeleteOrganizator(string id)
        {
            ISession s = DataLayer.GetSession();

            s.Delete(s.Query<Organizator>().Where(x => x.MatBr == id).First());

            s.Flush();
            s.Close();

            return 1;
        }

        public IList<SponzorView> GetSponzori()
        {
            ISession s = DataLayer.GetSession();

            IList<SponzorView> sponzori = new List<SponzorView>();
            IList<Sponzor> pom = new List<Sponzor>();

            pom = s.Query<Sponzor>().Select(x => x).ToList<Sponzor>();

            foreach (Sponzor sp in pom)
            {
                sponzori.Add(new SponzorView(sp));
            }

            return sponzori;
        }

        public OrganizatorView GetOrganizator(string id)
        {
            ISession s = DataLayer.GetSession();

            OrganizatorView org = new OrganizatorView(s.Query<Organizator>().Where(x => x.MatBr == id).First());

            return org;
        }

        public IList<SahistaView> GetSahiste()
        {
            ISession s = DataLayer.GetSession();

            IList<SahistaView> sahiste = new List<SahistaView>();
            IList<Sahista> pom = new List<Sahista>();

            pom = s.Query<Sahista>().Select(x => x).ToList<Sahista>();

            foreach (Sahista ss in pom)
            {
                sahiste.Add(new SahistaView(ss));
            }

            return sahiste;
        }

        public SponzorView GetSponzor(string id)
        {
            ISession s = DataLayer.GetSession();

            SponzorView sp = new SponzorView(s.Query<Sponzor>().Where(x => x.Naziv == id).First());

            return sp;
        }

        public int AddSponzor(Sponzor value)
        {
            ISession s = DataLayer.GetSession();

            s.Save(value);

            s.Flush();
            s.Close();

            return 1;
        }
    }
}

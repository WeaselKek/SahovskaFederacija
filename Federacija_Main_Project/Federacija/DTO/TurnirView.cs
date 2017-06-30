using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Federacija.Entiteti;

namespace Federacija.DTO
{
    public class TurnirView
    {
        public int Id { get; set; }
        public string Naziv { get; set; }
        public string Drzava { get; set; }
        public string Grad { get; set; }
        public int Godina { get; set; }
        public DateTime DatumOd { get; set; }
        public DateTime DatumDo { get; set; }
        public string NacinOdigravanja { get; set; }
        public int TrajanjePartije { get; set; }
        public string TipPoZnacaju { get; set; }
        public string TipTakmicarskog { get; set; }
        public string TipEgzibicionog { get; set; }
        public int Novac { get; set; }
        public string NamenaNovca { get; set; }
        public IList<OrganizatorView> Organizatori { get; set; }
        public IList<SponzorView> Sponzori { get; set; }

        public TurnirView(Turnir t)
        {
            this.Id = t.Id;
            this.Naziv = t.Naziv;
            this.Drzava = t.Drzava;
            this.Grad = t.Grad;
            this.Godina = t.Godina;
            this.DatumOd = t.DatumOd;
            this.DatumDo = t.DatumDo;
            this.NacinOdigravanja = t.NacinOdigravanja;
            this.TrajanjePartije = t.TrajanjePartije;
            this.TipPoZnacaju = t.PoZnacaju;
            this.TipEgzibicionog = t.TipEgzibicionog;
            this.TipTakmicarskog = t.TipTakmicarskog;
            this.Novac = t.Novac;
            this.NamenaNovca = t.Namena;

            Organizatori = new List<OrganizatorView>();
            Sponzori = new List<SponzorView>();

            foreach (Organizuje org in t.OrganizujeOrganizator)
            {
                this.Organizatori.Add(new OrganizatorView(org.OrganizujeOrganizator));
            }

            foreach (Sponzorise spon in t.SponzoriseSponzor)
            {
                this.Sponzori.Add(new SponzorView(spon.SponzoriseSponzor));
            }
        }

        public TurnirView()
        {

        }
    }
}

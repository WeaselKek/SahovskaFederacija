using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Federacija.Entiteti;

namespace Federacija.DTO
{
    public class SahistaView
    {
        public int Regbr { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public DateTime DatRodj { get; set; }
        public string Drzava { get; set; }
        public string SudijaId { get; set; }
        public string Tip { get; set; }

        public SahistaView(Sahista o)
        {
            this.Regbr = o.RegBr;
            this.Ime = o.Ime;
            this.Prezime = o.Prezime;
            this.DatRodj = o.DatRodj;
            this.Drzava = o.Drzava;
            this.SudijaId = "Ne";
            if (o is Majstor)
            {
                this.Tip = "Majstor";
                var m = o as Majstor;
                if (m.SudijaId != null)
                    this.SudijaId = "Da";
            }
            else if (o is MajstorskiKandidat)
            {
                this.Tip = "Majstorski Kandidat";
            }
            else
            {
                this.Tip = "Obican Clan";
            }
        }

        public SahistaView()
        {

        }
    }
}

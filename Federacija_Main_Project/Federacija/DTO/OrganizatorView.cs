using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Federacija.Entiteti;

namespace Federacija.DTO
{
    public class OrganizatorView
    {
        public string MatBr { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string Grad { get; set; }
        public string Sudija { get; set; }

        public OrganizatorView(Organizator o)
        {
            this.MatBr = o.MatBr;
            this.Ime = o.Ime;
            this.Prezime = o.Prezime;
            this.Grad = o.Grad;

            if (o.SudijaId != null)
            {
                this.Sudija = "DA";
            }
            else
            {
                this.Sudija = "NE";
            }
        }
    }
}

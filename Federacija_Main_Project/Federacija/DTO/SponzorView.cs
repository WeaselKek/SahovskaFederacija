using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Federacija.Entiteti;

namespace Federacija.DTO
{
    public class SponzorView
    {
        public string Naziv { get; set; }

        public SponzorView(Sponzor s)
        {
            this.Naziv = s.Naziv;
        }

        public SponzorView()
        {

        }
    }
}

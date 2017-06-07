using System;
using System.Collections.Generic;

namespace Federacija.Entiteti
{
    public class Sponzor
    {
        public virtual string Naziv { get; set; }
        public virtual IList<Sponzorise> SponzoriseTurnir { get; set; }

        public Sponzor()
        {
            SponzoriseTurnir = new List<Sponzorise>();
        }
    }
}
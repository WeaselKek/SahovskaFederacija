using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SBP_2deo.Entiteti
{
    public class Sponzorise
    {
        public virtual int Id { get; set; }
        public virtual Sponzor SponzoriseSponzor { get; set; }
        public virtual Turnir SponzoriseTurnir { get; set; }
    }
}

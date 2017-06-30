using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Federacija.Entiteti;

namespace Federacija.DTO
{
    public class PotezView
    {
        public int RedniBr { get; set; }
        public string PocetnoPolje { get; set; }
        public string KrajnjePolje { get; set; }
        public string Vreme { get; set; }

        public PotezView(Potez o)
        {
            this.RedniBr = o.RedniBr;
            this.PocetnoPolje = o.PocetnoPolje;
            this.KrajnjePolje = o.KrajnjePolje;
            this.Vreme = o.Vreme;
        }

        public PotezView()
        {
        }
    }
}

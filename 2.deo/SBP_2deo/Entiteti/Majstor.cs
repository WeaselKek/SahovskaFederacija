using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SBP_2deo.Entiteti
{
    public class Majstor
    {
        public virtual DateTime DatSticanja { get; set; }
        public Sudija Sudija { get; set; }
    }
}

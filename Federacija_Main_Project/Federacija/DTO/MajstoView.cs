using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Federacija.Entiteti;

namespace Federacija.DTO
{
    public class MajstorView : SahistaView
    {
        public DateTime DatSticanja;

        public MajstorView(Sahista o)
            : base(o)
        {
            this.DatSticanja = ((Majstor)o).DatSticanja;
        }
    }
}

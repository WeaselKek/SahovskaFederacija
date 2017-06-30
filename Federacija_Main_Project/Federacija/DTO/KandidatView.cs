using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Federacija.Entiteti;

namespace Federacija.DTO
{
    public class KandidatView : SahistaView
    {
        public int BrojPartijadoSticanja;

        public KandidatView(Sahista o)
            : base(o)
        {
            this.BrojPartijadoSticanja = ((MajstorskiKandidat)o).BrojPartijaDoSticanja;
        }
    }
}

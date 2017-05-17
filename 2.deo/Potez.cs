using System;

namespace Entiteti
{
    public class Potez
    {
        public virtual int Id { get; set; }
        public virtual int PartijaId { get; set; }
        public virtual int RedniBr { get; set; }
        public virtual string PocetnoPolje { get; set; }
        public virtual string KrajnePolje { get; set; }
        public virtual string Vreme { get; set; }

    }
}
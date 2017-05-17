using System;

namespace Entiteti
{
    public class Organizator
    {
        public virtual int Id { get; set; }
        public virtual string MatBr { get; set; }
        public virtual int RedniBr { get; set; }
        public virtual string PocetnoPolje { get; set; }
        public virtual string KrajnjePolje { get; set; }
        public virtual string Vreme { get; set; }
    }
}

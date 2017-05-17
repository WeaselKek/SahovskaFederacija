using System;

namespace SBP_2deo.Entiteti
{
    public class Potez
    {
        public virtual int Id { get; set; }
        public virtual int RedniBr { get; set; }
        public virtual string PocetnoPolje { get; set; }
        public virtual string KrajnjePolje { get; set; }
        public virtual string Vreme { get; set; }
        public Partija Partija { get; set; }
    }
}
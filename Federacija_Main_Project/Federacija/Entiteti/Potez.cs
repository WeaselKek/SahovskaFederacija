using System;

namespace Federacija.Entiteti
{
    public class Potez
    {
        public virtual int Id { get; set; }
        public virtual int RedniBr { get; set; }
        public virtual string PocetnoPolje { get; set; }
        public virtual string KrajnjePolje { get; set; }
        public virtual string Vreme { get; set; }
        public virtual Partija Partija { get; set; }
        public override string ToString()
        {
            return RedniBr +"  "+ PocetnoPolje+"  "+KrajnjePolje+"  "+Vreme;
        }
    }
}
using System;

namespace Entiteti
{
    public class Partija
    {
        public virtual int Id { get; set; }
        public virtual DateTime Datum { get; set; }
        public virtual string Vreme { get; set; }
        public virtual int Trajanje { get; set; }
        public virtual string Ishod { get; set; }

    }
}

using System;

namespace Entiteti {
    public class Turnir
    {
        public virtual int Id { get; set; }
        public virtual string Naziv { get; set; }
        public virtual string Drzava { get; set; }
        public virtual string Grad { get; set; }
        public virtual int Godina { get; set}
        public virtual DateTime DatumOd { get; set; }
        public virtual DateTime DatumDo { get; set; }

    }
}

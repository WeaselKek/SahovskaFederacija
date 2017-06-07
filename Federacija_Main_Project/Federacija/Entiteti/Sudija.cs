using System;

namespace Federacija.Entiteti
{
    public class Sudija
    {
        public virtual int Id { get; set; }
        public virtual int FlagMajstor { get; set; }
        public virtual int FlagOrganizator { get; set; }
    }
}

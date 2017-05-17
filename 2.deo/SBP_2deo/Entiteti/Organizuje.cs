using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SBP_2deo.Entiteti
{
    public class Organizuje
    {
        public virtual int Id { get; set; }
        public virtual Organizator OrganizujeOrganizator { get; set; }
        public virtual Turnir OrganizujeTurnir { get; set; }
    }
}

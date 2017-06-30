using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Federacija;
using Federacija.Entiteti;
using Federacija.DTO;

namespace WebApp.Controllers
{
    public class PartijaController : ApiController
    {
        // GET: api/Partija
        public IList<PartijaView> Get()
        {
            DataProvider dp = new DataProvider();

            return dp.GetPartije();
        }

        // GET: api/Partija/5
        public PartijaView Get(int id)
        {
            DataProvider dp = new DataProvider();

            return dp.GetPartija(id);
        }

        // POST: api/Partija
        public int Post([FromBody]Partija value)
        {
            DataProvider dp = new DataProvider();

            return dp.AddPartija(value);
        }

        // PUT: api/Partija/5
        public int Put(int id, [FromBody]Partija value)
        {
            DataProvider dp = new DataProvider();

            return dp.UpdatePartija(id, value);
        }

        // DELETE: api/Partija/5
        public int Delete(int id)
        {
            DataProvider dp = new DataProvider();

            return dp.DeletePartija(id);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Federacija.Entiteti;
using Federacija.DTO;
using Federacija;

namespace WebApp.Controllers
{
    public class SponzorController : ApiController
    {
        // GET: api/Sponzor
        public IList<SponzorView> Get()
        {
            DataProvider dp = new DataProvider();

            return dp.GetSponzori();
        }

        // GET: api/Sponzor/5
        public SponzorView Get(string id)
        {
            DataProvider dp = new DataProvider();

            return dp.GetSponzor(id);
        }

        // POST: api/Sponzor
        public int Post([FromBody]Sponzor value)
        {
            DataProvider dp = new DataProvider();

            return dp.AddSponzor(value);
        }

        // PUT: api/Sponzor/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Sponzor/5
        public int Delete(string id)
        {
            DataProvider dp = new DataProvider();

            return dp.DeleteSponzor(id);
        }
    }
}

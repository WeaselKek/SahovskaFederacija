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
    public class OrganizatorController : ApiController
    {
        // GET: api/Organizator
        public IList<OrganizatorView> Get()
        {
            DataProvider dp = new DataProvider();

            return dp.GetOrganizatori();
        }

        // GET: api/Organizator/5
        public OrganizatorView Get(string id)
        {
            DataProvider dp = new DataProvider();

            return dp.GetOrganizator(id);
        }

        // POST: api/Organizator
        public int Post([FromBody]Organizator value)
        {
            DataProvider dp = new DataProvider();

            return dp.AddOrganizator(value);
        }

        // PUT: api/Organizator/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Organizator/5
        public int Delete(string id)
        {
            DataProvider dp = new DataProvider();

            return dp.DeleteOrganizator(id);
        }
    }
}

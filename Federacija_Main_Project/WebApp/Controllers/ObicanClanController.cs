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
    public class ObicanClanController : ApiController
    {
        // GET: api/ObicanClan
        public IList<ObicanClanView> Get()
        {
            DataProvider dp = new DataProvider();

            return dp.GetObicanClanovi();
        }

        // GET: api/ObicanClan/5
        public ObicanClanView Get(int id)
        {
            DataProvider dp = new DataProvider();

            return dp.GetObicanClan(id);
        }

        // POST: api/ObicanClan
        public int Post([FromBody]ObicanClan value)
        {
            DataProvider dp = new DataProvider();

            return dp.AddObicanClan(value);
        }

        // PUT: api/ObicanClan/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/ObicanClan/5
        public int Delete(int id)
        {
            DataProvider dp = new DataProvider();

            return dp.DeleteObicanClan(id);
        }
    }
}

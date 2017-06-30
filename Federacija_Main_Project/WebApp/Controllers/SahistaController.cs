using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Federacija;
using Federacija.DTO;
using Federacija.Entiteti;

namespace WebApp.Controllers
{
    public class SahistaController : ApiController
    {
        // GET: api/Sahista
        public IList<SahistaView> Get()
        {
            DataProvider dp = new DataProvider();

            return dp.GetSahiste();
        }

        // GET: api/Sahista/5
        public SahistaView Get(int id)
        {
            DataProvider dp = new DataProvider();

            return dp.GetSahista(id);
        }

        // POST: api/Sahista Mora da se doda u bazu kao neki od nasledjenih tipova
        public int Post([FromBody]Sahista value)
        {
            return 1;
        }

        // PUT: api/Sahista/5
        public int Put(int id, [FromBody]Sahista value)
        {
            return 1;
        }

        // DELETE: api/Sahista/5
        public int Delete(int id)
        {
            DataProvider dp = new DataProvider();

            return dp.DeleteSahista(id);
        }
    }
}

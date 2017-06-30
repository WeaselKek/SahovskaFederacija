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
    public class PotezController : ApiController
    {
        // GET: api/Potez
        public IList<PotezView> Get()
        {
            DataProvider dp = new DataProvider();

            return dp.GetPotezi();
        }

        // GET: api/Potez/5
        public PotezView Get(int id)
        {
            DataProvider dp = new DataProvider();

            return dp.GetPotez(id);
        }

        // POST: api/Potez
        public int Post([FromBody]Potez value)
        {
            DataProvider dp = new DataProvider();

            return dp.AddPotez(value);
        }

        // PUT: api/Potez/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Potez/5
        public int Delete(int id)
        {
            DataProvider dp = new DataProvider();

            return dp.DeletePotez(id);
        }
    }
}

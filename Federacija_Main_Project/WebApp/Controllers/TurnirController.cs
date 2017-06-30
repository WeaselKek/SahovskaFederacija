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
    public class TurnirController : ApiController
    {
        // GET: api/Turnir
        public IList<TurnirView> Get()
        {
            DataProvider dp = new DataProvider();

            return dp.GetTurniri();
        }

        // GET: api/Turnir/5
        public TurnirView Get(int id)
        {
            DataProvider dp = new DataProvider();

            return dp.GetTurnir(id);
        }

        // POST: api/Turnir
        public int Post([FromBody]Turnir value)
        {
            DataProvider dp = new DataProvider();

            return dp.AddTurnir(value);
        }

        // PUT: api/Turnir/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Turnir/5
        public int Delete(int id)
        {
            DataProvider dp = new DataProvider();

            return dp.DeleteTurnir(id);
        }
    }
}

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
    public class KandidatController : ApiController
    {
        // GET: api/Kandidat
        public IList<KandidatView> Get()
        {
            DataProvider dp = new DataProvider();

            return dp.GetKandidati();
        }

        // GET: api/Kandidat/5
        public KandidatView Get(int id)
        {
            DataProvider dp = new DataProvider();

            return dp.GetKandidat(id);
        }

        // POST: api/Kandidat
        public int Post([FromBody]MajstorskiKandidat value)
        {
            DataProvider dp = new DataProvider();

            return dp.AddKandidat(value);
        }

        // PUT: api/Kandidat/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Kandidat/5
        public int Delete(int id)
        {
            DataProvider dp = new DataProvider();

            return dp.DeleteKandidat(id);
        }
    }
}

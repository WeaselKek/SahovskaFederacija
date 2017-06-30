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
    public class MajstorController : ApiController
    {
        // GET: api/Majstor
        public IList<MajstorView> Get()
        {
            DataProvider dp = new DataProvider();

            return dp.GetMajstori();
        }

        // GET: api/Majstor/5
        public MajstorView Get(int id)
        {
            DataProvider dp = new DataProvider();

            return dp.GetMajstor(id);
        }

        // POST: api/Majstor
        public int Post([FromBody]Majstor value)
        {
            DataProvider dp = new DataProvider();

            return dp.AddMajstor(value);
        }

        // PUT: api/Majstor/5
        public int Put(int id, [FromBody]Majstor value)
        {
            DataProvider dp = new DataProvider();

            return dp.UpdateMajstor(id, value);
        }

        // DELETE: api/Majstor/5
        public int Delete(int id)
        {
            DataProvider dp = new DataProvider();

            return dp.DeleteMajstor(id);
        }
    }
}

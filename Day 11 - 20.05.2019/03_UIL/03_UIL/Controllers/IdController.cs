using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace _03_UIL.Controllers
{
    public class IdController : ApiController
    {
        // GET: api/Id
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/Id/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Id
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Id/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Id/5
        public void Delete(int id)
        {
        }
    }
}

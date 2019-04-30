using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace MyFirst_Web_Api.Controllers
{
    public class First_Controller : ApiController
    {

        // GET: api/First_
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/First_/5
        public string Get(int id)
        {
            return "value Get";
        }

        // POST: api/First_
        public string Post()
        {
            return "value Post";
        }

        // PUT: api/First_/5
        public string Put()
        {
            return "value Put";
        }

        // DELETE: api/First_/5
        public string Delete()
        {
            return "value Delete";
        }
    }
}

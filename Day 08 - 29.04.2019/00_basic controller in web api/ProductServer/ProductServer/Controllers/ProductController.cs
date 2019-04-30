using System.Collections.Generic;
using System.Web.Http;

namespace ProductServer.Controllers
{
    public class ProductController : ApiController
    {

        // GET: api/Product
        public string Get()
        {
            return "get req";
        }

        // POST: api/Product
        public string Post()
        {
            return "post req";
        }

        // PUT: api/Product
        public string Put()
        {
            return "put req";
        }

        // DELETE: api/Product
        public string Delete()
        {
            return "delete req";
        }
    }
}

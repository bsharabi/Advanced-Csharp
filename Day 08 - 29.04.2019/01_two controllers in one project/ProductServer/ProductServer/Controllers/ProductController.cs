using System.Web.Http;

namespace ProductServer.Controllers
{
    public class ProductController : ApiController
    {
        public string Get()
        {
            return "product get";
        }


        public string Delete()
        {
            return "product delete";
        }

    }
}

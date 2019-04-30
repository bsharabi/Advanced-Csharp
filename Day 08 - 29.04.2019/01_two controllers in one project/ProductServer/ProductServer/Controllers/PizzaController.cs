
using System.Web.Http;

namespace ProductServer.Controllers
{
    public class PizzaController : ApiController
    {

        public string Get()
        {
            return "pizza get";
        }


        public string Delete()
        {
            return "pizza delete";
        }


    }
}

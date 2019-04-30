using ProductServer.Models;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace ProductServer.Controllers
{
    public class ProductController : ApiController
    {

        static List<Product> arrProducts = new List<Product> {
             new Product {id=1,name="bamba", price=5 },
             new Product {id=2,name="bread", price=5 },
             new Product {id=3,name="milk", price=6 },
             new Product {id=4,name="bisli", price=7 },
             new Product {id=5,name="banana", price=12 }
         };

        public List<Product> Get()
        {
            return arrProducts;
        }


        public Product Get(int id)
        {
            return arrProducts.FirstOrDefault(x=>x.id==id);
        }

    }
}

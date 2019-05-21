using ProductServer.Models;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace ProductServer.Controllers
{
    [RoutePrefix("api/productHandle")]
    public class ProductController : ApiController
    {
        static List<Product> arrProducts = new List<Product> {
             new Product {id=1,name="bamba", price=5 },
             new Product {id=2,name="bread", price=5 },
             new Product {id=3,name="milk", price=6 },
             new Product {id=4,name="bisli", price=7 },
             new Product {id=5,name="banana", price=12 }
         };

        [HttpGet]
        [Route("all")]
        public List<Product> Get()
        {
            return arrProducts;
        }

        [HttpGet]
        [Route("price/{price}")]
        public IHttpActionResult ProductByPrice([FromUri]int price)
        {
            Product p = arrProducts.FirstOrDefault(x => x.price == price);
            if (p != null)
                return Ok(p);
            return NotFound();
        }


        public IHttpActionResult Get([FromUri]int id)
        {
            Product p=arrProducts.FirstOrDefault(x => x.id == id);
            if (p!=null)
                return Ok(p);
            return NotFound();
        }

        public IHttpActionResult Post([FromBody]Product value)
        {
           if (ModelState.IsValid)
           {
               arrProducts.Add(value);
               return Ok();
           }
           else
           {
                return BadRequest(ModelState);
           }

        }


        public IHttpActionResult Put([FromUri]int id, [FromBody]Product value)
        {
            Product p = arrProducts.FirstOrDefault(x => x.id == id);

            if (p != null)
            {
                p.name = value.name;
                p.price = value.price;
                return Ok();
            }
        
            return NotFound();
        }

        public IHttpActionResult Delete([FromUri]int id)
        {
            Product p = arrProducts.FirstOrDefault(x => x.id == id);
            if (p != null)
            {
                arrProducts.Remove(p);
                return Ok();
            }
                
            return NotFound();
        }
    }
}
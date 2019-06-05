using _00_Return_status_code.Filters;
using ProductServer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace ProductServer.Controllers
{
    
    //[RoutePrefix("api/productHandle")]
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
        //[Route("all")]
        public List<Product> Get()
        {
            return arrProducts;
        }

        [HttpGet]
        //[Route("price/{price}")]
        public IHttpActionResult ProductByPrice([FromUri]int price)
        {
            Product p = arrProducts.FirstOrDefault(x => x.price == price);
            if (p != null)
                return Ok(p);
            return NotFound();
        }

        [RangeEx]
        public IHttpActionResult Get([FromUri]int id)
        {
            if (id < 0)
                throw new ArgumentOutOfRangeException();
            Product p=arrProducts.FirstOrDefault(x => x.id == id);
            if (p!=null)
                return Ok(p);
            return NotFound();
        }

        [Example]
        public IHttpActionResult Post([FromBody]Product value)
        {       
               arrProducts.Add(value);
               return Ok();
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
using _01_BOL;
using _02_BLL;
using System.Collections.Generic;
using System.Web.Http;

namespace _03_UIL.Controllers
{
    [RoutePrefix("api/book")]
    public class BookController : ApiController
    {
        private BookManager bookBll = new BookManager();

        [HttpGet]
        [Route("all")]
        public List<BookModel> Get()
        {
            return bookBll.GetAllBooks();
        }

        [HttpGet]
        [Route("id/{id}")]
        public IHttpActionResult Get([FromUri]int id)
        {
            BookModel book = bookBll.GetBookById(id);
            if (book != null)
                return Ok(book);
            return NotFound();
        }

        [HttpPost]
        [Route("")]
        public IHttpActionResult Post([FromBody]BookModel value)
        {
            if (ModelState.IsValid)
            {
                bool success = bookBll.AddBook(value);
                if(success)
                    return Ok();
                return BadRequest();
            }
            else
            {
                return BadRequest(ModelState);
            }

        }

        [HttpPut]
        [Route("id/{id}")]
        public IHttpActionResult Put([FromUri]int id, [FromBody]BookModel value)
        {
               bool success = bookBll.UpdateBook(id,value);
               if (success)
                   return Ok();
               return BadRequest();
        }

        [HttpDelete]
        [Route("id/{id}")]
        public IHttpActionResult Delete([FromUri]int id)
        {
            bool success = bookBll.DeleteBook(id);
            if (success)
                return Ok();
            return BadRequest();
        }
    }
}

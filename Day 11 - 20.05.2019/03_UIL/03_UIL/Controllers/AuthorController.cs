using _01_BOL;
using _02_BLL;
using System.Collections.Generic;
using System.Web.Http;

namespace _03_UIL.Controllers
{
    [RoutePrefix("api/author")]
    public class AuthorController : ApiController
    {
        private AuthorManager authorBll = new AuthorManager();

        [HttpGet]
        [Route("all")]
        public List<AuthorModel> Get()
        {
            return authorBll.GetAllAuthors();
        }

        [HttpGet]
        [Route("id/{id}")]
        public IHttpActionResult Get([FromUri]int id)
        {
            AuthorModel author = authorBll.GetAuthorById(id);
            if (author != null)
                return Ok(author);
            return NotFound();
        }

        [HttpPost]
        [Route("")]
        public IHttpActionResult Post([FromBody]AuthorModel value)
        {
            if (ModelState.IsValid)
            {
                bool success = authorBll.AddAuthor(value);
                if (success)
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
        public IHttpActionResult Put([FromUri]int id, [FromBody]AuthorModel value)
        {
            bool success = authorBll.UpdateAuthor(id, value);
            if (success)
                return Ok();
            return BadRequest();
        }

        [HttpDelete]
        [Route("id/{id}")]
        public IHttpActionResult Delete([FromUri]int id)
        {
            bool success = authorBll.DeleteAuthor(id);
            if (success)
                return Ok();
            return BadRequest();
        }
    }
}

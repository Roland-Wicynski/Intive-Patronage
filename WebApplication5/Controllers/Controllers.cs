using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Intive_Patronage.Controllers
{
    [Route("api")]
    [ApiController]
    public class Controllers : ControllerBase
    {
        // GET: api/<ValuesController>
        [HttpGet("AllBooks")]
        public IEnumerable<string> GetAllBooks()
        {
            return new string[] { "value1", "value2" };
        }

        [HttpGet("AllAuthors")]
        public IEnumerable<string> GetAllAuthors()
        {
            return new string[] { "value2", "value2" };
        }

        // GET api/<ValuesController>/5
        [HttpGet("AuthorName/")]
        public string GetAuthorByName(string authorName)
        {
            return "value";
        }

        // POST api/<ValuesController>
        [HttpPost("CreateAuthor")]
        public void PostCreateAuthor([FromBody] string value)
        {
        }

        [HttpPost("CreateBook")]
        public void PostCreateBook([FromBody] string value)
        {
        }

        // PUT api/<ValuesController>/5
        [HttpPut("UpdateBook")]
        public void PutUpdateBook(int id, [FromBody] string value)
        {
        }

        // DELETE api/<ValuesController>/5
        [HttpDelete("DeleteBook")]
        public void DeleteBook(int id)
        {
        }
    }
}

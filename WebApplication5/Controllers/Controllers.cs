using Intive_Patronage.DTO;
using Intive_Patronage.Models;
using Intive_Patronage.SQL;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Intive_Patronage.Controllers
{
    [Route("api")]
    [ApiController]
    public class Controllers : ControllerBase
    {
        private BookContext _bookContext;
        public Controllers(BookContext bookContext) 
        {
            _bookContext = bookContext;
        }

        // GET: api/<ValuesController>
        [HttpGet("AllBooks")]
        public IActionResult GetAllBooks()
        {
            var books = _bookContext.Book.ToList();
            return Ok(books);

        }

        [HttpGet("AllAuthors")]
        public IActionResult GetAllAuthors()
        {
            var author = _bookContext.Author.ToList();
            return Ok(author);
        }

        // GET api/<ValuesController>/5
        [HttpGet("searchAuthor/{authorName}")]
        public IEnumerable<AuthorModel> GetAuthorByName(string authorName)
        {

            IEnumerable<AuthorModel> results = _bookContext.Author.FromSqlRaw(@"Select * FROM Author WHERE FirstName LIKE '%' + @authorName + '%' or LastName LIKE '%' + @AuthorName + '%'", new SqlParameter("@authorName", authorName));
            
            return results;
        }

        [HttpGet("searchBook/{searchBook}")]
        public IEnumerable<BookModel> GetSearchBook(string searchBook)
        {

            IEnumerable<BookModel> results = _bookContext.Book.FromSqlRaw(@"Select * FROM Book WHERE Description LIKE '%' + @searchBook + '%' or ISBN LIKE '%' + @searchBook + '%' or Title LIKE '%' + @searchBook + '%'", new SqlParameter("@searchBook", searchBook));

            return results;
        }

        // POST api/<ValuesController>
        [HttpPost("CreateAuthor")]
        public IActionResult PostCreateAuthor([FromBody] AuthorDTO request)
        {
            AuthorModel author = new AuthorModel();
            author.gender = request.gender;
            author.lastName = request.lastName;
            author.firstName = request.firstName;
            author.birthDate = request.birthDate;

            for (int i = 0; i < request.bookId.Count(); i++)
            {
                author.bookAuthor[i].bookId = request.bookId[i];
            }
            var i = new Guid();


            try
            {
                _bookContext.Author.Add(author);
                _bookContext.SaveChanges();
                return Ok();
            }
            catch (Exception)
            {
                return StatusCode(500,"popsulo sie");
            }
            
        }

        [HttpPost("CreateBook")]
        public IActionResult PostCreateBook([FromBody] BookDTO request)
        {
            BookModel book = new BookModel();
            book.title = request.title;
            book.description = request.description;
            book.rating = request.rating;
            book.iSBN = request.iSBN;
            book.publicationDate =  request.publicationDate;
            try
            {
                _bookContext.Book.Add(book);
                _bookContext.SaveChanges();
                return Ok();
            }
            catch (Exception)
            {
                return StatusCode(500);
            }
        }

        // PUT api/<ValuesController>/5
        [HttpPut("UpdateBook")]
        public IActionResult PutUpdateBook([FromBody] BookModel request)
        {
            var book = _bookContext.Book.Find(request.Id);
            if (book == null)
            {
                return StatusCode(500);
            }
                book.title = request.title;
                book.description = request.description;
                book.rating = request.rating;
                book.iSBN = request.iSBN;
                book.publicationDate = request.publicationDate;
            try
            {
                _bookContext.Book.Entry(book).State = EntityState.Modified;
                _bookContext.SaveChanges();
                return Ok();
            }
            catch (Exception)
            {
                return StatusCode(500);
            }

        }

        // DELETE api/<ValuesController>/5
        [HttpDelete("DeleteBook/{id}")]
        public IActionResult DeleteBook(int id)
        {
            try
            {
                var book = _bookContext.Book.Find(id);
                if (book == null)
                {
                    return StatusCode(404);
                }
                _bookContext.Book.Remove(book);
                _bookContext.SaveChanges();
                return Ok();
            }
            catch (Exception)
            { 
                return BadRequest();
            }
        }
    }
}
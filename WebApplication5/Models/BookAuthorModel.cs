using Microsoft.EntityFrameworkCore;

namespace Intive_Patronage.Models
{
    [Keyless]
    public class BookAuthorModel
    {
        public int bookId { get; set; }
        public int authorId { get; set; }

        public BookModel book { get; set; }

        public AuthorModel author { get; set;}
    }
}

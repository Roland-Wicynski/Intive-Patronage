namespace Intive_Patronage.Models

{
    public class BookAuthorModel
    {
        public int BookId { get; set; }
        public int AuthorId { get; set; }

        public BookModel Book { get; set; }
        public AuthorModel Author { get; set; }
    }
}
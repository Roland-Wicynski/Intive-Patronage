using Intive_Patronage.Models;
using Microsoft.EntityFrameworkCore;

namespace Intive_Patronage.SQL

{
    public class BookContext : DbContext
    {
        
        public BookContext(DbContextOptions<BookContext> options) : base(options)
        {
            
        }
        
        public DbSet<AuthorModel> Author { get; set; }
        public DbSet<BookModel> Book { get; set; }
        public DbSet<BookAuthorModel> BookAuthor { get; set; }

        protected override void
        OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<BookAuthorModel>()
                .HasKey(x => new { x.BookId, x.AuthorId });
        }
    }
}

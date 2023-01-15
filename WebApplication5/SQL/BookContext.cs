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
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<BookAuthorModel>()
                .HasKey(bc => new { bc.bookId, bc.authorId });
            modelBuilder.Entity<BookAuthorModel>()
                .HasOne(bc => bc.book)
                .WithMany(b => b.bookAuthor)
                .HasForeignKey(bc => bc.bookId);
            modelBuilder.Entity<BookAuthorModel>()
                .HasOne(bc => bc.author)
                .WithMany(c => c.bookId)
                .HasForeignKey(bc => bc.authorId);
        }

    }
}

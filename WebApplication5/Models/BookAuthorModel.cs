using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;

namespace Intive_Patronage.Models
{
    [Keyless]
    public class BookAuthorModel
    {
        public int? bookId { get; }
        public string? authorId { get; }
    }
}

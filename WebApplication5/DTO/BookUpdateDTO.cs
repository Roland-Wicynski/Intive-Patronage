using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using Intive_Patronage.Models;

namespace Intive_Patronage.DTO
{
    public class BookUpdateDTO
    {
        [Required]
        public int Id { get; }
        public string title { get; set; }
        public string description { get; set; }
        public decimal rating { get; set; }
        public string iSBN { get; set; }
        public DateTime publicationDate { get; set; }
        public IList<int> AuthorId { get; set; }
    }
}
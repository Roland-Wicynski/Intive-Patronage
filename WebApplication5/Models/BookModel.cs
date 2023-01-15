
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Intive_Patronage.Models
{
    public class BookModel
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(100)]
        public string Title { get; set; }
        public string Description { get; set; }
        public decimal Rating { get; set; }
        [MaxLength(13)]
        public string ISBN { get; set; }
        public DateTime PublicationDate { get; set; }
    }
}

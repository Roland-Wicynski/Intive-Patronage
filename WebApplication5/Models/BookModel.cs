using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Intive_Patronage.Models
{
    public class BookModel
    {
        [ScaffoldColumn(false)]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public string title { get; set; }
        public string description { get; set; }
        public decimal rating { get; set; }
        public string iSBN { get; set; }
        public DateTime publicationDate { get; set; }
    }
}

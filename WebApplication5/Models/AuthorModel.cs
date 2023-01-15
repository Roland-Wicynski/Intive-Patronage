using Intive_Patronage;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Intive_Patronage.Models
{
    public class AuthorModel
    {
        [Key]
        public int Id { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public DateTime birthDate { get; set; }
        public bool gender { get; set; }

        //public IList<BookModel> book { get; set; }
    }
}

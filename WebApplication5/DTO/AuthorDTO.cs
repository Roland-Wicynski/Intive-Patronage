using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using Intive_Patronage.Models;

namespace Intive_Patronage.DTO
{
    public class AuthorDTO
    {
        public string firstName { get; set; }
        public string lastName { get; set; }
        public DateTime birthDate { get; set; }
        public bool gender { get; set; }
        public IList<int> bookId { get; set; } 
    }
}
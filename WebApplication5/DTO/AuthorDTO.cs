using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using Intive_Patronage.Models;

namespace Intive_Patronage.DTO
{
    public class AuthorDTO
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }
        public bool Gender { get; set; }
        public IList<int> BookId { get; set; } 
    }
}
using Intive_Patronage;

namespace Intive_Patronage.Models
{
    public class Author
    {
        public int Id { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public DateTime birthDate { get; set; }
        public byte Gender { get; set; }
    }
}

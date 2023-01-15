﻿
using System.ComponentModel.DataAnnotations;

namespace Intive_Patronage.Models
{
    public class BookModel
    {
        [Key]
        public int Id { get; set; }

        public string title { get; set; }
        public string description { get; set; }
        public decimal rating { get; set; }
        public string iSBN { get; set; }
        public DateTime publicationDate { get; set; }
        //public IList<AuthorModel> author { get; set; }
    }
}

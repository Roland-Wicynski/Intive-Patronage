﻿using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using Intive_Patronage.Models;

namespace Intive_Patronage.DTO
{
    public class BookDTO
    {
    public string Title { get; set; }
    public string Description { get; set; }
    public decimal Rating { get; set; }
    public string ISBN { get; set; }
    public DateTime PublicationDate { get; set; }
    }
}
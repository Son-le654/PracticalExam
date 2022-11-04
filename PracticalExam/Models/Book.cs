using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PracticalExam.Models
{
    public class Book
    {
      [Key] 
      public int Id { get; set; }
      public string Title { get; set; }
      public string Author { get; set; }
      public string Publisher { get; set; }
      public string Genre { get; set; }
      public string Price { get; set; }
    }
}
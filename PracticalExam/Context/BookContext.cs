using PracticalExam.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace PracticalExam.Context
{
    public class BookContext : DbContext
    {
        public DbSet<Book> Book { get; set; }
        
    }
}
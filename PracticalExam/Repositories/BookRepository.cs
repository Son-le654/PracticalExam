using PracticalExam.Context;
using PracticalExam.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace PracticalExam.Repositories
{
    public class BookRepository
    {
        private readonly BookContext db = new BookContext();

        public IList<Book> GetAllBooks()
        {

            return db.Book.OrderBy(p => p.Id).ToList();
        }
        public void AddBook(Book book)
        {
            db.Book.Add(book);
            db.SaveChanges();
        }
        public Book FindBook(int Id)
        {
            return db.Book.Find(Id);
        }
        public void UpdateBook(Book book)
        {
            db.Entry(book).State = EntityState.Modified;
            db.SaveChanges();
        }
        public void DeleteBook(int Id)
        {
            var item = db.Book.Find(Id);
            db.Book.Remove(item);
            db.SaveChanges();
        }
    }
}
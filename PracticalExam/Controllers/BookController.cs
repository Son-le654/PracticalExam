using PracticalExam.Models;
using PracticalExam.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PracticalExam.Controllers
{
    public class BookController : Controller
    {
        // GET: Book
        public ActionResult Index()
        {
            BookRepository bookRepo = new BookRepository();
            var book = bookRepo.GetAllBooks();
            return View(book);
        }

        public ActionResult Delete(int id)
        {
            BookRepository bookRepo = new BookRepository();
            bookRepo.DeleteBook(id);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }
        [HttpGet]
        public ActionResult Edit(int id)
        {
            BookRepository bookRepo = new BookRepository();
            var book = bookRepo.FindBook(id);
            return View(book);
        }
        [HttpPost]
        public ActionResult Edit(Book book)
        {
            BookRepository bookRepo = new BookRepository();
            bookRepo.UpdateBook(book);
            return RedirectToAction("Index");
        }
        [HttpPost]
        public ActionResult Create(Book book)
        {
            BookRepository bookRepo = new BookRepository();
            bookRepo.AddBook(book);
            return RedirectToAction("Index");
        }
    }
}
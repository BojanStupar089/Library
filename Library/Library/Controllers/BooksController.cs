using Library.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Library.Controllers
{
    public class BooksController : Controller
    {
        // GET: Books
        public ActionResult Index()
        {
            var books = GetBooks();
            return View(books);
        }



        private IEnumerable<Book> GetBooks() {

            return new List<Book> {


               new Book{ ID=1,Author="Ivo Andric", Title="Na Drini Cuprija",Genre="Domaci"},
                  new Book{ ID=2,Author="Ivo Andric", Title="Drina",Genre="Domaci"},
                     new Book{ ID=3,Author="Ivo Andric", Title=" Drin3",Genre="Domaci"}

            };
        }
    }
}
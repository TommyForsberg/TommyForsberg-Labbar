using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using BooksProjekt.Models.Entities;
using BooksProjekt.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace BooksProjekt.Controllers
{
    public class BooksController : Controller
    {
        BookContext context;
        public BooksController(BookContext context)
        {
            this.context = context;
        }
        // GET: /<controller>/
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(CreateBookVM model)
        {
            if (!ModelState.IsValid)
                return View(model);

                context.AddBookToDB(model);
            return RedirectToAction(nameof(BooksController.List));
        }

        [HttpGet]
        public IActionResult List()
        {
            ListBooksVM[] model = context.GetAllBooksVM();
            return View(model);
        }
        [HttpGet]
        public IActionResult Login()
        {
            var currentUser = Request.Cookies["Username"];
            if(currentUser != null)
                return RedirectToAction(nameof(BooksController.List));

            return View();
        }
        [HttpPost]
        public IActionResult Login(LoginVM model)
        {
            if (!ModelState.IsValid)
                return View(model);

            Response.Cookies.Append("Username", model.Name);
            return RedirectToAction(nameof(BooksController.List));

        }
        [HttpGet]
        public IActionResult Edit(int id)
        {
            CreateBookVM model = context.FetchSelectedBookVM(id);
            return View(model);

        }

        [HttpPost]
        public IActionResult Edit(int id, CreateBookVM model)
        {
            context.AddUpdatedBookToDB(id, model);
            return View(model);

        }
    }
}

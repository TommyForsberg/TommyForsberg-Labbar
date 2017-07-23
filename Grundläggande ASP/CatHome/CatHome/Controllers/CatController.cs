using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CatHome.Models.Entities;
using CatHome.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CatHome.Controllers
{
    public class CatController : Controller
    {
        CatHomeContext context;
       public CatController(CatHomeContext context)
        {
            this.context = context;
        }
        public IActionResult Index()
        {
            var model = context.GetAllCats();
            return View(model);
        }


        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(CreateCatVM model)
        {
            if (!ModelState.IsValid)
                return View(model);

            context.AddCatToDB(model);
            TempData[nameof(CreateCatVM.Name)] = model.Name;
            return RedirectToAction(nameof(CatController.Verification));
        }

        public IActionResult Verification()
        {
            if (TempData[nameof(CreateCatVM.Name)] != null)
            {
                var catName = (string)TempData[nameof(CreateCatVM.Name)];
                return View(nameof(Verification), catName);
            }
            else
            {
                return RedirectToAction(nameof(CatController.Create));
            }

           
        }
    }
}

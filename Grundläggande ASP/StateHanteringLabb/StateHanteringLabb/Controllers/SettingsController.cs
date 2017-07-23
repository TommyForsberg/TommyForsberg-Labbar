using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using StateHanteringLabb.Models.ViewModels;
using Microsoft.Extensions.Caching.Memory;
using Microsoft.AspNetCore.Http;
using StateHanteringLabb.Models;


// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace StateHanteringLabb.Controllers
{
    public partial class SettingsController : Controller
    {
        IMemoryCache cache;
       
        public SettingsController(IMemoryCache cache)
        {
            
            this.cache = cache;
            
        }
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
        public IActionResult Create(CreateCompanyVM model)
        {
            SetStates(model);
            return RedirectToAction(nameof(SettingsController.Display));
        }
        public IActionResult Display()
        {
            var model = GetModelFromStates();   
            return View(model);
        }
    }
}

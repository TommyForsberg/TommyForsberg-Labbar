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
       public void SetStates(CreateCompanyVM model)
        {
            HttpContext.Session.SetString(nameof(model.Name), model.Name);
            cache.Set(nameof(model.Email), model.Email);
            TempData["Message"] = "Dina värden har sparats!";
        }

        public DisplayCompanyVM GetModelFromStates()
        {
            var model = new DisplayCompanyVM();

            model.Greetings = (string)TempData["Message"];
            model.Name = HttpContext.Session.GetString(nameof(model.Name));
            model.Email = cache.Get<string>(nameof(model.Email));
            return model;
        }
    }
}

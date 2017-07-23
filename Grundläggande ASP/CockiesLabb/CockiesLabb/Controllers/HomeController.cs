using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CockiesLabb.Models;
using Microsoft.AspNetCore.Http;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CockiesLabb.Controllers
{
    public class HomeController : Controller
    {
        // GET: /<controller>/
        [HttpGet]
        public IActionResult Index()
        {
            if (Request.Cookies["UserName"] != null)
                return RedirectToAction(nameof(Welcome));

            return View();
        }
        [HttpPost]
        public IActionResult Index(UserDisplayVM model)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }

            if (model.AcceptCookies == true)
                Response.Cookies.Append("UserName", model.UserName,
                    new CookieOptions { Expires = DateTime.Now.AddMinutes(2) });
            else
                Response.Cookies.Append("UserName", model.UserName);

            return RedirectToAction(nameof(Welcome));
        }
        public IActionResult Welcome()
        {
            
            var name = Request.Cookies["UserName"];
            var model = new UserDisplayVM { UserName = name };
            
            return View(nameof(Welcome),model);
        }
    }
}

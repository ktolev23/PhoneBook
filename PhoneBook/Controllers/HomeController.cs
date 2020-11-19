using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using PhoneBook.ViewModels.Home;
using PhoneBook.Entity;
using PhoneBook.Database;
using PhoneBook.ActionFilters;

namespace PhoneBook.Controllers
{
   
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Logout()
        {
            if (this.HttpContext.Session.GetString("loggedUser") == null)
            {
                return RedirectToAction("Index", "Home");
            }

            this.HttpContext.Session.Remove("loggedUser");

            return RedirectToAction("Index", "Home");
        }

        [HttpGet]
        public IActionResult Login()
        {
            if (this.HttpContext.Session.GetString("loggedUser") != null)
            {
                return RedirectToAction("Index", "Home");
            }
            return View();
        }

        [HttpPost]
        public IActionResult Login(LoginVM model)
        {
            if (this.HttpContext.Session.GetString("loggedUser") != null)
            {
                return RedirectToAction("Index", "Home");
            }

            if (ModelState.IsValid == false)
            {
                return View(model);
            }

            UsersRepository repo = new UsersRepository();
            User loggedUser = repo.GetFirstOrDefault
                (u => u.Username == model.Username &&
                      u.Password == model.Password);

            if (loggedUser == null)
            {
                ModelState.AddModelError("AuthenticationFailed", "Wrong username or password!");
                return View(model);
            }

            this.HttpContext.Session.SetString("loggedUser", loggedUser.Id.ToString());
            this.HttpContext.Session.SetString("loggedUserUsername", loggedUser.FirstName);

            return RedirectToAction("Index", "Home");
        }
    }
}
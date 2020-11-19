using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PhoneBook.ActionFilters;
using PhoneBook.Database;
using PhoneBook.Entity;
using PhoneBook.ViewModels.Users;

namespace PhoneBook.Controllers
{
    [AuthenticationFilter]
    public class UsersController : Controller
    {
        public IActionResult Index(UsersIndexVM model)
        {
            UsersRepository repo = new UsersRepository();
            model.Items = repo.GetAll();

            return View(model);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(UsersCreateVM model)
        {
            if (ModelState.IsValid == false)
            {
                return View(model);
            }

            UsersRepository repo = new UsersRepository();
            User item = new User();
            item.Username = model.Username;
            item.Password = model.Password;
            item.FirstName = model.FirstName;
            item.LastName = model.LastName;

            repo.Add(item);

            return RedirectToAction("Index", "Users");
        }

        public IActionResult Delete(int Id)
        {
            UsersRepository repo = new UsersRepository();
            User item = new User();
            item.Id = Id;

            repo.Delete(item);

            return RedirectToAction("Index", "Users");
        }

        [HttpGet]
        public IActionResult Edit(int Id)
        {
            UsersRepository repo = new UsersRepository();
            User item = repo.GetById(Id);
            
            if (item == null)
            {
                return RedirectToAction("Index", "Users");
            }

            UsersEditVM model = new UsersEditVM();
            model.Id = item.Id;
            model.Username = item.Username;
            model.Password = item.Password;
            model.FirstName = item.FirstName;
            model.LastName = item.LastName;
            
            return View(model);
        }

        [HttpPost]
        public IActionResult Edit(UsersEditVM model)
        {
            if (ModelState.IsValid == false)
            {
                return View(model);
            }

            UsersRepository repo = new UsersRepository();
            User item = new User();
            item.Id = model.Id;
            item.Username = model.Username;
            item.Password = model.Password;
            item.FirstName = model.FirstName;
            item.LastName = model.LastName;

            repo.Update(item);

            return RedirectToAction("Index", "Users");
        }
    }
}
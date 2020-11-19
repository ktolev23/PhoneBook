using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PhoneBook.ActionFilters;
using PhoneBook.Database;
using PhoneBook.Entity;
using PhoneBook.ViewModels.Contacts;

namespace PhoneBook.Controllers
{
    [AuthenticationFilter]
    public class ContactsController : Controller
    {
        public IActionResult Index(ContactsIndexVM model)
        {
            int loggedUserId = Convert.ToInt32(this.HttpContext.Session.GetString("loggedUser"));
            ContactsRepository repo = new ContactsRepository();
            model.Items = repo.GetAll()
                .Where(c => c.UserId == loggedUserId)
                .ToList();

            return View(model);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(ContactsCreateVM model)
        {
            int loggedUserId = Convert.ToInt32(this.HttpContext.Session.GetString("loggedUser"));

            if (ModelState.IsValid == false)
            {
                return View(model);
            }

            ContactsRepository repo = new ContactsRepository();
            Contact item = new Contact();
            item.UserId = loggedUserId;
            item.FirstName = model.FirstName;
            item.LastName = model.LastName;
            item.Email = model.Email;

            repo.Add(item);

            return RedirectToAction("Index", "Contacts");
        }

        public IActionResult Delete(int Id)
        {
            ContactsRepository repo = new ContactsRepository();
            Contact item = new Contact();
            item.Id = Id;

            repo.Delete(item);

            return RedirectToAction("Index", "Contacts");
        }

        [HttpGet]
        public IActionResult Edit(int Id)
        {
            ContactsRepository repo = new ContactsRepository();
            Contact item = repo.GetById(Id);   

            if (item == null)
            {
                return RedirectToAction("Index", "Contacts");
            }

            ContactsEditVM model = new ContactsEditVM();
            model.Id = item.Id;
            model.UserId = item.UserId;
            model.FirstName = item.FirstName;
            model.LastName = item.LastName;
            model.Email = item.Email;

            return View(model);
        }

        [HttpPost]
        public IActionResult Edit(ContactsEditVM model)
        {
            if (ModelState.IsValid == false)
            {
                return View(model);
            }

            ContactsRepository repo = new ContactsRepository();
            Contact item = new Contact();
            item.Id = model.Id;
            item.UserId = model.UserId;
            item.FirstName = model.FirstName;
            item.LastName = model.LastName;
            item.Email = model.Email;

            repo.Update(item);

            return RedirectToAction("Index", "Contacts");
        }

        [HttpGet]
        public IActionResult Share(int Id)
        {
            ContactsShareVM model = new ContactsShareVM();

            PhoneBookDbContext context = new PhoneBookDbContext();
            
            model.Contact = context.Contacts
                                    .Where(u => u.Id == Id)
                                    .FirstOrDefault();

            model.SharedWith = context.UserToContacts
                                        .Include(utc => utc.ParentUser)
                                        .Include(utc => utc.ParentContact)
                                        .Where(i => i.ContactId == model.Contact.Id)
                                        .Select(i => i.ParentUser)
                                        .ToList();
           
            model.Users = context.Users.ToList();

            return View(model);
        }

        [HttpPost]
        public IActionResult Share(ContactsShareVM model)
        {
            PhoneBookDbContext context = new PhoneBookDbContext();

            UserToContact userToContact = new UserToContact();
            userToContact.UserId = model.UserId;
            userToContact.ContactId = model.ContactId;

            context.UserToContacts.Add(userToContact);
            context.SaveChanges();

            return RedirectToAction("Share", "Contacts", new { Id = model.ContactId });
        }

        public IActionResult RevokeAccess(int UserId, int ContactId)
        {
            PhoneBookDbContext context = new PhoneBookDbContext();

            UserToContact item = context.UserToContacts
                                            .Where(utc => utc.UserId == UserId &&
                                                          utc.ContactId == ContactId)
                                            .FirstOrDefault();

            if (item != null)
            {
                context.UserToContacts.Remove(item);
                context.SaveChanges();
            }

            return RedirectToAction("Share", "Contacts", new { Id = ContactId });
        }

    }
}

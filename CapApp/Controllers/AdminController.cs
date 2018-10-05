using CapApp.Abstract;
using CapApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CapApp.Controllers
{
    [Authorize]
    public class AdminController : Controller
    {
        private IPersonRepository repository;
        // GET: Admin
        public AdminController(IPersonRepository repo)
        {
            repository = repo;
        }

        public ViewResult Index()
        {
            return View(repository.Persons);
        }

        public ViewResult ChangeMod()
        {
            return View(repository.Persons);
        }

        public ViewResult Edit(int personId)
        {
            Person person = repository.Persons
                .FirstOrDefault(p => p.PersonId == personId);
            return View(person);
        }

        [HttpPost]
        public ActionResult Edit(Person person)
        {
            if (ModelState.IsValid)
            {
                repository.SavePerson(person);
                TempData["message"] = string.Format("Zapisano {0} ", person.Name);
                return RedirectToAction("ChangeMod");
            }
            else
            {
                return View(person);
            }
        }

        public ViewResult Create()
        {
            return View("Edit", new Person());
        }

        [HttpPost]
        public ActionResult Delete(int personId)
        {
            Person deletePerson = repository.DeletePerson(personId);
            if(deletePerson != null)
            {
                TempData["message"] = string.Format("Usunięto {0}", deletePerson.Name);
            }
            return RedirectToAction("ChangeMod");
        }
    }
}
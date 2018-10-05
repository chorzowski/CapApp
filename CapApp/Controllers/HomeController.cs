using CapApp.Abstract;
using CapApp.Concrete;
using CapApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CapApp.Controllers
{
    public class HomeController : Controller
    {
        private IPersonRepository repository;

        public HomeController()
        {
        }
     
        public HomeController(IPersonRepository personRepository)
        {
            this.repository = personRepository;
        }

        public ViewResult List()
        {
            
            return View(repository.Persons);
        }

    }
}
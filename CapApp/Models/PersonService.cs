using CapApp.Abstract;
using CapApp.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CapApp.Models
{
    public class PersonService 
    {
        private readonly EFPersonRepository _context;

        public PersonService(EFPersonRepository context)
        {
            _context = context;
        }

    }
}
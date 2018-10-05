using CapApp.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace CapApp.Concrete
{
    public class EFDbContext : DbContext
    {
        public DbSet<Person> Persons { get; set; }
    }
}
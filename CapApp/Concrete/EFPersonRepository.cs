using CapApp.Abstract;
using CapApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CapApp.Concrete
{
    public class EFPersonRepository : IPersonRepository
    {
        private EFDbContext context = new EFDbContext();

        public IEnumerable<Person> Persons
        {
            get { return context.Persons; }
        }

        public void SavePerson(Person person)
        {
            if(person.PersonId == 0)
            {
                context.Persons.Add(person);
            } else
            {
                Person dbEntry = context.Persons.Find(person.PersonId);
                if (dbEntry != null)
                {
                    dbEntry.Name = person.Name;
                    dbEntry.LastName = person.LastName;
                    dbEntry.TelephoneNumber = person.TelephoneNumber;
                    dbEntry.Address = person.Address;
                }
            }
            context.SaveChanges();
        }

        public Person DeletePerson(int personId)
        {
            Person dbEntry = context.Persons.Find(personId);
            if (dbEntry != null)
            {
                context.Persons.Remove(dbEntry);
                context.SaveChanges();
            }
            return dbEntry;
        }
    }
}
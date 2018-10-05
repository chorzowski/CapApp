using CapApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapApp.Abstract
{
    public interface IPersonRepository
    {
        IEnumerable<Person> Persons { get; }

        void SavePerson(Person person);
        Person DeletePerson(int personId);
    }
}

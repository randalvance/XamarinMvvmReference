using System;
using System.Collections.Generic;
using System.Linq;
using XamarinMvvmReference.Models;

namespace XamarinMvvmReference.Services
{
    public class PersonService : IPersonService
    {
        // Hardcoded for now - in real scenario, will retrieve from a web service
        private static List<Person> persons = new List<Person>
            {
                new Person { FirstName = "John", LastName = "Smith" },
                new Person { FirstName = "Evelin", LastName = "Oberg" },
                new Person { FirstName = "Jonathon", LastName = "Howell" },
                new Person { FirstName = "Anastasia", LastName = "Stevenson" },
                new Person { FirstName = "Patrick", LastName = "Moon" },
                new Person { FirstName = "Terry", LastName = "McGuiver" },
                new Person { FirstName = "Adam", LastName = "Hotch" },
                new Person { FirstName = "Curtis", LastName = "Drayer" },
                new Person { FirstName = "Gregory", LastName = "Stenger" },
                new Person { FirstName = "Lena", LastName = "Mitsurugi" }
            };

        public IEnumerable<Person> ListAll()
        {
            return persons;
        }

        public Person Retrieve(Guid id)
        {
            return persons.Where(p => p.PersonId == id).SingleOrDefault();
        }
    }
}

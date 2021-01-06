using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Personlist
{

    public static class PersonRegisterManager
    {
        public static void CreatePerson(Person person)
        {
            using (var db = new PersonregisterEntities())
            {
                
                db.SaveChanges();
            };
        }
    }
}

        //    public static Person GetPersonById(int id)
        //    {
        //        using (var db = new PersonregisterEntities())
        //        {
        //            var person = db.Person.Find(id);

        //            var streetName = person.Address.Street;
        //            return person;
        //        }
        //    }

        //    public static List<Person> GetPersonsByFirstName(string firstName)
        //    {
        //        using (var db = new PersonregisterEntities())
        //        {
        //            var persons = db.Person.Where(p => p.FirstName == firstName).Include(p => p.Address).ToList();
        //            return persons;
        //        }
        //    }

        //    public static List<Person> GetPersonsByStreetName(string streetName)
        //    {
        //        using (var db = new PersonregisterEntities())
        //        {
        //            var persons = db.Person.Where(p => p.Address.Street == streetName).ToList();
        //            return persons;
        //        }
        //    }
        //}
    


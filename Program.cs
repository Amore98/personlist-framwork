using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Personlist
{
    class Program
    {
        static void Main(string[] args)
        {
            var person = new Person()
            {
                FirstName = "omer",

                Age = 22,
                Address = new Address()
                {
                    Street = "anasvagen",

                }
            };


//PersonRegisterManager.CreatePerson(person);

//var person = PersonRegisterManager.GetPersonById(1);

//var streetName = person.Address.Street;
//var persons = PersonRegisterManager.GetPersonsByFirstName("Linus");

//var streetName = persons[0].Address.Street;

//var persons = PersonRegisterManager.GetPersonsByStreetName("Ramlösa Gränd");
}
}
}




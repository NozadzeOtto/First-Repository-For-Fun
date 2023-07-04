using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    public static class Helper
    {
        public static Person CreateRandomPerson(Random random)
        { 
            Person person = new Person();
            person.Firstname = "Madona";
            person.Lastname = "Jinchveleishvili";
            person.ID = random.Next(100_000_000, 999_999_999);
            person.PhoneNumber = random.Next(555_000_000, 599_000_000);
            person.Age = random.Next(0, 100);
            return person;
        }
    }
}

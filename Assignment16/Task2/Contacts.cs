using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    public class Contacts
    {
        public List<Person> Persons;

        public Contacts() { 
        
            Persons = new List<Person>();
        }

        public List<Person> WithFirstName(string firstName)
        {
            var persons = new List<Person>();
            foreach (var person in Persons)
            {
                if (person.FirstName.Contains(firstName))
                {
                    persons.Add(person);
                }
            }
            return persons;
        }

        public List<Person> WithLastName(string lastName)
        {
            var persons = new List<Person>();
            foreach (var person in Persons)
            {
                if (person.LastName.Contains(lastName))
                {
                    persons.Add(person);
                }
            }
            return persons;
        }

        public List<Person> WithFullName(string fullName)
        {
            var persons = new List<Person>();
            foreach (var person in Persons)
            {
                if ((person.LastName + person.FirstName).Contains(fullName))
                {
                    persons.Add(person);
                }
            }
            return persons;
        }

        public List<Person> WithAgeRange(int startAge, int endAge)
        {
            var persons = new List<Person>();
            foreach (var person in Persons)
            {
                if (person.Age >= startAge & person.Age <= endAge)
                {
                    persons.Add(person);
                }
            }
            return persons;
        }
    }
}

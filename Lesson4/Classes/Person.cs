using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    public class Person
    {
        public string Name { get; set; }
        public string LastName { get; set; }
        public string FullName { get => $"{Name} {LastName}"; }
    }

    public class Representator
    {
        public void RepresentPerson(Person person)
        {
            Console.Write("Дамы и господа! Представляю вам достопочтенного: ");
            Console.WriteLine(person.FullName);
        }
    }

    public class Circus
    {
        public Circus(Representator representator, List<Person> actors)
        {
            Representator = representator;
            Actors = actors;
        }

        public List<Person> Actors { get; }
        public Representator Representator { get; }

        public void StartShow()
        {
            if (Actors.Count == 0)
            {
                Console.WriteLine("Извините дамы и господа, выступать некому, цирк закрыт!");
            }

            foreach (Person person in Actors)
            {
                Representator.RepresentPerson(person);
            }
        }
    }
}

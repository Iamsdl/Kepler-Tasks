using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace _20Ex
{
    public static class ex15
    {
        public static List<Person> GenerateListOfPeople()
        {
            var people = new List<Person>();

            people.Add(new Person { FirstName = "Eric", LastName = "Fleming", Occupation = "Dev", Age = 24 });
            people.Add(new Person { FirstName = "Steve", LastName = "Smith", Occupation = "Manager", Age = 40 });
            people.Add(new Person { FirstName = "Brendan", LastName = "Enrick", Occupation = "Dev", Age = 30 });
            people.Add(new Person { FirstName = "Jane", LastName = "Doe", Occupation = "Dev", Age = 35 });
            people.Add(new Person { FirstName = "Samantha", LastName = "Jones", Occupation = "Dev", Age = 24 });

            return people;
        }

        public class Person
        {
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public string Occupation { get; set; }
            public int Age { get; set; }
        }
        public static string exer15()
        {
            List<Person> people = GenerateListOfPeople();
            Console.Write("people olther than: ");
            int age = int.Parse(Console.ReadLine());
            Console.Write("filter by name ");
            string name= Console.ReadLine();
            IEnumerable<bool> olderThan = people.Select(c => (c.Age > age));
            IEnumerable<bool> byName = people.Select(c => c.FirstName.Contains(name));
            for (int i = 0; i < olderThan.Count(); i++)
                if (olderThan.ElementAt(i))
                    Console.WriteLine(people[i].FirstName);
            for (int i = 0; i < olderThan.Count(); i++)
                if (byName.ElementAt(i))
                    Console.WriteLine(people[i].FirstName);

            return "";
        }
    }
}
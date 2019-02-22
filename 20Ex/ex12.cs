using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace _20Ex
{


    public static class ex12
    {
        public class Address
        {
            public string StreetAddress { get; set; }
            public string City { get; set; }
            public string State { get; set; }
            public string PostalCode { get; set; }
            public string Country { get; set; }
            public void write()
            {
                Console.WriteLine(this.StreetAddress);
                Console.WriteLine(this.City);
                Console.WriteLine(this.State);
                Console.WriteLine(this.PostalCode);
                Console.WriteLine(this.Country);
                Console.WriteLine();
            }
        }
        public class Person
        {
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public Address ShippingAddress { get; set; }
            public void write()
            {
                Console.WriteLine(this.FirstName);
                Console.WriteLine(this.LastName);
                this.ShippingAddress.write();
            }
        }
        public class Company
        {
            public string Name { get; set; }
            public Address ShippingAddress { get; set; }
            public void write()
            {
                Console.WriteLine(this.Name);
                this.ShippingAddress.write();
            }

        }
        public static string exer12()
        {
            List<Person> people = new List<Person>();
            List<Company> comps = new List<Company>();
            for (int i = 1; i <= 10; i++)
            {
                Person x = new Person();
                x.ShippingAddress = new Address();
                x.FirstName = "First " + i;
                x.LastName = "Last " + i;
                x.ShippingAddress.StreetAddress = "persstreet" + i;
                x.ShippingAddress.City = "perscity" + i;
                x.ShippingAddress.State = "persstate" + i;
                x.ShippingAddress.PostalCode = "perspostal" + i;
                x.ShippingAddress.Country = "perscountry" + i;
                people.Add(x);
                
                Company y = new Company();
                y.ShippingAddress = new Address();
                y.Name = "name " + i;
                y.ShippingAddress.StreetAddress = "compstreet" + i;
                y.ShippingAddress.City = "compcity" + i;
                y.ShippingAddress.State = "compstate" + i;
                y.ShippingAddress.PostalCode = "comppostal" + i;
                y.ShippingAddress.Country = "compcountry" + i;
                comps.Add(y);

            }
            foreach (Person x in people)
            {
                x.write();
            }
            foreach (Company x in comps)
            {
                x.write();
            }
            Console.ReadLine();
            return "too big too complicated too lazy";
        }
    }
}
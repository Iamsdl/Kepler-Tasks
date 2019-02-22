using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace _20Ex
{
    public static class ex14
    {
        public class Customer
        {
            public Customer(string name)
            {
                Name = name;
            }

            public string Name { get; }
            public List<Order> Orders { get; } = new List<Order>();
            public void addOrder(Order x)
            {
                if ((x != null) && (x.OrderDate < DateTime.Now)) //&&!string.IsNullOrEmpty(x.orderNumber)
                {
                    Orders.Remove(Orders.FirstOrDefault(c => c.OrderNumber == x.OrderNumber));
                    Orders.Add(x);
                }

            }
            public List<string> history
            {
                get
                {
                    List<string> temp = new List<string>();
                    temp = Orders.Select(c => (c.OrderNumber + c.OrderDate.ToString())).ToList();
                    return temp;

                }
            }
        }

        public class Order
        {
            public Order(string orderNumber, DateTime date)
            {
                OrderNumber = orderNumber;
                OrderDate = date;
            }
            public string OrderNumber { get; }
            public DateTime OrderDate { get; set; } = new DateTime();
        }



        public static string exer14()
        {
            Customer gigel = new Customer("gigel");
            Order ord = new Order("asdf", DateTime.Now);
            gigel.addOrder(null);
            gigel.addOrder(new Order("asdf", DateTime.Now));
            Console.WriteLine(string.Join("\n",gigel.history));

            return "";
        }
    }
}
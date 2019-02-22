using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace _20Ex
{
    public static class ex11
    { 
        public static void addTo(List<string> grocery)
        {
            Console.Write("add ");
            grocery.Add(Console.ReadLine());
        }
        public static void removeFrom(List<string> grocery)
        {
            Console.Write("remove ");
            grocery.Remove(Console.ReadLine());
        }
        public static void removeAllFrom(List<string> grocery)
        {
            grocery.RemoveAll(x => x.Any());
        }
        public static void checkInput(List<string> grocery)
        {
            Console.WriteLine("Enter command (+ item, - item, or -- to clear)):");
            string input = Console.ReadLine();
            if (input == "+")
            {
                addTo(grocery);
            }

            else if (input == "-")
            {
                removeFrom(grocery);
            }
            else
            {
                removeAllFrom(grocery);
            }
        }
        public static string exer11()
        {
            List<string> grocery = new List<string>();
                checkInput(grocery);
            return "go to 9";
        }
    }
}
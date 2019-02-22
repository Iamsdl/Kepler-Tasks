using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace _20Ex
{
    public static class ex9
    {
        public static List<string> exer9(string choice, string text, List<string> grocery)
        {
            if (grocery == null)
            {
                grocery = new List<string>();
            }

            if (choice == "+")
            {
                grocery.Add(text);
            }

            else if (choice == "-")
            {
                if (grocery.Any())
                {
                    grocery.Remove(text);
                }
            }
            else
            {
                grocery.Clear();
            }

            return grocery;


        }
    }
}
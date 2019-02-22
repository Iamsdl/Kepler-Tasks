using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace _20Ex
{
    public static class ex5
    {
        public static string exer5(int y)
        {
            Random x = new Random();
            int nr = x.Next(1, 3);
            if (y == nr)
            {
                return "gratz!";
            }
            else
            {
                if (y < nr)
                    return "too low";
                else
                    return "too high";
            }
        }
    }
}
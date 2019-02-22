using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace _20Ex
{
    public static class ex8
    { 
        public static string exer8()
        {
            string ret = "";
            for (int i = 1; i <= 4; i++)
            {
                for (int j = 0; j <= 24; j += i)
                    ret = ret + $"{j}, ";
                ret = ret + "\n";
            }
            return ret;
        }

    }
}
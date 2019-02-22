using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace _20Ex
{
    public static class ex10
    { 
        public static int exer10(string listaNr)
        {
            List<string> nr = listaNr.Split(',').ToList();

            int sum=0;
            foreach(string x in nr)
            {
                sum += Convert.ToInt16(x);
            }
            return sum;
        }
    }
}
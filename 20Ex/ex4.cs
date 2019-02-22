using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace _20Ex
{
    public static class ex4
    { 
        public static double[] exer4(int day,int month,int year)
        {
            DateTime birth = new DateTime(year, month, day);
            double days = (DateTime.Now - birth).TotalDays;
            Console.WriteLine(days);
            double daysToAniv = 10000 - (days % 10000);

            double[] ret = { days, daysToAniv };

            return ret;
        }
    }
}
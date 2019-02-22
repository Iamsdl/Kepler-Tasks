using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace _20Ex
{
    public static class ex6
    {
        public static string exer6()
        {
            DateTime time = DateTime.Now;
            int hour = time.Hour;
            if (hour >= 5 && hour < 11)
                return "ohayo";
            if (hour >= 11&&hour<18)
                return "konnichiwa";
            if (hour >= 18&&hour<22)
                return "konbanwa";
            if (hour >= 22||hour<5)
                return "oyasumi";
            return "";
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace _20Ex
{
    public static class ex7
    { 
        public static string exer7(int number)
        {
            string ret="Factors: ";
            while (number > 1) // convert this to while
            {
                int candidateFactor = 2;
                while (candidateFactor <= number) // convert this to while
                {
                    while (number % candidateFactor == 0) // found a factor
                    {
                        ret = ret + candidateFactor;
                        number = number / candidateFactor;// divide number by the factor you found and assign this back to number
                        if (number > 1)// print a comma if number is still greater than 1
                            ret = ret + ", ";
                    }
                    candidateFactor++;// don't forget to increment factor!
                }
            }
            return ret;
        }
    }
}
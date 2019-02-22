using System;

namespace _20Ex
{
    public static class ex3
    { 
        public static string exer3(string name,string loud)
        {
            string greeting = "greetings";
            if(loud=="loud")
            {
                greeting=greeting.ToUpper();
                name=name.ToUpper();
            }
            if(loud=="quiet")
            {
                greeting=greeting.ToLower();
                name=name.ToLower();
            }
            return $"{greeting} {name}!";


        }
    }
}
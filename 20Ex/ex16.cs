using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace _20Ex
{
    public static class ex16
    { 
        public class MyMissingTokenException : ArgumentException
        {
            public MyMissingTokenException(string message) : base(message)
            {

            }
        }
        public class MyInvalidTokenException : ArgumentException
        {
            public MyInvalidTokenException(string message) : base(message)
            {

            }
        }
        public static string exer16()
        {
            Console.WriteLine("write something with length between 1 and 5 characters");
            string th = Console.ReadLine();
            if (string.IsNullOrEmpty(th))
                throw new MyMissingTokenException("string is null or empty");
            if (th.Length > 5)
                throw new MyInvalidTokenException("too long");
            Console.WriteLine("success");
            return "";
        }
    }
}
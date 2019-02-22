using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace entity
{
    class Program
    {
        static void Main(string[] args)
        {
            SchoolDBEntities test = new SchoolDBEntities();
            Student asd = new Student() { StudentName = "alabala", StandardId = 3 };

            test.Students.Add(asd);
            test.SaveChanges();
            
            
            
        }
    }
}

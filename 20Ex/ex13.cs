using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace _20Ex
{
    public static class ex13
    {
        public class Person
        {
            public Person(string firstName, string lastName, DateTime dateOfBirth)
            {
                this.FirstName = firstName;
                this.LastName = lastName;
                this.DateOfBirth = dateOfBirth;
            }

            protected string FirstName { get; private set; }
            protected string LastName { get; private set; }
            public DateTime DateOfBirth { get; private set; }

            public string FullName { get { return $"{this.FirstName} {this.LastName}"; } }

            public bool IsAnAdult()
            {
                var eighteenYearsAgo = DateTime.Today.AddYears(-18);
                return this.DateOfBirth < eighteenYearsAgo;
            }
        }

        public class Student : Person
        {
            public Student(string firstName, string lastName, DateTime dateOfBirth)
                : base(firstName, lastName, dateOfBirth)
            { }
            public string SchoolName { get; set; }

            public string RosterName { get { return $"{this.LastName}, {this.FirstName}"; } }
        }

        public class Course
        {
            public Course(string Name, List<Student> Students)
            {
                this.Name = Name;
                this.Students = Students;
            }
            public string Name { get; private set; }
            private List<Student> Students { get; set; }
            public List<string> Roster
            {
                get
                {
                    List<string> temp = new List<string>();
                    foreach (Student x in this.Students)
                        temp.Add(x.RosterName);
                    return temp;
                }
            }
            public string RosterString
            {
                get
                {
                    return string.Join("\n", this.Roster);
                }
            }


        }
        public static string exer13()
        {
            Course test;
            {
                List<Student> temp = new List<Student>();
                for (int i = 1; i <= 10; i++)
                {
                    Student x = new Student($"first{i}", $"last{i}", new DateTime());
                    temp.Add(x);

                }
                test = new Course("testname", temp);
            }
            Console.Write(test.RosterString);
            return "";
        }
    }
}

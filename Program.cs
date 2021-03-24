using System;
using System.Linq;
using System.Collections.Generic;

namespace linq
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names = { "Hans", "Peter", "Mustername", "Manfred", "Günther", "Gustav" };
            List<Student> students = new List<Student>();

            LinqTest(names);

            students.Add(new Student(DegreeCourse.Biology, 3, "Sabrina", "Vogel"));
            students.Add(new Student(DegreeCourse.Biology, 3, "Anton", "Buffberger"));
            students.Add(new Student(DegreeCourse.Biology, 3, "Berta", "Nudel"));
            students.Add(new Student(DegreeCourse.Biology, 3, "Max", "Mustermann"));

            Part3.LinqPart3(students);
        }

        static void LinqTest(string[] names)
        {
            var linqTest = from name in names where name.Contains("t") select name;
            var linqTest2 = names.Where(name => name.Contains("t"));

            Console.WriteLine("LinqTest \n");
            foreach (string name in linqTest)
            {
                Console.WriteLine(name);
            }

            Console.WriteLine("LinqTest2");
            foreach (string name in linqTest2)
            {
                Console.WriteLine(name);
            }
        }
    }
}

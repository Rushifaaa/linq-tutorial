using System;
using System.Linq;

namespace linq
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names = { "Hans", "Peter", "Mustername", "Manfred", "Günther", "Gustav" };
            LinqTest(names);
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

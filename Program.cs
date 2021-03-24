using System;
using System.Linq;

namespace linq
{
    class Program
    {
        static void Main(string[] args)
        {
            LinqTest();
        }

        static void LinqTest()
        {
            string[] names = { "Hans", "Peter", "Mustername", "Manfred", "Günther", "Gustav" };
            var linqTest = from name in names where name.Contains("t") select name;

            foreach (string name in linqTest)
            {
                Console.WriteLine(name);
            }
        }
    }
}

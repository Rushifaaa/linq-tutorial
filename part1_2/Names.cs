using System;
using System.Linq;

namespace linq
{
    class Part1_2
    {
        public static void LinqTest(string[] names)
        {
            var linqTest = from name in names where name.Contains("t") select name;
            var linqTest2 = names.Where(name => name.Contains("t"));

            Console.WriteLine("Part 1-2 - LinqTest");
            foreach (string name in linqTest)
            {
                Console.WriteLine(name);
            }
            Console.WriteLine("______________________________________________________________________________________________");

            Console.WriteLine("Part 1-2 - LinqTest2");
            foreach (string name in linqTest2)
            {
                Console.WriteLine(name);
            }
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace linq
{
    class Part6
    {
        public static void NumbersMax(int[] numbers)
        {
            var result = numbers.Max();

            Console.WriteLine(result);
        }

        public static void NumbersMin(int[] numbers)
        {
            var result = numbers.Min();

            Console.WriteLine(result);
        }

        public static void NumbersOver10(int[] numbers)
        {
            var result = numbers.Where(number => number > 10);

            foreach (int number in result)
            {
                Console.WriteLine(number);
            }
        }

        public static void NumberMinOver10(int[] numbers)
        {
            var result = numbers.Where(number => number > 10).Min();

            Console.WriteLine(result);

        }

        public static void NumbersAvg(int[] numbers)
        {
            var result = numbers.Average();

            Console.WriteLine(result);
        }

        public static void NumbersSum(int[] numbers)
        {
            var result = numbers.Sum();

            Console.WriteLine(result);
        }

        public static void NumbersCount(int[] numbers)
        {
            var result = numbers.Count();

            Console.WriteLine(result);
        }

        public static void NumbersCountOver10(int[] numbers)
        {
            var result = numbers.Where(number => number > 10).Count();

            Console.WriteLine(result);
        }

        public static void AggregateSum(int[] numbers)
        {
            var result = numbers.Aggregate((sum, value) => sum + value);
            Console.WriteLine(result);
        }
        public static void AggregateConcatNames(string[] names)
        {
            var result = names.Aggregate((concat, value) => concat + ", " + value);
            Console.WriteLine(result);
        }

    }
}
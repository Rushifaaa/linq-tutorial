using System;
using System.Linq;
using System.Collections.Generic;

namespace linq
{

    class Part5
    {

        public static void GroupBy(List<Person> people)
        {
            var groupBy = people.GroupBy(person => person.Job);

            foreach (var group in groupBy)
            {
                Console.WriteLine("-----------------------------------------------");
                Console.WriteLine(group.Key);
                Console.WriteLine("-----------------------------------------------");

                foreach (Person person in group)
                {
                    Console.WriteLine(person.ToString());
                }
            }
        }
    }
}
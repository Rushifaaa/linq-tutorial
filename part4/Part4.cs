using System;
using System.Linq;
using System.Collections.Generic;

namespace linq
{

    class Part4
    {

        public static void OrderByName(List<Person> people)
        {
            var presonQuery = people.OrderBy(person => person.Name);

            foreach (Person person in presonQuery)
            {
                Console.WriteLine(person.ToString());
            }
        }

        public static void ThenByName(List<Person> people)
        {
            var presonQuery = people.OrderBy(person => person.Name)
                                    .ThenBy(person => person.Lastname).ToList();

            foreach (Person person in presonQuery)
            {
                Console.WriteLine(person.ToString());
            }
        }

    }

}
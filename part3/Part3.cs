using System;
using System.Linq;
using System.Collections.Generic;

namespace linq
{
    public class Part3
    {
        public static void LinqStudents(List<Student> students)
        {

            var computerSienceStudents = students.Where(student => student.degreeCourse == DegreeCourse.ComputerSience).Where(student => student.year >= 3);
            foreach (Student student in computerSienceStudents)
            {
                Console.WriteLine(student.ToString());
            }

        }

        public static void LinqAnimals(List<Animal> animals)
        {

            var dogs = animals.OfType<Dog>();
            var cats = animals.OfType<Cat>();

            foreach (Dog dog in dogs)
            {
                Console.WriteLine(dog.ToString());
            }


            foreach (Cat cat in cats)
            {
                Console.WriteLine(cat.ToString());
            }
        }
    }
}


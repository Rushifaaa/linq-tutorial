using System;
using System.Linq;
using System.Collections.Generic;

namespace linq
{
    class Program
    {
        static public List<Student> students = new List<Student>();
        static public List<Animal> animals = new List<Animal>();

        static void Main(string[] args)
        {
            string[] names = { "Hans", "Peter", "Mustername", "Manfred", "Günther", "Gustav" };

            Console.WriteLine("Part 1");
            Part1.LinqTest(names: names);

            students.Add(new Student(degreeCourse: DegreeCourse.Biology, year: 3, name: "Sabrina", lastname: "Vogel"));
            students.Add(new Student(degreeCourse: DegreeCourse.German, year: 4, name: "Anton", lastname: "Buffberger"));
            students.Add(new Student(degreeCourse: DegreeCourse.Math, year: 6, name: "Berta", lastname: "Nudel"));
            students.Add(new Student(degreeCourse: DegreeCourse.Math, year: 2, name: "Berta", lastname: "Nudel"));
            students.Add(new Student(degreeCourse: DegreeCourse.ComputerSience, year: 2, name: "Max", lastname: "Mustermann"));
            students.Add(new Student(degreeCourse: DegreeCourse.ComputerSience, year: 4, name: "Maxi", lastname: "Mustermann"));
            students.Add(new Student(degreeCourse: DegreeCourse.ComputerSience, year: 5, name: "Maxoi", lastname: "Mustermann"));
            Console.WriteLine();


            Console.WriteLine("Part 3 - Students");
            Part3.LinqStudents(students: students);

            animals.Add(new Dog(age: 12, gender: Gender.Male, name: "Ulrich"));
            animals.Add(new Cat(age: 10, gender: Gender.Male, name: "Koko"));
            animals.Add(new Dog(age: 6, gender: Gender.Male, name: "Idefix"));
            animals.Add(new Cat(age: 9, gender: Gender.Male, name: "Buffi"));
            animals.Add(new Dog(age: 5, gender: Gender.Male, name: "T"));
            Console.WriteLine();

            Console.WriteLine("Part 3 - Animals");
            Part3.LinqAnimals(animals: animals);

        }
    }
}

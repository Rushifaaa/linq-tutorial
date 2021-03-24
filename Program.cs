using System;
using System.Linq;
using System.Collections.Generic;

namespace linq
{
    class Program
    {
        public static string[] names = { "Hans", "Peter", "Mustername", "Manfred", "Günther", "Gustav" };
        public static List<Student> students = new List<Student>();
        public static List<Animal> animals = new List<Animal>();
        public static List<Person> people = new List<Person>();

        static void Main(string[] args)
        {
            Console.WriteLine("Part 1-2");
            Part1_2.LinqTest(names: names);
            Console.WriteLine();

            students.Add(new Student(degreeCourse: DegreeCourse.Biology, year: 3, name: "Sabrina", lastname: "Vogel"));
            students.Add(new Student(degreeCourse: DegreeCourse.German, year: 4, name: "Anton", lastname: "Buffberger"));
            students.Add(new Student(degreeCourse: DegreeCourse.Math, year: 6, name: "Berta", lastname: "Nudel"));
            students.Add(new Student(degreeCourse: DegreeCourse.Math, year: 2, name: "Berta", lastname: "Nudel"));
            students.Add(new Student(degreeCourse: DegreeCourse.ComputerSience, year: 2, name: "Max", lastname: "Mustermann"));
            students.Add(new Student(degreeCourse: DegreeCourse.ComputerSience, year: 4, name: "Maxi", lastname: "Mustermann"));
            students.Add(new Student(degreeCourse: DegreeCourse.ComputerSience, year: 5, name: "Maxoi", lastname: "Mustermann"));


            Console.WriteLine("Part 3 - Students");
            Part3.LinqStudents(students: students);
            Console.WriteLine();

            animals.Add(new Dog(age: 12, gender: Gender.Male, name: "Ulrich"));
            animals.Add(new Cat(age: 10, gender: Gender.Male, name: "Koko"));
            animals.Add(new Dog(age: 6, gender: Gender.Male, name: "Idefix"));
            animals.Add(new Cat(age: 9, gender: Gender.Male, name: "Buffi"));
            animals.Add(new Dog(age: 5, gender: Gender.Male, name: "T"));

            Console.WriteLine("Part 3 - Animals");
            Part3.LinqAnimals(animals: animals);
            Console.WriteLine();

            people.Add(new Person(age: 12, name: "Benjamin", lastname: "Boban"));
            people.Add(new Person(age: 32, name: "Alina", lastname: "Müll"));
            people.Add(new Person(age: 7, name: "Benjamin", lastname: "Müll"));
            people.Add(new Person(age: 18, name: "Daniela", lastname: "Blumemkohl"));
            people.Add(new Person(age: 20, name: "Carlos", lastname: "Rodrigez"));

            Console.WriteLine("Part 4 - Order By");
            Part4.OrderByName(people: people);
            Console.WriteLine();

            Console.WriteLine("Part 4 - Then By");
            Part4.ThenByName(people: people);
            Console.WriteLine();
        }
    }
}

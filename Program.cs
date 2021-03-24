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
        public static int[] numbers = { 10, 12, 13, 90, 100, 101, 000, 12 };

        static void Main(string[] args)
        {
            Console.WriteLine("Part 1-2");
            Part1_2.LinqTest(names: names);
            Console.WriteLine("______________________________________________________________________________________________");

            students.Add(new Student(degreeCourse: DegreeCourse.Biology, year: 3, name: "Sabrina", lastname: "Vogel"));
            students.Add(new Student(degreeCourse: DegreeCourse.German, year: 4, name: "Anton", lastname: "Buffberger"));
            students.Add(new Student(degreeCourse: DegreeCourse.Math, year: 6, name: "Berta", lastname: "Nudel"));
            students.Add(new Student(degreeCourse: DegreeCourse.Math, year: 2, name: "Berta", lastname: "Nudel"));
            students.Add(new Student(degreeCourse: DegreeCourse.ComputerSience, year: 2, name: "Max", lastname: "Mustermann"));
            students.Add(new Student(degreeCourse: DegreeCourse.ComputerSience, year: 4, name: "Maxi", lastname: "Mustermann"));
            students.Add(new Student(degreeCourse: DegreeCourse.ComputerSience, year: 5, name: "Maxoi", lastname: "Mustermann"));


            Console.WriteLine("Part 3 - Students");
            Part3.LinqStudents(students: students);
            Console.WriteLine("______________________________________________________________________________________________");

            animals.Add(new Dog(age: 12, gender: Gender.Male, name: "Ulrich"));
            animals.Add(new Cat(age: 10, gender: Gender.Male, name: "Koko"));
            animals.Add(new Dog(age: 6, gender: Gender.Male, name: "Idefix"));
            animals.Add(new Cat(age: 9, gender: Gender.Male, name: "Buffi"));
            animals.Add(new Dog(age: 5, gender: Gender.Male, name: "T"));

            Console.WriteLine("Part 3 - Animals");
            Part3.LinqAnimals(animals: animals);
            Console.WriteLine("______________________________________________________________________________________________");

            people.Add(new Person(age: 12, name: "Benjamin", lastname: "Boban", job: "Applikationsentwickler"));
            people.Add(new Person(age: 32, name: "Alina", lastname: "Müll", job: "Applikationsentwickler"));
            people.Add(new Person(age: 7, name: "Benjamin", lastname: "Müll", job: "Maurer"));
            people.Add(new Person(age: 18, name: "Daniela", lastname: "Blumemkohl", job: "Applikationsentwickler"));
            people.Add(new Person(age: 20, name: "Carlos", lastname: "Rodrigez", job: "Maurer"));

            Console.WriteLine("Part 4 - Order By");
            Part4.OrderByName(people: people);
            Console.WriteLine("______________________________________________________________________________________________");

            Console.WriteLine("Part 4 - Then By");
            Part4.ThenByName(people: people);
            Console.WriteLine("______________________________________________________________________________________________");

            Console.WriteLine("Part 5 - Group By");
            Part5.GroupBy(people: people);
            Console.WriteLine("______________________________________________________________________________________________");

            Console.WriteLine("Part 6 - Max");
            Part6.NumbersMax(numbers: numbers);
            Console.WriteLine("______________________________________________________________________________________________");

            Console.WriteLine("Part 6 - Min");
            Part6.NumbersMin(numbers: numbers);
            Console.WriteLine("______________________________________________________________________________________________");

            Console.WriteLine("Part 6 - > 10");
            Part6.NumbersOver10(numbers: numbers);
            Console.WriteLine("______________________________________________________________________________________________");

            Console.WriteLine("Part 6 - min > 10");
            Part6.NumberMinOver10(numbers: numbers);
            Console.WriteLine("______________________________________________________________________________________________");

            Console.WriteLine("Part 6 - Avarage");
            Part6.NumbersAvg(numbers: numbers);
            Console.WriteLine("______________________________________________________________________________________________");

            Console.WriteLine("Part 6 - Sum");
            Part6.NumbersSum(numbers: numbers);
            Console.WriteLine("______________________________________________________________________________________________");

            Console.WriteLine("Part 6 - Count");
            Part6.NumbersCount(numbers: numbers);
            Console.WriteLine("______________________________________________________________________________________________");

            Console.WriteLine("Part 6 - Count > 10");
            Part6.NumbersCountOver10(numbers: numbers);
            Console.WriteLine("______________________________________________________________________________________________");

            Console.WriteLine("Part 6 - AggregateSum");
            Part6.AggregateSum(numbers: numbers);
            Console.WriteLine("______________________________________________________________________________________________");

            Console.WriteLine("Part 6 - AggregateConcat");
            Part6.AggregateConcatNames(names: names);
            Console.WriteLine("______________________________________________________________________________________________");
        }
    }
}

using System;

namespace linq
{
    #region Animal
    public abstract class Animal
    {
        public int Age;
        public Gender Gender;
        public string Name;

        public override string ToString()
        {
            return Name + " is " + Age + " old " + "and its a " + Gender;
        }

        public abstract void Eat();
        public abstract void Drink();
    }
    #endregion

    class Dog : Animal
    {

        public int age { get; set; }
        public string name { get; set; }

        public Gender gender { get; set; }

        public Dog(int age, string name, Gender gender)
        {
            this.age = age;
            this.name = name;
            this.gender = gender;
        }

        public override void Eat()
        {
            Console.WriteLine("The Dog eats a bone");
        }

        public override void Drink()
        {
            Console.WriteLine("The Dog drinks water");
        }

        public override string ToString()
        {
            return "The Dog " + name + " is " + age + " years old and its a " + gender;
        }

    }

    class Cat : Animal
    {

        public int age { get; set; }
        public string name { get; set; }

        public Gender gender { get; set; }

        public Cat(int age, string name, Gender gender)
        {
            this.age = age;
            this.name = name;
            this.gender = gender;
        }


        public override void Eat()
        {
            Console.WriteLine("The Cat eats a Fish");
        }

        public override void Drink()
        {
            Console.WriteLine("The Cat drinks water");
        }

        public override string ToString()
        {
            return "The Cat " + name + " is " + age + " years old and its a " + gender;
        }

    }
}


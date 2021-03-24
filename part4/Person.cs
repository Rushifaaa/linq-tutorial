using System;

namespace linq
{

    class Person
    {

        public int Age;
        public string Name;
        public string Lastname;

        public Person(int age, string name, string lastname)
        {
            this.Age = age;
            this.Name = name;
            this.Lastname = lastname;
        }

        public override string ToString()
        {
            return Name + " " + Lastname + " is " + Age + " years old.";
        }

    }

}
using System;

namespace linq
{

    class Person
    {

        public int Age;
        public string Name;
        public string Lastname;
        public string Job;

        public Person(int age, string name, string lastname, string job)
        {
            this.Age = age;
            this.Name = name;
            this.Lastname = lastname;
            this.Job = job;
        }

        public override string ToString()
        {
            return Job + " " + Name + " " + Lastname + " is " + Age + " years old.";
        }

    }

}
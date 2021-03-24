using System;

namespace linq
{
    public enum DegreeCourse
    {
        ComputerSience,
        Biology,
        German,
        Math
    }

    public class Student
    {

        public DegreeCourse degreeCourse;
        public int year;
        public string name;
        public string lastname;

        public Student(DegreeCourse degreeCourse, int year, string name, string lastname)
        {
            this.degreeCourse = degreeCourse;
            this.year = year;
            this.name = name;
            this.lastname = lastname;
        }

        public override string ToString()
        {
            return name + " " + lastname + " is in " + degreeCourse + " in " + year + " Semester";
        }
    }
}
using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace linq
{

    public enum DegreeCourse
    {
        ComputerSience,
        Biology,
        German,
        Math
    }

    public class Part3
    {


        public static void LinqPart3(List<Student> students)
        {


        }


    }

    public class Student
    {

        DegreeCourse degreeCourse;
        int year;
        string name;
        string lastname;

        public Student(DegreeCourse degreeCourse, int year, string name, string lastname)
        {
            this.degreeCourse = degreeCourse;
            this.year = year;
            this.name = name;
            this.lastname = lastname;
        }

        public override string ToString()
        {
            return name + " " + lastname + " " + degreeCourse + " " + year + " Semester";
        }
    }

}


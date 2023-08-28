using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsingLINQ
{
    public class Student
    {
        public string? Firstname { get; set; }
        public string? Lastname { get; set; }
        public double TestMark { get; set; }

        public Student(string? firstname, string? lastname, double testMark)
        {
            Firstname = firstname;
            Lastname = lastname;
            TestMark = testMark;
        }
    }
}

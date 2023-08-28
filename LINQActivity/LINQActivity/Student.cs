using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQActivity
{
    public class Student
    {
        public int StudentId { get; set; }
        public string? Firstname { get; set; }
        public string? Lastname { get; set; }
        public int Age { get; set; }
        public char Gender { get; set; }
        public int YearOfStudy { get; set; }

        public Student(int studentId, string? firstname, string? lastname, int age, char gender, int yearOfStudy)
        {
            StudentId = studentId;
            Firstname = firstname;
            Lastname = lastname;
            Age = age;
            Gender = gender;
            YearOfStudy = yearOfStudy;
        }

        public override string? ToString()
        {
            string strGender = this.Gender.Equals('F') ? "Female" : "Male";
            return $"({StudentId}) {Firstname} {Lastname} - {Age} {strGender} : Year {YearOfStudy}";
        }
    }
}

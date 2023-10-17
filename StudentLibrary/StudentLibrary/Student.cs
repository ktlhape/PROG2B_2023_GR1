using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentLibrary
{
    /// <summary>
    /// Student Class
    /// </summary>
    public class Student
    {
        public string StudentId { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        private int _age;
        public int Age
        {
            get { return _age; }
            set {
                if (_age < 16)
                {
                    throw new Exception("Student should be at least 16 years");
                }
                else { _age = value; }
                }
        }
        private static List<Student> stList = new List<Student>();

        /// <summary>
        /// Create a student object with StudentId, Firstname, Lastname and Age
        /// </summary>
        /// <param name="studentId">Student Id for the student</param>
        /// <param name="firstname">Student's firstname</param>
        /// <param name="lastname">Student's lastname</param>
        /// <param name="age">Student's age</param>
        public Student(string studentId, string firstname, string lastname, int age)
        {
            StudentId = studentId;
            Firstname = firstname;
            Lastname = lastname;
            Age = age;
        }
        /// <summary>
        /// Add a student object to a collection
        /// </summary>
        /// <param name="st">Student object to be added</param>
        public static void AddStudent(Student st)
        {
            stList.Add(st);
        }
        /// <summary>
        /// Get the list of all students
        /// </summary>
        /// <returns>A list of students</returns>
        public static List<Student> AllStudents() =>
            stList;

        public override string ToString() =>
            $"({StudentId}) - {Firstname} {Lastname} : {Age}";
        
    }
}

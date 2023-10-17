using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using StudentLibrary;
namespace TestingStudentLibrary
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Add students
            //try
            //{
                Student.AddStudent(new Student("ST123", "Serena", "Williams", 25));
                Student.AddStudent(new Student("ST124", "Roger", "Federer", 24));
                Student.AddStudent(new Student("ST125", "Michael", "Jordan", 23));
                Student.AddStudent(new Student("ST126", "Jessica", "Jones", 11));
                Student.AddStudent(new Student("ST127", "David", "Specter", 35));
                Student.AddStudent(new Student("ST128", "Kevin", "De Bruyne", 22));
                Student.AddStudent(new Student("ST129", "Novak", "Djokovic", 31));
            //}
            //catch (Exception ex)
            //{

            //    Console.WriteLine(ex.Message); ;
            //}

            //Display all students
            foreach (Student st in Student.AllStudents())
            {
                Console.WriteLine(st.ToString());
            }
            Console.Read();
        }
    }
}

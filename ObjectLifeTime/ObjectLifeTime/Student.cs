using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectLifeTime
{
    public class Student : IDisposable
    {
        public string Name { get; set; } = "Kabelo";
        /// <summary>
        /// Constructor to build a student object
        /// </summary>
        public Student()
        {
            Console.WriteLine($"Building a student object for {Name}");
        }
        /// <summary>
        /// Construct a student object with the name
        /// </summary>
        /// <param name="theName">Student Name</param>
        public Student(string theName)
        {
            this.Name = theName;
            Console.WriteLine($"Building a student object for {Name}");
        }

        /// <summary>
        /// Destructor to destroy the student object
        /// </summary>
        //~Student()
        //{
        //    Console.WriteLine($"Destroying the student object for {Name}");
        //}

        public void Dispose()
        {
            Console.WriteLine($"Destroying the student object for {Name}");
        }
    }
}

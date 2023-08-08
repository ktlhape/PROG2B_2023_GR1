using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectLifeTime
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student st1 = new Student(); //Create the object          
            //st1 = null; // Empty the object
            //st2 = null;
            //GC.Collect();
            st1.Dispose();
            using (Student st2 = new Student("Steve"))
            {

            }

            Console.Read();
        }

        static void UsingDisposableObjects()
        {
            StreamReader reader1 = new StreamReader("");
            reader1.Dispose();

            using (StreamReader reader2 = new StreamReader(""))
            {

            }
        }
    }
}

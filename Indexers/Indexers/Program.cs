using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indexers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student st = new Student();
            st[0] = "Kabelo";
            st[1] = "James";
            st[2] = "Roger"; // set
            st[3] = "Carol";
            st[4] = "Michael";
            st[5] = "Lesego";

            for (int i = 0; i < st.Length(); i++)
            {
                Console.WriteLine(st[i]);
            }
             //get
            Console.Read();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnonymousTypes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region anonymousObject
            //Anonymous type
            var x = 5;
            x = 4;
            Console.WriteLine(x);
            // x = "K";
            var stObject = new {
            StNumber = "ST1000",
            Firstname = "David",
            TestMark = 89,
            Address = new
            {
                StreetNo = "021",
                StreetName = "Penelope",
                Code = "1971"
            }
            };
            //Cannot change properties of anonymous types
            //stObject.Firstname = "Kabelo"; 
            Console.WriteLine(stObject.StNumber + " " + stObject.Firstname + "\n");
            #endregion

            int[] numbers = new int[] {13, 5, 7, 2, 9, 3 };
            List<int> lsNumber = new List<int>() { 12, 5, 7, 2, 9, 3 }; ;

            int[] greaterThan5 = (from num in numbers
                               where num > 5
                               orderby num descending
                               select num).ToArray();

            /*Using LINQ, get all the even numbers from the list*/

            foreach (int num in greaterThan5)
            {
                Console.WriteLine(num);
            }

            Console.Read();
        }
    }

    public class Student
    {

    }
}

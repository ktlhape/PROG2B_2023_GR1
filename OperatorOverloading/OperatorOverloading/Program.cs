using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorOverloading
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Point pointA = new Point(5, 8);
            Point pointB = new Point(3, 12);
            Point pointBB = pointB++;

  
            Point pointC = 
                new Point(pointA.X + pointB.X,pointA.Y + pointB.Y);
            Point pointCC = pointA + pointB;

            Console.WriteLine(pointA.ToString());
            Console.WriteLine(pointB.ToString());
            Console.WriteLine(pointC.ToString());
            Console.WriteLine(pointCC.ToString());
            Console.WriteLine(pointBB.ToString());


            Console.Read();

        }
    }
}

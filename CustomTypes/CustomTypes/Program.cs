using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomTypes
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Rectangle rec = new Rectangle(3,6);
            Console.WriteLine($"Before changes - {rec.ToString()}");
            Square s = new Square(5);

            rec = s; //(10,5)
            s = (Square)rec;

            int p = 5;
            rec = (Rectangle)p;

            Console.WriteLine($"After conversion - {rec.ToString()}");

        }
    }
}

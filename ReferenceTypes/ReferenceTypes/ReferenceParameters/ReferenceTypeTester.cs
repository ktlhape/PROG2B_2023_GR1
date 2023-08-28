using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace ReferenceTypes.ReferenceParameters
{
    internal class ReferenceTypeTester
    {
        static void Main(string[] args)
        {
            string name = "Kabelo";
            Console.WriteLine($"Original string: {name}");
            PrintInput(name);
            Console.WriteLine("------");
            Console.WriteLine(name);
            Console.WriteLine("=====================");

            string name2 = "David";
            Console.WriteLine($"Original string: {name2}");
            PrintOutput(out name2);
            Console.WriteLine("------");
            Console.WriteLine(name2);

            int sum, product;
            double quotient;
            Calculate(5, 2, out sum, out product, out quotient);
            Console.WriteLine($"Sum: {sum}\nProduct: {product}\nQuoteint: {quotient}");


            Console.Read();
        }
        static void PrintInput(string str)
        {
            str = "Tuesday";
            Console.WriteLine(str);
        }
        static void PrintOutput(out string str)
        {
            str = "Wednesday";
            //Console.WriteLine(str);
        }
       static void Calculate(int x, int y, out int sum, out int product, out double quoteint)
        {
            sum = x + y;
            product = x * y;
            quoteint = x / y;
        }
    }
}

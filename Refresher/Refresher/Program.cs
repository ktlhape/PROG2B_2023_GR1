using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Refresher
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //int num1 = 5;
            //int num2 = 5;
            //int sum = 0;

            //sum = Sum(num1, num2);
            //Console.WriteLine("Sum: " + sum);
            //Console.WriteLine(CheckForThirty(14,16));
            //Console.WriteLine(CheckForThirty(8,30));
            //Console.WriteLine(CheckForThirty(15,5));

            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            Console.WriteLine("Sum: " + findSum2(99999));
            
            stopwatch.Stop();
            Console.WriteLine(stopwatch.ElapsedMilliseconds);
            Console.Read();

        }
        static int FindMax(int[] ar)
        {
            int max = int.MaxValue;
        }

        static int findSum(int n)
        {
            return n * (n + 1) / 2;
        }

        static int findSum2(int x)
        {
            int sum = 0;
            for (int i = 1; i <= x; i++)
            {
                sum += i;
            }
            return sum;
        }

        static int Sum(int num1, int num2)
        {
            int sum = 0;
            if (num2 == num1)
            {
                sum = (num1 + num2) * 3;
            }
            else
            {
                sum = (num1 + num2) ;
            }
            return sum;

        }

        static bool CheckForThirty(int num1, int num2)
        {
            return num1 == 30 || num2 == 30 ||
                (num1 + num2) == 30;
        }
    }
}

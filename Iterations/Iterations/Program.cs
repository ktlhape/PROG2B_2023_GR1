namespace Iterations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region hide
            /*1. Display "Hello World" 5 times
             * using a while loop*/

            /*2. Display "Hello World" 5 times
             * using a do while loop*/

            //Console.WriteLine("=====While Loop=====");
            //int x = 1;
            //while (x <= 5)
            //{
            //    Console.WriteLine("Hello World");
            //    x++;
            //}

            //Console.WriteLine("=====Do While Loop=====");
            //x = 1;
            //do
            //{
            //    Console.WriteLine("Hello World");
            //    x++;
            //} while (x <= 5);
            #endregion
            //int y = 1;
            //while (y <= 10)
            //{
            //    Console.WriteLine(y);
            //    y++;
            //}
            Print(1);
        }
        static void Print(int x)
        {
            if (x <= 10)
            {
                Console.WriteLine(x);
                //x++;
                Print(x + 1);
            }
        }
    }
}
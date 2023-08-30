namespace Multithreading
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Thread thOdd = new Thread(() => OddNumbers(1,10));
            Thread thEven = new Thread(() => EvenNumbers(1,10));

            thOdd.Start();
            thEven.Start();
            //OddNumbers();
            //EvenNumbers();

            Console.Read();
        }

        static void OddNumbers(int start, int end)
        {
            for (int i = start; i <= end; i++)
            {
                Thread.Sleep(2000);
                if (i % 2 != 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
        static void EvenNumbers(int start, int end)
        {
            for (int i = start; i <= end; i++)
            {
                Thread.Sleep(2000);
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }

    }
}
using System.Threading.Tasks;

namespace AsyncProgramming
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Option 1
            Task oddTask = new Task(OddNumbers);
            oddTask.Start();
            //Option 2
            Task.Run(EvenNumbers);
            DisplaySum();
            Task<double> averageTask = Task.Run(GetAverage);

            Console.WriteLine($"Average: {averageTask.Result}");
            #region

            //Option 3

            //Task oddTask2 = Task.Run(OddNumbers);

            //Task logicTask = Task.Run(() => 
            //{ 
            //    //logic
            //});

            //OddNumbers();
            //EvenNumbers();
            #endregion

            Console.Read();
        }
        static async Task EvenNumbers()
        {
            for (int i = 1; i <= 10; i++)
            {
                await Task.Delay(2000);
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
        static async void OddNumbers()
        {
            
            for (int i = 1; i <= 10; i++)
            {
                await Task.Delay(2000);
                if (i % 2 != 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
        static int GetSum()
        {
            Thread.Sleep(5000);
            int sum = 0;
            for (int i = 1; i <= 10; i++)
            {
                sum += i;
            }
            return sum;
        }

        static async void DisplaySum()
        {
            Task<int> sumTask = new Task<int>(GetSum);
            sumTask.Start();

            Console.WriteLine("... Busy calculating the sum");
            int sum = await sumTask;
            Console.WriteLine($"Sum: {sum}");
        }
        static async Task<double> GetAverage()
        {
            double average = 0;
            int total = 0;
            int count = 0;
            await Task.Delay(3000);
            for (int i = 1; i <= 10; i++)
            {
                total += i;
                count++;
            }
            average = (total / count);
            return average;
        }
    }
}
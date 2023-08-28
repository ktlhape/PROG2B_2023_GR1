using System.Diagnostics;
using System.Runtime.ExceptionServices;

namespace WindowsProcesses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var runningProcess = from proc in Process.GetProcesses(".")
                                 orderby proc.Id
                                 select proc;


            var chromProcess = from proc in Process.GetProcessesByName("chrome")
                               orderby proc.Id
                               select proc;

            //foreach (var p in chromProcess)
            //{
            //    Console.WriteLine($"{p.Id}\t{p.ProcessName}\t{p.Modules}");
            //}
            Console.WriteLine("Word = 1. Notepad = 2. Calculator = 3");
            int option = Convert.ToInt32(Console.ReadLine());
    
            string appName = "";

            if (option == 1)
            {
                appName = @"C:\Program Files\Microsoft Office\root\Office16\WINWORD.EXE";
            }else if (option == 2)
            {
                appName = "notepad";
            }
            else if (option == 3)
            {
                appName = "calc";
            }
            else
            {
                Console.WriteLine("Unknown app");
            }
            Process.Start(appName);



            Console.Read();
        }
    }
}
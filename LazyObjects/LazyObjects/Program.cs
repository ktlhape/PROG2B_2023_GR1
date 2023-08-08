using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LazyObjects
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Lazy<targetObeject> object = new Lazy<targetObject>(targetValue)

            Lazy<string[]> modules = new Lazy<string[]>(MyModules);

            //Display all the modules from the array
           
            for (int i = 0; i < modules.Value.Length; i++)
            {
                Console.WriteLine(modules.Value[i]);
            }
            Console.Read();
        }

        //Create a method to return an array of your modules
        static string[] MyModules()
        {

            return new string[] {"Prog","Databases","Cloud","Systems Software" };
        }
    }
}

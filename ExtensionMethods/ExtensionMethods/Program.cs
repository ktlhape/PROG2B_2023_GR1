using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string phrase = "Today is Tuesday, is it?";

            Console.WriteLine($"{phrase} has ({phrase.WordCount()}) words");
            Console.WriteLine($"{phrase} has ({phrase.CountVowels()}) vowels");
            Console.Read();

        }
    }
}

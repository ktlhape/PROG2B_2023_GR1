using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReferenceTypes.PointerTypes
{
    internal unsafe class PointerTester
    {
        static  void Main(string[] args)
        {
            int age = 18;
            //declare pointer
            //dataType* pointerName = &variableName;
            int* pAge = &age;

            Console.WriteLine(age);
            Console.WriteLine((int)pAge);
            Console.WriteLine(*pAge);
            Console.Read();




        }
        
    
    }
       
    
}

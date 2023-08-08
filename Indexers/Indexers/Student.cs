using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indexers
{
    public class Student
    {

        //private string[] names = new string[5];
        private List<string> names = new List<string>();
        //modifier return type this[params]

        public string this[int x]
        {
            get
            {
                return names[x];
            }
            set
            {
                names.Add(value);
            }
        }
        public int Length() => names.Count;




    }
}

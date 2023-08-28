using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethods
{
    public static class Extensions
    {
        /// <summary>
        /// Count the number of vowels in a string variable
        /// </summary>
        /// <param name="x">String variable</param>
        /// <returns>Number of vowels</returns>
        public static int CountVowels(this string x)
        {
            int count = 0;
            for (int i = 0; i < x.Length; i++)
            {
                string str = x.Substring(i, 1).ToLower();
                if (str.Equals("a") || str.Equals("e") || str.Equals("i") ||
                    str.Equals("o") || str.Equals("u") )
                {
                    count++;
                }
            }
            return count;
        }
        /// <summary>
        /// Count the numbers of words in a phrase
        /// </summary>
        /// <param name="x">The phrase</param>
        /// <returns>Number of words</returns>
        public static int WordCount(this string x)
        {
            int count = x.Split(new char[] { ' ', ',', '.', '?', '!' },
                StringSplitOptions.RemoveEmptyEntries).Length;
            return count;
        }
    }
}

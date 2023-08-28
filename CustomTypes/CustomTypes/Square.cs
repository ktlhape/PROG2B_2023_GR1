using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomTypes
{
    public class Square
    {
        public int Length { get; set; }

        public Square(int length)
        {
            Length = length;
        }

        public override string ToString() => 
            $"Length: {Length}";

       public static explicit operator Square(Rectangle r)
        {
            return new Square(r.Length);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomTypes
{
    public class Rectangle
    {
        public int Width { get; set; }
        public int Length { get; set; }

        public Rectangle(int width, int length)
        {
            Width = width;
            Length = length;
        }
        public override string ToString() =>
         $"Length: {Length}, Width: {Width}";

        public static implicit operator Rectangle(Square s)
        {
            return new Rectangle(s.Length * 2, s.Length);
        }
        //public static explicit operator Rectangle(Square s)
        //{
        //    return new Rectangle(s.Length * 2, s.Length);
        //}

        //Convert from int to a Rectangle
        public static explicit operator Rectangle(int x)
        {
            return new Rectangle(x * 2, x);
        }

        
    }
}

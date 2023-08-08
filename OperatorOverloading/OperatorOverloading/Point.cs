using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorOverloading
{
    public class Point
    {
        public int X { get; set; }
        public int Y { get; set; }

        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }
        //modifier static return type operator + (params)
        public static Point operator + (Point p1, Point p2)
        {
            return new Point(p1.X + p2.X, p1.Y + p2.Y);
        }
        public static Point operator ++(Point p)
        {
            return new Point(p.X + 10, p.Y + 10);
        }
        public static Point operator + (Point p, int x) =>
          new Point(p.X + x, p.Y + x);
        
        public static bool operator > (Point p1, Point p2)
        {
            return (p1.X > p2.X && p1.Y > p2.Y);
        }
        public static bool operator < (Point p1, Point p2) =>
            (p1.X < p2.X && p1.Y < p2.Y);
        

        public override string ToString() =>
       
           $"{this.GetType().Name}\nX: {X}\nY: {Y}\n--------------";
        
    }
}

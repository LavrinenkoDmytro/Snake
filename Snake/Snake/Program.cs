using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {
            Point p1 = new Point(15, 10, '*');
            Point p2 = new Point(1, 5, '#');
            

            List<Point> point = new List<Point>();
            point.Add(p1);
            point.Add(p2);

            foreach(Point n in point)
            {             
                n.Draw2();
            }

            Console.ReadLine();
        }

    }
}

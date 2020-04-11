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
            //Point p1 = new Point(15, 10, '*');
            //Point p2 = new Point(1, 5, '#');

            HorizontalLine horizontalLine = new HorizontalLine(1, 50, 1, '#');
            VerticalLine verticalLine = new VerticalLine(1, 1, 20, '&');
            horizontalLine.Draw();
            verticalLine.Draw();
            Console.ReadLine();
        }

    }
}

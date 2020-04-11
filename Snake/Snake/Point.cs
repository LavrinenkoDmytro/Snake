using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Point
    {
        public int x;
        public int y;
        public char sim;

        public Point(int x, int y, char sim)
        {
            this.x = x;
            this.y = y;
            this.sim = sim;
        }

        public Point() { }

        public void Draw()
        {
            Console.SetCursorPosition(x, y);
            Console.Write(sim);
        }

        // It's my second function Draw2 for better understand lesson_5 (how working RAM).
        public void Draw2()
        {
            Console.WriteLine("Вивод на екран значений x, y, sim :: " + x + ", " + y + ", " + sim);
        }

    }

}

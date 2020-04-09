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
            Draw(1, 2, '*');

            Draw(6, 8, '$');

            Console.ReadLine();
        }

        static void Draw(int x1, int y1, char simv)
        {
            Console.SetCursorPosition(x1, y1);
            Console.Write(simv);
        }
    }
}

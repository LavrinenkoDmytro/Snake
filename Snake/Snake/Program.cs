using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.SetWindowSize(80, 25);

            // Draw walls;
            HorizontalLine horizontalLeftLine = new HorizontalLine(1, 80, 1, '+');
            HorizontalLine horizontalRightLine = new HorizontalLine(1, 80, 25, '+');
            VerticalLine verticalHightLine = new VerticalLine(1, 1, 25, '+');
            VerticalLine verticalDownLine = new VerticalLine(80, 1, 25, '+');
            horizontalLeftLine.Draw();
            horizontalRightLine.Draw();
            verticalHightLine.Draw();
            verticalDownLine.Draw();

            //Draw snake;
            Point p = new Point(10, 10, '*');
            Snake snake = new Snake(p, 4, Direction.RIGHT);
            snake.Draw();
            snake.Move();
            Thread.Sleep(300);
            snake.Move();
            Thread.Sleep(300);
            snake.Move();
            Thread.Sleep(300);
            snake.Move();
            Thread.Sleep(300);
            snake.Move();
            Console.ReadLine();
        }

    }
}

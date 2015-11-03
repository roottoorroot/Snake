using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Point pointOne = new Point(4, 5, '*');
            Point pointTwo = new Point(1,2,'#');
           
            Console.SetBufferSize(80, 27);


            

            HorizontalLine gorLineTop = new  HorizontalLine(0, 78, 0, '+');
            HorizontalLine gorLineBottom = new HorizontalLine(0, 79, 24, '+');
            VerticalLine verLineLeft = new VerticalLine(0, 0, 24, '+');
            VerticalLine verLineRight = new VerticalLine(78, 0, 24, '+');

            gorLineTop.Draw();
            gorLineBottom.Draw();
            verLineLeft.Draw();
            verLineRight.Draw();


            Snake snake = new Snake(pointOne, 4, Direction.right);
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
            Thread.Sleep(300);
            snake.Move();
            Thread.Sleep(300);
            snake.Move();

            Console.ReadKey();
        }



    }
}

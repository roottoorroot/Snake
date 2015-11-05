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

            while (true)
            {
                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo key = Console.ReadKey();
                    if (key.Key == ConsoleKey.LeftArrow)
                    {
                        snake.direct = Direction.left;
                    }
                    else
                    {
                        if (key.Key == ConsoleKey.RightArrow)
                        {
                            snake.direct = Direction.right;
                        }
                        else
                        {
                            if (key.Key == ConsoleKey.DownArrow)
                            {
                                snake.direct = Direction.down;
                            }
                            else
                            {
                                snake.direct = Direction.up;
                            }
                        }
                    }
                }// End first if

                Thread.Sleep(100);
                snake.Move();

            }//End while




            Console.ReadKey();
        }



    }
}

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
                      
            Console.SetBufferSize(80, 27);                         //Bufer size

            Walls wall = new Walls(80,25);                         //Create all Wals
            Point point = new Point(4, 5, '*');                    //Create point
            Snake snake = new Snake(point, 2, Direction.right);    //Create first state of snake
            FoodCreator foodCreator = new FoodCreator(80, 25, '$');//Function for generate state of food
            Point food = foodCreator.CreateFood();                 //Create state of food

            wall.Draw();
            snake.Draw();
            food.Draw();
            
                              
                       

            while (true)
            {
                if (wall.IsHit(snake) || snake.IsHitTail()) //Protect to crash with wall or tail
                {
                    break;       //Out from circle           
                }

                if (snake.Eat(food)) 
                {
                    food = foodCreator.CreateFood();
                    food.Draw();
                }
                else
                {
                    snake.Move();
                }

                Thread.Sleep(100);

                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo key = Console.ReadKey();
                    snake.HandlKey(key.Key);
                }// End first if

               // Thread.Sleep(100);
                //snake.Move();

            }//End while




            Console.ReadKey();
        }



    }
}

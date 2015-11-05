using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Snake : Figure
    {
        Direction direct;
        public Snake(Point tail, int length, Direction _direct)
        {
            PointList = new List<Point>();
            direct = _direct;

            for (int i = 0; i < length; i++)
            {
                Point p = new Point(tail);
                p.Move(i, direct);
                PointList.Add(p);
            }

        }

        internal void Move()
        {
            Point tail = PointList.First();
            PointList.Remove(tail);
            Point head = GetNextStep();
            PointList.Add(head);

            tail.Clear();
            head.Draw();

            
        }
        public Point GetNextStep()
        {
            Point head = PointList.Last();
            Point nextPoin = new Point(head);
            nextPoin.Move(1, direct);
            return nextPoin;
        }
        public void HandlKey(ConsoleKey key)
        {

            if (key == ConsoleKey.LeftArrow)
            {
                direct = Direction.left;
            }
            else
            {
                if (key == ConsoleKey.RightArrow)
                {
                   direct = Direction.right;
                }
                else
                {
                    if (key == ConsoleKey.DownArrow)
                    {
                       direct = Direction.down;
                    }
                    else
                    {
                        direct = Direction.up;
                    }
                }
            }
        }
        internal bool Eat(Point food)
        {
            Point head = GetNextStep();
            if (head.IsHit(food))
            {
                food.sym = head.sym;
                PointList.Add(food);
                return true;
            }
            else
            {
                return false;
            }
        }

        internal bool IsHitTail()
        {
            var head = PointList.Last();
            for (int i = 0; i < PointList.Count - 2; i++)
            {
                if (head.IsHit(PointList[i]))
                {
                    return true;
                }
            }
            return false;
        }
    }
}

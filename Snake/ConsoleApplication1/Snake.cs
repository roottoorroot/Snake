using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Snake : Figure
    {
        public Direction direct;
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
    }
}

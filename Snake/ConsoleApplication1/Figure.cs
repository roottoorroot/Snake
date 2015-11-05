using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Figure
    {
        protected List<Point> PointList;

       
        public void Draw()
        {
            foreach (Point point in PointList)
            {
                point.Draw();
            }
        }

        internal bool IsHit(Figure figure)
        {
            foreach (var p in PointList)
            {
                if(figure.IsHit(p))
                return true;
            }
            return false;
        }

        private bool IsHit(Point point)
        {
            foreach (var p in PointList)
            {
                if (point.IsHit(p))
                {
                    return true;
                }
            }
            return false;
        }
    }
}

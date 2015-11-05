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
    }
}

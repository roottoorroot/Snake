using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class VerticalLine : Figure
    {
      

       
        public VerticalLine(int x, int yStart, int yEnd, char sym)
        {
            PointList = new List<Point>();
            for (int i = yStart; i < yEnd; i++)
            {
                Point p = new Point(x, i, sym);
                PointList.Add(p);
            }
        }

      
       
    }
}

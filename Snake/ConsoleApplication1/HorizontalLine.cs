using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class HorizontalLine : Figure
    {

       

       
        public HorizontalLine(int xLeft, int xRight, int y, char sym) //горизонтальные линии для отрисовки интерфейса
        {

            PointList = new List<Point>();
            for (int i = xLeft; i < xRight; i++)
            {
                Point p = new Point(i, y, sym);
                PointList.Add(p);
            }
        }




       
        
    }
}

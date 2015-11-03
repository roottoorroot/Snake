using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Point pointOne = new Point(0, 0, '*');
            Point pointTwo = new Point(1,2,'#');
            HorizontalLine gorLine = new HorizontalLine();
            VerticalLine verLine = new VerticalLine();


            pointOne.Draw();
            pointOne.Draw(0, 20, '*');
            pointOne.Draw(20, 20, '*');
            pointOne.Draw(20, 0, '*');
          

            gorLine.Draw(1, 20, 0, '-');
            gorLine.Draw(1, 20, 20, '-');
            verLine.Draw(0, 1, 20, '|');
            verLine.Draw(20, 1, 20, '|');


            Console.ReadKey();
        }



    }
}

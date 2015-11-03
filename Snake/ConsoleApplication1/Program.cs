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
            Point pointOne = new Point(1, 3, '*');
            Point pointTwo = new Point(4,5,'#');

            pointOne.Draw();
            pointTwo.Draw();


            List<int> numList = new List<int>();
            numList.Add(1);
            numList.Add(2);
            numList.Add(3);

            int x = numList[0];
            int y = numList[1];
            int z = numList[2];

            foreach (int num in numList)
            {
                Console.Write(num + " ");
            }

            List<Point> pointList = new List<Point>();
            pointList.Add(pointOne);
            pointList.Add(pointTwo);



            Console.ReadKey();
        }



    }
}

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

            pointOne.Drow();
            pointTwo.Drow();



            Console.ReadKey();
        }



    }
}

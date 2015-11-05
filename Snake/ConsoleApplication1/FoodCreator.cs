using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class FoodCreator 
    {
        int mapWight;
        int mapHeight;
        char sym;

        Random rnd = new Random();

        public FoodCreator(int x, int y, char sym)
        {

            this.mapWight = x;
            this.mapHeight = y;
            this.sym = sym;
        }

        public Point CreateFood()
        {
            int x = rnd.Next(2, mapWight - 2);
            int y = rnd.Next(2,mapHeight - 2);
            Point point = new Point(x, y, sym);
            return point;
        }
    }
}

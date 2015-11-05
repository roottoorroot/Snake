using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Walls
    {
          List<Figure> wallList;

          public Walls(int mapWeight, int mapHeight)
          {
              wallList = new List<Figure>();

              HorizontalLine gorLineTop = new HorizontalLine(0, mapWeight -2, 0, '+');
              HorizontalLine gorLineBottom = new HorizontalLine(0, mapWeight, mapHeight -1, '+');
              VerticalLine verLineLeft = new VerticalLine(0, 0, mapHeight - 1, '+');
              VerticalLine verLineRight = new VerticalLine(mapWeight - 2,0, mapHeight - 1, '+');

              wallList.Add(gorLineTop);
              wallList.Add(gorLineBottom);
              wallList.Add(verLineLeft);
              wallList.Add(verLineRight);
          }

          internal bool IsHit(Figure figure)
          {
              foreach (var wall in wallList)
              {
                  if (wall.IsHit(figure))
                  {
                      return true;
                  }
              }
              return false;
          }

          public void Draw()
          {
              foreach (var f in wallList)
              {
                  f.Draw();
              }

          }


           
    }
}

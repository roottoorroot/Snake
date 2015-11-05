using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Point
    {
        public int x = 0;
        public int y = 0;
        public char sym;

      

        public Point(int x1, int y1, char sym1)
        {
            x = x1;
            y = y1;
            sym = sym1;
        }

        public Point(Point p)
        {
            x = p.x;
            y = p.y;
            sym = p.sym;
        }

       

        public void Draw()
        {
            Console.SetCursorPosition(x, y);
            Console.WriteLine(sym);
        }

        public void Move(int offset, Direction direct)
        {
            if (direct == Direction.right)
            {
                x = x + offset;
            }
            else
            {
                if (direct == Direction.left)
                {
                    x = x - offset;
                }
                else
                {
                    if (direct == Direction.up)
                    {
                        y = y + offset;
                    }
                    else
                    {
                        y = y - offset;
                    }
                }
            }
        }
        public void Clear()
        {
            sym = ' ';
            Draw();
        }
        
    }
}

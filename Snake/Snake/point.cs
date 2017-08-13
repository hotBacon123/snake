using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class point
    {
        public int x, y;
        public char sym;

        public point(int _x,int _y,char _sym)
        {
            x = _x;
            y = _y;
            sym = _sym;
        }

        public point(point p)
        {
            x = p.x;
            y = p.y;
            sym = p.sym;
        }

        public void Move(int offset,direction dir)
        {
            if (dir == direction.RIGHT)
            {
                x += offset;
            }
            else if (dir == direction.LEFT)
            {
                x -= offset;
            }
            else if (dir == direction.UP)
            {
                y += offset;
            }
            else if (dir == direction.DOWN)
            {
                y -= offset;
            }

        }
        public void Draw()
        {
            Console.SetCursorPosition(x, y);
            Console.Write(sym);
        }

        public override string ToString()
        {
            return x + ", " + y + ", " + sym;
        }
    }
}

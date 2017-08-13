using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class vl : Figure
    {
        public vl(int yUp, int yDown, int x, char sym)
        {
            ptList = new List<point>();
            for (int y = yUp; y<=yDown; y++)
            {
                point p = new point(x, y, sym);
                ptList.Add(p);
            }
        }
        
    }
}

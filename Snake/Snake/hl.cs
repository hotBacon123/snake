using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{

    class hl : Figure
    {
        
        public hl(int xLeft,int xRight, int y,char sym)
        {
            ptList = new List<point>();
            for (int x= xLeft; x <= xRight; x++)
            {
                point p = new point(x, y, sym);
                ptList.Add(p);
            }
        }
        
    }
}

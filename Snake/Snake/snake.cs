using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class snake : Figure
    {
        public snake(point tail,int length,direction dir)
        {
            ptList = new List<point>();
            for (int i = 0; i < length; i++)
            {
                point p = new point(tail);
                p.Move(i, dir);
                ptList.Add(p);
            }
        }
    }
}

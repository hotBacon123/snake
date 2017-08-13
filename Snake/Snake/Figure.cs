using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Figure
    {
        protected List<point> ptList;

        public void Drow()
        {
            foreach (point p in ptList)
            {
                p.Draw();
            }
        }
    }
}

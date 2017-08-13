using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.SetBufferSize(80, 25);

            hl upLine = new hl(0,78,0,'+'); ;
            hl downLine = new hl(0, 78, 24, '+');
            vl leftLine = new vl(0, 24, 0, '+');
            vl rightLine = new vl(0, 24, 78, '+');
            upLine.Drow();
            downLine.Drow();
            leftLine.Drow();
            rightLine.Drow();

            point p = new point(4, 5, '*');
            snake snake = new snake(p, 4, direction.RIGHT);
            snake.Drow();

            Console.ReadLine();
        }

        
    }

}

using System;
using System.Collections.Generic;
using System.Text;

namespace MetdConst
{
    class Point
    {
        public int x { get; set; }
        public int y { get; set; }

        public Point(int x, int y)
        {
            this.x = x;
            this.y = y;

        }

        public void Print()
        {
            Console.WriteLine("x= " + this.x);
            Console.WriteLine("y= " + this.y);

        }
        public void Move(int dx, int dy)
        {
            this.x = x + dx;
            this.y = y + dy;
        }


    }
}

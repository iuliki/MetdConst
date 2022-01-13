using System;
using System.Collections.Generic;
using System.Text;

namespace MetdConst
{
    class Triangle
    {
        Point a { get; set; }
        Point b { get; set; }
        Point c { get; set; }

        public Triangle(Point a, Point b, Point c)
        {
            this.a = a;
            this.b = b;
            this.c = c;

        }

        public void Print()
        {
            Console.WriteLine("a= " +this.a.x+" "+ this.a.y);
            Console.WriteLine("b= " + this.b.x + " " + this.b.y);
            Console.WriteLine("c= " + this.c.x + " " + this.c.y);

        }

        public void Move(int dx, int dy)
        {
            this.a.x = this.a.x + dx;
            this.a.y = this.a.y + dy;
            this.b.x = this.a.x + dx;
            this.b.y = this.a.y + dy;
            this.c.x = this.c.x + dx;
            this.c.y = this.c.y + dy;
        }

    }
}

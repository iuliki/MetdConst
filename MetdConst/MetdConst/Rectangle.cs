using System;
using System.Collections.Generic;
using System.Text;

namespace MetdConst
{
    class Rectangle
    {
        Point a { get; set; }
        Point b { get; set; }
        Point c { get; set; }
        Point d { get; set; }

        int lun { get; set; }
        int lat { get,set; }

        public Triangle(Point a, int lun, int lat)
        {
            this.a = a;
            this.lun = lun;
            this.lat = lat;

           

        }
    }
}

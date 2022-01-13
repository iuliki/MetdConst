using System;

namespace MetdConst
{
    class Program
    {
        static void Main(string[] args)
        {

            Point p1 = new Point (1,1 );
            Point p2 = new Point (2,2 );
            Point p3 = new Point (3,3 );
            
            Triangle tr1 = new Triangle (p1,p2,p3);
            tr1.Print ();

            tr1.Move(1,1);
            tr1.Print();

        }
    }
}

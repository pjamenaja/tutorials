using System;
namespace Aut.Lab.lab10
{
    public class Circle
    {
        private Point point1 = null;

        private Point point2 = null;
        public Circle(Point p1,Point p2)
        {
            point1 = p1;
            point2 = p2;
        }
        public double Radius()
        {
            double pow = Math.Pow(point1.X - point2.X,2) + Math.Pow(point1.Y - point2.Y,2);
            double sumra = Math.Sqrt(pow);
            return(sumra);
        }
        public double Area(double ra)
        {
            double pow = Math.Pow(ra,2);
            double area = 3.14 * pow;
            return(area);
        }
        public double CircleLength(double ra)
        {      
            double length = 2 * 3.14 * ra;
            return(length);
        }
    }
}
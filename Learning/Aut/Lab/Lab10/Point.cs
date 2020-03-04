using System;
namespace Aut.Lab.lab10
{
    public class Point
    {
        double x = 0;
        double y = 0;
        
        public Point(string a,string b)
        {
            x = Convert.ToDouble(a);
            y = Convert.ToDouble(b);
        }
        public double X
        {
            get
            {
                return x;
            }
            set
            {
                x = value;
            }
        }
        public double Y
        {
            get
            {
                return y;
            }
            set
            {
                y = value;
            }
        }
    }
}
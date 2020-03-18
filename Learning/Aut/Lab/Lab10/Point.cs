using System;
namespace Aut.Lab.lab10
{
    public class Point
    {
        private double x = 0;
        private double y = 0;

        public Point(string a,string b)
        {
            x = Convert.ToInt32(a);
            y = Convert.ToInt32(b);    
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
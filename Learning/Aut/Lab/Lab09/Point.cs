using System;

namespace Aut.Lab.lab09
{
    public class Point
    {
        private double x = 0;
        private double y = 0;

        public Point(string a)
        {
            string[] arr = a.Split(',');
            x = Convert.ToDouble(arr[0]);
            y = Convert.ToDouble(arr[1]);
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
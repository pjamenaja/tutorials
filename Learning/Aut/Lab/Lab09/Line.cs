using System;
using System.Collections;

namespace Aut.Lab.lab09
{
    public class Line
    {       
    
        private Point point1 = null;
        private Point point2 = null;

        public Line(Point p1, Point p2)
        {          

            point1 = p1;
            point2 = p2;               
        }

        public double Length()
        {
            double powSquare = Math.Pow(point1.X - point2.X, 2) + Math.Pow(point1.Y - point2.Y, 2);
            double sumlength = Math.Sqrt(powSquare);
            return (sumlength);            
        }

        public double Slope()
        {       
            
            double sum = (point1.Y-point2.Y)/(point1.X-point2.X);          
            return(sum);
            
        }
        public void ShowC(double slope)
        {           
            double sumc = -(slope)*point1.X + point2.Y;
            Console.WriteLine("Sumc = {0}",sumc);
      

        }
        
    }
}
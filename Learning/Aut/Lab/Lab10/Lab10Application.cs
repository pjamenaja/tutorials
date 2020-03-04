using System;
namespace Aut.Lab.lab10
{
    public class lab10Application
    {
        public void Run()
        {
            Console.Write("Put point of center : ");
            string center = Console.ReadLine();
            string[] pointcen = center.Split(',');
            Console.Write("Put point : ");
            string point = Console.ReadLine();
            string[] point1 = point.Split(',');
            string cmd = "";        
            Point p = new Point(pointcen[0],pointcen[1]);
            Point p1 = new Point(point1[0],point1[1]);
            Circle cl = new Circle(p,p1);
            double radius = cl.Radius();
            double area = cl.Area(radius);
            double length = cl.CircleLength(radius);
            
            while(cmd != "exit")
            {
                Console.Write("Put command : ");
                string com = Console.ReadLine();
                string[]arrcom = com.Split(' ');
                cmd = arrcom[0];
                if(cmd == "exit")
                {
                    return;
                }
                
                else if(cmd == "show")
                {
                    Console.WriteLine("Radius of Circle = {0}",radius);
                    Console.WriteLine("Area of Circle = {0}",area);
                    Console.WriteLine("Length of Circle = {0}",length);
                    
                }

            }

        }
    }
}
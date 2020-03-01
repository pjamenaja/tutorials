using System;

namespace Aut.Lab.lab09
{
    class lab09Application
    {    
        public void Run()
        {
            Console.Write("Enter 2 point : ");
            string twopoint = Console.ReadLine();
            string[] arrpoint = twopoint.Split('|');
            Point p1 = new Point(arrpoint[0]);
            Point p2 = new Point(arrpoint[1]);
            Line l1 = new Line(p1,p2);         
            string cmd = "";
            while(cmd != "exist")
            {
                Console.Write("Please enter command : ");
                string command = Console.ReadLine();
                string[]splitcmd = command.Split(' ');
                cmd = splitcmd[0];
                if(cmd.Equals("length"))
                {
                    double length = l1.Length();
                    Console.WriteLine("Length = {0}",length);                  
                }
                else if(cmd.Equals("slope"))
                {                     
                    double slope = l1.Slope();
                    if(slope == -0)
                    {
                        Console.WriteLine("Slope = 0");
                    }
                    else
                    {
                        Console.WriteLine("Slope = {0}",slope);
                    }
                }
                else if(cmd.Equals("exit"))
                {
                    return;
                }
                else if(cmd.Equals("showc"))
                {
                    double length = l1.Length();
                    double slope = l1.Slope();
                    l1.ShowC(slope);
                }
                
                else if(cmd.Equals("show"))
                {    
                    double length = l1.Length();
                    double slope = l1.Slope();
                    Console.WriteLine("Length = {0}",length);
                    if(slope == -0)
                    {
                        Console.WriteLine("Slope = 0");
                    }
                    else
                    {
                        Console.WriteLine("Slope = {0}",slope);
                    }
                    l1.ShowC(slope);

                }
                
            }
            
        }
    }
}
using System;
using System.Collections;
namespace Aut.Lab.Lab11
{
    public class lab11Application
    {
        public void Run()
        { 
            Console.Write("Enter number : ");
            int num = Convert.ToInt32(Console.ReadLine());
            Powtwo P1 = new Powtwo(num);
            string cmd = "";
            while(cmd != "exit")
            {
                Console.Write("Enter command : ");
                string command = Console.ReadLine();
                string[] arrcom = command.Split(' ');
                cmd = arrcom[0];
                if(cmd == "change")
                {
                    P1.Binarynumeral();
                }
                else if(cmd == "exit")
                {
                    return;
                }
                else if(cmd == "count")
                {
                    int count = P1.Count();
                    Console.WriteLine(count);
                }
            }
        }
    }
}
using System;
namespace Aut.lab.lab15
{
    public class lab15application
    {
        public void Run()
        {
            while(true)
            {
                Console.Write("Put your Base : ");
                string yourbase = Console.ReadLine();
                Console.Write("Put your Power : ");
                string yourpower = Console.ReadLine();             
                if(yourbase == "exit")
                {
                    return;
                } 
                int base1 = Convert.ToInt32(yourbase);
                int power = Convert.ToInt32(yourpower);
                
                Power pw1 = new Power();
                int sum = pw1.BasePower(base1,power);
                Console.WriteLine("{0} power {1} = {2}",base1,power,sum);
            }
            
        }
    }
}
using System;
namespace Aut.lab.lab16
{
    public class lab16application
    {
        public void Run()
        {
            while(true)
            {
                Console.Write("Put your number : ");
                string yournumber = Console.ReadLine();
                Console.Write("Put your Multipliers : ");
                string yourmulti = Console.ReadLine();
            
                if(yournumber == "exit")
                {
                    return;
                } 
                int number = Int32.Parse(yournumber);
                int multi = Int32.Parse(yourmulti);
                PlusPower plus = new PlusPower();
                int output = plus.WorkProcess(number,multi); 
                Console.WriteLine("Output = {0}",output);
            }
            
            


        }
    }
}
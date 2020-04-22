using System;
using System.Collections;
namespace Aut.lab.lab14
{
    public class lab14Application
    {
        public void Run()
        {
            while(true)
            {
                Console.Write("Put your number : ");
                string inputnum = Console.ReadLine();              
                if(inputnum == "exit")
                {
                    return;
                }       
                int usernum = Int32.Parse(inputnum);              
                Amount a1 = new Amount();
                a1.Factor(usernum);
                
            }
            
            
        }
    }
}
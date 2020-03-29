using System;
using System.Collections;
namespace Aut.Lab.Lab12
{
    public class lab12application
    {
        public void Run()
        {              
            while(true)
            {
                Console.Write("Put Number : ");
                string num = Console.ReadLine();
                Basetwo b2 = new Basetwo(num); 
                if(num == "exit")
                {
                    return;
                }    
                b2.ChangeBaseTwo();
                
            }
            
            
                   
            
            


            
            
            
            
    
        }
    }
}
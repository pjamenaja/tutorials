using System;
using System.Collections;
namespace Aut.lab.lab14
{
    public class Amount
    {      
        private Queue myqueue = new Queue();      
        
        public void Factor(int number)
        {  
            
            if(IsPrime(number) == true)
            {
                myqueue.Enqueue(number);
                if(myqueue.Count == 1)
                {
                    Console.WriteLine(myqueue.Dequeue());
                }                                                                                                                
                return;  
            }
            
            int pushqueue = GetfirstFactor(number);
            int newnum = number / pushqueue;
            myqueue.Enqueue(pushqueue);
            Factor(newnum);
            
            if(IsPrime(newnum) == true)
            {
                foreach(int num in myqueue)
                {
                    Console.Write(num + " ");                           
                }
                Console.WriteLine();  
            }

            
        }
        
        
        private bool IsPrime(int inputnum)
        {                 
             
            bool Isprime = true;
            int divide = inputnum / 2;          
            for(int i = 2;i <= divide; i++)
            {
                if(inputnum % i == 0)
                {
                    Isprime = false; 
                    break;              
                }
            }
            if(Isprime == true)
            {
                return true;           
            }
            else
            {
                return false;           
            }
            
              
        }
        private int GetfirstFactor(int number)
        {
            int firstfac = 0;
            for(int i = 2;i<=number;i++)
            {
                if(number % i == 0 && IsPrime(i) == true)
                {
                    firstfac = i;
                    break;
                }
            }
            return(firstfac);
        }
           
    }
}    
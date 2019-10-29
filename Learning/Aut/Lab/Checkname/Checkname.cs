using System;
namespace Aut.Lab.lab09
{
    public class name
    {
        public void Run()
        {      
            int[]packnumber = new int[5];
            packnumber[0] = 1;
            packnumber[1] = 10;
            packnumber[2] = 20;
            packnumber[3] = 0;
            packnumber[4] = 50;
            int maxnumber = 0;
            for(int i = 0;i<packnumber.Length;i++)
            {               
               maxnumber = packnumber[0]; 
               if(packnumber[i] > maxnumber)
               {
                   maxnumber = packnumber[i];
               }   
            }
            Console.WriteLine(maxnumber);
            
        }
    }
}
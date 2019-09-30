using  System;

namespace Aut.Lab.SumArray
{
    public class SumArray
    {
        private double summation = 0;               
        private string numberlist = ""; 


        public SumArray(string numList)
        {  
            numberlist = numList;           
        }
        
        public void WhileLoopSum()
        {
            int i = 0;
            int total = 0;
            string[]sum = numberlist.Split(',');
            while(sum.Length>=0 && i<sum.Length)
            {                
                int s = Int32.Parse(sum[i]);                
                total = total+s;
                i++;                                
            }
            summation = total;                                            
        }

        public void ForLoopSum()
        {
            int total = 0;
            string[] sum = numberlist.Split(',');
            for(int i = 0;i<sum.Length;i++)
            { 
                int s = Int32.Parse(sum[i]);
                total = total + s;
            }
            summation = total;
        }

    
        public void Display()
        {
            Console.WriteLine("Sum = {0}", summation);
        }
    }
}
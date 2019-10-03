using  System;
using System.Collections;

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

        public void Sum(int type)
        {
            if (type == 1)
            {
                WhileLoopSum();
            }
            else if (type == 2)
            {
                ForLoopSum();
            }
            else
            {
                ForEachSum();
            }   
        }
                
        public void WhileLoopSum()
        {
            int i = 0;
            double total = 0;

            string[]sum = numberlist.Split(',');
            if (sum.Length <= 0)
            {
                summation = 0;                
                return;
            }
            
            while(i<sum.Length)
            {                
                double s = Double.Parse(sum[i]);                
                total = total+s;
                i++;                                
            }

            summation = total;                                            
        }

        public void ForLoopSum()
        {
            double total = 0;
            string[] sum = numberlist.Split(',');

            for(int i = 0; i<sum.Length; i++)
            { 
                double s = double.Parse(sum[i]);
                total = total + s;
            }
            summation = total;
        }

        public void ForEachSum()
        {
            double total = 0;
            string[] sums = numberlist.Split(',');

            foreach (string num in sums)
            { 
                double s = double.Parse(num);
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
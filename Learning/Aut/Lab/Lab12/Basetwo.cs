using System;
using System.Collections;

namespace Aut.Lab.Lab12
{
    public class Basetwo
    {
        private string inputnum = "";
                   
        public Basetwo(string num)
        {         
            inputnum = num;   
        }
        
        
        public void ChangeBaseTwo()
        {            
            char[] arrchar = inputnum.ToCharArray();           
            Int64 sum = 0;
            int len = arrchar.Length;
            for (int i = 1; i <= len; i++)
            {
                char ch = arrchar[i-1];
                int x = Convert.ToInt32(ch.ToString());
                sum = sum + (Int64) Math.Pow(2, len-i) * x;
                if(arrchar[i-1] != '0' && arrchar[i-1] !='1')
                {
                    Console.WriteLine("Error !!");
                }           
            }

            Console.WriteLine("Output = {0}", sum);
            
        }
        
    }
}


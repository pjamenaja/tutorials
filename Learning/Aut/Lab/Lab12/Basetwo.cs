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
        
        private bool isBase2Valid(string baseTwoStr)
        {
            char[] arrch = baseTwoStr.ToCharArray();
            for(int i = 0;i<arrch.Length;i++)
            {
                if(arrch[i] != '0' && arrch[i] != '1')
                {
                    return false;
                }             
            }
            return true;
            
        }

        public void ChangeBaseTwo()
        {            
            char[] arrchar = inputnum.ToCharArray();           

            if (!isBase2Valid(inputnum))
            {
                Console.WriteLine("Error !!");
                return;
            }
  
            Int64 sum = 0;
            int len = arrchar.Length;
            for (int i = 1; i <= len; i++)
            {
                char ch = arrchar[i-1];
                int x = Convert.ToInt32(ch.ToString());
                sum = sum + (Int64) Math.Pow(2, len-i) * x;
            }

            Console.WriteLine("Output = {0}", sum);                    
        }
        
    }
}


using System;
using System.Collections;
namespace Aut.lab.lab13
{
    public class PlusBasetwo
    {
        private string number1 = "";
        private string number2 = "";     
        Stack stacksum = new Stack();
         
        public PlusBasetwo(string num1, string num2)
        {
            number1 = num1;
            number2 = num2;           
        }
        
        private int Getmaxlength(int length1,int length2)
        {
            int outcompare = 0;
            if(length1 > length2)
            {
                outcompare = length1;
            }        
            else
            {
                outcompare = length2;
            }

            return(outcompare);
        }
            
        public void Plus()
        {            
            char[] len1 = number1.ToCharArray();
            char[] len2 = number2.ToCharArray(); 
            int length1 = len1.Length;
            int length2 = len2.Length; 
            int compare = Getmaxlength(length1,length2);       
            string num1pad = number1.PadLeft(compare,'0');
            string num2pad = number2.PadLeft(compare,'0');
            char[]arrnum1 = num1pad.ToCharArray();
            char[]arrnum2 = num2pad.ToCharArray(); 
                                               
            int carry = 0;                  

            for(int i = compare - 1; i >= 0; i--)
            {                                                                       
                int num1 = Int32.Parse(arrnum1[i].ToString());
                int num2 = Int32.Parse(arrnum2[i].ToString());                                                                          
                int sum = num1 + num2 + carry;                       
   
                if(sum == 2 )
                {
                    stacksum.Push(0);
                    carry = 1;
                }
                else if(sum == 3)
                {
                    stacksum.Push(1);
                    carry = 1;
                }
                                                 
                else
                {
                    stacksum.Push(sum);
                    carry = 0;
                }
  
            }
 
            if(carry > 0)
            {
                stacksum.Push(carry);
            }

            foreach(int num in stacksum)
            {          
                Console.Write(num);              
            }
            Console.WriteLine();
             
        }
    }
}
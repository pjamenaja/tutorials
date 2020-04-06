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
        public void Plus()
        {
            char[] arrnum1 = number1.ToCharArray();
            char[] arrnum2 = number2.ToCharArray();
            int length1 = arrnum1.Length;
            int carry = 0;
            for(int i = length1 - 1; i >= 0; i--)
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
             
        }
    }
}
using System;
using System.Collections;

namespace Aut.Lab.Lab11
{
   public class Powtwo
   {
      private int newnum = 0;

      Stack mystack = new Stack();
      public Powtwo(int num)
      {
         newnum = num;
         if(newnum == 0)
         {
            mystack.Push(0);
         }

      }
      public int Count()
      {
         int count = mystack.Count;
         return(count);
      }

      public void Binarynumeral()
      {                     
         while(newnum > 0)
         {                     
            if(newnum % 2 == 0)
            {
               mystack.Push(0);
            }
            else if(newnum % 2 == 1)
            {
               mystack.Push(1);
            }
            
            int sumdivide = newnum / 2;
            newnum = sumdivide;         
                                               
         }
         foreach(int num in mystack)
         {
            Console.Write(num);
         }
         Console.WriteLine();
               
      }
   } 
}
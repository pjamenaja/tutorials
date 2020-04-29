using System;
namespace Aut.lab.lab16
{
    public class PlusPower
    {
        public int WorkProcess(int num ,int multi)
        {
            int sum = 0;
            if(multi == 1)
            {
                return num;
            }    
            sum = num + WorkProcess(num,multi-1);        
            return(sum);

            

        }
    }
}
using System;
namespace Aut.lab.lab15
{
    public class Power
    {
        public int BasePower(int base1,int power1)
        {
            if(power1 == 1)
            {
                return base1;
            }
            int v = BasePower(base1,power1-1);          
            int r = base1 * v;           
            return (r);
        }
    }
}
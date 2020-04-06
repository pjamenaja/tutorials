using System;
namespace Aut.lab.lab13
{
    public class lab13Application
    {
        public void Run()
        {

            Console.Write("Put Number1 : ");
            string num1 = Console.ReadLine();
            Console.Write("Put Number2 : ");
            string num2 = Console.ReadLine();
            PlusBasetwo pl = new PlusBasetwo(num1,num2);
            pl.Plus();

                


        }
    }
}
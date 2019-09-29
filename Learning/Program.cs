using System;
using Aut.Lab.Argument;

namespace Learning
{
    class Program
    {
        static void Main(string[] args)
        {            
            if (args.Length <= 1)
            {
               Console.WriteLine("Please enter sub-command");
               return;
            }
            
            string cmd = args[0];
            string param = args[1];      

            if (cmd.Equals("echo"))
            {
                ArgumentLab lab01 = new ArgumentLab(param);
            }
        }
    }
}

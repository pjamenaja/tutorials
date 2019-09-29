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
            
            string command = args[0];
            string command2 = args[1];
            if(command.Equals("echo"))
            {
                ArgumentLab L1 = new ArgumentLab(command2);
            }
        }
    }
}

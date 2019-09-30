using System;
using Aut.Lab.Argument;
using Aut.Lab.SumArray;

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
                ArgumentLab echoCmd = new ArgumentLab(command2);
            }
            else if (command.Equals("sum"))
            {
                SumArray sumCmd = new SumArray(command2);
                //sumCmd.ForLoopSum();
                sumCmd.WhileLoopSum();
                sumCmd.Display();
            }           
            
            
             
             

        }
    }
}

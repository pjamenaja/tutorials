using System;
using Aut.Lab.Argument;
using Aut.Lab.SumArray;
using Aut.Lab.Lab03;
using Aut.Lab.Lab04;
using Aut.Lab.Lab05;
using Aut.Lab.lab06;


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
                
                sumCmd.ForLoopSum();
                sumCmd.WhileLoopSum();
                sumCmd.Sum(3);
                sumCmd.Display();

            }
            else if (command.Equals("lab03"))
            {
                ReplApplication Rep = new ReplApplication(command2);
                Rep.Run(); 
            }
            else if (command.Equals("lab04"))
            {
                Lab04Application ha = new Lab04Application(command2);
                ha.Run();
            }
            else if (command.Equals("lab05"))
            {
                Lab05Application read = new Lab05Application(command2);
                read.Run();
            }
            else if (command.Equals("lab06"))
            {              
                Lab06Application L6 = new Lab06Application(command2);
                L6.Run();
            }            
        }
    }
}

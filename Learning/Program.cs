using System;
using Aut.Lab.Argument;
using Aut.Lab.SumArray;
using Aut.Lab.Lab03;
using Aut.Lab.Lab04;
using Aut.Lab.Lab05;
using Aut.Lab.lab06;
using Aut.Lab.Lab07;
using Aut.Lab.Lab08;
using Aut.Lab.lab09;
using Aut.Lab.lab10;
using Aut.Lab.Lab11;
using Aut.Lab.Lab12;
using Aut.lab.lab13;

namespace Learning
{
    class Program
    {
        static void Main(string[] args)
        {                                 
            string command = args[0];
            
            if(command.Equals("echo"))
            {
                string command2 = args[1];
                ArgumentLab echoCmd = new ArgumentLab(command2);
            }
            else if(command.Equals("lab00"))
            {
                name mylab = new name();
                mylab.Run();
            }
            else if (command.Equals("sum"))
            {
                string command2 = args[1];
                SumArray sumCmd = new SumArray(command2);
                
                sumCmd.ForLoopSum();
                sumCmd.WhileLoopSum();
                sumCmd.Sum(3);
                sumCmd.Display();

            }
            else if (command.Equals("lab03"))
            {
                string command2 = args[1];
                ReplApplication Rep = new ReplApplication(command2);
                Rep.Run(); 
            }
            else if (command.Equals("lab04"))
            {
                string command2 = args[1];
                Lab04Application ha = new Lab04Application(command2);
                ha.Run();
            }
            else if (command.Equals("lab05"))
            {
                string command2 = args[1];
                Lab05Application read = new Lab05Application(command2);
                read.Run();
            }
            else if (command.Equals("lab06"))
            {
                string command2 = args[1];              
                Lab06Application L6 = new Lab06Application(command2);
                L6.Run();                                                 
            }
            else if (command.Equals("lab07"))
            {              
                if(args.Length<=1)
                {
                  Lab07Application L7 = new Lab07Application();
                  L7.Run();  
                }                
            }
            else if(command.Equals("lab08"))
            {
                if(args.Length<=1)
                {
                    Lab08Application L8 = new Lab08Application();
                    L8.Run();
                }
            }
            else if(command.Equals("lab09"))
            {
                lab09Application L9 = new lab09Application();
                L9.Run();
            }
            else if (command.Equals("lab10"))
            {
                lab10Application L10 = new lab10Application();
                L10.Run();
            }
            else if (command.Equals("lab11"))
            {
                lab11Application L11 = new lab11Application();
                L11.Run();
            }
            else if(command.Equals("lab12"))
            {
                lab12application l12 = new lab12application();
                l12.Run();
            }
            else if(command.Equals("lab13"))
            {
                lab13Application l13 = new lab13Application();
                l13.Run();
            }            
        }
    }
}

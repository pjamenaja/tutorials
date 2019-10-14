using System;

namespace Aut.Lab.Lab07
{
    public class Lab07Application
    {
        Stack mystack = new Stack();

        public void Run()
        {
            string cmd = "";
            while(!cmd.Equals("quit"))
            {
                Console.Write("Enter command : ");
                string command = Console.ReadLine();
                string[] cmdsplit = command.Split(' ');
                cmd = cmdsplit[0];
                if(cmd.Equals("clear"))
                {
                    mystack.Clear();
                }
                else if(cmd.Equals("quit"))
                {
                    return;
                }
                else if(cmd.Equals("display"))
                {
                    mystack.DisplayStack();
                }
                else if(cmd.Equals("push"))
                {
                    if(cmdsplit.Length == 1)
                    {
                        Console.WriteLine("What would you like to push ?");
                    }
                    else
                    {
                        string itempush = cmdsplit[1];
                        mystack.Push(itempush);
                    }
                    
                }
                else if(cmd.Equals("pop"))
                {
                    string data = mystack.Pop();
                    Console.WriteLine("Pop item : {0}",data);
                }
                else if(cmd.Equals("count"))
                {
                    Console.WriteLine("Size of your Stack => {0}",mystack.Count);
                }
                
            }
        }
    }
}
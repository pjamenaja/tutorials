using System;
using System.Collections;
namespace Aut.Lab.lab06
{
    public class Lab06Application
    {
        Queue myque = new Queue();
        private string name = "";
        public Lab06Application(string fileName)
        {
            name = fileName;          
        }
        public void Run()
        {
            string cmd = "";
            while(!cmd.Equals("quit"))
            {
                Console.Write("Please enter command : ");
                string cm = Console.ReadLine();
                string[] command = cm.Split(' ');
                cmd = command[0];
                if(cmd.Equals("clear"))
                {
                    myque.Clear();                  
                }
                else if(cmd.Equals("quit"))
                {
                    return;
                }
                else if(cmd.Equals("enque"))
                {                                      
                    if(command.Length == 1)
                    {                       
                        Console.WriteLine("Please put command !!");
                    }
                    else
                    {
                        string word = command[1];  
                        myque.Enqueue(word);
                    }
                }
                else if(cmd.Equals("display"))
                {
                    myque.DisplayQue();
                }
                else if(cmd.Equals("count"))
                {                    
                    Console.WriteLine("Size of Queue = {0}",myque.Count);
                }
                else if(cmd.Equals("deque"))
                {                   
                    Console.WriteLine("Deque item : {0}",myque.Dequeue());
                }
            }
        }
    }
}
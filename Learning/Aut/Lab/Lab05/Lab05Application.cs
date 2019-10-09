using System;
using System.IO;
using System.Collections;

namespace Aut.Lab.Lab05
{
    public class Lab05Application
    {
        Hashtable data = new Hashtable();
        private string datafilename = "";
        public Lab05Application(string filename)
        {
            datafilename = filename;                     
        }
        
        public void Run()
        {
            string command = "";
            while(!command.Equals("quit"))
            {
                Console.Write("Please enter command : ");
                string cmd = Console.ReadLine();
                string[]name = cmd.Split(' ');
                cmd = name[0];               
                if(cmd.Equals("clear"))
                {
                    data.Clear();
                }
                else if(cmd.Equals("count"))
                {
                    Console.WriteLine("Size of hashtable is : {0}",data.Count);
                }
                else if(cmd.Equals("quit"))
                {
                    return;
                }
                else if(cmd.Equals("load"))
                {
                    string[] lines = File.ReadAllLines(datafilename);         
                    Loopforeach(lines);
                }                   
                else if(cmd.Equals("find"))
                {
                    string key = name[1];
                    if(data.ContainsKey(key))
                    {
                        Vocab vocab = (Vocab) data[key];
                        Console.WriteLine("Show value of this Key : {0}",vocab.wordvalue);
                    }
                    else
                    {
                        Console.WriteLine("Not found this key !!!");
                    }
                }                                              
            }
        }
        private void Loopforeach(string[] li)
        {
            foreach (string line in li)
            {
                Vocab vocab = new Vocab(line);
                data.Add(vocab.name,vocab);               
            }
        }

    }
}



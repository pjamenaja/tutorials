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
                        Console.WriteLine("Show value of this Key : {0}",data[key]);
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
            foreach(string file in li)
            {
            string[] split = file.Split("|");
            string key = split[0];
            string Value = split[2];
            data.Add(key,Value);                                            
            }
        }

    }
}



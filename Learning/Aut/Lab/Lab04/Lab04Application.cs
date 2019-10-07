using System;
using System.Collections;
using System.Collections.Generic;

namespace Aut.Lab.Lab04
{
    public class Lab04Application
    {
        Hashtable namehash = new Hashtable();
        
        public Lab04Application(string data)
        {                  
            string[] vocab = data.Split(',');
            Loopforeach(vocab);                      
        }
        public void Run()
        {
            string cmd = "";
            while(!cmd.Equals("quit"))
            {
                Console.Write("Please enter command : ");
                string cd = Console.ReadLine();
                string[]ad = cd.Split(' ');
                cmd = ad[0];

                if(cmd.Equals("clear"))
                {
                    namehash.Clear();
                }
                else if(cmd.Equals("quit"))
                {
                    return;
                }
                else if(cmd.Equals("count"))
                {
                    Console.WriteLine("Size of hashtable is : " + namehash.Count);
                }
                else if(cmd.Equals("show"))
                {
                    foreach(DictionaryEntry name in namehash)
                    {
                        Console.WriteLine("Show name in hash : {0} = {1} ",name.Key,name.Value);
                    }                  
                }
                else if(cmd.Equals("add"))
                {                                     
                    if(ad.Length == 1)
                    {
                        Console.WriteLine("Please put Key and Value");
                    }
                    else
                    {
                        additem(ad);
                    }                                      
                }
                else if(cmd.Equals("find"))
                {
                    string find = ad[1];                   
                    if(namehash.ContainsKey(find))
                    {                      
                        Console.WriteLine("Show value Of this key : {0}",namehash[find]);
                    }                   
                    else
                    {
                        Console.WriteLine("Not found !!");
                    }
                }
                else if(cmd.Equals("remove"))
                {
                    string rem = ad[1];
                    namehash.Remove(rem);
                    Console.WriteLine("You have deleted ");
                }
            }          
        }
        private void Loopforeach(string[] cd)
        {
           foreach(string ele in cd)
            {
                string[] divide = ele.Split('=');
                string key = divide[0];
                string value = divide[1];
                namehash.Add(key,value);
            }                 
        }
        private void additem(string[] ad)
        {
            string nameadd = ad[1];
            string[] addname = nameadd.Split('=');
            string key = addname[0];
            string value = addname[1];
            namehash.Add(key,value);
        } 


    }

    
}
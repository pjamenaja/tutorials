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
            foreach(string ele in vocab)
            {
                string[] divide = ele.Split('=');
                string key = divide[0];
                string value = divide[1];
                namehash.Add(key,value);
            }
                      
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
                    string nameadd = ad[1];
                    string[] addname = nameadd.Split('=');
                    string key = addname[0];
                    string value = addname[1];
                    namehash.Add(key,value);
                    
                }
                else if(cmd.Equals("find"))
                {
                    string search = ad[1];
                    foreach(DictionaryEntry find in namehash)
                    {
                        if(namehash.ContainsKey(search))
                        {
                            Console.WriteLine("Show value of this word : {0}",find.Value);
                        }
                        else
                        {
                            Console.WriteLine("Not found !!");
                        }
                    }
                }

            }

        } 


    }

    
}
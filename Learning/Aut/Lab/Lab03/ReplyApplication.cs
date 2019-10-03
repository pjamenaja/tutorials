using System;
using System.Collections;



namespace Aut.Lab.Lab03
{
    public class ReplyApplication
    {
        ArrayList arrs = new ArrayList();

        public ReplyApplication(string mes)
        {
            string[] fields = mes.Split(',');
            Loop(fields);
        }

        public void Run()
        {
            string cmd = "";
            while(!cmd.Equals("quit"))
            {
                Console.Write("Please enter command : ");
                string s = Console.ReadLine();
                string[] prms = s.Split(' ');
                cmd = prms[0];

                if(cmd.Equals("count"))
                {
                    Console.WriteLine("Array count is : " + arrs.Count);
                }            
                else if(cmd.Equals("clear"))
                {
                    arrs.Clear();
                }
                else if(cmd.Equals("show"))
                {                   
                    foreach(string field in arrs)
                    {
                        Console.WriteLine("show data in Arrays : " + field);
                    }                 
                }
                else if(cmd.Equals("add"))
                {  
                    string list = prms[1];   
                    string[]ad = list.Split(',');  
                    Loop(ad);
                }
            }            
        }
        public void Loop(string[] ind)
        {
            foreach(string ad in ind)
            {
                arrs.Add(ad);
            }
        }        
    }    
}
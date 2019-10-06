using System;
using System.Collections;


namespace Aut.Lab.Lab03
{
    public class ReplApplication
    {
        ArrayList arrs = new ArrayList();

        public ReplApplication(string mes)
        {
            string[] fields = mes.Split(',');
            AddArray(fields);
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
                    if(prms.Length == 1)
                    {                        
                        Console.Write("Please enter value to be added to ArrayList : ");
                    }                  
                    else 
                    {
                        string list = prms[1];           
                        string[]ad = list.Split(',');  
                        AddArray(ad); 
                    }                                      
                }                           
            }            
        }
        private void AddArray(string[] ind)
        {
            foreach(string ad in ind)
            {
                arrs.Add(ad);
            }
        }        
    }    
}
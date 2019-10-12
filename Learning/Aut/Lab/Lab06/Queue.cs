using System;
using System.Collections;

namespace Aut.Lab.lab06
{
    public class Queue
    {    
        private ArrayList arr = new ArrayList();
        public int Count{get;set;}
                    
        public void Enqueue(string data)
        {           
            if(!arr.Contains(data))
            {
                arr.Add(data);
                
            }
            else
            {
                Console.WriteLine("Is already contains !!");
            }
        }        

        public string Dequeue()
        {
            string item = arr[0].ToString();
            arr.Remove(item);
            if(arr.Count == 0)
            {
                Console.WriteLine("No index in Array !!");
            }
            return(item);          
            
        }
        public void Clear()
        {
            arr.Clear();
        }

        public void DisplayQue()
        {
            foreach(string obj in arr)
            {
                Console.WriteLine("DisplayQue : {0}",obj);
            }
        }
        
    }
}

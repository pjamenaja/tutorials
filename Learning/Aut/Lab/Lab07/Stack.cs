using System;
using System.Collections;
namespace Aut.Lab.Lab07
{
    public class Stack
    {
        ArrayList mylish = new ArrayList();
        
        public int Count
        {
            get
            {
                return(mylish.Count);
            }
        }
        public void Push(string data)
        {
            mylish.Add(data);
        }
        public string Pop()
        {
            if(mylish.Count == 0)
            {
                Console.WriteLine("No Index in Array !!");
                
            }
            string lastitem = mylish[Count-1].ToString();
            mylish.Remove(lastitem);
            return(lastitem);                                  
        }
        public void Clear()
        {
            mylish.Clear();
        }
        public void DisplayStack()
        {
            foreach(var item in mylish)
            {
                Console.WriteLine("DisplayStack => {0}",item);
            }
        }
        
    }
    
}


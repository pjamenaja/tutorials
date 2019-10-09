using System;

namespace Aut.Lab.Lab05
{
    public class Vocab
    {
        public string name{get;set;}
        public string wordtype{get;set;}
        public string wordvalue{get;set;}

        public Vocab(string line)
        {
            string[] word = line.Split('|');
            name = word[0];
            wordtype = word[1];
            wordvalue = word[2];
        }

    }
}
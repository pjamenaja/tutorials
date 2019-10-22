using System;

namespace Aut.Lab.Lab08
{
    class Lab08Application
    {
        Oxboard mygame = new Oxboard();

        public void Run()
        {           
            string cmd = "";
            while(!cmd.Equals("quit"))
            {
                Console.Write("Please enter command : ");
                string command = Console.ReadLine();
                string[]splitcmd = command.Split(' ');
                cmd = splitcmd[0];
                if(cmd.Equals("clear"))
                {
                    mygame.Clear();
                    mygame.DisplayBoard();
                }
                else if(cmd.Equals("quit"))
                {
                    return;
                }
                else if(cmd.Equals("put"))
                {
                    string put = splitcmd[1];
                    string[]splitput = put.Split(',');
                    int row = Int32.Parse(splitput[0]);
                    int column = Int32.Parse(splitput[1]);
                    string mark = splitput[2];
                    mygame.Put(row,column,mark);                   
                    mygame.DisplayBoard();
                    bool check = mygame.IsGameOver();
      
                    if(check == true)
                    {
                        string winner = mygame.GetTheWinner();
                        Console.WriteLine("The Winner is {0}",winner);
                        return;
                    }
                    
                    
          
                }
                
            }
        }
    }
}
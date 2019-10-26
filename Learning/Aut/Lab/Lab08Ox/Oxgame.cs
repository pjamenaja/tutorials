using System;
using System.Collections;


namespace Aut.Lab.Lab08
{
    public class Oxboard
    {       
        private string[,] board = new string[3,3];
        private string winner = "";
        
        public Oxboard()
        {
            Clear();
        }

        public void Put(int row, int column, string mark)
        {          
            if(board[row,column] == " ")
            {
                board[row,column] = mark;
            }
            else
            {
                Console.WriteLine("Is already exist ");
            }
                      
                                
        }

        public void Clear()
        {       
            for (int r=0; r<3; r++)
            {
                for (int c=0; c<3; c++)
                {
                    board[r,c] = " ";
                }
            }

            winner = "";
        }

        private bool CheckGameOverByRow(int row, int len)    
        {
            string prevMark = "";
            for (int col = 0; col < 3; col++)
            {
                string mark = board[row, col];
                if(col == 0)
                {
                    prevMark = mark;
                }
                
                if (!prevMark.Equals(mark))
                {
                    return false;
                }

                prevMark = mark;
            }

            if (prevMark.Equals("O") || prevMark.Equals("X"))
            {
                winner = prevMark;
                return true;
            }
           

            return false;
        }

        private bool CheckGameOverByColumn(int col, int len)    
        {            
            string prevMark = "";
            for(int row = 0 ;row<3;row++)
            {
                string mark = board[row,col];
                if(row == 0)
                {
                    prevMark = mark;
                }
                if(!prevMark.Equals(mark))
                {
                    return false;
                }

                prevMark = mark;
            }

            if (prevMark.Equals("O") || prevMark.Equals("X"))
            {
                winner = prevMark;
                return true;
            }
                       
            return false;
        }

        private bool CheckGameoverByDiagonal()
        {
            string[] arr1 = new string[3] 
            {
                board[0,0], 
                board[1,1], 
                board[2,2] 
            };

            string[] arr2 = new string[3] 
            {
                board[0,2], 
                board[1,1], 
                board[2,0] 
            };

            bool check1 = CheckArrayIsOver(arr1);
            bool check2 = CheckArrayIsOver(arr2);

            return check1 || check2;                        
        }

        private bool CheckArrayIsOver(string[] arr)
        {
            string prevMark = "";

            for(int i = 0; i<3; i++)
            {
                string mark = arr[i];
                if(i == 0)
                {
                    prevMark = mark;
                }

                if (!prevMark.Equals(mark))
                {
                    return false;
                }

                prevMark = mark;
            }

            if (prevMark.Equals("O") || prevMark.Equals("X"))
            {
                winner = prevMark;
                return true;
            }
             
            return false;
        }
        public bool CheckDraw()
        {
            for(int i = 0;i<3;i++)
            {
                for(int j = 0;j<3;j++)
                {
                    if(board[i,j] == " ")
                    {
                        return false;
                    }
                }
            }
            return true;                   
        }
        public bool IsGameOver()
        {            

            bool isOver0 = CheckGameOverByRow(0, 3);
            bool isOver1 = CheckGameOverByRow(1, 3);
            bool isOver2 = CheckGameOverByRow(2, 3);

            bool isOver3 = CheckGameOverByColumn(0, 3);
            bool isOver4 = CheckGameOverByColumn(1, 3);
            bool isOver5 = CheckGameOverByColumn(2, 3);

            bool isOver6 = CheckGameoverByDiagonal();
      
            bool isOver = isOver0 || isOver1 || isOver2 || isOver3 || isOver4 || isOver5 || isOver6;
            return isOver;
        }

        public string GetTheWinner()
        {
            return winner;
        }

        public void DisplayBoard()
        {
            for (int r=0; r<3; r++)
            {
                Console.WriteLine(" {0} | {1} | {2} ", board[r,0], board[r,1], board[r,2]);
                if(r!=2)
                {
                    Console.WriteLine("___|___|___");
                }
            }
                    
        }
    }    
}
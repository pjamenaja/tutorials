using System;
using System.Collections;

namespace Aut.Lab.Lab08
{
    public class Oxboard
    {       
        private string[,] board = new string[3,3];

        public Oxboard()
        {
            Clear();
        }

        public void Put(int row, int column, string mark)
        {
            board[row,column] = mark;
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

            if (prevMark.Equals("O"))
            {
                Console.WriteLine("O Win");
                return true;
            }
            else if(prevMark.Equals("X"))
            {
                Console.WriteLine("X win");
                return(true);
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
            if (prevMark.Equals("O"))
            {
                Console.WriteLine("O Win");
                return true;
            }
            else if(prevMark.Equals("X"))
            {
                Console.WriteLine("X win");
                return(true);
            }
            return false;
        }

        private bool CheckGameoverByDiagonal(int Dia,int len)
        {
           
        }


        public bool IsGameOver()
        {            

            bool isOver0 = CheckGameOverByRow(0, 3);
            bool isOver1 = CheckGameOverByRow(1, 3);
            bool isOver2 = CheckGameOverByRow(2, 3);

            bool isOver3 = CheckGameOverByColumn(0, 3);
            bool isOver4 = CheckGameOverByColumn(1, 3);
            bool isOver5 = CheckGameOverByColumn(2, 3);

            bool isOver6 = CheckGameoverByDiagonal(0, 3);
            bool isOver7 = CheckGameoverByDiagonal(1, 3);
            



            
            bool isOver = isOver0 || isOver1 || isOver2 || isOver3 || isOver4 || isOver5;
            return isOver;
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
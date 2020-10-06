using System;
using System.Collections.Generic;
using System.Text;

namespace tic_tac_toe
{
    public class Board
    {
        public static string[,] board = new string[3, 3] { { "1", "2", "3" }, { "4", "5", "6" }, { "7", "8", "9" } };

        public int Hit(string select, string player)
        {
            int i, j;
            for (i = 0; i < 3; i++)
            {
                for (j = 0; j < 3; j++)
                {
                    if (board[i, j].ToString() == select)
                    {
                        board[i, j] = player;
                        return 1;
                    }
                    if (board[i, j].ToString() != select && board[i, j].ToString() == "X" || board[i, j].ToString() != select && board[i, j].ToString() == "Y")
                        continue;
                }
                if (CheckIfBoardIsFull(board)) return -1;
            }
            
            Console.Write("this place is allredy token \n");
            return 0;
        }              
    public bool CheckIfBoardIsFull(string[,]board)
        {
            int i, j, counter = 0;
            for (i = 0; i < 3; i++)
            {
                for (j = 0; j < 3; j++)
                {
                    if (board[i, j] == "X" || board[i, j] == "Y")
                        counter++;
                }
            }
            if (counter == 9) return true;
            return false;   
         }
        public int CheckWin(string[,] board)
        {
            int i, j;
            int rowX, rowY;
            int colX, colY;
            int mainAlachsonX, seconderyAlachsonX;
            int mainAlachsonY, seconderyAlachsonY;


            //ROW WIN
            for (i = 0; i < 3; i++)
            {
                rowX = 0;
                rowY = 0;
                for (j = 0; j < 3; j++)
                {
                    if (board[i, j] == "X") rowX++;
                    else if (board[i, j] == "Y") rowY++;
                }
                if (rowX == 3)
                {
                    Console.WriteLine("game over --- player X won!");
                    return 1;
                }
                if (rowY == 3)
                {
                    Console.WriteLine("game over --- player Y won!");
                    return 1;
                }
            }
            //COL WIN
            for (i = 0; i < 3; i++)
            {
                colX = 0;
                colY = 0;
                for (j = 0; j < 3; j++)
                {
                    if (board[j, i] == "X") colX++;
                    else if (board[j, i] == "Y") colY++;
                }
                if (colX == 3)
                {
                    Console.WriteLine("game over --- player X won!");
                    return 1;
                }
                if (colY == 3)
                {
                    Console.WriteLine("game over --- player Y won!");
                    return 1;
                }
            }
            // ALACHSON WIN
            mainAlachsonX = 0;
            seconderyAlachsonX = 0;
            mainAlachsonY = 0;
            seconderyAlachsonY = 0;
            for (i = 0; i < 3; i++)
            {
                for (j = 0; j < 3; j++)
                {
                    //main alachson
                    if (i == j && board[i, j] == "X") mainAlachsonX++;
                    else if (i == j && board[i, j] == "Y") mainAlachsonY++;

                    //secondery alachson
                    if (i + j == 2 || i == j)
                    {
                        if (board[i, j] == "X") seconderyAlachsonX++;
                        else if (board[i, j] == "Y") seconderyAlachsonY++;
                    }
                }
            }
            if (mainAlachsonX == 3)
            {
                Console.WriteLine("game over --- player X won!");
                return 1;
            }
            if (mainAlachsonY == 3)
            {
                Console.WriteLine("game over --- player Y won!");
                return 1;
            }
            if (seconderyAlachsonX == 3)
            {
                Console.WriteLine("game over --- player X won!");
                return 1;
            }
            if (seconderyAlachsonY == 3)
            {
                Console.WriteLine("game over --- player Y won!");
                return 1;
            }
            return 0;
        }

        public void PrintBoard()
        {
            for(int i = 0;i<3;i++)
            {
                Console.WriteLine("\n");
                for (int j = 0; j< 3; j++)
                    Console.Write($" | {board[i, j]} |");
            }
            Console.WriteLine("\n");
        }
    }
}

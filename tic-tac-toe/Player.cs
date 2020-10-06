using System;
using System.Collections.Generic;
using System.Text;

namespace tic_tac_toe
{
    public class Player
    {

         Board boardGame = new Board();
         public string playerX = "X";
         public string playerY = "Y";
         public static string player = "";

        public string Switch(string play)
        {
            
            if(play == playerX)
            {
                player = playerY;
                return player;
            }
            if(play == playerY)
            {
                player = playerX;
                return player;
            }
            return player;
        }

        public int Move(string player)
        {
            //insert value
            int flag = 1;
            string selection = "";
            Console.WriteLine($"player {player} please insert a number between 1 - 9:");
            while (flag != 0)
            {
                selection = Console.ReadLine();
                try
                {
                    int res;
                    int temp = int.Parse(selection);
                    if (temp > 9 || temp < 1)
                        throw new Exception();
                    else
                    {
                        res = boardGame.Hit(selection, player);
                        if (res == 0) throw new Exception();
                        if (res == -1)
                        {
                            Console.WriteLine("game over!\n");
                            return 0;
                        }
                        boardGame.PrintBoard();
                        flag = 0;
                        break;
                    }
                 }
                catch 
                {
                    Console.WriteLine($"player {player} please insert a number between 1 - 9:");
                }   
            }
            return 1;
        }
        
    }      
}               
     
                   
 

    


using System;
using System.Collections.Generic;
using System.Text;

namespace tic_tac_toe
{
    public class App
    {
        public static void Main(string[] args)
        {
            Board b = new Board();
            Player p1 = new Player();
            Player.player = p1.playerX;
            string player = Player.player;
            b.PrintBoard();

            Console.WriteLine($"Player {Player.player} begins..\n");
            bool flag = true;
            int res, win;
            while (flag)
            {
                res = p1.Move(player);
                win = b.CheckWin(Board.board);
                if(win == 1)
                    break;
                if(res == 0)
                {
                    if(win == 0)
                    {
                        Console.WriteLine("is't a Drow!");
                        break;
                    }
                }
                
                player = p1.Switch(player);

            }
            Console.WriteLine("final resulte:\n");
            b.PrintBoard();
            flag = false;
            Console.ReadLine();
        }
        
    
    }
   
}


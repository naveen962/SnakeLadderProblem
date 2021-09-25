using System;
using System.Collections.Generic;
using System.Text;

namespace SnakeLadderUC4
{
    class TossDice
    {
        static Boolean playerturn = true;


        public static int playgame(int pos,String player)
        {
            Random ran = new Random();
            int rolldice = ran.Next(1, 7);
            Console.WriteLine("Player gets = " + rolldice);
            int choice = ran.Next(0, 3);
            Console.WriteLine("choice : " + choice);
            const int NoPlay = 0;
            const int Ladder = 1;
            const int Snake = 2;
            switch (choice)
            {
                case NoPlay:
                    break;

                case Ladder:
                    pos = pos + rolldice;
                    playgame(pos,player);
                    if (pos > 100)
                    {
                        pos = pos - rolldice;
                        playgame(pos,player);
                    }
                    break;
                case Snake:
                    pos = pos - rolldice;

                    if (pos < 0)
                    {
                        pos = 0;

                    }
                    break;

            }
            Console.WriteLine("Position of player = " + pos);
            return pos;
        }

        static void Main(string[] args)
        {
            int player1count = 0;
            int player2count = 0;
            
            while (player1count < 100 && player2count < 100)
            {
                if (playerturn)
                {
                    player1count = playgame(player1count, "player1");
                }
                else
                {
                    player2count = playgame(player2count, "player2");
                }
                playerturn = !playerturn;
                if (player1count == 100 || player2count == 100)
                {
                    Console.WriteLine("Player 1 is winner " + player1count);
                    break;
                }
                else
                {
                    Console.WriteLine("Player 2 is winner " + player2count);
                    break;
                }
            }
        }
    }
}




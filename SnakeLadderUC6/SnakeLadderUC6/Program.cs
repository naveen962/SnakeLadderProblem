using System;
using System.Collections.Generic;
using System.Text;

namespace SnakeLadderUC4
{
    class TossDice
    {

      
        public static int playgame(int pos)
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
                    if (pos > 100)
                    {
                        pos = pos - rolldice;
                        playgame(pos);
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
            int playercount = 0;
            int temp = 0;

            while (playercount < 100)
            {
                temp = temp + 1;
                playercount = playgame(playercount);
                if (playercount == 100)
                {
                    Console.WriteLine("player reaches the goal : " + playercount);
                    Console.WriteLine("The Number of Times Dice Rolled To reach goal : " + temp);
                }
               
            }


      }
    }
}







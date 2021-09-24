using System;

namespace SnakeLadderUC3
{
    class Program
    {
        static void Main(string[] args)
        {
            int playerpos = 0;
            
            Random ran=new Random();
            int rolldice=ran.Next(1, 7);
            Console.WriteLine("Player gets = " + rolldice);
            int choice = ran.Next(0, 3);
            Console.WriteLine("Choice = "+choice);
            const int NoPlay = 0;
            const int Ladder = 1;
            const int Snake = 2;
            switch (choice)
            {
                case NoPlay:
                    break;

                case Ladder:
                    playerpos = playerpos + rolldice;
                    Console.WriteLine("Player at position = " +playerpos);
                    break;
                case Snake:
                    playerpos = playerpos - rolldice;
                    Console.WriteLine("Player at position = " +playerpos);
                    break;

            }
        }
    }
}

using System;

namespace SnakeLadderUC2
{
    class Program
    {
        static void Main(string[] args)
        {
            int playerpos = 0;
            Random ran = new Random();
            int rolldicePlayer1=ran.Next(0, 7);
            Console.WriteLine(" Player1 dice rolled and get = " + rolldicePlayer1);
           
        }
    }
}

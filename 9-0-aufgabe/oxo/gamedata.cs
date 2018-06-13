using System;

namespace oxo
{
    class Game
    {
        public static char[] gameData = new char[]{'1','2','3','4','5','6','7','8','9'};
        public static int counter = 0;
        public static char[] turn = new char[]{'X', 'O'}; 

        public static void Turn()
        {
            if((counter %2) == 0)
            {
                Console.WriteLine("==========");
                Console.WriteLine("Player 1");
                Console.WriteLine("==========");
            }
            else
            {
                Console.WriteLine("==========");
                Console.WriteLine("Player 2");
                Console.WriteLine("==========");
            }
            DrawBoard();
        }

        public static void DrawBoard()
        {
            // Game newGame = new Game();
            Console.WriteLine("|#####|");
            Console.WriteLine("|" + gameData[0] + "|" + gameData[1] + "|" + gameData[2] + "|");
            Console.WriteLine("|" + gameData[3] + "|" + gameData[4] + "|" + gameData[5] + "|");
            Console.WriteLine("|" + gameData[6] + "|" + gameData[7] + "|" + gameData[8] + "|");
            Console.WriteLine("|#####|");
            addInput();
        }

        public static void addInput()
        {
            Console.WriteLine("Input eingeben");
            int input = Convert.ToInt32(Console.ReadLine());
            counter ++;
            Turn();
        }
    }

}
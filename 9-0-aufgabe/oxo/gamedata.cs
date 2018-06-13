using System;

namespace oxo
{
    class Game
    {
        public static char[] gameData = new char[]{'1','2','3','4','5','6','7','8','9'};
        public static int counter = 0;
        public static char[] turn = new char[]{'X', 'O'}; 
        public static char player;

        public static void Turn()
        {
            if((counter %2) == 0)
            {
                Console.WriteLine("--------");
                Console.WriteLine("Player 1 - X");
                Console.WriteLine("--------");
                player = turn[0];
            }
            else
            {
                Console.WriteLine("--------");
                Console.WriteLine("Player 2 - O");
                Console.WriteLine("--------");
                player = turn[1];
            }
            DrawBoard();
        }

        public static void DrawBoard()
        {
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
            
            if(0 < input && input < 10)
            {
                if(gameData[input -1] != turn[0] && gameData[input -1] != turn[1])
                {
                    gameData[input -1 ] = player;
                    counter ++;
                }
                else
                {
                    ValueInUse();
                } 
            }
            else
            {
                ValueInvalid();
            } 
            Turn();
        }

        private static void ValueInUse()
        {
            Console.WriteLine("--------");
            Console.BackgroundColor = ConsoleColor.Red;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(" + Value in use. Please insert a new value + ");
            Console.ResetColor();
            Console.WriteLine("--------");
        }

        private static void ValueInvalid()
        {
            Console.WriteLine("--------");
            Console.BackgroundColor = ConsoleColor.Red;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(" + Value invalid. Please insert a new value + ");
            Console.ResetColor();
            Console.WriteLine("--------");
        }
    }

}
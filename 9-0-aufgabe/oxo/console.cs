using System;

namespace oxo
{
    class ConsoleOutput
    {

        public static void Field()
        {
            Console.WriteLine("|#####|");
            Console.WriteLine("|" + Game.gameData[0] + "|" + Game.gameData[1] + "|" + Game.gameData[2] + "|");
            Console.WriteLine("|" + Game.gameData[3] + "|" + Game.gameData[4] + "|" + Game.gameData[5] + "|");
            Console.WriteLine("|" + Game.gameData[6] + "|" + Game.gameData[7] + "|" + Game.gameData[8] + "|");
            Console.WriteLine("|#####|");
        }

        #region Error Message Value 
        public static void ValueInUse()
        {
            Console.WriteLine("--------");
            Console.BackgroundColor = ConsoleColor.Red;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(" + Value in use. Please insert a new value + ");
            Console.ResetColor();
            Console.WriteLine("--------");
        }

        public static void InvalidValue()
        {
            Console.WriteLine("--------");
            Console.BackgroundColor = ConsoleColor.Red;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(" + Invalid value. Please insert a new value + ");
            Console.ResetColor();
            Console.WriteLine("--------");
        }
        #endregion

        #region Winner
        public static void WinnerColor()
        {
            Game.counter ++;
            Console.BackgroundColor = ConsoleColor.Green;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(" Player " + Game.turn[Game.counter % 2] + " Win ");
            Console.ResetColor();
            Field();
        }
        #endregion

        #region Draw
        public static void DrawColor()
        {
            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(" Draw ");
            Console.ResetColor();
            Field();
        }
        #endregion
    }

}
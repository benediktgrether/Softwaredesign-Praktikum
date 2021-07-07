using System;

namespace oxo
{
    class ConsoleOutput
    {

        public static void Field()
        {
            int forcounter = 2;
            Console.WriteLine("|#####|");
            
            for(int i = 0; i < 9; i++)
            {
                if (i < forcounter)
                {
                    Console.Write("|");
                    Console.Write(Game.gameData[i]);
                }else{
                    Console.Write("|");
                    Console.WriteLine(Game.gameData[i] + "|");
                    forcounter = forcounter + 3;
                }
            }
            
            Console.WriteLine("|#####|");
        }

        public static void Player()
        {
            Console.WriteLine("--------");
            if((Game.counter % 2) == 0)  <- player existiert doch schon, keine weitere Abfrage erforderlich
            {
                Console.WriteLine("Player X");
            }
            else
            {
                Console.WriteLine("Player O");
            }
            Console.WriteLine("--------");
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

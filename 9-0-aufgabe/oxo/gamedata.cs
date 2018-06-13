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
            for(;;)
            {
                Field();
                if((counter %2) == 0)
                {
                    Console.WriteLine("--------");
                    Console.WriteLine("Player X");
                    Console.WriteLine("--------");
                    player = turn[0];
                }
                else
                {
                    Console.WriteLine("--------");
                    Console.WriteLine("Player O");
                    Console.WriteLine("--------");
                    player = turn[1];
                }

                addInput();

                if(checkWin())
                {
                    WinnerColor();
                    break;
                }

                if(Draw())
                {
                    DrawColor();
                    break;
                }
            }
        }

        public static void Field()
        {
            Console.WriteLine("|#####|");
            Console.WriteLine("|" + gameData[0] + "|" + gameData[1] + "|" + gameData[2] + "|");
            Console.WriteLine("|" + gameData[3] + "|" + gameData[4] + "|" + gameData[5] + "|");
            Console.WriteLine("|" + gameData[6] + "|" + gameData[7] + "|" + gameData[8] + "|");
            Console.WriteLine("|#####|");
        }

        public static void addInput()
        {
            Console.WriteLine("Please insert your Turn");
            
            int input = 0; 
            try
            {
                input = int.Parse(Console.ReadLine());
            }
            catch
            {
                
            }
            
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
                InvalidValue();
            } 
            checkWin();
        }
    
        public static bool checkWin()
        {
            // bool win = false;
            if(gameData[0] == gameData[1] && gameData[0] == gameData[2]){return true;}
            if(gameData[3] == gameData[4] && gameData[3] == gameData[5]){return true;}
            if(gameData[6] == gameData[7] && gameData[6] == gameData[8]){return true;}

            if(gameData[0] == gameData[3] && gameData[0] == gameData[6]){return true;}  
            if(gameData[1] == gameData[4] && gameData[1] == gameData[7]){return true;}  
            if(gameData[2] == gameData[5] && gameData[2] == gameData[8]){return true;}

            if(gameData[0] == gameData[4] && gameData[0] == gameData[8]){return true;}  
            if(gameData[2] == gameData[4] && gameData[2] == gameData[6]){return true;}
            return false;  
        }

        public static bool Draw()
        {
            if(counter == 8)
            {
                return true;
            }else
            {
                return false;
            }
        }

        #region Error Message Value 
        private static void ValueInUse()
        {
            Console.WriteLine("--------");
            Console.BackgroundColor = ConsoleColor.Red;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(" + Value in use. Please insert a new value + ");
            Console.ResetColor();
            Console.WriteLine("--------");
        }

        private static void InvalidValue()
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
        private static void WinnerColor()
        {
            counter ++;
            Console.BackgroundColor = ConsoleColor.Green;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(" Player " + turn[counter % 2] + " Win ");
            Console.ResetColor();
            Field();
        }
        #endregion

        #region Draw
        private static void DrawColor()
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
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
                
                if(Draw())
                {
                    Console.WriteLine("Draw");
                    FinishBoard();
                    break;
                }
                
                if(checkWin())
                {
                    Console.WriteLine("Player " + turn[counter % 2] + " Win");
                    FinishBoard();
                    break;
                }
                counter ++;
            }
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

        #region Game Finish Board

        private static void FinishBoard()
        {
            Console.WriteLine("|#####|");
            Console.WriteLine("|" + gameData[0] + "|" + gameData[1] + "|" + gameData[2] + "|");
            Console.WriteLine("|" + gameData[3] + "|" + gameData[4] + "|" + gameData[5] + "|");
            Console.WriteLine("|" + gameData[6] + "|" + gameData[7] + "|" + gameData[8] + "|");
            Console.WriteLine("|#####|");
        }
        #endregion
    }

}
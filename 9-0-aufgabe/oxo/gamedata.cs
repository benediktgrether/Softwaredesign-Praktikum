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
                ConsoleOutput.Field();
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
                    ConsoleOutput.WinnerColor();
                    break;
                }

                if(Draw())
                {
                    ConsoleOutput.DrawColor();
                    break;
                }
            }
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
                    ConsoleOutput.ValueInUse();
                } 
            }
            else
            {
                ConsoleOutput.InvalidValue();
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
            if(counter == 9)
            {
                return true;
            }else
            {
                return false;
            }
        }
    }

}
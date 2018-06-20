using System;

namespace oxo
{
    class Game
    {
        // Kollege Müller schreibt gerne ein "_" vor Attribute
        public static char[] gameData = new char[]{'1','2','3','4','5','6','7','8','9'};
        public static int counter = 0;
        public static char[] turn = new char[]{'X', 'O'}; 
        public static char player;

        public static void Turn()
        {
            for(;;) <- Alternativ while(true)
            {
                ConsoleOutput.Field(); <- besser PrintField()
                if((counter %2) == 0)
                {
                    ConsoleOutput.Player();
                    player = turn[0];
                }
                else
                {
                    ConsoleOutput.Player(); <- Dopplung
                    player = turn[1];
                }
                turn[ (counter%2) ? 0: 1 ];

                addInput(); <- HandleInput();

                if(checkWin())  <- CheckWin
                {
                    ConsoleOutput.WinnerColor(); <- PrintWinner()
                    break;
                }

                if(Draw())
                {
                    ConsoleOutput.DrawColor(); <- ????
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
                Ausgabe: gib Zahl zwischen 1 und 9 ein!
            }
            
            if(0 < input && input < 10)
            {
                if(gameData[input -1] != turn[0] && gameData[input -1] != turn[1]) <- vielleicht kann man auch einfach prüfen, ob es noch eine Zahl ist?
                {
                    gameData[input -1 ] = player;
                    counter ++;
                }
                else
                {
                    ConsoleOutput.ValueInUse(); <- der Wert wird gerade benutzt?
                } 
            }
            else
            {
                ConsoleOutput.InvalidValue();
            } 
            checkWin(); <- warum hier ein zweiter Aufruf?
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
            einfacher: return (counter > 8);
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

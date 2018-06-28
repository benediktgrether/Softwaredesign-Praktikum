using System;

namespace swd_endaufgabe
{
    class Program
    {
    
    static int currentLocation = 0;

    static string[,] _parkplatz = new string[,]{{"null","Supermarkt","null","null"}};
    static string[] map = {"Parkplatz", "Supermarkt", "Büro", "Kühlraum", "Hinterhof"};
    static bool[,] direction = new bool[,] 
    {
        {false, false,true,false}, 
        {true, false,false,false},
        {false, false, false, true},
        {true, true, false, false},
        {false, false, false, true}
    };
        static void Main(string[] args)
        {
            for(;;)
            {
                Console.Write("What would you like to do: ");
                string input = Console.ReadLine();
                // input.ToCharArray[0];
                char[] myChar = input.ToCharArray();
                switch(myChar[0])
                {
                    case 'n':
                    if(direction [currentLocation, 0] == true)
                    {
                        currentLocation -= 2;
                    }
                    else
                    {
                        Console.WriteLine("There is no way! Please choose another one!");
                    }
                    break;

                    case 'e':
                    if(direction [currentLocation, 1] == true)
                    {
                        currentLocation += 1;
                    }
                    else
                    {
                        Console.WriteLine("There is no way! Please choose another one!");
                    }
                    break;

                    case 's':
                    if(direction [currentLocation, 2] == true)
                    {
                        currentLocation += 2;
                    }
                    else
                    {
                        Console.WriteLine("There is no way! Please choose another one!");
                    }
                    break;

                    case 'w':
                    if(direction [currentLocation, 3] == true)
                    {
                        currentLocation -= 1;
                    }
                    else
                    {
                        Console.WriteLine("There is no way! Please choose another one!");
                    }
                    break;

                    case 'h':
                        Console.WriteLine("help");
                    break;

                    case 'q':
                        Environment.Exit(0);
                    break;
                }
                Console.WriteLine(map[currentLocation]);
            }
        }
    }
}

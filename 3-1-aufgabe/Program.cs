using System;

namespace _3_1_aufgabe
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int value = Convert.ToInt32(args[0]);
            
            // ToDo - If Bediengung erstellen das den Wert zwischen 0 und 1023 überprüft   
            
            toHexal(value);
            }
        public static int toHexal(int value)
        {
            /* 
            Umwandlung von 6 --> Dez
            Die Basis ist hier 6. 
            Jede Zahl in diesem System wird als Summe von Potenzen in 6 geschrieben, 
            die Faktoren vor diesen Potenzen sind die Ziffern der Zahl in diesem System: 
            1324(6)=1⋅6^3+3⋅6^2+2⋅6^1+4
            */

            // To-Do int -> Länge zählen und eine for-schleife rückwärtszählen 
            // int zahl auseinander nehmen

            return value;
        }
    }
}

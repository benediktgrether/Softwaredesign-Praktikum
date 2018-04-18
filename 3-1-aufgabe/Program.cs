using System;

namespace _3_1_aufgabe
{
    class Program
    {
        static void Main(string[] args)
        {
            int value = Convert.ToInt32(args[0]);
            
            if (0 <= value && value <= 1023 ){
                toHexal(value);
            }else{
                Console.WriteLine("Please make a input from 0 to 1023");
            }
        }
        public static int toHexal(int value)
        {

            Console.WriteLine(value + " Der Rest beträgt : " + value % 6);
            for (int i = value.ToString().Length; i > 0; i--)
            {
                Console.WriteLine(i);
            }
           
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

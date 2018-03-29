using System;

namespace _1_2_aufgabe
{
    class Program
    {
        static string[] subjects = { "Harry", "Hermine", "Ron", "Hagrid", "Snape", "Dumbledore" };
        static string[] verbs = { "braut", "liebt", "studiert", "hasst", "zaubert", "zerstört" };
        static string[] objects = { "Zaubertränke", "den Grimm", "Lupin", "Hogwards", "die Karte des Rumtreibers", "Dementoren" };
        
        static void Main(string[] args)
        {
            int num;
            int[] array = new int[5];
            int[] count = new int[5];
            for (int i = 0; i < count.Length; i++)
            {
                num = GetVerse();
                count[i] = num;

                // num = GetVerse();
                // // count[i] = num;
                // int numTwo = GetVerse();
                // array[i] = numTwo;
                // // Console.Write(num + " | ");
                // if( num == array[i]){
                //     count[i] = num;
                //     Console.WriteLine( num + " == " + count[i] + " -- " + array[i] );
                // }else{
                //     Console.WriteLine( num + " != " + count[i] + " -- " + array[i] );
                //     num = GetVerse();
                //     // array[i] = num;
                // }

                // if (count[i] == num){
                //     num = GetVerse();
                //     // count[i] = num;
                // }else{
                //     count[i] = num;
                //     // num = GetVerse();
                // }
                
                // Console.WriteLine( i + " Random number is " + num + " " + subjects[num]);
                // Console.WriteLine( "Zähler :" + count[i]);
            }
            // Console.WriteLine("Random number is " + num);
        }

        public static int GetVerse(){
            Random rnd = new Random();
            int num = rnd.Next(1, 5);
            // Console.WriteLine(num);
            return num;
        }
    }
}

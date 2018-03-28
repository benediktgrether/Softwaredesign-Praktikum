using System;

namespace _1_2_aufgabe
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            GetVerse();
            // static string[] subjects = { "Harry", "Hermine", "Ron", "Hagrid", "Snape", "Dumbledore" };
            // static string[] verbs = { "braut", "liebt", "studiert", "hasst", "zaubert", "zerstört" };
            // static string[] objects = { "Zaubertränke", "den Grimm", "Lupin", "Hogwards", "die Karte des Rumtreibers", "Dementoren" };
        }
    // public static void GetVerse(string[] subjects, string[] verbs, string[] objects){

    // }

        public static void GetVerse(){
            Random rnd = new Random();
            int num = rnd.Next(1, 5);
            Console.WriteLine(num);
        }
    }
}

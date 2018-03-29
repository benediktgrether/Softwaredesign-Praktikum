using System;

namespace _1_2_aufgabe
{
    class Program
    {
        static string[] subjects = { "Harry", "Hermine", "Ron", "Hagrid", "Snape", "Dumbledore" };
        static string[] verbs = { "braut", "liebt", "studiert", "hasst", "zaubert", "zerstört" };
        static string[] objects = { "Zaubertränke", "den Grimm", "Lupin", "Hogwards", "die Karte des Rumtreibers", "Dementoren" };

        static int subLength = subjects.Length;
        static string Sub;
        static string Verb;
        static string Obj;
        static void Main(string[] args)
        {
            string[] verse = new string[subLength];
            for (int i = 0; i < subjects.Length; i++)
            {
                GetVerse();
                verse[i] = Sub + " " + Verb + " " + Obj;
            }
            for (int i = 0; i < subjects.Length; i++){
                Console.WriteLine(verse[i]);
            }
        }

        public static void GetVerse()
        {
            Random rnd = new Random();
            int num = rnd.Next(0, subLength);

            while (subjects[num] == "used")
            {
                num = rnd.Next(0, subLength);
            }
            Sub = subjects[num];
            subjects[num] = "used";

            while (verbs[num] == "used")
            {
                num = rnd.Next(0, subLength);
            }
            Verb = verbs[num];
            verbs[num] = "used";

            while (objects[num] == "used")
            {
                num = rnd.Next(0, subLength);
            }
            Obj = objects[num];
            objects[num] = "used";
        }
    }
}

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
            Random random = new Random();
            int randomsubject = random.Next(0, subLength);
            int randomverb = random.Next(0, subLength);
            int randomobject = random.Next(0, subLength);

            while (subjects[randomsubject] == "used")
            {
                randomsubject = random.Next(0, subLength);
            }
            Sub = subjects[randomsubject];
            subjects[randomsubject] = "used";

            while (verbs[randomverb] == "used")
            {
                randomverb = random.Next(0, subLength);
            }
            Verb = verbs[randomverb];
            verbs[randomverb] = "used";

            while (objects[randomobject] == "used")
            {
                randomobject = random.Next(0, subLength);
            }
            Obj = objects[randomobject];
            objects[randomobject] = "used";
        }
    }
}

using System;

namespace _1_2_aufgabe
{
    class Program
    {
        static string[] Subjects = { "Harry", "Hermine", "Ron", "Hagrid", "Snape", "Dumbledore" };
        static string[] Verbs = { "braut", "liebt", "studiert", "hasst", "zaubert", "zerstört" };
        static string[] Objects = { "Zaubertränke", "den Grimm", "Lupin", "Hogwards", "die Karte des Rumtreibers", "Dementoren" };

        static int subLength = Subjects.Length;
        static string Sub;
        static string Verb;
        static string Obj;
        
        static void Main(string[] args)
        {
            string[] verse = new string[subLength];
            for (int i = 0; i < Subjects.Length; i++)
            {
                GetVerse();
                verse[i] = Sub + " " + Verb + " " + Obj;
            }
            for (int i = 0; i < Subjects.Length; i++){
                Console.WriteLine(verse[i]);
            }
        }

        public static void GetVerse()
        {
            Random rnd = new Random();
            int subNum = rnd.Next(0, subLength);
            int verbNum = rnd.Next(0, subLength);
            int objNum = rnd.Next(0, subLength);

            while (Subjects[subNum] == "used")
            {
                subNum = rnd.Next(0, subLength);
            }
            Sub = Subjects[subNum];
            Subjects[subNum] = "used";

            while (Verbs[verbNum] == "used")
            {
                verbNum = rnd.Next(0, subLength);
            }
            Verb = Verbs[verbNum];
            Verbs[verbNum] = "used";

            while (Objects[objNum] == "used")
            {
                objNum = rnd.Next(0, subLength);
            }
            Obj = Objects[objNum];
            Objects[objNum] = "used";
        }
    }
}

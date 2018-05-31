using System;
using System.Collections.Generic;

namespace L07_DesignPatterns
{   
    
    class Program
    {
        static public List<Person> personen = new List<Person>();
        static void Main(string[] args)
        {
            #region singleton
            // List<Person> personen = new List<Person>();

            // Eine Stelle, an der Personen angelegt werden
            new Person( "Dieter", 44);
            new Person( "Horst", 45);
            new Person( "Walter", 33);
            new Person( "Karl-Heinz", 22);


            // Eine ANDERE Stelle, an der Personen angelegt werden
            new Person( "Brunhilde", 56);
            new Person( "Maria", 75);
            new Person( "Kunigunde", 22);
            new Person( "Tusnelda", 12);

            foreach(var person in personen)
            {
                Console.WriteLine(personen);
            }

            // // Eine Stelle, an der Personen angelegt werden
            // personen.Add(new Person( "Dieter", 44));
            // personen.Add(new Person( "Horst", 45));
            // personen.Add(new Person( "Walter", 33));
            // personen.Add(new Person( "Karl-Heinz", 22));


            // // Eine ANDERE Stelle, an der Personen angelegt werden
            // personen.Add(new Person( "Brunhilde", 56));
            // personen.Add(new Person( "Maria", 75));
            // personen.Add(new Person( "Kunigunde", 22));
            // personen.Add(new Person( "Tusnelda", 12));





            foreach (var person in personen)
                Console.WriteLine(person);


            #endregion    
            Console.WriteLine("Hello World!");

            #region decorator
            List<GameChar> character = new List<GameChar>();

            character.Add(new Monster());
            character.Add(new Hero());
            character.Add(new WithAColdChar(new Hero()));
            character.Add(new HoarseChar(new Monster()));
            character.Add(new HoarseChar(new WithAColdChar(new Hero())));

            foreach (var GameChar in character)
            {
                GameChar.Threaten();
                Console.WriteLine();
            }

            #endregion
        }
    }
}

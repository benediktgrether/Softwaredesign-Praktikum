using System;

namespace uml_aufgabe
{
    interface Person
    {
        string FirstName();
        string LastName();
        int Age();
    }

    interface Member : Person
    {
        int MatriculationNumber();
        string[] courses();
    }

    interface Professor : Person 
    {
        string Room();
        DateTime OfficeDays();
        DateTime OfficeHours();
        string[] courses();
    }

    interface Course : Professor, Member
    {
        string Titel();
        DateTime day();
        DateTime time();
        string CoursRoom();
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}

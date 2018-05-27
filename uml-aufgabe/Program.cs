using System;

namespace uml_aufgabe
{


    public interface Iinformation
    {
        void SampleMethod();
    }

    class Person
    {
        public string FirstName;
        public string LastName;
        public int Age;
    }

    class Member : Person
    {
        public int MatriculationNumber;
        public string[] courses;
    }

    class Professor : Person 
    {
        public string Room;
        public Datetime OfficeDays;
        public Datetime OfficeHours;
        public string[] courses;
    }

    class Course : Professor, Member
    {
        public string Titel;
        public Datetime day;
        public Datetime time;
        public string CoursRoom;
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}

using System;
using System.Collections.Generic;

namespace uml_aufgabe
{
    public class CoursesList<T>
    {

        class Person
        {
            public string FirstName;
            public string LastName;
            public int Age;
        }

        class Member : Person
        {
            public int MatriculationNumber;
            public List<CoursesList<T>> course = new List<CoursesList<T>>();
        }

        class Professor : Person 
        {
            public string Room;
            public DateTime OfficeDays;
            public DateTime OfficeHours;
            public List<CoursesList<T>> course = new List<CoursesList<T>>();

            public void OutputCourse(){
                foreach (T course in Course)
                {
                    Console.WriteLine(Course.Title);
                }
            }
            public Participiant<T> OutputTotalParticipant()
            {
                List<Participiant> TotalParticipiant = new List<Participiant>();
                foreach (T course in Course)
                {
                    foreach(Participiant participiant in Member.Participiant)
                    {
                        if(!TotalParticipiant.Contains(participiant))
                        {
                            TotalParticipant.Add(participiant);
                        }
                    }
                }
                return TotalParticipant;
            }


        }

        class Course 
        {

            public string Titel;
            public DateTime Day;
            public DateTime Time;
            public string CourseRoom;

            public Professor Professor;
            List<Participiant> TotalParticipiant;
            public void OutputInformation(){
                Console.WriteLine("Kurs: " + Titel + " Tag: " + Day + " Uhrzeit:  " + Time + " Raum: " + CourseRoom);
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
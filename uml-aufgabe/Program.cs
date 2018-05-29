using System;
using System.Collections.Generic;

namespace uml_aufgabe
{
    class Person
    {
        public string FirstName;
        public string LastName;
        public int Age;
    }

    class Participant : Person
    {
        public int MatriculationNumber;
        public List<Course> Course;
    }

    class Professor : Person 
    {
        public string Room;
        public DateTime OfficeDays;
        public DateTime OfficeHours;

        public List<Course> Course;

        public void OutputCourse()
        {
            foreach (Course course in Course)
                Console.WriteLine(course.Titel);
        }

        public List<Participant> OutputTotalParticipant()
        {
            List<Participant> TotalParticipant = new List<Participant>();
            
            foreach (Course course in Course)
                foreach(Participant participant in course.TotalParticipant)
                    if(!TotalParticipant.Contains(participant))
                        TotalParticipant.Add(participant);

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
        public List<Participant> TotalParticipant;
        public void OutputInformation(){
            Console.WriteLine("Kurs: " + Titel + " Tag: " + Day + " Uhrzeit:  " + Time + " Raum: " + CourseRoom);
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
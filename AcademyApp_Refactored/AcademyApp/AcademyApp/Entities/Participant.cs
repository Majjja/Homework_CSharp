using System;
using System.Collections.Generic;
using System.Text;
using AcademyApp.Enums;
using SubjectServices;

namespace AcademyApp.Entities
{
    public class Participant
    {
        internal object participants;

        public Participant()
        {
            SubjectTrainers = new Dictionary<Participant, Subject>();
            Subjects = new List<Subject>();
            Participants = new List<Participant>();
        }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public DateTime DateOfBirth { get; set; }

        public List<Subject> Subjects { get; set; }

        public List<Participant> Participants { get; set; }

        public Dictionary<Participant, Subject> SubjectTrainers { get; set; }

        public AcademyRole Role { get; set; }

        private int Age { get; set; }

        private int HowOld(DateTime today)
        {
            if (today.Month < DateOfBirth.Month || today.Month == DateOfBirth.Month && today.Day < DateOfBirth.Day)
                Age = today.Year - DateOfBirth.Year - 1;
            else
                Age = today.Year - DateOfBirth.Year;
            return Age;
        }

        public void Greetings()
        {
            Console.WriteLine($"Hello I'm {FirstName} {LastName} and I'm {HowOld(DateTime.Today)} years old!");
        }

        

        public void PrintFullName()
        {
            Console.WriteLine($"{FirstName} {LastName}");
        }

    }
}

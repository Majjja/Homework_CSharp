using System;
using System.Collections.Generic;
using System.Text;
using AcademyApp.Enums;
using AcademyApp.Entities;

namespace AcademyApp.Helpers
{
    public class ParticipantHelper
    {
        public static void FindParticipantByRole(List<Participant> participants, AcademyRole role)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("----------------------------");
            Console.WriteLine($"{role}:");
            Console.WriteLine("----------------------------");

            foreach (var participant in participants)
            {
                if (participant.Role == role)
                    participant.PrintFullName();
            }

            Console.ResetColor();
        }

        public static void PrintAllParticipants(List<Participant> participants)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("----------------------------");
            Console.WriteLine("Greetings from all Participants:");
            Console.WriteLine("----------------------------");

            foreach (var participant in participants)
            {
                participant.Greetings();
            }

            Console.ResetColor();
        }

        public static void PrintSubjects(List<Subject> subjects)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("----------------------------");
            Console.WriteLine("All Subjects:");
            Console.WriteLine("----------------------------");

            foreach (var subject in subjects)
            {
                Console.WriteLine($"Title: {subject.Title}, Semester: {subject.Semester}");
            }

            Console.ResetColor();
        }

        public static void PrintTrainersBySubjects(Dictionary<Participant, Subject> subjectTrainers)
        {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("----------------------------");
                Console.WriteLine("Subjects by Trainers:");
                Console.WriteLine("----------------------------");

            foreach (var participant in subjectTrainers)
            {
                Console.WriteLine($"{participant.Key.FirstName} - {participant.Value.Title}");
            }
        }
    }
}

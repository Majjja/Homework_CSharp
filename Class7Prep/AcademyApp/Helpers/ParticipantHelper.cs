using System;
using AcademyApp.Entities;
using AcademyApp.Enums;
using SubjectServices;

namespace AcademyApp.Helpers
{
    public class ParticipantHelper
    {
        public static void FindParticipantByRole(Participant[] participants, AcademyRole role)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            foreach (var participant in participants)
            {
                if (participant.Role == role)
                    participant.PrintFullName();
            }
        }

        //Added method
        public static void PrintTrainersAndAssistantsFrom1stSemester(Participant[] participants)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Trainers, Co-Trainers and Assistants from 1st Semester:");

            foreach (var participant in participants)
            {
                participant.PrintFullName();
                Console.WriteLine($"***{participant.Role}***");
                foreach (var subject in participant.Subjects)
                {
                    Console.WriteLine($" - {subject.Title}");
                }
            Console.WriteLine("---------------------------------");
            }
        }
    }
}

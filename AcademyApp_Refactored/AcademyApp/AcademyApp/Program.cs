using System;
using AcademyApp.Entities;
using AcademyApp.Enums;
using AcademyApp.Helpers;
using System.Collections.Generic;
using SubjectServices;

namespace AcademyApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var participants = new Participant();

            //Filling the list with participants
            participants.Participants.Add(
                new Participant()
                {
                    FirstName = "Goce",
                    LastName = "Kabov",
                    DateOfBirth = new DateTime(1992, 5, 15),
                    Role = AcademyRole.Assistant
                });

            participants.Participants.Add(new Participant()
            {
                FirstName = "Vukashin",
                LastName = "Obradovikj",
                DateOfBirth = new DateTime(1989, 3, 15),
                Role = AcademyRole.Assistant
            });

            participants.Participants.Add(new Participant()
            {
                FirstName = "Maja",
                LastName = "Jovanovska",
                DateOfBirth = new DateTime(1987, 5, 25),
                Role = AcademyRole.Student
            });

            participants.Participants.Add(new Participant()
            {
                FirstName = "Ljupco",
                LastName = "Kalkov",
                DateOfBirth = new DateTime(1987, 4, 1),
                Role = AcademyRole.Student
            });

            participants.Participants.Add(new Participant()
            {
                FirstName = "Biljana",
                LastName = "Davidovska",
                DateOfBirth = new DateTime(1984, 5, 15),
                Role = AcademyRole.Student
            });

            var miodrag = new Participant()
            {
                FirstName = "Miodrag",
                LastName = "Cekic",
                DateOfBirth = new DateTime(1989, 5, 15),
                Role = AcademyRole.Trainer,
            };

            var jane = new Participant()
            {
                FirstName = "Jane",
                LastName = "Dimeski",
                DateOfBirth = new DateTime(1989, 2, 15),
                Role = AcademyRole.Trainer
            };

            var trajan = new Participant()
            {
                FirstName = "Trajan",
                LastName = "Stevkovski",
                DateOfBirth = new DateTime(1989, 6, 15),
                Role = AcademyRole.Trainer
            };

            var ivo = new Participant()
            {
                FirstName = "Ivo",
                LastName = "Kostovski",
                DateOfBirth = new DateTime(1989, 5, 15),
                Role = AcademyRole.Trainer
            };

            var aleksandar = new Participant()
            {
                FirstName = "Aleksandar",
                LastName = "Kocevski",
                DateOfBirth = new DateTime(1989, 5, 15),
                Role = AcademyRole.Assistant
            };


            participants.Participants.AddRange(new List<Participant>() { ivo, trajan, aleksandar, jane });

            //Filling the list with Subjects
            var cSharpBasic = (new Subject()
            {
                Title = "C# Basic",
                Semester = 2,
                Tools = new Tooling() { MainIDE = "VS 2019", AlternativeIDE = "VS Code" }
            });

            var cSharpAdvanced = (new Subject()
            {
                Title = "C# Advanced", 
                Semester = 2,
                Tools = new Tooling() { MainIDE = "VS 2019", AlternativeIDE = "VS Code" }
            });

            var jsBasic = (new Subject()
            {
                Title = "JS Basic",
                Semester = 1,
                Tools = new Tooling() { MainIDE = "VS Code", AlternativeIDE = "VS 2019" }
            });

            var jsAdvanced = (new Subject()
            {
                Title = "JS Advanced",
                Semester = 1,
                Tools = new Tooling() { MainIDE = "VS Code", AlternativeIDE = "VS 2019" }
            });

            var html = (new Subject()
            {
                Title = "HTML",
                Semester = 1,
                Tools = new Tooling() { MainIDE = "SublimeText3", AlternativeIDE = "SublimeText" }
            });

            var css = (new Subject()
            {
                Title = "CSS",
                Semester = 1,
                Tools = new Tooling() { MainIDE = "SublimeText3", AlternativeIDE = "SublimeText" }
            });

            participants.Subjects.AddRange(new List<Subject>() { html, css, jsBasic, jsAdvanced, cSharpBasic, cSharpAdvanced });

            participants.SubjectTrainers.Add(jane, html);
            participants.SubjectTrainers.Add(trajan, jsBasic);
            participants.SubjectTrainers.Add(ivo, jsAdvanced);
            participants.SubjectTrainers.Add(miodrag, cSharpBasic);

            ParticipantHelper.PrintAllParticipants(participants.Participants);
            
            ParticipantHelper.FindParticipantByRole(participants.Participants, AcademyRole.Student);
            
            ParticipantHelper.PrintSubjects(participants.Subjects);
             
            ParticipantHelper.PrintTrainersBySubjects(participants.SubjectTrainers);


            Console.WriteLine(DateTime.Today.Month);
            Console.WriteLine(DateTime.Today.Day);
            Console.WriteLine(DateTime.Today);

            Console.ReadLine();
        }
    }
}

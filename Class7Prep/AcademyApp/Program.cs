using System;
using AcademyApp.Entities;
using AcademyApp.Enums;
using AcademyApp.Helpers;
using SubjectServices;

namespace AcademyApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Participant participant1 = new Participant();
            participant1.FirstName = "Miodrag";
            participant1.LastName = "Cekikj";
            participant1.DateOfBirth = new DateTime(1989, 5, 15);
            participant1.Role = AcademyRole.Trainer;
            participant1.Greetings();

            var participant2 = new Participant();
            participant2.FirstName = "Goce";
            participant2.LastName = "Kabov";
            participant2.DateOfBirth = new DateTime(1992, 5, 15);
            participant2.Role = AcademyRole.Assistant;
            participant2.Greetings();

            var participant3 = new Participant("Bob", "Marley");
            participant3.Role = AcademyRole.Assistant;
            Console.ForegroundColor = ConsoleColor.Yellow;
            participant3.PrintFullName();

            var participant4 = new Participant()
            {
                FirstName = "Tupac",
                LastName = "Shakur",
                Subjects = new Subject[2] 
            };

            //Added Subjects with Tools
            #region MyRegion
            var cSharBasic = new Subject();
            cSharBasic.Title = "C# Basic";
            cSharBasic.Semester = 2;
            cSharBasic.Tools = new Tooling()
            {
                MainIDE = "VS 2019",
                AlternativeIDE = "VS Code"
            };

            var cSharpAdvanced = new Subject();
            cSharpAdvanced.Title = "C# Advanced";
            cSharpAdvanced.Semester = 2;
            cSharpAdvanced.Tools = new Tooling()
            {
                MainIDE = "VS 2019",
                AlternativeIDE = "VS Code"
            };
            #endregion

            participant4.PrintFullName();

            var participants = new Participant[4];
            participants[0] = participant1;
            participants[1] = participant2;
            participants[2] = participant3;
            participants[3] = participant4;

            ParticipantHelper.FindParticipantByRole(participants, AcademyRole.Trainer);

            //Added more Participant with subjects and tools, from 1st semester
            #region MyRegion
            var introductionTrainer = new Participant()
            {
                FirstName = "Risto",
                LastName = "Panchevski",
                Role = AcademyRole.Trainer,
                Subjects = new Subject[]
                {
                    new Subject()
                    {
                        Title = "Introduction to Web Development",
                        Semester = 1
                    }
                }
            };

            var htmlCssTrainer = new Participant()
            {
                FirstName = "Jane",
                LastName = "Dimeski",
                Role = AcademyRole.Trainer,
                Subjects = new Subject[]
                {
                    new Subject()
                    {
                        Title = "HTML",
                        Semester = 1,
                        Tools = new Tooling()
                        {
                            MainIDE = "Sublime Text 3"
                        }
                    },
                    new Subject()
                    {
                        Title = "CSS",
                        Semester = 1,
                        Tools = new Tooling()
                        {
                            MainIDE = "Sublime Text 3"
                        }
                    }
                }
            };

            var htmlCssAssistant = new Participant()
            {
                FirstName = "Vukashin",
                LastName = "Obradovikj",
                Role = AcademyRole.Assistant,
                Subjects = new Subject[]
                {
                    new Subject()
                    {
                        Title = "HTML",
                        Semester = 1,
                        Tools = new Tooling()
                        {
                            MainIDE = "Sublime Text 3"
                        }
                    },
                    new Subject()
                    {
                        Title = "CSS",
                        Semester = 1,
                        Tools = new Tooling()
                        {
                            MainIDE = "Sublime Text 3"
                        }
                    }
                }
            };

            var jsBasicCotrainer = new Participant()
            {
                FirstName = "Trajan",
                LastName = "Stevkovski",
                Role = AcademyRole.Cotrainer,
                Subjects = new Subject[]
                {
                    new Subject()
                    {
                        Title = "Java Script Basic",
                        Semester = 1,
                        Tools = new Tooling()
                        {
                            MainIDE = "VS Code",
                            AlternativeIDE = "VS 2019"
                        }
                    }
                }
            };

            var jsCotrainer = new Participant()
            {
                FirstName = "Ivo",
                LastName = "Kostovski",
                Role = AcademyRole.Cotrainer,
                Subjects = new Subject[]
                {
                    new Subject()
                    {
                        Title = "Java Script Basic",
                        Semester = 1,
                        Tools = new Tooling()
                        {
                            MainIDE = "VS Code",
                            AlternativeIDE = "VS 2019"
                        }
                    },
                    new Subject()
                    {
                        Title = "Java Script Advanced",
                        Semester = 1,
                        Tools = new Tooling()
                        {
                            MainIDE = "VS Code",
                            AlternativeIDE = "VS 2019"
                        }
                    }
                }
            };

            var jsAdvancedCotrainer = new Participant()
            {
                FirstName = "Aleksandar",
                LastName = "Kocevski",
                Role = AcademyRole.Cotrainer,
                Subjects = new Subject[]
                {
                    new Subject()
                    {
                        Title = "Java Script Advanced",
                        Semester = 1,
                        Tools = new Tooling()
                        {
                            MainIDE = "VS Code",
                            AlternativeIDE = "VS 2019"
                        }
                    }
                }
            };

            var firstSemesterTrainers = new Participant[6];
            firstSemesterTrainers[0] = introductionTrainer;
            firstSemesterTrainers[1] = htmlCssTrainer;
            firstSemesterTrainers[2] = htmlCssAssistant;
            firstSemesterTrainers[3] = jsBasicCotrainer;
            firstSemesterTrainers[4] = jsCotrainer;
            firstSemesterTrainers[5] = jsAdvancedCotrainer;

            ParticipantHelper.PrintTrainersAndAssistantsFrom1stSemester(firstSemesterTrainers);
            #endregion

            Console.ReadLine();
        }

        
    }
}
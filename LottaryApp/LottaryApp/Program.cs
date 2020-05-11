using LottaryApp.Entities;
using System;
using LottoService;
using System.Collections.Generic;
using LottaryApp.Helpers;
using LottaryApp.Enums;

namespace LottaryApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var user1 = new User() { FullName = "Igor Dzambazov" };
            user1.SetAge(55);

            var user2 = new User() { FullName = "Maja Jovanovska" };
            user2.SetAge(32);

            var user3 = new User() { FullName = "Miodrag Cekikj" };
            user3.SetAge(30);

            var user4 = new User() { FullName = "Goce Kabov" };
            user4.SetAge(28);

            var user5 = new User() { FullName = "John Doe" };
            user5.SetAge(15);

            var user6 = new User() { FullName = "Bob Marley" };
            user1.SetAge(65);

            var user7 = new User() { FullName = "Susy" };
            user2.SetAge(35);

            var user8 = new User() { FullName = "Natali Natali" };
            user3.SetAge(40);

            var user9 = new User() { FullName = "Susan Morell" };
            user4.SetAge(17);

            var user10 = new User() { FullName = "Joe Vitale" };
            user5.SetAge(70);

            var ticket1 = new Ticket() { User = user1, UsersCombination = { 2, 15, 7, 22, 35, 33, 5 } };

            var ticket2 = new Ticket() { User = user2, UsersCombination = { 3, 32, 12, 8, 17, 25, 21 } };

            var ticket3 = new Ticket() { User = user3, UsersCombination = { 4, 6, 14, 27, 31, 1, 9 } };

            var ticket4 = new Ticket() { User = user4, UsersCombination = { 19, 13, 26, 29, 30, 16, 11 } };

            var ticket5 = new Ticket() { User = user5, UsersCombination = { 3, 13, 18, 27, 10, 24, 34 } };

            var ticket6 = new Ticket() { User = user6, UsersCombination = { 1, 4, 20, 23, 32, 16, 5 } };

            var ticket7 = new Ticket() { User = user7, UsersCombination = { 33, 32, 2, 18, 7, 23, 22 } };

            var ticket8 = new Ticket() { User = user8, UsersCombination = { 1, 11, 21, 31, 20, 24, 19 } };

            var ticket9 = new Ticket() { User = user9, UsersCombination = { 9, 3, 6, 19, 13, 17, 14 } };

            var ticket10 = new Ticket() { User = user10, UsersCombination = { 18, 7, 12, 10, 8, 6, 4 } };

            var session = new Session();
            session.Tickets.AddRange(new List<Ticket>() { ticket1, ticket2, ticket3, ticket4,
                ticket5, ticket6, ticket7, ticket8, ticket9, ticket10 });

            Console.WriteLine("-------------------------------------------");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("The Winning Combination for the first session is:");
            var firstSession = new FirstSession();
            firstSession.StartSession();
            Console.ResetColor();


            Console.WriteLine("-------------------------------------------");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("The Winning Combination for the second session is:");
            var secondSession = new SecondSession();
            secondSession.StartSession();
            Console.ResetColor();

            Console.WriteLine("-------------------------------------------");


            foreach (var ticket in session.Tickets)
            {
                var matches = LottaryHelpers.CheckTicket(firstSession.WinningCombination, ticket.UsersCombination);

                switch (matches)
                {
                    case (int)Prize.TV:
                        Console.WriteLine($"Congratulation! You won a {Prize.TV}!");
                        break;
                    case (int)Prize.Vacation:
                        Console.WriteLine($"Congratulation! You won a {Prize.Vacation}!");
                        break;
                    case (int)Prize.MotorBike:
                        Console.WriteLine($"Congratulation! You won a {Prize.MotorBike}!");
                        break;
                    case (int)Prize.Car:
                        Console.WriteLine($"Congratulation! You won a {Prize.Car}!");
                        break;
                    case 2:
                        firstSession.TicketsWithoutWin.Add(ticket);
                        break;
                    default:
                        secondSession.TicketsWithTwoMatches.Add(ticket);
                        break;
                }
            }

            Console.WriteLine("-------------------------------------------");
            firstSession.GetRandomTicketWithoutWin();
            secondSession.GetRandomTicketWithTwoMatches();

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using LottaryApp.Enums;

namespace LottaryApp.Entities
{
    public class SecondSession : Session
    {
        public SecondSession()
        {
            TicketsWithTwoMatches = new List<Ticket>();
        }
        public List<Ticket> TicketsWithTwoMatches { get; set; }

        public void GetRandomTicketWithTwoMatches()
        {
            var rand = new Random().Next(TicketsWithTwoMatches.Count);

            if (TicketsWithTwoMatches.Count > 0)
            {
                Console.Write("User with combination: ");
                TicketsWithTwoMatches[rand].UsersCombination.ForEach(num => Console.Write($"{num}, "));
                Console.WriteLine($"Is a winner of {Prize.Vacation}");
            }
            else
                Console.WriteLine("There is no ticket with 2 matches.");
        }
    }
}

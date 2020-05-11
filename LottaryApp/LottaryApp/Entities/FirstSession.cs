using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using LottaryApp.Helpers;
using LottaryApp.Enums;


namespace LottaryApp.Entities
{
    public class FirstSession : Session
    {
        public FirstSession()
        {
            TicketsWithoutWin = new List<Ticket>();
        }
       
        public List<Ticket> TicketsWithoutWin { get; set; }
        

        public void GetRandomTicketWithoutWin()
        {
            var rand = new Random().Next( TicketsWithoutWin.Count);

            if (TicketsWithoutWin.Count > 0)
            {
                Console.Write("User with combination: ");
                TicketsWithoutWin[rand].UsersCombination.ForEach(num => Console.Write($"{num}, "));
                Console.WriteLine($"Is a winner of {Prize.TV}");
            }
            else
                Console.WriteLine("There is no ticket without win");
        }
    }
}

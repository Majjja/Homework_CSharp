using LottaryApp.Helpers;
using System;
using System.Collections.Generic;
using System.Text;
using LottoService;

namespace LottaryApp.Entities
{
    public class Session
    {
        public Session()
        {
            Count++;
            SessionId = Count;
            WinningCombination = new List<int>();
            Tickets = new List<Ticket>();
        }

        private static int Count = 0;
        public int SessionId { get; set; }
        public List<int> WinningCombination { get; set; }
        public List<Ticket> Tickets { get; set; }


        public void StartSession()
        {
            WinningCombination = LottoNumberGenerator.GenerateNumbers();
        }

    }
}

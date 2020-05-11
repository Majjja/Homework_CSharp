using LottaryApp.Enums;
using System.Collections.Generic;

namespace LottaryApp.Entities
{
    public class Ticket
    {
        public Ticket()
        {
            UsersCombination = new List<int>();
        }

        public List<int> UsersCombination { get; set; }
        public User User { get; set; }
        public Prize Prize { get; set; }
    }
}

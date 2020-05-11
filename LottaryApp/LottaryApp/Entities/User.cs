using System;
using System.Collections.Generic;
using System.Text;

namespace LottaryApp.Entities
{
    public class User
    {
        public string FullName { get; set; }
        private int Age { get; set; }

        private void BuyTicket()
        {
            Console.WriteLine($"{FullName}, you got new ticket");
        }

        public void SetAge(int age)
        {
            if (age < 18)
                Console.WriteLine($"Sorry {FullName}, Lottary is not allowed for users under age of 18");
            else
            {
                Age = age;
                BuyTicket();
            }
        }
    }
}

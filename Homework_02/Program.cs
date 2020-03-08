using System;

namespace Homework_02
{
    class Program
    {
        static void Main(string[] args)
        {
            //Exercise_01
            #region
            string hello = "Hello";
            string world = "World";
            string sayHello = ($"{hello} {world}!");
            Console.WriteLine(sayHello);

            string someValue = "9";
            string someOtherValue = "3";
            string concatTheValues = String.Concat(someValue, someOtherValue);
            Console.WriteLine(concatTheValues);
            #endregion

            //Exercise_02
            #region
            Console.WriteLine("Say Something:");
            string input = Console.ReadLine();
            int num = 1;
            var theInput = $"{num}. {input}";
            Console.WriteLine(theInput);
            #endregion

            //Exercise_03
            #region
            int creditsOnMobBill = 102;
            int smsCredits = 5;
            int result = creditsOnMobBill / smsCredits;
            Console.WriteLine($"You can send {result} messages.");
            #endregion

            //Exercise_04_Bonus
            #region
            Console.WriteLine("Enter some Number:");
            var input2 = Console.ReadLine();
            int number;
            bool convertedNumber = int.TryParse(input2, out number);

            if (convertedNumber)
            {
                var theNumber = number % 2 == 0 ? $"{convertedNumber} - The Number {number} is Even number." 
                    : $"{convertedNumber} - The Number {number} is Odd number.";
                Console.WriteLine(theNumber);
            }
            else
            {
                Console.WriteLine($"{convertedNumber} - You didn't enter any number and the value is {number}.");
            }
            #endregion

            Console.ReadLine();
        }
    }
}

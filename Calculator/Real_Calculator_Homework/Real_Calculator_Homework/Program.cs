using System;

namespace Real_Calculator_Homework
{
    class Program
    {
        static void Main(string[] args)
        {

            int count = 0;
            while (true)
            {
                Console.WriteLine("Enter the operation:");
                var userOperator = Console.ReadLine();

                if (userOperator == "+" || userOperator == "-" || userOperator == "*" || userOperator == "/")
                {
                    count++;
                    Console.WriteLine("Enter the first number:");
                    double number1;
                    bool parsed1 = double.TryParse(Console.ReadLine(), out number1);

                    Console.WriteLine("Enter the second number:");
                    double number2;
                    bool parsed2 = double.TryParse(Console.ReadLine(), out number2);

                    if (parsed1 && parsed2)
                    {
                        switch (userOperator)
                        {
                            case "+":
                                double result1 = number1 + number2;
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine($"{number1} {userOperator} {number2} = {result1}");
                                Console.ResetColor();
                                break;
                            case "-":
                                double result2 = number1 - number2;
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine($"{number1} {userOperator} {number2} = {result2}");
                                Console.ResetColor();
                                break;
                            case "*":
                                double result3 = number1 * number2;
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine($"{number1} {userOperator} {number2} = {result3}");
                                Console.ResetColor();
                                break;
                            case "/":
                                double result4 = number1 / number2;
                                if (number2 == 0)
                                {
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.WriteLine("Division with zero is not posible, please try again.");
                                    Console.ResetColor();
                                }
                                else
                                {
                                    Console.ForegroundColor = ConsoleColor.Green;
                                    Console.WriteLine($"{number1} {userOperator} {number2} = {result4.ToString("0.00")}");
                                    Console.ResetColor();
                                }
                                break;
                            default:
                                Console.WriteLine("Error occured.");
                                break;
                        }
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Invalid input numbers.");
                        Console.ResetColor();
                    }
                }
                else if (userOperator.ToUpper() == "S")
                {
                    if (count == 0)
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("You have not used the calculator. Thank you for the interest, try the calculation another time.");
                        Console.ResetColor();
                        break;
                    }
                    else if (count != 0)
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("Thnak you for using the calculator.");
                        Console.ResetColor();
                        break;
                    }
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Invalid operation selected.");
                    Console.ResetColor();
                }
            }
            Console.ReadLine();
        }
    }
}

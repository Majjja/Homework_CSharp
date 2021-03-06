﻿using System;

namespace Homework_04_Refactored_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = 0;
            while (true)
            {
                Msg("Enter the operation:");
                var userOperator = Console.ReadLine();
                if (userOperator == "+" || userOperator == "-" || userOperator == "*" || userOperator == "/")
                {
                    count++;
                    Msg("Enter the first number:");
                    double number1;
                    bool parsed1 = double.TryParse(Console.ReadLine(), out number1);

                    Msg("Enter the second number:");
                    double number2;
                    bool parsed2 = double.TryParse(Console.ReadLine(), out number2);

                    if (parsed1 && parsed2)
                    {
                        switch (userOperator)
                        {
                            case "+":
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine($"{number1} + {number2} = {Sum(number1, number2)}");
                                Console.ResetColor();
                                break;
                            case "-":
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine($"{number1} - {number2} = {Subtract(number1, number2)}");
                                Console.ResetColor();                              
                                break;
                            case "*":
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine($"{number1} * {number2} = {Multiply(number1, number2)}");
                                Console.ResetColor();
                                break;
                            case "/":
                                if (number2 == 0)
                                {
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.WriteLine("Division with zero is not posible, please try again.");
                                    Console.ResetColor();
                                }
                                else
                                {
                                    Console.ForegroundColor = ConsoleColor.Green;
                                    Console.WriteLine($"{number1} / {number2} = {Division(number1, number2).ToString("0.00")}");
                                    Console.ResetColor();
                                }                              
                                break;
                            default:
                                Msg("Error occured.");
                                break;
                        }
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Msg("Invalid input numbers.");
                        Console.ResetColor();
                    }
                }
                else if (userOperator.ToUpper() == "S")
                {
                    if (count == 0)
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Msg("You have not used the calculator. Thank you for the interest, try the calculation another time.");
                        Console.ResetColor();
                        break;
                    }
                    else if (count != 0)
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Msg("Thnak you for using the calculator.");
                        Console.ResetColor();
                        break;
                    }
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Msg("Invalid operation selected.");
                    Console.ResetColor();
                }
            }
            Console.ReadLine();
        }
        public static double Sum(double first, double second)
        {    
            return first + second;
        }

        public static double Subtract(double first, double second)
        {
            return first - second;
        }

        public static double Multiply(double first, double second)
        {
            return first * second;
        }

        public static double Division(double first, double second)
        {
            return first / second;
        }

        public static void Msg(string msg)
        {
            Console.WriteLine(msg);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;
using Calculator.Helpers;

namespace Calculator.Models
{
    public static class Calc
    {
        public static int Max(List<int> numbers)
        {
            return CalcHelpers.FindMax(numbers);
        }

        public static int Min(List<int> numbers)
        {
            return CalcHelpers.FindMin(numbers);
        }

        public static decimal Avg(List<int> numbers)
        {
            return CalcHelpers.FindAverage(numbers);
        }

        public static int Sum(List<int> numbers)
        {
            return CalcHelpers.FindSum(numbers);
        }

        public static int Duplicate(List<int> numbers)
        {
            return CalcHelpers.FindDuplicate(numbers);
        }

        public static bool Contains(List<int> numbers, int number)
        {
            return CalcHelpers.Conatains(numbers, number);
        }

        public static int Abs(int number)
        {
            return CalcHelpers.FindAbsolute(number);
        }

        public static decimal FahToCel(decimal number)
        {
            return CalcHelpers.FahToCel(number);
        }

        public static decimal CelToFah(decimal number)
        {
            return CalcHelpers.CellToFah(number);
        }
    }
}

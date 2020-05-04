using System;
using System.Collections.Generic;
using System.Text;

namespace Calculator.Helpers
{
    internal static class CalcHelpers
    {
        internal static int FindMax(List<int> numbers)
        {
            int max = 0;
            foreach (var number in numbers)
            {
                if (number > max)
                    max = number;
            }
            return max;
        }

        internal static int FindMin(List<int> numbers)
        {
            int min;
            min = numbers[0];
            foreach (var number in numbers)
            {
                if (number < min)
                    min = number;
            }
            return min;
        }

        internal static decimal FindAverage(List<int> numbers)
        {
            int sum = 0;
            numbers.ForEach(number => sum += number);
            return Convert.ToDecimal(sum) / Convert.ToDecimal(numbers.Count);
        }

        internal static int FindSum(List<int> numbers)
        {
            int sum = 0;
            foreach (var item in numbers)
            {
                sum += item;
            }
            return sum;
        }

        internal static int FindDuplicate(List<int> numbers)
        {
            int count = 0;
            for (int i = 0; i < numbers.Count; i++)
            {
                for (int j = i + 1; j < numbers.Count; j++)
                {
                    if (numbers[i] == numbers[j])
                    {
                        count += 1;
                        break;
                    }
                }
            }
            return count;
        }

        internal static bool Conatains(List<int> numbers, int number)
        {
            foreach (var item in numbers)
            {
                if (number == item)
                    return true;
            }
            return false;
        }

        internal static int FindAbsolute(int number)
        {
            if (number < 0)
                return number / -1;
            return number;
        }

        internal static decimal FahToCel(decimal number)
        {
            return (number - 32) * 5 / 9;
        }

        internal static decimal CellToFah(decimal number)
        {
            return (number / 5) * 9 + 32;
        }


    }
}

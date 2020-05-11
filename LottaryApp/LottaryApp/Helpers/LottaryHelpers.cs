using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace LottaryApp.Helpers
{
    public class LottaryHelpers
    {
        public static int CheckTicket(List<int> winningCombination, List<int> usersCombination)
        {
            int count = 0;
            foreach (var number in winningCombination)
            {
                foreach (var num in usersCombination)
                {
                    if (number == num)
                        count++;
                }
            }
            return count;
        }
    }
}

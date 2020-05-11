using System;
using System.Collections.Generic;
using System.Text;

namespace LottoService
{
    public class LottoNumberGenerator
    {
        public static List<int> GenerateNumbers()
        {
            var winningCombination = new List<int>();
            var rand = new Random();
            for (int i = 0; i < 7; i++)
            {
                while (winningCombination.Count < 7)
                {
                    int randNum = rand.Next(1, 36);

                    if (!winningCombination.Contains(randNum))
                        winningCombination.Add(randNum);
                }
            }
            //Console.WriteLine("");
            winningCombination.ForEach(num => Console.Write(num == winningCombination[winningCombination.Count - 1] ? $"{num}" : $"{num}, "));
            Console.WriteLine("");

            return winningCombination;
        }
    }
}

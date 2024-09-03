using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseProblems.Solutions.MediumSolution
{
    public class Solution2260
    {
        public int MinimumCardPickup(int[] cards)
        {
            var dictionaryNumbers = new Dictionary<int, int>();
            var minValue = int.MaxValue;

            for (int i = 0; i < cards.Length; i++)
            {
                if (dictionaryNumbers.ContainsKey(cards[i]))
                    minValue = Math.Min(minValue, i + 1 - dictionaryNumbers[cards[i]]);
                dictionaryNumbers[cards[i]] = i;
            }

            return minValue == int.MaxValue ? -1 : minValue;
        }
    }
}

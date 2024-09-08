using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseProblems.Solutions.MediumSolution
{
    public class Solution2028
    {
        public int[] MissingRolls(int[] rolls, int mean, int n)
        {
            var m = rolls.Length;
            var count = n + m;

            var sum = mean * count;
            var sumNumberInRolls = rolls.Sum();
            var sumUnknownNumbers = sum - sumNumberInRolls;

            var result = new List<int>();

            while (sumUnknownNumbers > 0)
            {
                var number = sumUnknownNumbers / n;

                if (number > 6 || number < 1)
                    return Array.Empty<int>();

                n--;
                sumUnknownNumbers -= number;
                result.Add(number);
            }


            return result.ToArray();
        }
    }
}

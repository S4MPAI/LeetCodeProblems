using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseProblems.Solutions.MediumSolution
{
    public class Solution2300
    {
        public int[] SuccessfulPairs(int[] spells, int[] potions, long success)
        {
            var result = new int[spells.Length];
            var index = 0;
            Array.Sort(potions);

            foreach (var spell in spells) 
            {
                var left = 0;
                var right = potions.Length - 1;
                long pair = 0;

                while (left != right)
                {
                    var current = left + (right - left) / 2;
                    pair = (long)potions[current] * spell;

                    if (pair >= success)
                    {
                        right = current;
                    }
                    else
                    {
                        left = current + 1;
                    }

                }

                pair = (long)potions[left] * spell;
                if (pair < success && left == right)
                {
                    index++;
                    continue;
                }

                result[index++] = potions.Length - left;
            }

            return result;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseProblems.Solutions.EasySolution
{
    public class Solution1207
    {
        public bool UniqueOccurrences(int[] arr)
        {
            var numbersCount = new Dictionary<int, int>();

            foreach (var number in arr)
            {
                if (!numbersCount.ContainsKey(number))
                    numbersCount.Add(number, 0);

                numbersCount[number]++;
            }

            var uniqueNumbersCount = new HashSet<int>(numbersCount.Values);
            return numbersCount.Count == uniqueNumbersCount.Count;
        }
    }
}

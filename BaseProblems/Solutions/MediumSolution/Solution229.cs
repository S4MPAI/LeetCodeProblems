using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseProblems.Solutions.MediumSolution
{
    public class Solution229
    {
        public IList<int> MajorityElement(int[] nums)
        {
            var result = new List<int>();
            var numberCounts = new Dictionary<int, int>();
            var minCounts = nums.Length / 3; 

            foreach (int i in nums)
            {
                if (!numberCounts.ContainsKey(i))
                {
                    numberCounts[i] = 0;
                }
                numberCounts[i]++;
            }

            foreach (var numberData in numberCounts) 
            {
                if (numberData.Value > minCounts)
                    result.Add(numberData.Key);
            }

            return result;
        }
    }
}

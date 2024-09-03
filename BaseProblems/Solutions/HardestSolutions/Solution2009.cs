using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseProblems.Solutions.HardestSolutions
{
    public class Solution2009
    {
        public int MinOperations(int[] nums)
        {
            int n = nums.Length;
            int ans = n;

            HashSet<int> unique = new HashSet<int>();
            foreach (int num in nums)
            {
                unique.Add(num);
            }

            int[] newNums = new int[unique.Count];
            int index = 0;

            foreach (int num in unique)
            {
                newNums[index++] = num;
            }

            Array.Sort(newNums);

            int j = 0;
            for (int i = 0; i < newNums.Length; i++)
            {
                while (j < newNums.Length && newNums[j] < newNums[i] + n)
                {
                    j++;
                }

                int count = j - i;
                ans = Math.Min(ans, n - count);
            }

            return ans;
        }
    }
}

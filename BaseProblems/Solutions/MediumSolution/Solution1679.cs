using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseProblems.Solutions.MediumSolution
{
    public class Solution1679
    {
        public int MaxOperations(int[] nums, int k)
        {
            var ans = 0;
            nums = nums.OrderBy(x => x).ToArray();
            var left = 0;
            var right = nums.Length - 1;

            while (left < right) 
            {
                var sum = nums[left] + nums[right];
                if (sum == k)
                {
                    ans++;
                    left++;
                    right--;
                }
                else if (sum > k)
                    right--;
                else
                    left++;
            }

            return ans;
        }

        public int MaxOperations1(int[] nums, int k)
        {
            var ans = 0;
            var dictionary = new Dictionary<int, int>();

            foreach (var x in nums)
            {
                var remaining = k - x;

                if (dictionary.TryGetValue(remaining, out var numberCount) && numberCount > 0)
                {
                    ans++;
                    dictionary[remaining] = numberCount - 1;
                }
                else
                {
                    if (!dictionary.ContainsKey(x))
                        dictionary[x] = 0;
                    dictionary[x]++;
                }
            }

            return ans;
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseProblems.Solutions.EasySolution
{
    public class Solution2215
    {
        public IList<IList<int>> FindDifference(int[] nums1, int[] nums2)
        {
            var hashSetNums1 = new HashSet<int>(nums1);
            var hashSetNums2 = new HashSet<int>(nums2);
            var ans = new List<IList<int>>
            {
                new List<int>(),
                null
            };

            foreach (var num in hashSetNums1)
            {
                if (hashSetNums2.Contains(num))
                    hashSetNums2.Remove(num);
                else
                    ans[0].Add(num);
            }

            ans[1] = new List<int>(hashSetNums2);
            return ans;
        }
    }
}

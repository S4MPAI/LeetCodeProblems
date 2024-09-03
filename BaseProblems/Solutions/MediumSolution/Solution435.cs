using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseProblems.Solutions.MediumSolution
{
    public class Solution435
    {
        public int EraseOverlapIntervals(int[][] intervals)
        {
            Array.Sort(intervals, (a, b) => a[0].CompareTo(b[0]));
            var prevEnd = intervals[0][1];
            var count = 0;

            for (int i = 1; i < intervals.Length; i++)
            {
                if (intervals[i][0] >= prevEnd)
                {
                    prevEnd = intervals[i][1];
                }
                else
                {
                    count++;
                    prevEnd = Math.Min(prevEnd, intervals[i][1]);
                }
            }
            
            return count;
        }
    }
}

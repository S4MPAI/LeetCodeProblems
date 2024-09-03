using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseProblems.Solutions.MediumSolution
{
    public class Solution452
    {
        public int FindMinArrowShots(int[][] points)
        {
            Array.Sort(points, (a, b) => a[0].CompareTo(b[0]));
            var minEnd = points[0][1];
            var arrows = 0;

            for (int i = 1; i < points.Length; i++)
            {
                if (points[i][0] <= minEnd)
                {
                    minEnd = Math.Min(minEnd, points[i][1]);
                }
                else
                {
                    arrows++;
                    minEnd = points[i][1];
                }
            }
            arrows++;

            return arrows;
        }
    }
}

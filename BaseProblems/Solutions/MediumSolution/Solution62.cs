using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseProblems.Solutions.MediumSolution
{
    public class Solution62
    {
        public int UniquePaths(int m, int n)
        {
            var data = new int[2][];
            data[1] = Enumerable.Repeat(1, n).ToArray();
            data[0] = new int[n];
            data[0][0] = 1;

            for (int i = 1; i < m; i++)
            {
                (data[0], data[1]) = (data[1], data[0]);

                for (int j = 1; j < n; j++)
                    data[1][j] = data[0][j] + data[1][j - 1];
            }

            return data[1][n - 1];
        }
    }
}

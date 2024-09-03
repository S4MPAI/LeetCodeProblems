using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseProblems.Solutions.EasySolution
{
    public class Solution997
    {
        public int FindJudge(int n, int[][] trust)
        {
            if (n == 1)
                return 1;

            var trusts = new Dictionary<int, int>();

            foreach (var t in trust)
            {
                if (trusts.ContainsKey(t[1]))
                    trusts[t[1]]++;
                else
                    trusts[t[1]] = 1;

                trusts[t[0]] = -1;
            }

            foreach (var t in trusts)
                if (t.Value == n - 1)
                    return t.Key;

            return -1;
        }
    }
}

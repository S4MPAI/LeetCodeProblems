using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseProblems.Solutions.MediumSolution
{
    public class Solution790
    {
        const long MODULO = 1000000007;
        public int NumTilings(int n)
        {
            if (n == 1)
                return 1;

            var dominoTiling = new long[n + 1];
            dominoTiling[0] = 1;
            dominoTiling[1] = 1;
            dominoTiling[2] = 2;
            for (int i = 3; i <= n; i++)
            {
                dominoTiling[i] = (dominoTiling[i - 1] * 2 + dominoTiling[i - 3]) % MODULO;
            }

            return (int)dominoTiling[n];
        }
    }
}

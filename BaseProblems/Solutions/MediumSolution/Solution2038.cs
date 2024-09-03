using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace BaseProblems.Solutions.MediumSolution
{
    public class Solution2038
    {
        public bool WinnerOfGame(string colors)
        {
            var aRemovesCount = 0;
            var bRemovesCount = 0;

            for (var i = 0; i < colors.Length; i++)
            {
                var currentChar = colors[i];
                var count = 0;

                while (i < colors.Length && colors[i] == currentChar)
                {
                    i++;
                    count++;
                }

                if (currentChar == 'A')
                {
                    aRemovesCount += Math.Max(count - 2, 0);
                }
                else
                {
                    bRemovesCount += Math.Max(count - 2, 0);
                }

                i--;
            }

            return aRemovesCount > bRemovesCount;
        }
    }
}

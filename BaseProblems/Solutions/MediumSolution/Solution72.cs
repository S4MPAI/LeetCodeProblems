using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseProblems.Solutions.MediumSolution
{
    public class Solution72
    {
        public int MinDistance(string word1, string word2)
        {
            var operationCounts = new int[word1.Length + 1][];
            for (int i = 0; i < operationCounts.Length; i++)
            {
                operationCounts[i] = new int[word2.Length + 1];
            }

            for (int i = 1; i <= word1.Length; i++)
            {
                operationCounts[i][0] = i;
            }

            for (int i = 1; i <= word2.Length; i++)
            {
                operationCounts[0][i] = i;
            }

            for (int i = 1; i <= word1.Length; i++)
            {
                for (int j = 1; j <= word2.Length; j++)
                {
                    if (word1[i - 1] == word2[j - 1])
                    {
                        operationCounts[i][j] = operationCounts[i - 1][j - 1];
                    }
                    else
                    {
                        operationCounts[i][j] = Math.Min(operationCounts[i - 1][j - 1], Math.Min(operationCounts[i - 1][j], operationCounts[i][j - 1])) + 1;
                    }
                }
            }

            return operationCounts[^1][^1];
        }
    }
}

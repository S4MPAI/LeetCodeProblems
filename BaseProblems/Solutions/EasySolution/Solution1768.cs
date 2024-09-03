using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseProblems.Solutions.EasySolution
{
    public class Solution1768
    {
        public string MergeAlternately(string word1, string word2)
        {
            var newWord = new StringBuilder();
            var max = Math.Max(word1.Length, word2.Length);

            for (int i = 0; i < max; i++)
            {
                if (i < word1.Length)
                    newWord.Append(word1[i]);

                if (i < word2.Length)
                    newWord.Append(word2[i]);
            }

            return newWord.ToString();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseProblems.Solutions.MediumSolution
{
    public class Solution443
    {
        public int Compress(char[] chars)
        {
            var currentChar = chars[0];
            var count = 1;
            var currentIndex = 0;

            for (var i = 1; i < chars.Length + 1; i++)
            {
                if (i != chars.Length && currentChar == chars[i])
                    count++;
                else
                {
                    chars[currentIndex] = currentChar;
                    currentChar = i != chars.Length ? chars[i] : ' ';
                    var charCount = count.ToString();
                    currentIndex++;
                    if (count != 1)
                        foreach (var number in charCount)
                        {
                            chars[currentIndex] = number;
                            currentIndex++;
                        }

                    count = 1;
                }
            }

            return currentIndex;
        }
    }
}

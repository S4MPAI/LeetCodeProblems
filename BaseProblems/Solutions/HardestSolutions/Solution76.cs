using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseProblems.Solutions.HardestSolutions
{
    public class Solution76
    {
        public string MinWindow(string s, string t)
        {
            var charCount = new Dictionary<char, int>();
            var result = "";
            

            foreach (char c in t)
            {
                if (!charCount.ContainsKey(c))
                    charCount[c] = 0;
                charCount[c]++;
            }

            var left = 0;
            var currentMinLength = s.Length;
            var currentCharCount = new Dictionary<char, int>();
            var charFound = 0;

            for (int i = 0; i < s.Length; i++)
            {
                if (charCount.ContainsKey(s[i]))
                {
                    if (!currentCharCount.ContainsKey(s[i]))
                        currentCharCount[s[i]] = 0;
                    currentCharCount[s[i]]++;

                    if (currentCharCount[s[i]] <= charCount[s[i]])
                        charFound++;

                    while (!charCount.ContainsKey(s[left]) || (currentCharCount[s[left]] > charCount[s[left]] && charFound == t.Length))
                    {
                        if (currentCharCount.ContainsKey(s[left]))
                            currentCharCount[s[left]]--;

                        left++;
                    }

                    if (charFound == t.Length)
                    {
                        var currentStringLength = i - left + 1;
                        if (currentStringLength <= currentMinLength)
                        {
                            result = s.Substring(left, currentStringLength);
                            currentMinLength = currentStringLength;
                        }
                        currentCharCount[s[left]]--;
                        left++;
                        charFound--;
                    }
                }
            }

            return result;
        }
    }
}

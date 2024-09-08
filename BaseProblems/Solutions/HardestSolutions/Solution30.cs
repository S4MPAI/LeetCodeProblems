using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseProblems.Solutions.HardestSolutions
{
    public class Solution30
    {
        public IList<int> FindSubstring(string s, string[] words)
        {
            var result = new List<int>();

            var wordLength = words[0].Length;
            var totalWords = words.Length;
            var substringLength = wordLength * totalWords;

            if (substringLength > s.Length)
                return result;

            var wordCount = new Dictionary<string, int>();

            foreach ( var word in words)
            {
                if (wordCount.ContainsKey(word))
                    wordCount[word]++;
                else
                    wordCount[word] = 1;
            }

            for ( var i = 0; i < wordLength; i++)
            {
                var currentWordCount = new Dictionary<string, int>();
                var wordsFound = 0;
                var left = i;

                for ( var j = i; j <= s.Length - wordLength; j += wordLength)
                {
                    var currentWord = s.Substring(j, wordLength);

                    if (wordCount.ContainsKey(currentWord))
                    {
                        if (currentWordCount.ContainsKey(currentWord))
                            currentWordCount[currentWord]++;
                        else
                            currentWordCount[currentWord] = 1;

                        wordsFound++;

                        while (currentWordCount[currentWord] > wordCount[currentWord])
                        {
                            var leftWord = s.Substring(left, wordLength);
                            wordsFound--;
                            currentWordCount[leftWord]--;
                            left += wordLength;
                        }

                        if (totalWords == wordsFound)
                            result.Add(left);
                    }
                    else
                    {
                        currentWordCount.Clear();
                        wordsFound = 0;
                        left = j + wordLength;
                    }
                }
            }

            return result;
        }
    }
}

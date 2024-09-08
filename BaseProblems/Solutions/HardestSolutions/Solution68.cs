using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseProblems.Solutions.HardestSolutions
{
    public class Solution68
    {
        public IList<string> FullJustify(string[] words, int maxWidth)
        {
            var result = new List<string>();
            var currentLine = new StringBuilder(maxWidth);
            var currentLineWordCount = 0;
            var currentLineWordsLength = 0;
            var startWordInLineIndex = 0;

            for (int i = 0; i < words.Length; i++)
            {
                if (words[i].Length + currentLineWordsLength + currentLineWordCount <= maxWidth)
                {
                    currentLineWordsLength += words[i].Length;
                    currentLineWordCount++;
                }
                else
                {
                    result.Add(CreateLine(words, maxWidth, currentLine, currentLineWordCount, currentLineWordsLength, startWordInLineIndex));

                    startWordInLineIndex = i;
                    currentLineWordCount = 1;
                    currentLineWordsLength = words[i].Length;
                }
            }

            result.Add(CreateLastLine(words, maxWidth, currentLine, currentLineWordCount, currentLineWordsLength, startWordInLineIndex));
            
            return result;
        }

        private static string CreateLine(string[] words, int maxWidth, StringBuilder currentLine, int currentLineWordCount, int currentLineWordsLength, int startWordInLineIndex)
        {
            if (currentLineWordCount == 1)
                currentLine.Append(words[startWordInLineIndex]).Append(' ', maxWidth - currentLineWordsLength).ToString();
            else
            {
                var separatorsCount = currentLineWordCount - 1;
                var separatorLengthSum = maxWidth - currentLineWordsLength;
                var oneSeparatorLength = separatorLengthSum / separatorsCount;
                var uniqSeparatorCount = separatorLengthSum % separatorsCount;

                for (int j = 0; j < separatorsCount; j++)
                {
                    currentLine.Append(words[startWordInLineIndex + j]);
                    currentLine.Append(' ', oneSeparatorLength + (uniqSeparatorCount > 0 ? 1 : 0));

                    if (uniqSeparatorCount > 0)
                        uniqSeparatorCount--;
                }

                currentLine.Append(words[startWordInLineIndex + separatorsCount]);
            }
            var result = currentLine.ToString();
            currentLine.Clear();
            return result;
        }

        private static string CreateLastLine(string[] words, int maxWidth, StringBuilder currentLine, int currentLineWordCount, int currentLineWordsLength, int startWordInLineIndex)
        {
            if (currentLineWordCount == 1)
                currentLine.Append(words[startWordInLineIndex]).Append(' ', maxWidth - currentLineWordsLength).ToString();
            else
            {
                var separatorsCount = currentLineWordCount - 1;
                for (int j = 0; j < separatorsCount; j++)
                {
                    currentLine.Append(words[startWordInLineIndex + j]);
                    currentLine.Append(' ');
                }

                currentLine.Append(words[startWordInLineIndex + separatorsCount]);
                currentLine.Append(' ', maxWidth - currentLineWordsLength - separatorsCount);
            }
            var result = currentLine.ToString();
            currentLine.Clear();
            return result;
        }
    }
}

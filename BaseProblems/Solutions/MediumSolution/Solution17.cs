using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseProblems.Solutions.MediumSolution
{
    public class Solution17
    {
        private static readonly Dictionary<int, List<char>> telNumbersDictionary = GetTelNumberDictionary();

        private static Dictionary<int, List<char>> GetTelNumberDictionary()
        {
            var dictionary = new Dictionary<int, List<char>>();
            var currentChar = 'a';
            for (int i = 2; i < 10; i++)
            {
                dictionary[i] = new List<char>(4);

                for (int j = 0; j < 3; j++)
                {
                    dictionary[i].Add(currentChar);
                    currentChar++;
                }

                if (i == 7 || i == 9)
                {
                    dictionary[i].Add(currentChar);
                    currentChar++;
                }
            }

            return dictionary;
        }

        public IList<string> LetterCombinations(string digits)
        {
            var result = new List<string>();
            if (digits == "")
            {
                return result;
            }
            var combination = new char[digits.Length];
            AddCombinations(result, combination, 0, digits);
            return result;
        }

        private void AddCombinations(List<string> result, char[] currentCombination, int index, string digits)
        {
            if (index >= digits.Length)
            {
                result.Add(new string(currentCombination));
                return;
            }

            var number = digits[index] - '0';
            foreach (char c in telNumbersDictionary[number])
            {
                currentCombination[index] = c;
                AddCombinations(result, currentCombination, index + 1, digits);
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseProblems.Solutions.EasySolution
{
    public class Solution345
    {
        private char[] vowels = new[] { 'a', 'e', 'i', 'o', 'u' };

        public string ReverseVowels(string s)
        {
            var word = s.ToCharArray();
            var left = 0;
            var right = s.Length - 1;

            while (left < right)
            {
                while (left < right && !IsVowel(word[left]))
                    left++;

                while (left < right && !IsVowel(word[right]))
                    right--;

                if (left < right)
                {
                    (word[left], word[right]) = (word[right], word[left]);
                    left++;
                    right--;
                }
            }

            return new string(word);
        }

        public bool IsVowel(char a) => vowels.Contains(char.ToLower(a));

    }
}

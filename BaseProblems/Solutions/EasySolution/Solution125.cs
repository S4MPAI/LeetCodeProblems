using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseProblems.Solutions.EasySolution
{
    public class Solution125
    {
        public bool IsPalindrome(string s)
        {
            var leftLetter = 0;
            var rightLetter = s.Length - 1;

            while (leftLetter < rightLetter)
            {
                while (leftLetter < rightLetter && IsNotSymbolCheck(s[leftLetter]))
                    leftLetter++;
                while (leftLetter < rightLetter && IsNotSymbolCheck(s[rightLetter]))
                    rightLetter--;

                if (leftLetter >= rightLetter)
                    break;

                if (char.ToLower(s[leftLetter]) != char.ToLower(s[rightLetter]))
                    return false;
                leftLetter++;
                rightLetter--;
            }

            return true;
        }

        private static bool IsNotSymbolCheck(char symbol)
        {
            return !(char.IsLetter(symbol) || char.IsDigit(symbol));
        }
    }
}

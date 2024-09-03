using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseProblems.Solutions.MediumSolution
{
    public class Solution2390
    {
        public string RemoveStars(string s)
        {
            var characters = new Stack<char>();

            foreach (var c in s)
            {
                if (c == '*')
                    characters.Pop();
                else
                    characters.Push(c);
            }

            return string.Concat(characters.Reverse());
        }
    }
}

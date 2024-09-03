using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseProblems.Solutions.MediumSolution
{
    public class Solution394
    {
        public string DecodeString(string s)
        {
            var builder = new StringBuilder();
            var stack = new Stack<(int, int)>();
            var counts = 0;

            foreach (var c in s)
            {
                if ('[' == c)
                {
                    stack.Push((builder.Length, counts));
                    counts = 0;
                }
                else if (']' == c)
                {
                    (var start, var times) = stack.Pop();
                    var length = builder.Length - start;
                    for (var i = 1; i < times; i++)
                        builder.Append(builder, start, length);
                }
                else if (char.IsDigit(c))
                    counts = 10 * counts + (c - '0');
                else
                    builder.Append(c);
            }
            
            return builder.ToString();
        }
    }
}

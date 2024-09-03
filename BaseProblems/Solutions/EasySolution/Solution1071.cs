using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseProblems.Solutions.EasySolution
{
    public class Solution1071
    {
        public string GcdOfStrings(string str1, string str2)
        {
            if (str1 + str2 != str2 + str1)
                return "";

            return str1.Substring(0, Gcd(str1.Length, str2.Length));
        }

        public int Gcd(int x, int y)
        {
            if (y == 0)
                return x;

            return Gcd(y, x % y);
        }
    }
}

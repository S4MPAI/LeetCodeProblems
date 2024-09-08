using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseProblems.Solutions.MediumSolution
{
    public class Solution12
    {
        private Dictionary<int, char> intsToRomans = new Dictionary<int, char>()
        {
            { 1, 'I' },
            { 5, 'V' },
            { 10, 'X' },
            { 50, 'L' },
            { 100, 'C' },
            { 500, 'D' },
            { 1000, 'M' }
        };

        public string IntToRoman(int num)
        {
            var bitLevel = 1;
            var result = new LinkedList<char>();

            while (num > 0)
            {
                var number = num % 10;
                num /= 10;

                if (number == 4 || number == 9)
                {
                    number += 1;
                    result.AddFirst(intsToRomans[number * bitLevel]);
                    result.AddFirst(intsToRomans[bitLevel]);
                }
                else
                {
                    while (number % 5 > 0)
                    {
                        result.AddFirst(intsToRomans[bitLevel]);
                        number -= 1;
                    }

                    if (number == 5)
                        result.AddFirst(intsToRomans[number * bitLevel]);
                }

                bitLevel *= 10;
            }

            return string.Join("", result);
        }
    }
}

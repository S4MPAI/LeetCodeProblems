using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseProblems.Solutions.MediumSolution
{
    public class Solution6
    {
        public string Convert(string s, int numRows)
        {
            if (numRows == 1) 
                return s;

            var maxStep = 2 * (numRows - 2) + 2;

            var result = new char[s.Length];
            var currentResultIndex = 0;
            var currentStep = 0;

            for (var i = 0; i < numRows; i++)
            {
                currentResultIndex = AddRowChars(result, s, maxStep, currentStep, currentResultIndex, i);

                currentStep += 2;
            }

            return string.Join("", result);
        }

        private static int AddRowChars(char[] result, string s, int maxStep, int step,  int currentResultIndex, int currentRow)
        {
            for (var j = currentRow; j < s.Length; j += step)
            {
                result[currentResultIndex] = s[j];
                currentResultIndex++;
                step = step == maxStep ? step : maxStep - step;
            }

            return currentResultIndex;
        }
    }
}

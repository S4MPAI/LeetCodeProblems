using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseProblems.Solutions.EasySolution
{
    public class Solution118
    {
        public IList<IList<int>> Generate(int numRows)
        {
            var array = new int[numRows][];

            for (int i = 0; i < numRows; i++)
            {
                var row = new int[i + 1];
                array[i] = row;

                row[0] = 1;
                row[^1] = 1;

                for (int j = 1; j < i; j++)
                    row[j] = array[i - 1][j - 1] + array[i - 1][j];
            }

            return array;
        }
    }
}

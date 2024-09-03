using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseProblems.Solutions.MediumSolution
{
    public class Solution2352
    {
        public int EqualPairs(int[][] grid)
        {
            var length = grid.Length;
            var rowData = new Dictionary<string, int>();
            var columnData = new Dictionary<string, int>();
            var builder = new StringBuilder();
            
            for (int i = 0; i < length; i++)
            {
                builder.Clear();
                for (int j = 0; j < length; j++)
                    builder.Append(grid[i][j]).Append(' ');

                var row = builder.ToString();
                rowData[row] = rowData.GetValueOrDefault(row, 0) + 1;
            }

            for (int i = 0; i < length; i++)
            {
                builder.Clear();
                for (int j = 0; j < length; j++)
                    builder.Append(grid[j][i]).Append(' ');

                var column = builder.ToString();
                columnData[column] = columnData.GetValueOrDefault(column, 0) + 1;
            }

            var res = 0;
            foreach (var row in rowData)
                res += row.Value * columnData.GetValueOrDefault(row.Key, 0);

            return res;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseProblems.Solutions.MediumSolution
{
    public class Solution54
    {
        public IList<int> SpiralOrder(int[][] matrix)
        {
            var startI = 0;
            var startJ = 0;
            var endI = matrix.Length - 1;
            var endJ = matrix[0].Length - 1;
            var iteration = 0;
            var count = matrix.Length * matrix[0].Length;
            var result = new List<int>();

            while (result.Count < count)
            {
                switch (iteration)
                {
                    case 0:
                        for (var i = startJ; i <= endJ; i++)
                            result.Add(matrix[startI][i]);
                        startI++;
                        break;
                    case 1:
                        for (var i = startI; i <= endI; i++)
                            result.Add(matrix[i][endJ]);
                        endJ--;
                        break;
                    case 2:
                        for (var i = endJ; i >= startJ; i--)
                            result.Add(matrix[endI][i]);
                        endI--;
                        break;
                    case 3:
                        for (var i = endI; i >= startI; i--)
                            result.Add(matrix[i][startJ]);
                        startJ++;
                        break;
                }

                iteration = (iteration + 1) % 4;
            }

            return result;
        }
    }
}

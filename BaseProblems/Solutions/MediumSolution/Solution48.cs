using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseProblems.Solutions.MediumSolution
{
    public class Solution48
    {
        public void Rotate(int[][] matrix)
        {
            var n = matrix.Length;
            var maxInd = n - 1;

            for (int i = 0; i < n / 2; i++)
            {
                for (var j = i; j < n - 1 - i; j++)
                {
                    var currentPos = (y: j, x: maxInd - i);
                    var startPos = (i, j);
                    var nextNumber = matrix[i][j];
                    var iter = 0;

                    for (var k = 0; k < 4; k++)
                    { 
                        (nextNumber, matrix[currentPos.y][currentPos.x]) = (matrix[currentPos.y][currentPos.x], nextNumber);
                        currentPos = (currentPos.x, maxInd - currentPos.y);
                    }
                }
            }
        }
    }
}

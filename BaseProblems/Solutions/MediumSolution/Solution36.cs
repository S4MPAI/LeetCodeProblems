using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseProblems.Solutions.MediumSolution
{
    public class Solution36
    {
        public bool IsValidSudoku(char[][] board)
        {
            var boardSize = board.Length;
            var rows = new HashSet<int>[boardSize];
            var cols = new HashSet<int>[boardSize];
            var cells = new HashSet<int>[boardSize];
            var cellSize = 3;

            for (int i = 0; i < board.Length; i++)
            {
                rows[i] = new HashSet<int>();
                cols[i] = new HashSet<int>();
                cells[i] = new HashSet<int>();
            }

            for (var i = 0; i < boardSize; i++)
            {
                for (var j = 0; j < boardSize; j++)
                {
                    var value = board[i][j];
                    if (!char.IsDigit(value))
                        continue;
                    var cellNumber = cellSize * (i / cellSize) + (j / cellSize);
                    if (rows[i].Contains(value) || cols[j].Contains(value) || cells[cellNumber].Contains(value))
                        return false;

                    rows[i].Add(value);
                    cols[j].Add(value);
                    cells[cellNumber].Add(value);
                }
            }

            return true;
        }
    }
}

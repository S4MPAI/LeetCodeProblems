using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseProblems.Solutions.MediumSolution
{
    public class Solution1926
    {
        public int NearestExit(char[][] maze, int[] entrance)
        {
            var queue = new Queue<(int row, int column, int steps)>();
            var dxy = new (int y, int x)[] {(1, 0), (0, 1), (-1, 0), (0,-1)};
            var visited = new bool[maze.Length, maze[0].Length];
            queue.Enqueue((entrance[0], entrance[1], 0));
            visited[entrance[0], entrance[1]] = true;

            while (queue.Count > 0)
            {
                var cell = queue.Dequeue();

                if (!(cell.row == entrance[0] && cell.column == entrance[1]) && 
                    (cell.row == 0 || cell.row == maze.Length - 1 || cell.column == 0 || cell.column == maze[0].Length - 1))
                {
                    return cell.steps;
                }

                foreach (var direction in dxy.Select(x =>(row: cell.row + x.y, column: cell.column + x.x, steps: cell.steps + 1)))
                {
                    if (direction.row < 0 || direction.row > maze.Length - 1 || direction.column < 0 || direction.column > maze[0].Length - 1 ||
                        maze[direction.row][direction.column] == '+' || visited[direction.row, direction.column])
                        continue;

                    queue.Enqueue(direction);
                    visited[direction.row, direction.column] = true;
                }
            }

            return -1;
        }
    }
}

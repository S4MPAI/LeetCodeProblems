using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseProblems.Solutions.MediumSolution
{
    public class Solution994
    {
        public int OrangesRotting(int[][] grid)
        {
            var queue = new Queue<Point>();
            var directions = new Size[] { new(0, 1), new(1, 0), new(0, -1), new(-1, 0) };
            var minutes = 0;
            var freshOrangeCount = 0;
            var lengthY = grid.Length;
            var lengthX = grid[0].Length;

            for (int i = 0; i < lengthY; i++)
            {
                for (int j = 0; j < lengthX; j++)
                {
                    if (grid[i][j] == 2)
                    {
                        var point = new Point(j, i);
                        queue.Enqueue(point);
                    }

                    if (grid[i][j] == 1)
                        freshOrangeCount++;
                }
            }

            while (queue.Count > 0 && freshOrangeCount != 0)
            {
                var length = queue.Count;

                for (int i = 0; i < length; i++)
                {
                    var rottenOrange = queue.Dequeue();

                    foreach (var newOrange in directions.Select(dir => rottenOrange + dir).Where(point => IsInMap(point, lengthX, lengthY) && grid[point.Y][point.X] == 1))
                    {
                        queue.Enqueue(newOrange);
                        grid[newOrange.Y][newOrange.X] = 2;
                        freshOrangeCount--;
                    }

                    
                }

                minutes++;
            }

            return freshOrangeCount == 0 ? minutes : -1;
        }

        private static bool IsInMap(Point point, int X, int Y) => point.X >= 0 && point.X < X && point.Y >= 0 && point.Y < Y;
    }
}

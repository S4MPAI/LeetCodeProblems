using BaseProblems.HelperClasses;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseProblems.Solutions.MediumSolution
{
    public class Solution2326
    {
        public int[][] SpiralMatrix(int m, int n, ListNode head)
        {
            var matrix = new int[m][];
            for (int i = 0; i < m; i++)
                matrix[i] =  Enumerable.Repeat(-1, n).ToArray();
            var borders = new SpiralBorders() { Left = 0, Right = n - 1, Top = 0, Bottom = m - 1 };
            var iteration = 0;

            while (head != null)
            {
                switch (iteration)
                {
                    case 0:
                        head = GoRight(matrix, borders, head);
                        break;
                    case 1:
                        head = GoBottom(matrix, borders, head);
                        break;
                    case 2:
                        head = GoLeft(matrix, borders, head);
                        break;
                    case 3:
                        head = GoTop(matrix, borders, head);
                        break;
                }

                iteration = (iteration + 1) % 4;
            }

            return matrix;
        }

        private ListNode GoLeft(int[][] matrix, SpiralBorders borders, ListNode head)
        {
            var current = borders.Right;

            while (head != null && current >= borders.Left)
            {
                matrix[borders.Bottom][current] = head.val;
                current--;
                head = head.next;
            }

            borders.Bottom--;

            return head;
        }

        private ListNode GoRight(int[][] matrix, SpiralBorders borders, ListNode head)
        {
            var current = borders.Left;

            while (head != null && current <= borders.Right)
            {
                matrix[borders.Top][current] = head.val;
                current++;
                head = head.next;
            }

            borders.Top++;

            return head;
        }

        private ListNode GoTop(int[][] matrix, SpiralBorders borders, ListNode head)
        {
            var current = borders.Bottom;

            while (head != null && current >= borders.Top)
            {
                matrix[current][borders.Left] = head.val;
                current--;
                head = head.next;
            }

            borders.Left++;

            return head;
        }

        private ListNode GoBottom(int[][] matrix, SpiralBorders borders, ListNode head)
        {
            var current = borders.Top;

            while (head != null && current <= borders.Bottom)
            {
                matrix[current][borders.Right] = head.val;
                current++;
                head = head.next;
            }

            borders.Right--;

            return head;
        }

        public class SpiralBorders
        {
            public int Left, Right, Top, Bottom;
        }
    }
}

using BaseProblems.HelperClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseProblems.Solutions.MediumSolution
{
    public class Solution2807
    {
        public ListNode InsertGreatestCommonDivisors(ListNode head)
        {
            var current = head;
            var next = head.next;

            while (next != null)
            {
                var value = GetNOD(current.val, next.val);
                current.next = new ListNode(value, next);
                (current, next) = (next, next.next);
            }

            return head;
        }

        private static int GetNOD(int a, int b)
        {
            if (b > a)
                (a, b) = (b, a);

            while (b > 0)
                (a, b) = (b, a % b);

            return a;
        }
    }
}

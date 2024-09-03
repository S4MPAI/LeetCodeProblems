using BaseProblems.HelperClasses;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseProblems.Solutions.MediumSolution
{
    public class Solution2130
    {
        public int PairSum(ListNode head)
        {
            var current = head;
            var count = 0;

            while (current != null)
            {
                count++;
                current = current.next;
            }

            current = head;
            for (var i = 0; i < count/2; i++)
                current = current.next;

            ListNode prev = null;
            while (current != null)
            {
                var next = current.next;
                current.next = prev;
                (prev, current) = (current, next);
            }

            current = prev;
            var sum = 0;
            for (var i = 0; i  < count/2; i++)
            {
                sum = Math.Max(sum, head.val + current.val);
                current = current.next;
                head = head.next;
            }

            return sum;
        }

        public int PairSum1(ListNode head)
        {
            var current = head;
            var next = head;
            var sum = 0;
            var stack = new Stack<int>();

            while (next != null) 
            {
                stack.Push(current.val);
                current = current.next;
                next = next.next.next;
            }

            while (current != null)
            {
                sum = Math.Max(sum, stack.Pop() + current.val);
                current = current.next;
            }

            return sum;
        }
    }
}

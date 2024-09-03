using BaseProblems.HelperClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseProblems.Solutions.MediumSolution
{
    public class Solution92
    {
        public ListNode ReverseBetween(ListNode head, int left, int right)
        {
            if (head == null || left == right) return head;

            (ListNode prev, ListNode current) = (null, head);

            for (int i = 0; i < left - 1; i++)
                (prev, current) = (current, current.next);

            var connectorNode = prev;
            var newTail = current;

            for (int i = 0; i < right - left; i++)
            {
                var next = current.next;
                current.next = prev;
                (prev, current) = (current, next);
            }

            newTail.next = current;

            if (connectorNode != null)
                connectorNode.next = prev;
            else
                head = prev;

            return head;
        }
    }
}

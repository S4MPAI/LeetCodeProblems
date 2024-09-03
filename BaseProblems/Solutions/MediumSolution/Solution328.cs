using BaseProblems.HelperClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseProblems.Solutions.MediumSolution
{
    public class Solution328
    {
        public ListNode OddEvenList(ListNode head)
        {
            if (null == head || head.next == null) return head;
            var prev = head;
            var current = head.next;
            var firstOdd = current;
            
            while (current?.next != null && prev.next != null)
            {
                prev.next = prev.next.next;
                current.next = current.next.next;
                prev = prev.next;
                current = current.next;
            }

            prev.next = firstOdd;
            return head;
        }
    }
}

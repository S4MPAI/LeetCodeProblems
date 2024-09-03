using BaseProblems.HelperClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseProblems.Solutions.MediumSolution
{
    public class Solution2095
    {
        public ListNode DeleteMiddle(ListNode head)
        {
            var current = head;
            var count = 0;

            while (current != null)
            {
                current = current.next;
                count++;
            }

            if (count == 1) 
                return null;

            ListNode prev = null;
            current = head;

            for (int i = 0; i < count / 2; i++)
                (prev, current) = (current, current.next);

            var next = current.next;
            prev.next = next;

            return head;
        }
    }
}

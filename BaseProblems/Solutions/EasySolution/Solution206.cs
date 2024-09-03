using BaseProblems.HelperClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseProblems.Solutions.EasySolution
{
    public class Solution206
    {
        public ListNode ReverseList(ListNode head)
        {
            (ListNode previous, ListNode current) = (null, head);

            while (current != null)
            {
                var next = current.next;
                current.next = previous;
                (previous, current) = (current, next);
            }

            return previous;
        }
    }
}

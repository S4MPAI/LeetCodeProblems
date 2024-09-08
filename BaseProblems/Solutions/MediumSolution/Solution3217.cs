using BaseProblems.HelperClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseProblems.Solutions.MediumSolution
{
    public class Solution3217
    {
        public ListNode ModifiedList(int[] nums, ListNode head)
        {
            var numsHashSet = new HashSet<int>(nums);

            ListNode prev = null;
            var current = head;
            var newHead = head;

            while (current != null)
            {
                if (numsHashSet.Contains(current.val))
                {
                    if (prev == null)
                    {
                        newHead = current.next;
                        current = current.next;
                        
                    }
                    else
                    {
                        prev.next = current.next;
                        current = current.next;
                    }
                        
                    continue;
                }

                (prev, current) = (current, current.next);
            }

            return newHead;
        }
    }
}

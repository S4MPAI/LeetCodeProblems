using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BaseProblems.HelperClasses;

namespace BaseProblems.Solutions.EasySolution
{
    public class Solution141
    {
        public bool HasCycle(ListNode head)
        {
            var slowTarget = head?.next;
            var fastTarget = slowTarget?.next;

            while (slowTarget != null && fastTarget != null)
            {
                if (slowTarget == fastTarget)
                    return true;

                slowTarget = slowTarget.next;
                fastTarget = fastTarget.next?.next;
            }

            return false;
        }
    }
}

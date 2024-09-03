using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BaseProblems.HelperClasses;

namespace BaseProblems.Solutions.MediumSolution
{
    public class Solution725
    {
        public ListNode[] SplitListToParts(ListNode head, int k)
        {
            var result = new ListNode[k];
            var count = 0;
            var current = head;

            while (current != null)
            {
                count++;
                current = current.next;
            }

            var width = count / k;
            var rem = count % k;
            current = head;

            for (var i = 0; i < k; i++)
            {
                head = current;

                for (var j = 0; j < width + (i < rem ? 1 : 0) - 1; j++)
                    current = current?.next;

                if (current != null)
                {
                    var prev = current;
                    current = current.next;
                    prev.next = null;
                }

                result[i] = head;
            }

            return result;
        }
    }
}

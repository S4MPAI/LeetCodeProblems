using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseProblems.HelperClasses
{
    public class ListNode
    {
        public int val;
        public ListNode next;

        public ListNode(int x)
        {
            val = x;
            next = null;
        }

        public ListNode(int x, ListNode next = null)
        {
            val = x;
            this.next = next;
        }
    }
}

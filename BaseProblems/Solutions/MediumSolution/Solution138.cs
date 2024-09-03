using BaseProblems.HelperClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace BaseProblems.Solutions.MediumSolution
{
    public class Solution138
    {
        public Node CopyRandomList(Node head)
        {
            if (head == null) return head;

            var current = head;
            while (current != null)
            {
                var newNode = new Node(current.val);
                newNode.next = current.next;
                current.next = newNode;
                current = current.next.next;
            }

            current = head;
            while (current != null)
            {
                current.next.random = current.random?.next;
                current = current.next.next;
            }

            var currentOldNode = head;
            var newHead = head.next;
            var currentNewNode = head.next;
            while (currentNewNode != null)
            {
                currentOldNode.next = currentNewNode.next;
                currentNewNode.next = currentNewNode.next?.next;
                currentOldNode = currentOldNode.next;
                currentNewNode = currentNewNode.next;
            }

            return newHead;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Leecode
{
    public class TwoPoints
    {
        public bool HasCycle(ListNode head)
        {
            if (head == null) return false;
            ListNode last = head;
            ListNode first = head.next;
            while(last!=first&&last.next!=null&&first.next!=null&&first.next.next!=null)
            {
                last = last.next;
                first = first.next.next;
            }
            if (last == first) return true;
            return false;
        }
    }
}

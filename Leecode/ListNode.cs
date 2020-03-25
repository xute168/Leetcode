using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Leecode
{
    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode head;
        public ListNode tail;
        public ListNode(int x)
        {
            val = x;
            next = null;
        }

        public ListNode(IList<int> nd)
        {
            
            for(int i=0;i<nd.Count();i++)
            {
                if(i==0)
                {
                    var newNd = new ListNode(nd[i]);
                    head = newNd;
                    tail = newNd;
                }
                else
                {
                    var newNd = new ListNode(nd[i]);
                    tail.next = newNd;
                    tail = newNd;
                    
                }                
            } 
        }

        public void CircleListNode( int pos)
        {
            //ListNode head = new ListNode(nd);
            if (pos < 0) return;
            ListNode cur = head;
            ListNode posNd=head;
            while(cur.next!=null)
            {
                if (pos == 0)
                {
                    tail.next = cur;
                    break;
                }
                cur = cur.next;
                pos--;
                      
            }
                   
            
        }
    }
}

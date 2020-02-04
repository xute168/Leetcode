using System;
using System.Collections.Generic;
using System.Text;

namespace Leecode
{

    //Definition for a binary tree node.
    public class TreeNode<T>:IComparable<T>
        where T:IComparable<T>
    {
        public T val;
        public TreeNode<T> left;
        public TreeNode<T> right;
        public TreeNode(T x) { val = x; }
        public int CompareTo(T other)
        {
            return val.CompareTo(other);
        }
    }

}

using System;
using System.Collections.Generic;
using System.Text;

namespace Leecode
{

    public class BinarySeachTree<T> : IComparable<T>
        where T : IComparable<T>
    {
        public TreeNode<T> _root;

        public void Add(T value)
        {
            if (_root == null)
            {
                _root = new TreeNode<T>(value);
            }
            else
            {
                AddTo(_root, value);
            }
        }

        public int CompareTo(T other)
        {
            throw new NotImplementedException();
        }

        private void AddTo(TreeNode<T> root, T value)
        {
            if (value.CompareTo(root.val) < 0)
            {
                if (root.left == null)
                {
                    root.left = new TreeNode<T>(value);
                }
                else
                {
                    AddTo(root.left, value);
                }
            }
            else
            {
                if (root.right == null)
                {
                    root.right = new TreeNode<T>(value);
                }
                else
                {
                    AddTo(root.right, value);
                }
            }
        }
    }

}

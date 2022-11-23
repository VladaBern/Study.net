using System;
using System.Collections;
using System.Collections.Generic;

namespace HomeTask2
{
    internal class BinaryTree<T> : IEnumerable<T> where T : IComparable<T>
    {
        private BinaryTreeNode<T> root;
        private int count;

        public int Count { get { return count; } }

        public void Add(T value)
        {
            if (root == null)
                root = new BinaryTreeNode<T>(value);
            else
                AddTo(root, value);

            count++;
        }

        private void AddTo(BinaryTreeNode<T> node, T value)
        {
            if (value.CompareTo(node.Value) < 0)
            {
                if (node.Left == null)
                    node.Left = new BinaryTreeNode<T>(value);
                else
                    AddTo(node.Left, value);
            }
            else
            {
                if (node.Right == null)
                    node.Right = new BinaryTreeNode<T>(value);
                else
                    AddTo(node.Right, value);
            }
        }

        public bool Contains(T value)
        {
            BinaryTreeNode<T> current = root;

            while (current != null)
            {
                int result = current.CompareTo(value);

                if (result > 0)
                    current = current.Left;
                else if (result < 0)
                    current = current.Right;
                else
                    return true;
            }

            return false;
        }

        private void InOrderTraversal(BinaryTreeNode<T> node, List<T> list)
        {
            if (node.Left != null)
                InOrderTraversal(node.Left, list);

            list.Add(node.Value);

            if (node.Right != null)
                InOrderTraversal(node.Right, list);
        }

        public IEnumerator<T> GetEnumerator()
        {
            List<T> list = new List<T>();
            InOrderTraversal(root, list);
            return list.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyInterfaces;

namespace MyLib
{
    public class MyBinaryTree<T> : MyInterfaces.IBinaryTree<T> where T : IComparable<T>
    {
        private class TreeNode
        {
            public T Value;
            public TreeNode? Left;
            public TreeNode? Right;

            public TreeNode(T value)
            {
                this.Value = value;
                Left = null;
                Right = null;
            }
        }
        private TreeNode? root;
        public int Count { get; private set; }
        
        public MyBinaryTree()
        {
            root = null;
            Count = 0;
        }

        public void Add(T value)
        {
            root = AddRecursive(root, value);
            Count++;
        }

        public void Clear()
        {
            root = null;
            Count = 0;
        }

        public bool Contains(T value)
        {
            return ContainsRecursive(root, value);
        }

        public T[] ToArray()
        {
            T[] result = new T[Count];
            int index = 0;
            InOrderTraversal(root, ref result, ref index);
            return result;
        }

        private TreeNode AddRecursive(TreeNode? node, T value)
        {
            if (node == null)
            {
                return new TreeNode(value);
            }

            if (value.CompareTo(node.Value) >= 0)
            {
                node.Left = AddRecursive(node.Left, value);
            }
            else if (value.CompareTo(node.Value) < 0)
            {
                node.Right = AddRecursive(node.Right, value);
            }

            return node;
        }

        private bool ContainsRecursive(TreeNode? node, T value)
        {
            if (node == null)
            {
                return false;
            }

            if (value.CompareTo(node.Value) >= 0)
            {
                return true;
            }

            if (value.CompareTo(node.Value) < 0)
            {
               
                return ContainsRecursive(node.Left, value);
            }
            else
            {
                return ContainsRecursive(node.Left, value);
            }
        }

        private void InOrderTraversal(TreeNode? node, ref T[] result, ref int index)
        {
            if (node != null)
            {
                InOrderTraversal(node.Left, ref result, ref index);
                result[index++] = node.Value;
                InOrderTraversal(node.Right, ref result, ref index);
            }
        }

    }
}

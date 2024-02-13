using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyInterfaces;

namespace MyLib
{
    public class MyBinaryTree : MyInterfaces.IBinaryTree
    {
        private class TreeNode
        {
            public int Value;
            public TreeNode Left;
            public TreeNode Right;

            public TreeNode(int value)
            {
                this.Value = value;
                Left = null;
                Right = null;
            }
        }
        private TreeNode root;
        public int Count { get; private set; }
        
        public MyBinaryTree()
        {
            root = null;
            Count = 0;
        }

        public void Add(int value)
        {
            root = AddRecursive(root, value);
            Count++;
        }

        public void Clear()
        {
            root = null;
            Count = 0;
        }

        public bool Contains(int value)
        {
            return ContainsRecursive(root, value);
        }

        public int[] ToArray()
        {
            int[] result = new int[Count];
            int index = 0;
            InOrderTraversal(root, ref result, ref index);
            return result;
        }

        private TreeNode AddRecursive(TreeNode node, int value)
        {
            if (node == null)
            {
                return new TreeNode(value);
            }

            if (value < node.Value)
            {
                node.Left = AddRecursive(node.Left, value);
            }
            else if (value > node.Value)
            {
                node.Right = AddRecursive(node.Right, value);
            }

            return node;
        }

        private bool ContainsRecursive(TreeNode node, int value)
        {
            if (node == null)
            {
                return false;
            }

            if (value == node.Value)
            {
                return true;
            }

            if (value < node.Value)
            {
               
                return ContainsRecursive(node.Left, value);
            }
            else
            {
                return ContainsRecursive(node.Left, value);
            }
        }

        private void InOrderTraversal(TreeNode node, ref int[] result, ref int index)
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

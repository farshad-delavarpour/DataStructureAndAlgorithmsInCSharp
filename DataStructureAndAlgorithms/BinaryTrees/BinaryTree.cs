using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructureAndAlgorithms.BinaryTrees
{
    public class BinaryTree
    {
        private Node _root;

        public void Add(int value)
        {
            Node node = new(value);
            if (_root == null)
            {
                _root = node;
                return;
            }

            Node current = _root;
            while (true)
            {
                if (current.Value < value)
                {
                    if (current.Left == null)
                    {
                        current.Left = node;
                        break;
                    }
                    current = current.Left;
                }
                else
                {
                    if (current.Right == null)
                    {
                        current.Right = node;
                        break;
                    }
                    current = current.Right;
                }
            }
        }

        public bool Find(int value)
        {
            Node current = _root;
            while (current != null)
            {
                if (current.Value == value)
                {
                    return true;
                }
                if (current.Value < value)
                {
                    current = current.Left;
                }
                else
                {
                    current = current.Right;
                }
            }
            return false;
        }

        public void TraverseInOrder()
        {
            TraverseInOrder(_root);
        }

        private void TraverseInOrder(Node root)
        {
            if (root is null)
                return;

            TraverseInOrder(root.Left);
            Console.WriteLine(root);
            TraverseInOrder(root.Right);
        }

        public void TraversePostOrder()
        {
            TraversePostOrder(_root);
        }

        private void TraversePostOrder(Node root)
        {
            if (root is null)
                return;

            TraverseInOrder(root.Left);
            TraverseInOrder(root.Right);
            Console.WriteLine(root);
        }

        public void TraversePreOrder()
        {
            TraversePreOrder(_root);
        }

        private void TraversePreOrder(Node root)
        {
            if (root == null)
                return;
            Console.WriteLine(root.Value);
            TraversePreOrder(root.Left);
            TraversePreOrder(root.Right);
        }


        private class Node
        {
            public override string ToString()
            {
                return Value.ToString();
            }

            public Node(int value)
            {
                Value = value;
            }

            public int Value { get; set; }
            public Node Left { get; set; }
            public Node Right { get; set; }
        }
    }

}

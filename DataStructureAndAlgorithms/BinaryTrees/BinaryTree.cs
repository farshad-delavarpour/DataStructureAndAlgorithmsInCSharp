
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
                if (current.Value > value)
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

        #region Traverse
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
        #endregion

        public bool Equals(BinaryTree tree)
        {
            return Equals(_root, tree._root);
        }

        private bool Equals(Node first, Node second)
        {
            if (first == null && second == null)
                return true;
            
            if(first != null && second != null)
                return first.Value == second.Value && Equals(first.Left, second.Left) && Equals(first.Right, second.Right);
            
            return false;
        }

        public int Height()
        {
            return Height(_root);
        }

        private int Height(Node root)
        {
            if (root == null)
                return -1;

            if (root.Left is null && root.Right is null)
                return 0;

            return 1 + Math.Max(Height(root.Left), Height(root.Right));
        }

        public bool IsBinarySearchTree()
        {
            return IsBinarySearchTree(_root, int.MinValue, int.MaxValue);
        }

        private bool IsBinarySearchTree(Node node, int min, int max)
        {
            if (node is null)
                return true;

            if(node.Value < min || node.Value > max)
                return false;

            return IsBinarySearchTree(node.Left, min, node.Value - 1) && IsBinarySearchTree(node.Right, node.Value + 1, max);
        }

        public void PrintKDistanceNodes(int distance)
        {
            PrintKDistanceNode(_root, distance);
        }

        private void PrintKDistanceNode(Node node, int distance)
        {
            if (node is null)
                return;
            
            if(distance == 0)
            {
                Console.WriteLine(node.Value);
                return;
            }

            PrintKDistanceNode(_root.Left, distance - 1);
            PrintKDistanceNode(_root.Right, distance - 1);
        }

        public int Min()
        {
            if(_root == null)
                return -1;
            return Min(_root);
        }

        private int Min(Node node)
        {
            if (node is null)
                return int.MaxValue;

            if (IsLeaf(node))
                return node.Value;

            return Math.Min(node.Value, Math.Min(Min(node.Left), Min(node.Right)));
        }

        private static bool IsLeaf(Node node)
        {
            return node.Left == null && node.Right == null;
        }
        //      3
        //  2     5
        //1     4        
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

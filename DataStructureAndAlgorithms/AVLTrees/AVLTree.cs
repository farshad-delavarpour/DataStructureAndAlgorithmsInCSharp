using DataStructureAndAlgorithms.Test;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructureAndAlgorithms.AVLTrees
{
    public class AVLTree
    {
        private AVLNode _root;

        public void Insert(int value)
        {
            _root = Insert(_root, value);
        }

        private AVLNode Insert(AVLNode root, int value)
        {
            if(root == null)
                return new AVLNode(value);
         
            if(value > root.Value)
            {
                root.Right = Insert(root.Right, value);
            }
            else
            {
                root.Left = Insert(root.Left, value);
            }
            root.Height = Math.Max(Height(root.Left), Height(root.Right)) + 1;
            return root;
        }

        private int Height(AVLNode node)
        {
            return node is null ? -1 : node.Height;
        }

        private bool IsLeaf(AVLNode node)
        {
            return node.Left is null && node.Right is null;
        }

        private class AVLNode
        {
            public AVLNode(int value)
            {
                Value = value;
            }

            public int Value { get; set; }
            public int Height { get; set; } = 0;
            public AVLNode Left { get; set; }
            public AVLNode Right { get; set; }
        }
    }


}

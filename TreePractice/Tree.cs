using System;
using System.Collections.Generic;

namespace TreePractice
{
    public class Tree
    {
        private Node root;

        public Node Root { get => root; }
        public int Height { get => GetHeight(root); }

        private int GetHeight(Node node)
        {
            if (node == null)
                return 0;

            int lHeight = GetHeight(node.Ln);
            int rHeight = GetHeight(node.Rn);

            if (lHeight > rHeight)
                return lHeight + 1;
            else if (rHeight > lHeight)
                return rHeight + 1;
            else
                return rHeight + 1;
        }

        private Tree()
        { }

        public Tree(Node root)
        {
            this.root = root ?? throw new ArgumentNullException(nameof(root));
        }
    }
}

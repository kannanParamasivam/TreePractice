using System;

namespace TreePractice
{
    public class Tree
    {
        private Node root;

        public Node Root { get => root; }

        private Tree()
        { }

        public Tree(Node root)
        {
            this.root = root ?? throw new ArgumentNullException(nameof(root));
        }
    }
}

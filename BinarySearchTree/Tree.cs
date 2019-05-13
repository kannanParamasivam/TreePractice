using System;
using System.Text;

namespace BinarySearchTree
{
    public class Tree
    {
        private Node root;

        public Node Root { get => this.root; }

        public Tree()
        {
            this.root = new Node();
        }

        public bool Add(int value)
        {
            return root.Add(value: value);
        }

        public bool Contains(int value)
        {
            if (this.root.Value < 0)
                return false;

            return this.root.Contains(value: value);
        }

        public string PrintInOrder()
        {
            if (this.root.Value < 0)
                return string.Empty;

            StringBuilder sb = new StringBuilder();
            this.root.TraverseInOrder(sb: sb);

            return sb.ToString().Trim();
        }
    }
}

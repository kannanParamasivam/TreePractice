namespace TreePractice
{
    public class Node
    {
        private Node ln;
        private Node rn;
        private string data;
        public Node Ln { get => ln; set => ln = value; }
        public Node Rn { get => rn; set => rn = value; }
        public string Data { get => data; }

        private Node()
        {

        }
        public Node(string data, Node ln = null, Node rn = null)
        {
            this.data = data;
            this.ln = ln;
            this.rn = rn;
        }
    }
}

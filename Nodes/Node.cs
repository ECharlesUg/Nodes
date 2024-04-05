namespace Nodes
{
    internal class Node
    {
        private int _data;
        private Node? _next;
        public int Data
        {
            get { return _data; }
            set { _data = value; }
        }
        public Node? Next
        {
            get { return _next; }
            set { _next = value; }
        }

        public Node (int value)
        {
            Data = value;
            Next = null;
        }

        public override string ToString()
        {
            return $"[{Data}]";
        }

        
    }
}
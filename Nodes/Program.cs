using Nodes;

internal class Program
{
    static void Main(string[] args)
    {
        Node node1 = new Node(15);
        Node node2 = new Node(39);
        Node node3 = new Node(27);
        Node node4 = new Node(-10);

        node4.Next = node1;
        node1.Next = node3;
        node3.Next = node2;


        Nodes(node4);

        static void Nodes(Node node)
        {
            while (node != null)
            {
                Console.Write(node);
                node = node.Next;
                if (node != null)
                    Console.Write(" -> ");
            }
            Console.Write(" -> ");
            Console.Write("Null");
        }
    }
}
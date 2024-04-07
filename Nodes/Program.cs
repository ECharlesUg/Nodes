using Nodes;
using System;

internal class Program
{
    static void Main(string[] args)
    {
        Node node1 = new Node(15);
        Node node2 = new Node(39);
        Node node3 = new Node(27);
        Node node4 = new Node(-10);

        node1.Next = node2;
        node2.Next = node3;
        node3.Next = node4;

        SortNodes(node1);
        Nodes(node1);
    }

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

    static void SortNodes(Node head)
    {
        Node currentTerm = head;
        while (currentTerm != null)
        {
            Node term = currentTerm.Next;

            while (term != null)
            {
                if (currentTerm.Data > term.Data)
                {
                    int store = currentTerm.Data;
                    currentTerm.Data = term.Data;
                    term.Data = store;
                }
                term = term.Next;
            }

            currentTerm = currentTerm.Next;
        }
    }
}

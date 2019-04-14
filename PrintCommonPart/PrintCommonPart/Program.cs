using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintCommonPart
{
    class Program
    {
        public class Node
        {
            public int value;
            public Node next;
            public Node(int data)
            {
                this.value = data;
            }
        }

        public static void printCommonPart(Node head1,Node head2)
        {
            Console.WriteLine("Common part:");
            while (head1 != null && head2 != null)
            {
                if (head1.value < head2.value)
                {
                    head1 = head1.next;
                }else if(head1.value > head2.value)
                {
                    head2 = head2.next;
                }
                else
                {
                    Console.Write(head1.value + " ");
                    head1 = head1.next;
                    head2 = head2.next;
                }
            }
            Console.WriteLine();
        }

        public static void printLinkedList(Node node)
        {
            Console.WriteLine("LinkedList:");
            while (node != null)
            {
                Console.Write(node.value + " ");
                node = node.next;
            }
            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            Node node1 = new Node(2);
            node1.next = new Node(3);
            node1.next.next = new Node(4);
            node1.next.next.next = new Node(5);

            Node node2 = new Node(1);
            node2.next = new Node(2);
            node2.next.next = new Node(3);
            node2.next.next.next = new Node(4);
            node2.next.next.next.next = new Node(5);

            printLinkedList(node1);
            printLinkedList(node2);
            printCommonPart(node1, node2);

            Console.ReadKey();
        }
    }
}

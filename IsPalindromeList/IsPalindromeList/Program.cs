using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsPalindromeList
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

        // first method : need n space
        public static bool isPalindrome1(Node head)
        {
            Stack<Node> stack = new Stack<Node>();
            Node cur = head;
            while (cur != null)
            {
                stack.Push(cur);
                cur = cur.next;
            }
            while (head != null)
            {
                if (head.value != stack.Pop().value)
                {
                    return false;
                }
                head = head.next;
            }
            return true;
        }


        // second method : need n/2 extra space
        public static bool isPalindrome2(Node head)
        {
            if (head == null || head.next == null)
                return true;
            Node right = head.next;
            Node cur = head;
            while (cur.next != null && cur.next.next != null)
            {
                right = right.next;
                cur = cur.next.next;
            }
            Stack<Node> stack = new Stack<Node>();
            while (right != null)
            {
                stack.Push(right);
                right = right.next;
            }
            while (stack.Count != 0)
            {
                if (head.value != stack.Pop().value)
                    return false;
                head = head.next;
            }
            return true;
        }

        // method third : need o(1) extra space
        public static bool isPalindrome3(Node head)
        {
            if(head == null || head.next == null)
                return true;
            Node n1 = head;
            Node n2 = head;
            while (n2.next != null && n2.next.next != null)
	        {
                n1 = n1.next;
                n2 = n2.next.next;
            }
            n2 = n1.next;
            n1.next = null;
            Node n3 = null;
            while (n2 != null)
            {
                n3 = n2.next;
                n2.next = n1;
                n1 = n2;
                n2 = n3;
            }
            n3 = n1;
            n2 = head;
            bool res = true;
            while (n1 != null && n2 != null)
            {
                if (n1.value != n2.value)
                {
                    res = false;
                    break;
                }
                n1 = n1.next;
                n2 = n2.next;
            }
            n1 = n3.next;
            n3.next = null;
            while (n1 != null)
            {
                n2 = n1.next;
                n1.next = n3;
                n3 = n1;
                n1 = n2;
            }
            return res;
        }

        // printf list fun
        public static void printLinkedList(Node node)
        {
            Console.WriteLine("Linked list:");
            while (node!=null)
            {
                Console.Write(node.value + " ");
                node = node.next;
            }
            Console.WriteLine("######################");
        }

        static void Main(string[] args)
        {
            Node head = null;
            printLinkedList(head);
            Console.WriteLine(isPalindrome1(head) + "|");
            Console.WriteLine(isPalindrome2(head) + "|");
            Console.WriteLine(isPalindrome3(head) + "|");
            Console.WriteLine("**********************");

            head = new Node(1);
            printLinkedList(head);
            Console.WriteLine(isPalindrome1(head) + "|");
            Console.WriteLine(isPalindrome2(head) + "|");
            Console.WriteLine(isPalindrome3(head) + "|");
            Console.WriteLine("**********************");

            head = new Node(1);
            head.next = new Node(2);
            printLinkedList(head);
            Console.WriteLine(isPalindrome1(head) + "|");
            Console.WriteLine(isPalindrome2(head) + "|");
            Console.WriteLine(isPalindrome3(head) + "|");
            Console.WriteLine("**********************");

            head = new Node(1);
            head.next = new Node(2);
            head.next.next = new Node(3);
            printLinkedList(head);
            Console.WriteLine(isPalindrome1(head) + "|");
            Console.WriteLine(isPalindrome2(head) + "|");
            Console.WriteLine(isPalindrome3(head) + "|");
            Console.WriteLine("**********************");

            head = new Node(1);
            head.next = new Node(2);
            head.next.next = new Node(1);
            printLinkedList(head);
            Console.WriteLine(isPalindrome1(head) + "|");
            Console.WriteLine(isPalindrome2(head) + "|");
            Console.WriteLine(isPalindrome3(head) + "|");
            Console.WriteLine("**********************");

            Console.ReadKey();
        }
    }
}

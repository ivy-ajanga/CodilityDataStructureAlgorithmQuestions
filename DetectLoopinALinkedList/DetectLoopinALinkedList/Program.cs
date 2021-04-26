using System;
using System.Collections.Generic;

namespace DetectLoopinALinkedList
{
    class LinkedList
    {
        public Node head;
        public class Node
        {
            public int val;
            public Node next;
            public Node (int item)
            {
                val = item;
                next = null;
            }
        }
        public void Push(int val)
        {
            Node item = new Node(val);
            item.next = head;
            head = item;
        }
        public static bool IsLoop(Node val)
        {
            HashSet<Node> checker = new HashSet<Node>();
            while(val!=null)
            {
                //if we have node in cycle means we have a cycle already
                if(checker.Contains(val))
                {
                    return true;
                }
                //else add the value to the hash table
                checker.Add(val);
                val = val.next;

            }
            return false;
        }
        public static void Main(String[] args)
        {
            LinkedList a = new LinkedList();
            a.Push(20);
            a.Push(4);
            a.Push(15);
            a.Push(10);
            a.head.next.next.next.next = a.head;
            if(IsLoop(a.head))
            {
                Console.WriteLine("YES");
            }
            else
            {
                Console.WriteLine("NO");
            }
        }
    }
}

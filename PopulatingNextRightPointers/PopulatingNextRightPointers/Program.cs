using System;

public class Node
{
    public int val;
    public Node left;
    public Node right;
    public Node next;

    public Node() { }

    public Node(int _val)
    {
        val = _val;
    }

    public Node(int _val, Node _left, Node _right, Node _next)
    {
        val = _val;
        left = _left;
        right = _right;
        next = _next;
    }
    public static Node Connect(Node root)
    {
        if (root == null) return null;
        Node item = root;
        while (item != null)
        {
            Node dummyval = new Node(0);
            Node tempval = dummyval;
            while (item != null)
            {
                if (item.left != null)
                {
                    tempval.next = item.left;
                    tempval = tempval.next;
                }
                if (item.right != null)
                {
                    tempval.next = item.right;
                    tempval = tempval.next;
                }
                item = item.next;
            }
            item = dummyval.next;
        }
        return root;
    }
    static void Main(string[] args)
    {
        Node tree = new Node();
        tree = new Node(1);
        tree.left = new Node(2);
        tree.right = new Node(3);
        tree.left.left = new Node(4);
        tree.left.right = new Node(5);
        tree.right.left = new Node(6);
        tree.right.right = new Node(7);
        tree.Connect();
    }
}

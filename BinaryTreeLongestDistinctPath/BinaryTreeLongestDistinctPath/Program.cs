using System;
using System.Collections.Generic;

public class Node
{
    public Node left, right;
    public int key;
    public Node(int v)
    {
        key = v;
        left = right = null;
    }
}

public class BinaryTree
{
    public int x;
    public BinaryTree l;
    public BinaryTree r;
    Node root;
    public BinaryTree()
    {
        root = null;
    }


    public static int solution(BinaryTree T)
    {
        HashSet<int> route = new HashSet<int>();
        int height = 0;
        return Checker(T, route, height);
    }
    public static int Checker(BinaryTree root, HashSet<int> route, int height)
    {
        if (route.Contains(root.x))
        {
            return height;
        }
        else
        {
            route.Add(root.x);
            height++;
        }
        int maximum = height;
        if (root.l != null)
        {
            return Math.Max(Checker(root.l, route, height), maximum);
        }
        if (root.r != null)
        {
            return Math.Max(Checker(root.r, route, height), maximum);
        }
        route.Remove(root.x);
        return maximum;
    }
    static void Main(string[] args)
    {
        BinaryTree tree = new BinaryTree();

        tree.root = new Node(1);
        tree.root.left = new Node(2);
        tree.root.right = new Node(3);
        tree.root.left.left = new Node(3);
        tree.root.left.right = new Node(6);
        tree.root.right.left = new Node(3);
        tree.root.right.right = new Node(1);
        tree.root.left.left.left = new Node(2);
        tree.root.right.left.left = new Node(5);
        tree.root.right.right.right = new Node(6);
        Console.WriteLine(solution(tree));
    }
}


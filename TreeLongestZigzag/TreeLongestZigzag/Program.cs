using System;
using System.Collections.Generic;
// you can also use other imports, for example:
// using System.Collections.Generic;
// you can write to stdout for debugging purposes, e.g.
// Console.WriteLine("this is a debug message");
// Binary Tree node

public class Node
{
    public Node l, r;
    public int key;
    public Node(int v)
    {
        key = v;
        l = r = null;
    }
}


public class Tree
{
    public int x;
    public Tree l;
    public Tree r;
    public Node root;
    public Tree()
    {
        root = null;
    }
    public static int checkPath(Tree T, int turns, bool left, bool right)
    {
        int maxTurns = turns;
        int turnsL = turns;
        int turnsR = turns;

        // Check if current node has a left child
        if (T.l != null)
        {
            // Console.WriteLine("checkPath function");
            // If the current node IS NOT a left child then increment the turn 
            // counter (i.e. this is node is a right child and you are calling a 
            // left child so you have a turn)
            if (!left)
                turnsL++;
            // Call checkPath again with the left child, the number of turns to 
            // this point, the left child set to true, and the right child set to 
            // false (you are calling from a left child)
            maxTurns = Math.Max(checkPath(T.l, turnsL, true, false), maxTurns);
        }

        // Check if current node has a left child
        if (T.r != null)
        {
            // Console.WriteLine("checkPath function");
            // If the current node IS NOT a right child then increment the turn 
            // counter (i.e. this is node is a left child and you are calling a 
            // right child so you have a turn)
            if (!right)
                turnsR++;
            // Call checkPath again with the right child, the number of turns to 
            // this point, the left child set to false, and the right child set to 
            // false (you are calling from a right child)
            maxTurns = Math.Max(checkPath(T.r, turnsR, false, true), maxTurns);
        }

        return maxTurns;
    }
    public static int solution(Tree T)
    {
        // write your code in C# 6.0 with .NET 4.5 (Mono)

        // Initally the number of turns is zero
        return checkPath(T, 0, true, true);
    }
    public static void Main(string[] args)
    {
        Tree tree = new Tree();
        tree.root = new Node(5);
        tree.root.l = new Node(3);
        tree.root.r = new Node(10);
        tree.root.r.l = new Node(1);
        tree.root.r.r = new Node(15);
        tree.root.r.r.l = new Node(30);
        tree.root.r.r.r = new Node(8);
        tree.root.r.r.l.r = new Node(9);

        Console.WriteLine(solution(tree));
    }
}






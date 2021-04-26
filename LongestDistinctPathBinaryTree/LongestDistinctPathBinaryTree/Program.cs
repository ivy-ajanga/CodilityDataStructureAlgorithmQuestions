using System;
using System.Collections.Generic;

public class Tree
{
    public int x;
    public Tree l;
    public Tree r;
    public Tree(int value)
    {
        x = value;
        l = null;
        r = null;
    }
    public static int solution(Tree T)
    {
        HashSet<int> route = new HashSet<int>();
        int height = 0;
        return Checker(T, route, height);
    }
    public static int Checker(Tree root, HashSet<int> route, int height)
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
        Tree tree = new Tree(1);
        tree.l = new Tree(2);
        tree.r = new Tree(3);
        tree.l.l = new Tree(3);
        tree.l.r = new Tree(6);
        tree.r.l = new Tree(3);
        tree.r.r = new Tree(1);
        tree.l.l.l = new Tree(2);
        tree.r.r.l = new Tree(5);
        tree.r.r.r = new Tree(6);
        
        Console.WriteLine(solution(tree));
    }
}


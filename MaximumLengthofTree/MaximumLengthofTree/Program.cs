using System;
using System.Collections.Generic;
public class Tree
{
    public Tree l;
    public Tree r;

    public Tree(int value)
    {
        
        l = null;
        r = null;
    }
    public static int solution(Tree T)
    {
       
        return LongestPath(T, 0, 0);
    }
    public static int LongestPath(Tree T, int left, int right)
    {
        int max = Math.Max(left, right);
        if (T == null)
        {
            return 0;
        }
        if (T.l != null)
        {
           max=Math.Max(LongestPath(T.l, left + 1, 0), max);
        }
        if (T.r != null)
        {
           max= Math.Max(LongestPath(T.r, 0, right + 1), max);
        }

        return max;
    }
    static void Main(string[] args)
    {
        Tree tree = new Tree(5);
        tree.l = new Tree(3);
        tree.r = new Tree(10);
        tree.r.l = new Tree(12);
        tree.r.l.l = new Tree(21);
        tree.r.l.r = new Tree(20); //2
        Console.WriteLine(solution(tree));
    }
}

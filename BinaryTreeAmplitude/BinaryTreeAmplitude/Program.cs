using System;

namespace VisibleNodesInBinaryTree
{
    class Tree
    {
        public int x;
        public Tree l;
        public Tree r;
        public Tree(int val)
        {
            x = val;
            l = r = null;
        }
        static void Main(string[] args)
        {
            Tree tree = new Tree(5);
            tree.l = new Tree(8);
            tree.r = new Tree(9);
            tree.l.l = new Tree(12);
            tree.l.r = new Tree(2);
            tree.r.l = new Tree(7);
            tree.r.r = new Tree(4);
            tree.r.l.l= new Tree(1);
            tree.r.r.l = new Tree(3);  //8

        }
        int Checker(Tree T, int minimum, int maximum)
        {
            //we are finding the greatest difference in a path of a tree
            //using dfs we can go through each element of the tree in different paths getting the greatest difference
            if (T == null) return maximum - minimum;//end of tree path
            minimum = Math.Min(minimum, T.x);
            maximum = Math.Max(maximum, T.x);
            //Console.WriteLine(minimum + "min");
           // Console.WriteLine(maximum + "max");
            int leftside = Checker(T.l, minimum, maximum);
            int rightside = Checker(T.r, minimum, maximum);
            //Console.WriteLine(leftside + "left");
            //Console.WriteLine(rightside + "right");
            return Math.Max(leftside, rightside);
        }
        public int solution(Tree T)
        {
            if (T == null) return 0;
            else return Checker(T, T.x, T.x);
        }
    }
}

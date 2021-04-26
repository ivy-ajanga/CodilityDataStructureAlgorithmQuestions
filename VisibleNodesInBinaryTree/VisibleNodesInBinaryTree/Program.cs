using System;

namespace VisibleNodesInBinaryTree
{
    class Tree
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
        static void Main(string[] args)
        {
            Tree tree = new Tree(5);
            tree.l = new Tree(3);
            tree.r = new Tree(10);
            tree.l.l = new Tree(20);
            tree.l.r = new Tree(21);
            tree.r.l = new Tree(1);  //4


            Console.WriteLine(solution(tree));

        }
        static int Checker(Tree T, int max)
        {
            if (T == null) return 0;
            int maximum = Math.Max(max, T.x);
            if (T.x >= max)
            {
                return 1 + Checker(T.l, maximum) + Checker(T.r, maximum);
            }
            return Checker(T.l, maximum) + Checker(T.r, maximum);
        }
        public static int solution(Tree T)
        {
            return Checker(T, int.MinValue);
        }
        
    }
}

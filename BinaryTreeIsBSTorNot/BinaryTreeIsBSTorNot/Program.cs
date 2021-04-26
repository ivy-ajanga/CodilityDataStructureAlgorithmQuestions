using System;

namespace BinaryTreeIsBSTorNot
{
    public class Node
    {
        public int value;
        public Node left;
        public Node right;
        public Node(int item)
        {
            value=item;
            left = right = null;
        }

    }
    class BinaryTree
    {
        public Node root;
      
        public virtual bool solution
        {
            get
            {
                return isBST(root, long.MinValue, long.MaxValue);
            }
            
        }
        public virtual bool isBST(Node T, long min, long max)
        {
            if (T == null) return true;
            //traverses down the tree keeping track of the narrowing min and max
            //allowed values as it goes, looking at each node only once.
            if (min < T.value && max > T.value)
            {
                var left = isBST(T.left, min, T.value);
                var right = isBST(T.right, T.value, max);
                if (left && right) return true;
            }
            return false;
        }
        public static void Main(string[] args)
        {
            BinaryTree tree = new BinaryTree();
            tree.root = new Node(4);
            tree.root.left = new Node(2);
            tree.root.right = new Node(5);
            tree.root.left.left = new Node(1);
            tree.root.left.right = new Node(3);
            if(tree.solution)
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

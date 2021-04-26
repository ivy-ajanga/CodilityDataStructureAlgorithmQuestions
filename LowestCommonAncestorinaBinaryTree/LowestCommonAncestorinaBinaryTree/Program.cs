using System;

namespace LowestCommonAncestorinaBinaryTree
{
    class Node
    {
        public int val;
        public Node left;
        public Node right;
        public Node(int item)
        {
            val = item;
            left = right = null;
        }
    }
    class BinaryTree
    {
        public Node root;
        public Node solution(int a, int b)
        {
            return LCA(root, a, b);
        }
        public Node LCA(Node root, int a, int b)
        {
            //if null return null
            if (root == null) return null;
            //if a or b matches its root value return node
            if (root.val == a || root.val == b) return root;
            //looks for keys in left and right subtrees recursively
            Node left = LCA(root.left, a,b);
            Node right = LCA(root.right, a, b);
            //if the above returns none null in both left and right return node
            if (left != null && right != null) return root;
            //else check if either right or left is LCA
            return (left != null) ? left : right;
        }
        static void Main(string[] args)
        {
            BinaryTree tree = new BinaryTree();
            tree.root = new Node(1);
            tree.root.left = new Node(2);
            tree.root.right = new Node(3);
            tree.root.left.left = new Node(4);
            tree.root.left.right = new Node(5);
            tree.root.right.left = new Node(6);
            tree.root.right.right = new Node(7);

            Console.WriteLine("LCA(4, 5) = " +
                              tree.solution(4, 5).val);
            Console.WriteLine("LCA(4, 6) = " +
                              tree.solution(4, 6).val);
            Console.WriteLine("LCA(3, 4) = " +
                              tree.solution(3, 4).val);
            Console.WriteLine("LCA(2, 4) = " +
                              tree.solution(2, 4).val);
        }
    }
}

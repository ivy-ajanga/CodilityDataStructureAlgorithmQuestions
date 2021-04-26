using System;

namespace Add2NosRepresentedbylinkedlistsSet2
{
    /*
       1) Calculate sizes of given two linked lists. 
       2) If sizes are same, then calculate sum using recursion. Hold all nodes in recursion call stack till the rightmost node, calculate the sum of rightmost nodes and forward carry to the left side. 
       3) If size is not same, then follow below steps: 
      ….a) Calculate difference of sizes of two linked lists. Let the difference be diff 
      ….b) Move diff nodes ahead in the bigger linked list. Now use step 2 to calculate the sum of the smaller list and right sub-list (of the same size) of a larger list. Also, store the carry of this sum. 
      ….c) Calculate the sum of the carry (calculated in the previous step) with the remaining left sub-list of a larger list. Nodes of this sum are added at the beginning of the sum list obtained the previous step.
       */
    class LinkedList
    {
        class Node
        {
            public int val;
            public Node next;
            public Node(int item)
            {
                this.val = item;
            }
        }
        void Print(Node head)
        {
            while (head != null)
            {
                Console.Write(head.val + " ");
                head = head.next;
            }
        }
        Node head1, head2, result;
        int carry;
        void Push(int val, int list)
        {
            Node a = new Node(val);
            if (list == 1)
            {
                a.next = head1;
                head1 = a;
            }
            else if (list == 2)
            {
                a.next = head2;
                head2 = a;
            }
            else
            {
                a.next = result;
                result = a;
            }
        }
        //adds 2 linkedlists of same size
        void SumSameSize(Node a, Node b)
        {
            if (a == null) return;
            SumSameSize(a.next, b.next);

            int sum = a.val + b.val + carry;
            carry = sum / 10;
            sum = sum % 10;

            Push(sum, 3);
        }
        Node cur;
        // This function is called after the smaller 
        // list is added to the bigger lists's sublist 
        // of same size. Once the right sublist is added,
        // the carry must be added to the left side of 
        // larger list to get the final result.
        void propagatecarry(Node head1)
        {
            if (head1 != cur)
            {
                propagatecarry(head1.next);
                int sum = carry + head1.val;
                carry = sum / 10;
                sum %= 10;
                Push(sum, 3);
            }
        }
        int getsize(Node head)
        {
            int length = 0;
            while(head!=null)
            {
                length++;
                head = head.next;
            }
            return length;
        }
      
        
       
        void AddLists()
        {
            if(head1==null)
            {
                result = head2;
                return;
            }
            if (head2 == null)
            {
                result = head1;
                return;
            }
            int size1 = getsize(head1);
            int size2= getsize(head2);
            if(size1==size2)
            {
                SumSameSize(head1, head2);
            }
            else
            {
                if(size1<size2)
                {
                    Node temp = head1;
                    head1 = head2;
                    head2 = temp;
                }
                int diff = Math.Abs(size1 - size2);
                //move diff no of nodes in first list
                Node tmp = head1;
                while(diff-- >= 0)
                {
                    cur = tmp;
                    tmp = tmp.next;

                }
                //add the lists with same size now
                SumSameSize(cur, head2);
                propagatecarry(head1);
            }
            if (carry > 0)
                Push(carry, 3);
        }
       
        static void Main(string[] args)
        {
            LinkedList list = new LinkedList();
            list.head1 = null;
            list.head2 = null;
            list.result = null;
            list.carry = 0;
            int[] A = { 9, 9, 9 };
            int[] B= { 1, 8 };
            for (int i = A.Length-1; i>=0; i--)
            {
                list.Push(A[i], 1);
            }
            for (int i = B.Length - 1; i >= 0; i--)
            {
                list.Push(B[i], 2);
            }
            list.AddLists();
            list.Print(list.result);
        }

      
    }
}

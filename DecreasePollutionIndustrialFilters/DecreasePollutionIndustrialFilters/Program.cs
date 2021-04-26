using System;
using System.Linq;
using System.Collections.Generic;
namespace Industrial
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(solution(new int[] { 1, 2, 4, 8 }));//3
            Console.WriteLine(solution(new int[] { 5, 19, 8, 1 }));//3
            Console.WriteLine(solution(new int[] { 16, 16 }));//2
            Console.WriteLine(solution(new int[] { 3, 0, 5 }));//2
            Console.WriteLine(solution(new int[] { 3, 1, 5 }));//3
            Console.WriteLine(solution(new int[] { 10, 10 }));//2
        }
        public static int solution(int[] A)
        {
            decimal targetsum = (decimal)A.Sum() / 2;
            Array.Sort(A);
            Array.Reverse(A);
            
            Queue <decimal> store = new Queue<decimal>();
            store.Enqueue((decimal)A[0] / 2);
            decimal filtered = (decimal)A[0] / 2;
            int i = 1;
            int countfilter = 1;
            if (targetsum <= 0) return 0;
          

            while(filtered<targetsum)
            {
                //find largest element in queue
              decimal largest = store.Peek();
                //Compare next element in array with largest element in queue
              if(largest>(decimal)A[i])
              {
                    store.Dequeue();
                    store.Enqueue(largest/2);
                    filtered += largest / 2;
                 
              }
              else
              {
                    filtered += (decimal)A[i] / 2;
                    store.Enqueue((decimal)A[i]/2);
                  
                    i++;
              }
              countfilter++;
            }

            return countfilter;
        }
       
    }
}


using System;
using System.Collections.Generic;
namespace PeakFlags
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(solution(new int[] { 1, 5, 3, 4, 3, 4, 1, 2, 3, 4, 6, 2 }));
        }

        public static int solution(int[] A)
        {
            List<int> store = new List<int>();
            for (int i = 1; i < A.Length - 1; i++)
            {
                if (A[i - 1] < A[i] && A[i + 1] < A[i])
                {
                    store.Add(i);
                }
            }
            if (store.Count <= 2) return store.Count;
            //int k = 0;
            //int j = 1;
            //int K = store.Count;
            //int count = 1;

            //while(K>0)
            //{
            //    while (j < store.Count)
            //    {
            //        if (store[j] - store[k] >= K)
            //        {
            //            count++;
            //            k = j;
            //            j = k + 1;
            //            if (count == K) return count;
            //        }
            //        else
            //        {
            //            j++;
            //        }

            //    }
            //    K--;
            //}
            int k = 0;

            int K = store.Count;
            int count = 1;
            int sum = 0;
            for(k=0; k<store.Count-1;k++)
            {
                sum += store[k + 1] - store[k];
                if (sum >= K)
                {
                    sum = 0;
                    count++;
                }
            }
            return count;

        }   
    }
}

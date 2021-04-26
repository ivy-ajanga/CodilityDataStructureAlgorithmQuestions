using System;

namespace MaxApples
{
    class Program
    {
        static void Main(string[] args)
        {
            //int []A ={2,1,5,6,0,9,5,0,3,8}; //L=4 M=3//31
            //int []B={0,6,5,2,2,5,1,9,4};//L=1 K=2  //20
            //int[]C={3, 8, 1 ,4, 2, 7 ,22,9};//L=3, K=2  29
            // int[]D = { 6, 1, 4, 6, 3, 2, 7, 4 };//K=3, L=2 //24
            //int K = 3;
            //int L = 2;
            int[] D = { 10, 19, 15 };//-1
            int K = 2;
            int L = 2;
            Console.WriteLine(solution(D, K, L));
        }
        public static int solution(int[] A, int K, int L)
        {
            int maxApples = 0;
            if ((K + L) > A.Length) return -1;
            //get prefix sum of given trees in array
            for (long i = 1; i < A.Length; i++)
            {
                A[i] += (int)(A[i - 1] % ((long)Math.Pow(10, 9)));
            }
            //initialize our starting points
            maxApples = A[K + L - 1];
            int MaxL = A[L - 1];
            int MaxK = A[K - 1];
            //compare starting point and sums in the loop to get max sum of consecutive K and L
            for (int k = L + K; k < A.Length; k++)
            {
                MaxK = Math.Max(MaxK, A[k - L] - A[k - K - L]);
                MaxL = Math.Max(MaxL, A[k - K] - A[k - K - L]);
                maxApples = Math.Max(maxApples, Math.Max(MaxL + A[k] - A[k - K], MaxK + A[k] - A[k - L]));
            }
            return maxApples;
        }
    }
}

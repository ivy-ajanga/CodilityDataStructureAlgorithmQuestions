using System;
using System.Collections.Generic;
namespace MaximalNetworkRank
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[] A = { 1, 2, 3, 3 };
            //int[] B = { 2, 3, 1, 4 };//4
            //int N = 4;
            int[] A = { 1, 2, 4, 5 };
            int[] B = { 2, 3, 5, 6 };//2
            int N = 6;
            Console.WriteLine(solution(A,B,N));
        }
        public static  int solution(int[] A, int[] B, int N)
        {
            List<int> hs = new List<int>();
            hs.Add(A[0]);
            hs.Add(B[0]);
            int cnt = 1;
            for (int i = 1; i < A.Length; i++)
            {
                if (hs.Contains(A[i]) || hs.Contains(B[i]))
                {
                    cnt++;
                    hs.Add(A[i]);
                    hs.Add(B[i]);
                }
            }

            return cnt;
        }
    }
}

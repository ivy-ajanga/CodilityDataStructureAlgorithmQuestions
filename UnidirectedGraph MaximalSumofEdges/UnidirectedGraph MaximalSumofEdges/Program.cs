using System;
using System.Collections.Generic;
namespace UnidirectedGraph_MaximalSumofEdges
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = 5;
            int[] A = { 2, 2, 1, 2 };
            int[] B = { 1, 3, 4, 4 };
            Console.WriteLine(solution(N,A,B));
        }
        public static int solution(int N,int[]A,int[]B)
        {
            var dict = new Dictionary<int, List<int>>();
            for (int i = 1; i < N; i++)
            {
               if(!dict.ContainsKey(A[i]))
               {
                    dict.Add(A[i], );
               }
            }
            foreach(var item in dict)
            {
                Console.WriteLine(item);
            }
            return 1;
        }
    }
}

using System;

namespace LadderCodility
{
    class Program
    {
        public static void Main(string[] args)
        {
            //int[] A = { 4, 4, 5, 5, 1 };
            //int[] B = { 3, 2, 4, 3, 1 };
            int[] A = { 4};
            int[] B = { 3 };
            Console.WriteLine(solution(A, B));
        }
        public static string solution(int[] A, int[] B)
        {
            //use fibonacci to get possible ways of climbing ladder
            int N = A.Length;
            int[] F = new int[N + 1];
            int[] res = new int[N];
            if (N == 0 || N == 1)
            {
                F[0] = 0;
                F[1] = 1;
            }
            else if (N == 2)
            {
                F[0] = 0;
                F[1] = 1;
                F[2] = 2;
            }
            if (N >= 3)
            {

                F[0] = 0;
                F[1] = 1;
                F[2] = 2;
                for (int i = 3; i < F.Length; i++)
                {
                    F[0] = 0;
                    F[1] = 1;
                    F[2] = 2;
                    //no of climbing ways can be very large so it is sufficient to return result modulo 2^P to avoid an overflow
                    //given p is in arr B ranges 1-30
                    F[i] = (F[i - 1] + F[i - 2]) % (int)(Math.Pow(2, 30));
                }
            }
            for (int i = 0; i < A.Length; i++)
            {
                //no of ways of climbing a ladder with A[i]rungs modulo 2^B[i]
                res[i] = F[A[i]] % (int)(Math.Pow(2, B[i]));
            }
            var result = string.Join(",", res);
            return result;
        }
    }
}

using System;

namespace RiceChessBoard
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] A = { { 2, 2, 4, 2 }, { 0, 3, 0, 1 }, { 1,2, 2, 1 }, { 4, 1, 2, 2 } };
            Console.WriteLine(RiceChessBoard(A));
        }
        public static int RiceChessBoard(int[,]A)
        {

            return Helper(A, 0, 0, 0, 0);
        }
        public static int Helper(int[,]A, int P, int Q, int count, int sum)
        {
            int N = A.GetLength(0);
            int M = A.GetLength(1);
            sum += A[P, Q];
            
            if(P+1<N)
            {
                count = Math.Max(count, Helper(A, P + 1, Q, count, sum));
            }
            if (Q+1 < M)
            {
                count = Math.Max(count, Helper(A, P, Q + 1, count, sum));
            }
            if (P == N-1 && Q==M-1)
            
                count = Math.Max(count,sum);
            
            sum -= A[P, Q];
          
            return count;
        }
    }
}

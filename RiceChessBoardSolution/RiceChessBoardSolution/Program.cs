using System;

namespace RiceChessBoard
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] A = { { 2, 2, 4, 2 }, { 0, 3, 0, 1 }, { 1, 2, 2, 1 }, { 4, 1, 2, 2 } };
            Console.WriteLine(RiceChessBoard(A));
        }
        public static int RiceChessBoard(int[,] A)
        {
            int N = A.GetLength(0);
            int M = A.GetLength(1);

            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < M; j++)
                {
                   if (i==0 && j!=0)
                   {
                        A[i, j] += A[i, j - 1];
                   }
                   if (i != 0 && j == 0)
                   {
                        A[i, j] += A[i-1, j];
                   }
                    if (i != 0 && j != 0)
                    {
                        A[i, j] = Math.Max(A[i, j]+ A[i - 1, j], A[i, j] + A[i, j-1]);
                    }
                }
            }
            return A[N - 1, M - 1];
        }
       
    }
}

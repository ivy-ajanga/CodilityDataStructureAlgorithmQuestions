using System;

class MainClass
{
    public static void Main(string[] args)
    {
        int[,]A ={{1,1,0},{1,0,1},{0,0,0}};
        //int[,] A = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
        Console.WriteLine(FlipAndInvertImage(A));

    }
    public static int[,] FlipAndInvertImage(int[,] A)
    {
        //reverse array
        int M = A.GetLength(0);
        int N = A.GetLength(1);
        for (int i = 0; i < M; i++)
        {
            int start = 0;
            int end = N - 1;
            while (start < end)
            {
                int temp = A[i, start];
                A[i, start] = A[i, end];
                A[i, end] = temp;
                start++;
                end--;
            }
            //invert it 
            for (int j = 0; j < N; j++)
            {
                A[i, j] ^= 1;
            }
        }

        foreach (var item in A)
        {
            Console.WriteLine(item);
        }
        return A;
    }
}
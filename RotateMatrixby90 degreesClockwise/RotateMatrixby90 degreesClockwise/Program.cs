using System;

namespace RotateMatrix90degrees
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[,]A = new int[,] { { 1, 2, 3 }, { 4,5,6}, { 7,8,9} };
            int[,] A = new int[,] { { 1, 2, 3, 4 }, { 5, 6, 7, 8 }, { 9, 10, 11, 12 }, { 13, 14, 15, 16 }, { 17, 18, 19, 20 } };

            Console.WriteLine(solution(A));
        }
        public static int[,] solution(int[,] A)
        {
            int col = A.GetLength(1);
            int row = A.GetLength(0);
            int[,] rotated = new int[col, row];

            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    //first row is last column
                    //2nd row is last but 1 column
                    /*
                            123       741
                            456   =>  852
                            789       963
                     */
                    rotated[j, (row-1)-i] = A[i, j];
                }
            }

            for (int i = 0; i < col; i++)
            {
                for (int j = 0; j < row; j++)
                {
                    Console.Write(rotated[i,j] + " ");
                }
                Console.WriteLine();
            }
            return rotated;
        }

    }
}

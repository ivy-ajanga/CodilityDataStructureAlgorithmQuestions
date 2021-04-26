using System;

namespace RotateMatrix90degreesAnticklockwise
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[,]A = new int[,] { { 1, 2, 3 }, { 4,5,6}, { 7,8,9} };
            int[,] A = new int[,] { { 1, 2, 3,4 }, { 5, 6,7,8 }, { 9,10,11,12 }, { 13,14,15,16}, {17,18,19,20 } };
            int[,] rotated = solution(A);
           
            //Console.WriteLine(solution(A));
        }
        public static int[,] solution(int[,]A)
        {
            int col = A.GetLength(1);
            int row = A.GetLength(0);
            int [,]rotated = new int[col,row];

            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    //first row is inverted 1st column
                    //2nd row is inverted 2nd column and so on 
                    /*
                            123       36
                            456   =>  25
                            789       14
                     */
                    rotated[(col - 1) - j, i] = A[i, j];
                }
            }
            for (int i = 0; i < col; i++)
            {
                for (int j = 0; j < row; j++)
                {
                    Console.Write(rotated[i, j] + " ");
                }
                Console.WriteLine();
            }

            return rotated;
        }
        

      
    }
}

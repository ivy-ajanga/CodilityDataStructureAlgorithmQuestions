using System;

namespace RotateRoundClocks
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] A = new int[,] { { 1, 2 }, { 2, 4 }, { 4, 3 }, { 2, 3 }, { 1, 3 } };
            int P = 4;
            Console.WriteLine(solution(A, P));
        }
        public static int solution(int[,] A, int P)
        {
            //check the first clock if 1, 2 check if other clocks are 4,3 or 2,3 if so they can flipped to 1,2 
            //2, 4 can be flipped if other is 1,3 
            int count = 0;
            bool checker = false;
            int col = A.GetLength(1);

            int row = A.GetLength(0);

            for (int i = 0; i < row; i++)
            {
                for (int k = i+1; k < row; k++)
                {
                    for (int l = 0; l < col; l++)
                    {
                        checker = true;
                        for (int j = 0; j < col; j++)
                        {
                            if (A[i, j] != A[k, (j + 1)%col])
                            {
                                checker = false;
                                break;
                               
                            }
                        }
                        if (checker)
                        {
                            count++;
                            break;
                        }
                    }                  
                }
            }
            return count;
        }
    }
}

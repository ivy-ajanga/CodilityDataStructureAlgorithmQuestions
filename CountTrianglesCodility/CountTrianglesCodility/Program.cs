using System;

namespace CountTrianglesCodility
{
    class Program
    {
        public static void Main(string[] args)
        {
            int[] A = { 10, 2, 5, 1, 8, 12 };//4
                                             //10, 21, 22, 100, 101, 200, 300//6
                                             //10,2,5,1,8,12//4
            Console.WriteLine(solution(A));
        }
        public static int solution(int[] A)
        {
            int triangles = 0;
            for (int i = 0; i < A.Length; i++)
            {
                for (int j = i + 1; j< A.Length; j++)
                {
                    for (int k = j + 1; k < A.Length; k++)
                    {
                        if (A[i] + A[j] > A[k] && A[i] + A[k] > A[j] && A[j] + A[k] > A[i]) triangles++;

                    }
                }
            }
            return triangles;
        }
    }
}

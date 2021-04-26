using System;

namespace CannonBallsCodility
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] A = { 1, 2, 0, 4, 3, 2, 1, 5, 7 };
            int[] B = { 2,8,0,7,6,5,3,4,5,6,5 };
            Console.WriteLine(solution(A,B));
        }
        public static int[] solution (int[]A, int[]B)
        {
            for (int j = 0; j < B.Length; j++)
            {
                for (int i = 0; i < A.Length; i++)
                {
                    
                    if (i>0 && i<A.Length && B[j]!=0)
                    {
                        if (A[i] >=B[j])
                        {
                            A[i - 1]++;
                            break;
                        }
                    }
                   
                }
            }
            foreach (var item in A)
            {
                Console.WriteLine(item);
            }
            return A;
        }
    }
}

using System;

namespace KingofFrankiaCastles
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(solution(new int[] {2,2,3,4,3,3,2,2,1,1,2,5 }));//4
            Console.WriteLine(solution(new int[] {-3,-3 }));//1
        }
        public static int solution(int[]A)
        {
            int hill = 0;
            int valley = 1;
            int area = -1;
            int castle = 1;
          
            for (int i = 0; i < A.Length-1; i++)
            {
                if(A[i+1]> A[i])
                {
                    area = hill;
                }
                if (A[i + 1]<A[i])
                {
                    area = valley;
                }
                if(area == valley && A[i+1]>A[i] )
                {
                    castle++;
                }
                if (area == hill && A[i + 1]<A[i])
                {
                    castle++;
                }
            }
            if (area != -1)
            {
                castle++;
            }
            return castle;
        }
    }
}

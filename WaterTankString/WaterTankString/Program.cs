using System;
using System.Collections.Generic;

namespace NonintersectingSegments
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(solution(new int[] { 10, 1, 3, 1, 2, 2, 1, 0, 4 }));//3
        }
        public static int solution(int[] A)
        {
            int count = 0;
            int sum= 0;
            Dictionary<int, int> dict = new Dictionary<int, int>();
            for (int i = 0; i < A.Length - 1; i += 2)
            {
                sum += A[i];
                Console.WriteLine(sum);
                
            }
            return count;
        }
    }
}

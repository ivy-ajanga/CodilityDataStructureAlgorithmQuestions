using System;

namespace AestheyticTrees
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
        public int solution(int[] A)
        {
            //check if at A[i] the next tree is smaller or greater
            //if so return 0
            int result = 0;
            for (int i = 1; i < A.Length - 1; i++)
            {
                if (A[i] > A[i + 1] || A[i] > A[i - 1] || A[i] < A[i + 1] || A[i] < A[i - 1])
                {
                    result = 0;
                }
                if (A[i + 1] > A[i])
                {
                    result++;
                }
            }
            return result;
        }

    }
}

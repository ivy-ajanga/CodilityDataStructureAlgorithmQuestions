using System;

namespace SwitchingArray
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(solution(new int[] { 3,-7,3,-7,3}));//5
            Console.WriteLine(solution(new int[] { 4,4,4}));//3
            Console.WriteLine(solution(new int[] {7,4,-2,4,-2,-9 }));//4
            Console.WriteLine(solution(new int[] {7,-5,-5,-5,7,-1,7 }));//3
        }
        public static int solution(int[] A)
        {
            if (A.Length <= 2) return A.Length;
            int firsteven = A[0];
            int firstodd = A[1];
            int max_switch = 0;
            int j = 0;
            for (int i = 2; i < A.Length; i++)
            {
                if (i % 2 != 0 && A[i] != firstodd || i % 2 == 0 && A[i] != firsteven)
                {
                    //record the length of max switch
                    max_switch = Math.Max(max_switch, i - j);
                    //reset our starting point
                    j = i - 1;
                    //reset the firsteven and first odd to next elements in array
                    if (i % 2 != 0)
                    {
                        firsteven = A[i - 1];
                        firstodd = A[i];
                    }
                    else
                    {
                        firsteven = A[i];
                        firstodd = A[i - 1];
                    }
                }
            }
            return Math.Max(max_switch, A.Length - j);
        }
    }
}

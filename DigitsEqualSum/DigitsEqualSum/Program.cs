using System;
using System.Collections.Generic;

namespace DigitsEqualSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] A = {51,42,71,17 };
            Console.WriteLine(solution(A));
        }
        public static  int solution(int[] A)
        {
            /*
            1. 51=>6  42 =>6 71=>8 17=>8 max sum of 1st pair is 93
            2. 42 is 6 33 is 6 60 is 6 max sum of 1st pair  102
            */

            var ls = new List<int>();
            int result = -1;
            int n = A.Length;
            for (int i = 0; i < A.Length; i++)
            {
                int sum = SumofDigits(A[i]);
                ls.Add(sum);
                
            }
            int max = 0;
            for (int i = 0; i < A.Length-1; i++)
            {
                if (ls[i] == ls[i+1])
                {
                    max += A[i];
                    result = Math.Max(max, result + A[i]);
                }
            }
            return result;
        }
        //get sum of digits in a helper fn
        public static int SumofDigits(long num)
        {
            long sumDigit = 0;
            while (num > 0)
            {
                sumDigit += (num % 10);
                num /= 10;
            }
            return (int)sumDigit;
        }
    }
}

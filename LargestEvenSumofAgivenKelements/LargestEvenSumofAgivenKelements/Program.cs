using System;
using System.Linq;
using System.Collections.Generic;

namespace LargestEvenSumofAgivenKelements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] A = {4,9,8,2,6 };
            int K = 3;
            Console.WriteLine(solution(A,K));
        }
        public static int solution(int[] A, int K)
        {
            if (K == A.Length && A.Sum() % 2 == 0)
                return A.Sum();
            if (K > A.Length) return -1;
            //create odd and even list to store odd and even elements from array
            //sort the lists
            //increment the maximum with even list if K is odd
            //else increment the maximum with both odd and even
            int maximum = 0;
            List<int> EvenNos = new List<int>();
            List<int> OddNos = new List<int>();
            for (int i = 0; i < A.Length; i++)
            {
                if (A[i] % 2 == 0)
                    EvenNos.Add(A[i]);
                else OddNos.Add(A[i]);
            }
            EvenNos.Sort();
            OddNos.Sort();
            int k = EvenNos.Count - 1;
            int l = OddNos.Count - 1;
            while (K > 0)
            {
                if (K % 2 != 0)
                {
                    if (k >= 0)
                    {
                        maximum += EvenNos[k];
                        k--;
                    }
                    else
                    {
                        return -1;
                    }
                    K--;
                }
                else if (k >= 1 && l >= 1)
                {
                    if (EvenNos[k] + EvenNos[k - 1] <= OddNos[l] + OddNos[l - 1])
                    {
                        maximum += OddNos[l] + OddNos[l - 1];
                        l -= 2;
                    }
                    else
                    {
                        maximum += EvenNos[k] + EvenNos[k - 1];
                        k -= 2;
                    }
                    K -= 2;
                }
                else if (k >= 1)
                {
                    maximum += EvenNos[k] + EvenNos[k - 1];
                    k -= 2;
                    K -= 2;
                }
                else if (l >= 1)
                {
                    maximum += OddNos[l] + OddNos[l - 1];
                    l -= 2;
                    K -= 2;
                }
            }
            return maximum;

        }
    }
}

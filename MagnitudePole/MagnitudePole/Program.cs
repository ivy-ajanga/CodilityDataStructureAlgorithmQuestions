using System;
using System.Collections.Generic;
namespace MagnitudePole
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] A = { 3, 1, 4, 5, 9, 7, 6, 11 };//3,4,7
            //int[] A = { 4, 2, 2, 3, 1, 4, 7, 8, 6, 9 };//5,9
            Console.WriteLine(magnitudes(A));
        }
        public static int magnitudes(int[] A)
        {
            int N = A.Length;
            int[] prefixsumR = new int[N];
            int[] prefixsumL = new int[N];
            //build all mins from the end which is 9 and replace it with any number less than it
            int min = prefixsumL[N - 1] = A[N - 1];

            for (int i = N - 2; i >= 0; i--)
            {
                if (A[i] < min)
                {
                    min = A[i];
                }
                prefixsumL[i] = min;
            }
            //build all max from beginning and replace it with any number greater than it
            int max = prefixsumR[0] = A[0];
            for (int i = 0; i < N; i++)
            {
                if (A[i] > max)
                {
                    max = A[i];
                }
                prefixsumR[i] = max;
            }
            int res = 0;
            for (int i = 0; i < N; i++)
            {
                if (A[i] == prefixsumR[i] && A[i] == prefixsumR[i])
                {
                    res = i;
                }
            }

            return res;
        }
    }
}

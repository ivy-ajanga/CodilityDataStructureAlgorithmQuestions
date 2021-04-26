using System;
using System.Collections.Generic;
namespace RotateRoundClocks
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] A = new int[,] { { 1, 2 }, { 2, 4 }, { 4,3 }, { 2,3 }, { 1, 3 } };
            int P = 4;
            Console.WriteLine(solution(A,P));
        }
        public static int solution(int[,] A, int P)
        {
            Dictionary<string, int> clockCount = new Dictionary<string, int>();
            int[] a = new int[A.Length];
            int p = 0;
            for (int i = 0; i < A.Length; i++)
            {
                p = A[i, i];
                a[i]=p;
                rotate(clockCount, a ,P);
            }
            int count = 0;
            foreach (KeyValuePair<string, int> clockHands in clockCount)
                for (int i = clockHands.Value; i > 1; i--)
                    count += i - 1;
            return count;
        }
        public static string minLexRotation (string S)
        {
            int N1 = S.Length;
            S += S;
            int N = S.Length;

            //failure function
            int[] f = new int[N];
            for (int i = 0; i < N; i++)
            {
                f[i] = -1;
            }
            int k = 0;
            for (int j = 0; j < N; j++)
            {
                char sj = S[j];
                int i = f[j - k - 1];
                while(i!=-1 && sj!=S[k+i+1])
                {
                    if (sj < S[k + i + 1])
                        k = j - i - 1;
                    i = f[i];
                }
                if (sj != S[k + i + 1])
                {
                    if (sj < S[k])
                        k = j;
                    f[j - k] = -1;
                }
                else
                    f[j - k] = i + 1;
            }
            return S.Substring(k,N1);
        }
        public static void rotate (Dictionary<string,int>clockCount, int[]clock, int P)
        {
            int M = clock.Length;
            string minFirst = "";
            Array.Sort(clock);
            for (int i = 0; i < M-1; i++)
            
                minFirst += Math.Abs(clock[i + 1] - clock[i]).ToString();
                minFirst += (P - clock[M - 1] - clock[0]).ToString();
            string minLex = minLexRotation(minFirst);
            if (clockCount.ContainsKey(minLex))
                clockCount[minLex]++;
            else
                clockCount.Add(minLex, 1);
        }
    }
}

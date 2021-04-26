using System;
using System.Collections.Generic;

namespace test
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] A = { 2, 2, 3, 4, 5 };
            List<int> scores = new List<int>();
            for (int i = 0; i < A.Length; i++)
            {
                scores.Add(A[i]);
            }
           
            int K = 4;
            Console.WriteLine(numPlayers(K, scores));
        }
        public static int numPlayers(int k, List<int> scores)
        {
            if (k <= 0) return 0;
            scores.Sort();
            scores.Reverse();
            int rank = 1;
            int result = 0;
            for (int i = 0; i < scores.Count; i++)
            {
                if (i == 0) rank = 1;
                else if (scores[i] != scores[i - 1]) rank = i + 1;
                if (rank <= k && scores[i] > 0) result++;
                else break;
            }
            return result;
        }
        public static long carParkingRoof(List<long> cars, int k)
        {
            cars.Sort();
            long N = cars.Count;
            long minimum = cars[k - 1] - cars[0];
            for (int i = 1; i <= N - k; i++)
            {
                if (minimum > cars[k - 1 + i] - cars[i])
                {
                    minimum = cars[k - 1 + i] - cars[i];
                }
            }
            return minimum + 1;
        }


    }
}

using System;
using System.Collections.Generic;
namespace PeakFlags
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(solution(new int[] { 1, 5, 3, 4, 3, 4, 1, 2, 3, 4, 6, 2 }));
        }

        public static int solution(int[] A)
        {
            List<int> store = new List<int>();
            for (int i = 1; i < A.Length - 1; i++)
            {
                if (A[i - 1] < A[i] && A[i + 1] < A[i])
                {
                    store.Add(i);
                }
            }

            if (store.Count <= 2) return store.Count;
            int start = 1;
            int end = store.Count;
            int finalflag = 1;
            while (start <= end)
            {
                int used = 0;
                int mark = store[0];
                bool determiner = false;
                int flags = (start + end) / 2;

                for (int i = 0; i < store.Count; i++)
                {
                    if (store[i] >= mark)
                    {
                        used++;
                        mark = store[i] + flags;
                        if (used == flags)
                        {
                            determiner = true;
                            break;
                        }
                    }
                }
                if (determiner)
                {
                    finalflag = flags;
                    start = flags + 1;
                }
                else
                {
                    end = flags - 1;
                }
            }

            return finalflag;
        }

    }
}

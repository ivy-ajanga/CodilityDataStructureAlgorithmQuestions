using System;

namespace BinaryPeriod
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = 955;
            Console.WriteLine(solution(N));
        }
        public static int solution(int n)
        {
            int[] d = new int[30];
            int l = 0;
            int p;
            while (n > 0)
            {
                d[l] = n % 2;
                n /= 2;
                l++;
            }
            for (p = 1; p < 1 + l / 2; ++p)
            {
                int i;
                bool ok = true;
                for (i = 0; i < l - p; ++i)
                {
                    if (d[i] != d[i + p])
                    {
                        ok = false;
                        break;
                    }
                }
                if (ok)
                {
                    return p;
                }
            }
            return -1;
        }
    }
   
}

using System;

namespace rectilinearArea
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(solution(0,2,5,10,3,1,20,15));
        }
        public static int solution (int K, int L, int M, int N, int P, int Q, int R, int S)
        {
            int area = 0;
            long width = 0;
            long height = 0;

            //find width
            if (K <= P && M <= R && M > P) width = (long)M - (long)P;
            else if(K<=P && R<=M) width = (long)R- (long)P;
            else if (P<=K && R<=M && R>K) width = (long)R - (long)K;
            else if (P<=K && M<=R) width = (long)M- (long)K;
            if (width == 0) return 0;
            //find height
            if (L <= Q && N <= S && N > Q) height = (long)N - (long)Q;
            else if (L<=Q && S<=N) height = (long)S- (long)Q;
            else if(Q<=L && S<=N && S>L) height = (long)S - (long)L;
            if(Q<=L && N<=S) height = (long)N - (long)L;
            if (height == 0) return 0;
            //find area
            area = (int)width * (int)height;
            if (area <= 2147483647|| width <= 2147483647 || height <= 2147483647)
                return area;
            else return -1;
        }
       
    }
}

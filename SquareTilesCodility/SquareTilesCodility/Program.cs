using System;

namespace SquareTilesCodility
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine(solution(8, 0));//2
            //Console.WriteLine(solution(4,3));//4
            //Console.WriteLine(solution(13, 3));//5
            Console.WriteLine(solution(0, 18));//8
        }
        public static int solution(int M, int N)
        {
            //get how many N blocks can form a complete square
            int size = (int)Math.Sqrt(N);
            /*if there are unused N block test if there are enough
             * M blocks to fill the missing N spaces and form a complete square 
             * Check the next size up (size+1)2 subtract N and multiply by 4
             * (N==4M blocks)
             * check if there are N blocks to fill the space
             */
            if(size>0)
            {
                if(4*(Math.Pow(size+1,2)-N)<=M)
                {
                    M -= 4 * ((int)Math.Pow(size + 1, 2) - N);
                    size++;
                }
            }
            //multiply by 2, each N block is 2*widw
            size *= 2;
            // Finally check if you can move up to the next size
            // with only M blocks. To make the square one block larger
            // you need to add size blocks to each size and then one to
            // corner (2*size +1)

            while (M>=2*size+1)
            {
                M -= 2 * size + 1;
                size++;
            }
            return size;
        }
    }
}

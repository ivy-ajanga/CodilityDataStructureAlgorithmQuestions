using System;

namespace AlternatingTrees
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(solution(new int[] {3,4,5,3,7 }));//3
            Console.WriteLine(solution(new int[] {1,2,3,4}));//-1
            Console.WriteLine(solution(new int[] { 1, 3,1,2}));//0
        }
        public static int solution(int[]A)
        {
            int N = A.Length-1;
            int count = 0;
            int[] trees = new int[N];
            // Check if initial array is already asthetically
            // pleasing, if so return.

            if (Helper(A)) return 0;
            // Check all possible arrays by removing each element in
            // the array and passing to the test function

            for (int i = 0; i < N+1; i++)
            {
                int index = 0;
                for (int j = 0; j < N+1; j++)
                {
                    if(j!=i)
                    {
                        trees[index] = A[j];
                        index++;
                    }
                }
                // Count after the removal of each element if
                // array is pleasing

                if (Helper(trees)) count++;
            }
            if(count==0)
                return -1;
            return count;
        }
        //check aesthetic
        public static bool Helper(int[]trees)
        {
            int N = trees.Length;
            bool pattern = false;
            //check first trees pattern if decreasing/increasing
            if (trees[0] < trees[1])
            {
                pattern = true;
            }
            else pattern = false;
            //check if entire loop is alternating if so increment count
            int count = 1;
            while(count+1<N)
            {
                if(trees[count]<trees[count+1]&& !pattern)
                {
                    pattern = true;
                }
                else if(trees[count] > trees[count + 1] && pattern)
                {
                    pattern = false;
                }
                else
                {
                    break;
                }
                count++;
            }
            // Return true if array is alternating
            if (count + 1 == N)
                return true;
             return false;
        }
    }
}

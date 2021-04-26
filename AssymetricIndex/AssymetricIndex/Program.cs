using System;

namespace AssymetricIndex
{
    class Program
    {
        static void Main(string[] args)
        {
            int X = 7;
            int[] A = { 6, 5, 4, 3, 2, 1 };//6
            //int X = 5;
            //int[] A = { 5, 5, 1, 7, 2, 3, 5 };//4
            Console.WriteLine(solution(X,A));
        }
        public static int solution(int X,int[]A)
        {
            int N = A.Length;
            int[] prefix = new int[N];
            int[] postfix = new int[N];
            int[] arr = new int[N];
            int reds = 0;
            int greens = 0;
            for (int i = 0; i < A.Length; i++)
            {
                if (A[i] == X)
                {
                    arr[i] = 1;
                    greens++;
                }
             
            }
            prefix[0] = arr[0];
            for (int i = 1; i <N; i++)
            {
                
               prefix[i] = prefix[i-1]+arr[i];
                
            }
            
            for (int i = N-1; i >= 0; i--)
            {
                if(i<N-1)
                {
                    if (A[i] != X)
                    {
                        postfix[i] = postfix[i + 1] + 1;
                        reds++;
                    }
                    else
                    {
                        postfix[i] = postfix[i + 1];
                    }
                }
                else
                {
                    if(A[N-1]!=X)
                    {
                        postfix[i] = 1;
                        reds++;
                    }
                    
                }
            }
            
            if (reds == N) return N;
            else if (greens == N) return 0;
            for (int i = 0; i < A.Length - 1; i++)

                if (prefix[i] == postfix[i + 1])

                    return i + 1;
            return 0;
                
            
            
            
        }
       
    }
}

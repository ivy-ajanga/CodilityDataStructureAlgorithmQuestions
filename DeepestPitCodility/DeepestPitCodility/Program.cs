using System;
using System.Linq;

namespace DeepestPit
{
	class Program
	{

		public class DeepestPit
		{
			public static void Main(String[] args)
			{
				int[] a = { 0, 1, 3, -2, 0, 1, 0, -3, 2, 3 };

				Console.WriteLine(solution1(a));

			}
			public static int solution1(int[] A)
			{
				int N = A.Length;
				int[] prefix = new int[N];
				int[] postfix = new int[N];
                int[] min = new int[N];
                prefix[0] = 0;
                for (int i = 1; i < N; i++)
                {
                    if (A[i - 1] < A[i])
                    {
                        prefix[i] = 0;
                    }
                    else
                    { 
                        prefix[i] = prefix[i - 1] + (A[i - 1] - A[i]);
                    }
                }

                for (int i = N - 2; i >= 0; i--)
                {

                    if (A[i] <A[i + 1])
                    {
                        postfix[i] = postfix[i + 1] + Math.Abs(A[i] - A[i + 1]);
                    }
                    
                }
                //edge cases
                if(N<1 || N> 1000000)return -1;
                if (postfix.All(x => x == 0) || prefix.All(x => x == 0)) return -1;
                for (int i = 0; i < N; i++)
                {
                    min[i] = Math.Min(prefix[i], postfix[i]);
                }
               
                return min.Max();
			}


		}
	}
}

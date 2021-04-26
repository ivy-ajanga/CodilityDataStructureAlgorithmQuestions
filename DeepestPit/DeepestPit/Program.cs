using System;

namespace DeepestPit
{
    class Program
    {
       
		public class DeepestPit
		{
			public static void Main(String[] args)
			{
				int[] a = {0,1,3,-2,0,1,0,-3,2,3};

                Console.WriteLine(solution1(a));

			}
			public static int solution1(int[] A)
			{
				int height = 0;
				int P = 0;
				int Q = -1;
				int R = -1;
				//check back and front 
				for (int j = 1; j < A.Length; j++)
				{
                    //sequence is increasing j-1 is Q
                    if (A[j] >= A[j - 1] && Q < 0)
                    {
                        Q = j - 1;
                    }
                    if ((A[j] <= A[j- 1] || j + 1 == A.Length) && (Q >= 0 && R < 0))
					{
						
						if (A[j] <= A[j - 1])
							R = j - 1;
				
						else
							R = j;
						
						height = Math.Max(height, Math.Min(A[P] - A[Q], A[R] - A[Q]));
						P = j - 1;
						Q = R = -1;
					}
				}
				if (height == 0) height = -1;
				return height;

			}
		

		}
	}
}

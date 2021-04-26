using System;
using System.Collections.Generic;
namespace CuttingCake
{
    class Program
    {
        static void Main(string[] args)
        {
            int X = 6;
            int Y = 7;
            int K = 3;
            int[] A = { 1, 3 };
            int[] B = {1,5 };
            Console.WriteLine(solution(X,Y,K,A,B));
        }
        public static int solution(int X, int Y, int K, int[] A, int[] B)
        {
            int N = A.Length+1;
            
            int length = A.Length;
            //find height
            int[] height = new int[length + 1];
            height[0] = B[0];
            for (int i = 1; i < length; i++)
            {
                height[i] = B[i] - B[i - 1];
            }
            height[length] = Y - B[length - 1];
            //find width
            int[] width = new int[length + 1];
            width[0] = A[0];
            for (int i = 1; i < length; i++)
            {
                width[i] = A[i] - A[i - 1];
            }
            width[length] = X - A[length - 1];
            int[,] area = new int[N,N];
            //find area
            for (int i = 0; i <N; i++)
            {
                for (int j = 0; j <N; j++)
                {
                    area[i,j] = width[i] * height[j];
                }
            }
            List<int> ls = new List<int>();
            foreach (var item in area)
            {
                ls.Add(item);
            }
           
            //sort area and reverse to start from largest
            ls.Sort();
            ls.Reverse();
            //return K th largest area
            return ls[K-1];
        }
       
    }
}

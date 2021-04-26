using System;
using System.Linq;
namespace NonPositivePlantEnergy
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[] A = { 5, 3, 8, 3, 2 };
            //int X = 2;
            //int Y = 5;
            //Console.WriteLine(solution(A, X, Y));//7
            //int[] A = { 4, 2, 7 };
            //int X = 4;
            //int Y = 100;
            //Console.WriteLine(solution(A, X, Y));//12
            //int[] A = { 2, 2, 1, 2, 2 };
            //int X = 2;
            //int Y = 3;
            //Console.WriteLine(solution(A, X, Y));//8
            int[] A = { 4, 1, 5, 3 };
            int X = 5;
            int Y = 2;
            Console.WriteLine(solution(A, X, Y));//4
        }
        public static int solution(int[] A, int X, int Y)
        {
            Array.Sort(A);
            Array.Reverse(A);
            int costX = A.Length * X;
            int costY = 0;
            int minCost = costX;
            int energyY = 0;
            int indexY = A.Length-1;
            for (int i = 0; i < A.Length; i++)
            {
                energyY += A[i];
                while (indexY>=0 && energyY>0 && energyY>=A[indexY])
                {
                    energyY -= A[indexY];
                    indexY--;
                }
                costY+=Y;
                if(indexY-i < 0)
                    costX = 0;
                else
                    costX = X * (indexY - i);
                
                if ((costY + costX) < minCost)
                    minCost = costY + costX;
            }
            return minCost;
        }
    }
}

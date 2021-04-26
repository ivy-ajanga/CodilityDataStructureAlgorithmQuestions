using System;
using System.Collections.Generic;
using System.Linq;
namespace NonintersectingSegments
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(solution(new int[] { 10, 1, 3, 1, 2, 2, 1, 0, 4 }));//3
            Console.WriteLine(solution(new int[] { 5,3,1,3,2,3 }));//1
            Console.WriteLine(solution(new int[] { 9,9,9,9,9}));//2
        }
        public static int solution(int[] A)
        {
            int[] sumarr = new int[A.Length-1];
            Dictionary<int, int> dict = new Dictionary<int, int>();
            List<int> myList = new List<int>();
            for (int i = 0; i < A.Length - 1; i++)
            {
                int sum = A[i] + A[i + 1];
                sumarr[i] = sum;
            }
            int prevSum = 0;
            for (int i = 0; i < A.Length-1; i++)
            {
                if (sumarr[i] != prevSum)
                {
                    prevSum = sumarr[i];
                    if (!dict.ContainsKey(sumarr[i]))
                    {
                        dict.Add(sumarr[i], 1);
                    }
                    else
                    {
                        dict[sumarr[i]]++;
                    }
                }
                else
                {
                    prevSum = 0;
                    continue;

                }
                
            }
            var maxValue = dict.Values.Max();



            return maxValue;
        }
    }
}

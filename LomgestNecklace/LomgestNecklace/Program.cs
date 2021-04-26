using System;
using System.Collections.Generic;

namespace LomgestNecklace
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] A = {5,4,0,3,1,6,2 };
            Console.WriteLine(solution(A));
        }
        public static int solution(int[]A)
        {
            int max = 0;
            Dictionary<int, int> dict = new Dictionary<int, int>();
            int[] visited = new int[A.Length];
           int  longestnecklace = 0;
            for (int i = 0; i < A.Length; i++)
            {
                dict.Add(i,A[i]);
            }
          
            int j = 0;
            while(j<visited.Length)
            {
                if(visited[j]==0)
                {
                    if(dict.ContainsKey(j))
                    {
                        visited[j] = 1;
                        longestnecklace += 1;
                        j = dict[j];
                        
                    }
                }
                else
                {
                    max = Math.Max(max, longestnecklace);
                    longestnecklace = 0;
                    j++;
                }
            }
            
            return max;
        }
      

    }
}

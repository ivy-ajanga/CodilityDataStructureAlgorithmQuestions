using System;
using System.Collections.Generic;
namespace Test
{
    public class Graph
    {
        static void Main(string[] args)
        {
            //int[] A = { 1, 3, 2, 4 };  
            //int[] B = { 4, 1, 3, 2 };  // True 
            //int[] A = { 1, 2,3, 4 };
            //int[] B = { 2,1,4,3 };  // False
            //int[] A = { 1, 2,1 };
            //int[] B = { 2,3,3};  // False
            //int[] A = { 1, 2, 3, 4 };
            //int[] B = { 2, 1, 4, 3 };  // False
            int[] A = { 1, 2, 2, 3, 3 };
            int[] B = { 2, 3, 4, 5 };  // False

            Console.WriteLine(solution(A, B));
        }
        
        public static bool solution(int[] A, int[] B)
        {
            Dictionary<int, int> dict = new Dictionary<int, int>();
            for (int i = 0; i < A.Length; i++)
            {
                if(dict.ContainsKey(A[i]))
                {
                    return false;
                }
                else
                {
                    dict.Add(A[i], B[i]);
                }
               
            }
            int[] visited = new int[A.Length+1];
            int nextEl = B[0];
            visited[B[0]] = 1;
            for (int i = 1; i < A.Length; i++)
            {
                nextEl=dict[nextEl];
                if (visited[i] == 0)
                {
                    visited[i] = 1;
                }
                else
                {
                    return false;
                }
                
            }
           
            return true;
        }
       
    }
}

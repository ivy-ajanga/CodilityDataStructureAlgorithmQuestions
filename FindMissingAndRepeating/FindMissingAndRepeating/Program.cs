using System;
using System.Collections.Generic;
namespace FindMissingAndRepeating
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] A = { 2, 2 };
            int[] arr = { 1, 3, 3 };
            int n = A.Length;
            Console.WriteLine(findTwoElement(A,n));
        }
        static int[] findTwoElement(int []arr, int n)
        {
            Dictionary<int, bool> dict = new Dictionary<int, bool>();
            int[] A = new int[n];
            List<int> a = new List<int>();
            for (int i=0; i<arr.Length;i++)
            {
                if(!dict.ContainsKey(arr[i]))
                {
                    dict.Add(arr[i], true);
                }
                else
                {
                    a.Add(arr[i]);
                }               
            }
            for (int i = 1; i < arr.Length; i++)
            {
                if(!dict.ContainsKey(i))
                {
                    a.Add(i);
                }
            }

            foreach (var item in a)
            {
                Console.WriteLine(item);
            }
            return a.ToArray();
        }
    }
}

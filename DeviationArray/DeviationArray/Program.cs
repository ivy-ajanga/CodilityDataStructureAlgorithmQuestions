using System;
using System.Linq;
using System.Collections.Generic;

class Solution
{
    static void Main(string[] args)
    {
        Console.WriteLine(solution(new int[] { 9,4,-3,-10}));//3
        //Console.WriteLine(solution(new int[0] { }));//-1
    }
    public static int solution(int[] A)
    {
        if (A.Length<=0) return -1;
        List<long> ls = new List<long>();
        //find mean
        long meanA = 0;
        long sum = 0;
        for (long i=0; i<A.Length;i++)
        {
            sum += A[i];
            meanA = sum/ A.Length;
        }
     
        foreach (var item in A)
        {
            long diff = Math.Abs(item-meanA);
         
           
            ls.Add(diff);
        }

        var maxValue = ls.Max();
        var index = ls.IndexOf(maxValue);


       return index;
    }
}

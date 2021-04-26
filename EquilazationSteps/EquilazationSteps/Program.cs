using System;
using System.Linq;

class Test
{
    static void Main()
    {
        //int[] A = new[] { 11,3,7,1};//5 
        int[] A = new[] { 6,6,6,6 };//-1
       //int[] A = new[] { 1,4,7};//-1
        //int[] A = new[] { 2,8,6,3,2,1 };//-1
        Console.WriteLine(Transform(A));
       
    }

    static int Transform(int[] A)
    {
        if (A.Select(x => x % 2).Distinct().Skip(1).Any())
        {
            return -1;
           
        }
        int max = A.Max();
        int min = A.Min();
        if (max == min)
        {
            return -1;
        }
        int mean = (max-min)/2;

        return mean;

    }
}
using System;
using System.Collections.Generic;
namespace ValidTimeCount
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(solution(1,8,3,2));//6
            Console.WriteLine(solution(2,3,3,2));//3
            Console.WriteLine(solution(6,2,4,7));//0
        }
       
        public static int solution(int A, int B, int C, int D)
        {
            int[] time = new int[] { A,B,C,D};
            HashSet<string> storeTime = new HashSet<string>();
            Permut(time, 0, time.Length-1, storeTime);
            return storeTime.Count;
        }
        public static void Permut(int[]time, int l, int r, HashSet<string>storeTime)
        {
            string strTime = String.Format(time[0] + "" + time[1] + "" + time[2] + "" + time[3] + "" );
            if(l==r && !storeTime.Contains(strTime))
            {
                if(time[0]<=1 && time[2]<=5 || time[0]==2 && time[1]<=3 && time[2]<=5)
                {
                    storeTime.Add(strTime);
                }
            }
            else
            {
                for (int i = l; i <=r; i++)
                {
                    //swap
                    int temp = time[i];
                    time[i] = time[l];
                    time[l]=temp;
                    //recursion called
                    Permut(time, l + 1, r, storeTime);
                    //backtrack
                    temp = time[i];
                    time[i] = time[l];
                    time[l] = temp;
                }
            }
        }
       
    }
}

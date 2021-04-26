using System;
using System.Collections.Generic;
using System.Text;
class MainClass
{
    public static void Main(string[] args)
    {
        Console.WriteLine(solution(new int[] { 100, 100, 100 }, new string[] { "2020-12-31", "2020-12-22", "2020-12-03" }));//240
        Console.WriteLine(solution(new int[] { 180, -50, -25, -25 }, new string[] { "2020-01-01", "2020-01-01", "2020-01-01", "2020-01-31" }));//25
    }
    public static int solution(int[] A, string[] D)
    {
        int income = 0;
        int fee = 0;
        int final = 0;
        int months = 12;
        int cards = 0;
        int cardincome = 0;
        HashSet<string> store = new HashSet<string>();
        for (int i = 0; i < A.Length; i++)
        {
            income += A[i];
            store.Add(D[i].Substring(5, 2));

            if (A[i] < 0)
            {
                cards++;
                cardincome += Math.Abs(A[i]);
                if (cardincome > 100 && cards >= 3 && store.Count == 1)
                {
                    months--;
                    store.Clear();
                    cards = 0;
                    cardincome = 0;
                }
            }


            fee = 5 * months;
            final = income - fee;
        }
        return final;
    }
}
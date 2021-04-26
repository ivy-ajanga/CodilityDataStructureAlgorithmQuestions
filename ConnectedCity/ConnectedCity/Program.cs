using System;
using System.Collections.Generic;

namespace ConnectedCity
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] T = new int[] { 9, 1, 4, 9, 0, 4, 8, 9, 0, 1 };
            Console.WriteLine(solution(T));
        }
        public static int[] solution(int[] T)
        {
            int capital = -1;
            Dictionary<int, List<int>> dict = new Dictionary<int, List<int>>();
            int[] distance = new int[T.Length - 1];
            if (T.Length <= 1) return distance;
            for (int i = 0; i < T.Length; i++)
            {
                if (i == T[i]) capital = i;
                else
                {
                    if (dict.ContainsKey(i))
                    {
                        dict[i].Add(T[i]);
                    }
                    else
                    {
                        dict.Add(i, new List<int> { T[i] });
                    }
                    if (dict.ContainsKey(T[i]))
                    {
                        dict[T[i]].Add(i);
                    }
                    else
                    {
                        dict.Add(T[i], new List<int> { i });
                    }
                }
            }
            Distance(dict, distance, capital, -1, 0);
            foreach (var item in distance)
            {
                Console.WriteLine(item);
            }
            return distance;
        }
        public static int[] Distance(Dictionary<int, List<int>> dict, int[] distance, int city, int parent, int height)
        {

            foreach (int item in dict[city])

                if (item != city && item != parent)

                    Distance(dict, distance, item, city, height + 1);


            if (parent != -1)

                distance[height - 1]++;

            return distance;
        }
    }
}

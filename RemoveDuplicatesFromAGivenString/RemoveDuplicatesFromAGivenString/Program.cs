using System;
using System.Collections.Generic;

namespace RemoveDuplicatesFromAGivenString
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(solution("geeksforgeeks"));
        }
        public static string solution(string str)
        {
            //you can sort the string given
            char[] temp = str.ToCharArray();
            Array.Sort(temp);
            str = String.Join("", temp);
            HashSet<char> set = new HashSet<char>();
            for (int i = 0; i < str.Length; i++)
            {
                set.Add(str[i]);
            }
            //string res = set.ToString();
            foreach (var item in set)
            {
                Console.WriteLine(item);
            }
            return "";
        }
    }
}

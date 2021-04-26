using System;
using System.Collections.Generic;
namespace Balanced
{
    class Program
    {
        static void Main(string[] args)
        {
            string a = "azABaabza";
            Console.WriteLine(solution(a));
        }
        public static int solution(string s)
        {
            int[] lower = new int[26];
            int i;


            int[] capital = new int[26];
            Array.Clear(lower, 0, lower.Length);
            Array.Clear(capital, 0, capital.Length);

            for (i = 0; i < s.Length; i++)
            {
                if (s[i] >= 65 && s[i] <= 90)
                    capital[(int)s[i] - 65]++;
                else
                    lower[(int)s[i] - 97]++;
            }

            Dictionary<char, int> mp = new Dictionary<char, int>();

            for (i = 0; i < 26; i++)
            {
                if (lower[i] != 0 && capital[i] == 0)
                {
                    mp[(char)(i + 97)] = 1;
                }
                else if (capital[i] != 0 && lower[i] == 0)
                    mp[(char)(i + 65)] = 1;

            }

            Array.Clear(lower, 0, lower.Length);
            Array.Clear(capital, 0, capital.Length);


            i = 0;
            int st = 0;

            int start = -1, end = -1;
            int minm = Max;

            while (i < s.Length)
            {
                if (mp.ContainsKey(s[i]))
                {
                    while (st < i)
                    {
                        if ((int)s[st] >= 65 &&
                            (int)s[st] <= 90)
                            capital[(int)s[st] - 65]--;
                        else
                            lower[(int)s[st] - 97]--;

                        st++;
                    }
                    i += 1;
                    st = i;
                }
                else
                {
                    if ((int)s[i] >= 65 && (int)s[i] <= 90)
                        capital[(int)s[i] - 65]++;
                    else
                        lower[(int)s[i] - 97]++;


                    while (true)
                    {
                        if ((int)s[st] >= 65 &&
                            (int)s[st] <= 90 &&
                            capital[(int)s[st] - 65] > 1)
                        {
                            capital[(int)s[st] - 65]--;
                            st++;
                        }
                        else if ((int)s[st] >= 97 &&
                                 (int)s[st] <= 122 &&
                                 lower[(int)s[st] - 97] > 1)
                        {
                            lower[(int)s[st] - 97]--;
                            st++;
                        }
                        else
                            break;
                    }


                    if (balanced(lower, capital))
                    {
                        if (minm > (i - st + 1))
                        {
                            minm = i - st + 1;
                            start = st;
                            end = i;
                        }
                    }
                    i += 1;
                }
            }
            string result = "";

            if (start == -1 || end == -1)
                return -1;


            else
            {
                result = "";
                for (int j = start; j <= end; j++)
                    result += s[j];

                return result.Length;
            }
            return -1;
        }
        public const int Max = int.MaxValue;

        static bool balanced(int[] lower,int[] capital)
        {

            for (int i = 0; i < 26; i++)
            {
                if (lower[i] != 0 && (capital[i] == 0))
                    return false;

                else if ((lower[i] == 0) && (capital[i] != 0))
                    return false;
            }
            return true;
        }

        
    }
}

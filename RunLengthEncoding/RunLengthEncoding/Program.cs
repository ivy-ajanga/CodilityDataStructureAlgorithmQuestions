using System;

namespace RunLengthEncoding
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "aaaabbbccc";//a4b3c3
            string str1 = "abbbcdddd";//a1b3c1d4
            solution(str1);
        }
        static void solution (string str)
        {
            //if str[i] equals str[i+1] count +=1 
            //if not res =count new str=str[i]+res count =0
           
           
            for (int i = 0; i < str.Length-1; i++)
            {
                int count = 1;
                while (i<str.Length-1 && str[i]==str[i+1])
                {
                    count++;
                    i++;
                }
                Console.Write(str[i]);
                Console.Write(count);
            }

            
        }
    }
}

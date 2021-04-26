using System;

namespace Encodingnumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(solution("011100"));//8
            Console.WriteLine(solution("111"));//5
            Console.WriteLine(solution("1111010101111"));//22
            Console.WriteLine(solution("1111010101111"));//22
        }
        public static int solution(string S)
        {
            // convert binary to decimal
            //if even divide by 2
            //if odd subtract 1
            ulong num = Convert.ToUInt64(S, 2);
            int operations = 0;
            while (num > 0)
            {
                if (num % 2 == 0)
                {
                    num /= 2;
                    operations++;
                }
                else
                {
                    num -= 1;
                    operations++;
                }
            }
            return operations;
        }
    }
}
